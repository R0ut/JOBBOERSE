using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JOBBOERSE
{
    public partial class MainForm : Form
    {
        ConnectionCheck connectionCheck = new ConnectionCheck();
        GetHtml side = new GetHtml();
        RegEx expresion;

        
        
        public MainForm()
        {
            InitializeComponent();
            expresion = new RegEx(txtContact);
            if (connectionCheck.Internet() == true) picInternetStatus.Image = Properties.Resources.good;
            else picInternetStatus.Image = Properties.Resources.bad;


        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (connectionCheck.Internet() == true)
            {
                
                side.GetMainSide(webDownload); //pobranie głównej strony to dobre i zapisuje ja w res/html.txt tutaj

                for (int i = 0; i < 10; i++)
                {
                    expresion.LoadFile("html", 1, i);// to raz

                    side.GetSide("http://jobboerse.arbeitsagentur.de" + expresion.Found, "htmlOffer"); // pobrany kod strony już z ofertą 
                    expresion.LoadFile("htmlOffer", 2, i);
                }
                 
              
            }
            else picInternetStatus.Image = Properties.Resources.bad;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            expresion.LoadFile("html", 1,1);
            webDownload.Url = new System.Uri("http://jobboerse.arbeitsagentur.de" + expresion.Found, System.UriKind.Absolute);
        }
    }
}
