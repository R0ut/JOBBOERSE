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
/// moze zmienic ten loading na jakies foto tylko z napisem loading i sam progres bar. Usunąc stara baza z solution. Poczyscic i zrobic .exe moze podziała. mozna sprawdzic na stacjonarce
/// </summary>
namespace JOBBOERSE
{
    public partial class MainForm : Form
    {
        ConnectionCheck connectionCheck = new ConnectionCheck();
        GetHtml side = new GetHtml();
        RegEx expresion;
        SQL sql = new SQL();
        
        
        private string sidelink;
        
        public MainForm()
        {
            InitializeComponent();
            if (connectionCheck.Internet() == true) picInternetStatus.Image = Properties.Resources.good;
            else picInternetStatus.Image = Properties.Resources.bad;
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
          

            if (connectionCheck.Internet() == true)
            {
                picLoading.Visible = true;
                progBarDwonload.Visible = true;
                sidelink = webDownload.Url.AbsoluteUri;
                expresion = new RegEx(sidelink);

                for (int ii = 1; ii < 21; ii++) //21 to max stron 2 to jedna strona pobiera i przechodzi na druga bez poierania
                {
                    side.GetMainSide(webDownload); //pobranie głównej strony to dobre i zapisuje ja w res/html.txt tutaj
                    progBarDwonload.Value = ii;

                    for (int i = 0; i < 10; i++)
                    {
                        expresion.LoadFile("html", 1, (i + (10 * (ii - 1))));// to raz
                        side.GetSide("http://jobboerse.arbeitsagentur.de" + expresion.Found, "htmlOffer"); // pobrany kod strony już z ofertą 
                        expresion.LoadFile("htmlOffer", 2, i);
                    }
                    expresion.LoadFile("html", 3, 0);// przeszukanie linku na next strone




                    webDownload.Url = new System.Uri("http://jobboerse.arbeitsagentur.de/vamJB/stellenangeboteFinden.html?" + "d_6827794_p=" + (ii + 1) + "&execution=e" + expresion.Found + "s1", System.UriKind.Absolute);
                    while (webDownload.ReadyState != WebBrowserReadyState.Complete)
                    {
                        Application.DoEvents();
                    }
                    //MessageBox.Show("Loaded");

                }
                MessageBox.Show("Downloaded all websites","Information",MessageBoxButtons.OK, MessageBoxIcon.Information);
               
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

        private void btnShowData_Click(object sender, EventArgs e)
        {
            var dataShow = new DataShow();
            dataShow.Show();
        }

      

        private void webDownload_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            if (webDownload.Url != (new System.Uri("http://jobboerse.arbeitsagentur.de/vamJB/startseite.html?kgr=as&aa=1&m=1&vorschlagsfunktionaktiv=true", System.UriKind.Absolute)))
                btnGetContact.Enabled = true;
        }
    }
}
