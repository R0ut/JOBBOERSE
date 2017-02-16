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
        RegEx expresion = new RegEx();

        private string firstSide= "http://jobboerse.arbeitsagentur.de/vamJB/stellenangeboteFinden.html?execution=e2s1&d_6827794_p=1";
        
        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (connectionCheck.Internet() == true)
            {
                picInternetStatus.Image = Properties.Resources.good;
                // side.GetSide(firstSide,"html"); //pobranie głównej strony
                side.GetMainSide(webDownload); //pobranie głównej strony to dobre 



                
                //Zrobic zeby stronka sie załadowała a potem pobrac kod
                expresion.LoadFile("html", 1);// to raz
                side.GetSide("http://jobboerse.arbeitsagentur.de" + expresion.Found,"htmlOffer");
                expresion.LoadFile("htmlOffer", 2); // to 10 razy
                                                                                    //porobic wyrazenia regularne 
            }
            else picInternetStatus.Image = Properties.Resources.bad;

        }
    }
}
