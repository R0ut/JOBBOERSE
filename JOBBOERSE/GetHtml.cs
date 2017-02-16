using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


//klasa do pobierania treści stron i zapisania ich w odpowiednim pliku
namespace JOBBOERSE
{
    class GetHtml
    {
        private string html;

        //pobiera strone i zapisuje ja w resources\html.txt
        public void GetMainSide(WebBrowser browser)
        {
            string projectPath = (Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName + "\\Resources"); // path to local resources
            if (!Directory.Exists(projectPath)) { Directory.CreateDirectory(projectPath); }
            string tempFileName = projectPath + "\\html.txt";
            StreamWriter writer = File.CreateText(tempFileName);
            writer.Write(browser.DocumentText);

            writer.Flush(); writer.Close();
        }
        public void GetSide(string side, string file) //side jest to string strony a res jest to resource txt tutaj przy  stronie main ma byc html, a przy ofercie pracy htmlOffer
        {
            //get html code from side
            try
            {
                string url = side;
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
                request.Proxy = null;
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                StreamReader sr = new StreamReader(response.GetResponseStream());
                html = sr.ReadToEnd();
                sr.Close();
            }
            catch (Exception ea)
            {
                MessageBox.Show(ea.ToString());
            }
            //Zapis do pliku w katalogu Pogoda
            try
            {
                string projectPath = (Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName) + "/Resources/" + file + ".txt"; // path of project
                System.IO.File.WriteAllText(projectPath, html);
            }
            catch (Exception er)
            {
                MessageBox.Show(er.ToString());
            }
        }
    }
}
