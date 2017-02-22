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

        /// <summary>
        /// Method that download html code from WebBrowser. And save in res.html
        /// </summary>
        public void GetMainSide(WebBrowser browser)
        {
            string projectPath = (Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName + "\\Resources"); // path to local resources
            if (!Directory.Exists(projectPath)) { Directory.CreateDirectory(projectPath); }
            string tempFileName = projectPath + "\\html.txt";
            StreamWriter writer = File.CreateText(tempFileName);
            writer.Write(browser.DocumentText);

            writer.Flush(); writer.Close();
        }

        /// <summary>
        ///Method that download html code. Is used to different offers
        /// </summary>
        /// <param name="side">side is string to webside</param>
        public void GetSide(string side) 
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
            //File save
            try
            {
                string projectPath = (Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName) + "/Resources/htmlOffer.txt"; // path of project
                System.IO.File.WriteAllText(projectPath, html);
            }
            catch (Exception er)
            {
                MessageBox.Show(er.ToString());
            }
        }
    }
}
