using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

/// <summary>
/// na forum jest infor co do sciaganiecia. Moze zmienic przyciski na obrazki napisac kod zeby z pliku txt do bazy danych dodał dane 
/// dodac do kazdego ogloszenia date kiedy pobrana, jeszcze nie wiadomo przeczytac na fb
/// </summary>
namespace JOBBOERSE
{
    public partial class MainForm : Form
    {
        ConnectionCheck connectionCheck = new ConnectionCheck();
        GetHtml side = new GetHtml();
        RegEx expresion;
        SQL sql = new SQL();
        string[] imie = new string[4603];
        string[] nazwisko = new string[4603];
        string[] nazwafirmy = new string[4603];
        string[] plec = new string[4603];
        string[] ulica = new string[4603];
        string[] email = new string[4603];
        string[] kod = new string[4603];
        string[] miasto = new string[4603];


        private string sidelink;

        /// <summary>
        /// App start
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
            if (connectionCheck.Internet() == true) picInternetStatus.Image = Properties.Resources.good;
            else picInternetStatus.Image = Properties.Resources.bad;
        }
        /// <summary>
        /// Button Get contact info event to download data and save to into database
        /// </summary>
        private void button1_Click(object sender, EventArgs e)
        {
            getSaveData();
        }
        /// <summary>
        /// Button ShowData event to show data base in new form
        /// </summary>
        private void btnShowData_Click(object sender, EventArgs e)
        {
            var dataShow = new DataPresent();
            dataShow.Show();
        }

        /// <summary>
        /// Main method to get data from websides and save them to database
        /// </summary>
        private void getSaveData()
        {

            if (connectionCheck.Internet() == true)
            {
                picLoading.Visible = true;
                progBarDwonload.Visible = true;
                sidelink = webDownload.Url.AbsoluteUri;
                expresion = new RegEx(sidelink);

                for (int ii = 1; ii < 21; ii++) //ii=21 is max webside`s from 1 to 20, ii=2 is first siede download
                {
                    side.GetMainSide(webDownload); // donload main webside html code and save in resources.html.txt
                    progBarDwonload.Value = ii;

                    for (int i = 0; i < 10; i++)
                    {
                        expresion.LoadFile("html", 1, (i + (10 * (ii - 1))));
                        side.GetSide("http://jobboerse.arbeitsagentur.de" + expresion.Found); //get html code with one job offert
                        expresion.LoadFile("htmlOffer", 2, i);
                    }
                    expresion.LoadFile("html", 3, 0);// get next webside code to dig for oferts (page2,page3...,page20)




                    webDownload.Url = new System.Uri("http://jobboerse.arbeitsagentur.de/vamJB/stellenangeboteFinden.html?" + "d_6827794_p=" + (ii + 1) + "&execution=e" + expresion.Found + "s1", System.UriKind.Absolute);
                    while (webDownload.ReadyState != WebBrowserReadyState.Complete)
                    {
                        Application.DoEvents();
                    }


                }
                MessageBox.Show("Downloaded all websites", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                progBarDwonload.Visible = false;
                picLoading.Visible = false;
                webDownload.Url = (new System.Uri("http://jobboerse.arbeitsagentur.de/vamJB/startseite.html?kgr=as&aa=1&m=1&vorschlagsfunktionaktiv=true", System.UriKind.Absolute));
                sql.Separator();
            }
            else
            {
                picInternetStatus.Image = Properties.Resources.bad;
                MessageBox.Show("Internet connection problem");
            }
        }

        private void webDownload_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            if (webDownload.Url != (new System.Uri("http://jobboerse.arbeitsagentur.de/vamJB/startseite.html?kgr=as&aa=1&m=1&vorschlagsfunktionaktiv=true", System.UriKind.Absolute)))
                btnGetContact.Enabled = true;
            else btnGetContact.Enabled = false;
        }
        
        
        /// <summary>
        /// Button Exit event to close app
        /// </summary>
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
    }
}
