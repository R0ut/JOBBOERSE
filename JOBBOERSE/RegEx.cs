using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JOBBOERSE
{
    class RegEx
    {
        SQL sql;
        private string text, patern, found, sideLink;
        private string compName, name, surtName, street, zipCode, city;


        public RegEx(string sideLink)
        {
            this.sideLink = sideLink;
            sql = new SQL();
        }
        public string Found { get; private set; }

        /// <summary>
        /// This method filter txt file, with difrent regular expresions
        /// </summary>
        /// <param name="file">this parametr say with txt file we will use.Enabled files: html,htmlOffer</param>
        /// <param name="patternOption">patternOption define what expressions we will use. Option 1 main side it will download links to offers,Option 2 geting adress information from ofert,Option 3 get next webside code to dig for oferts (page2,page3...,page20)</param>
        /// <param name="j">Parametr to next pages</param>
        public void LoadFile(string file, int patternOption, int j)
        {

            try
            {
                string projectPath = (Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName) + "/Resources/" + file + ".txt"; // path of project
                text = System.IO.File.ReadAllText(projectPath);

                if (patternOption == 1)
                {

                    patern = ReplacePattern(Properties.Resources.pattern1 + j + Properties.Resources.pattern1_1);
                    match();
                    if (found != null)
                    {
                        Found = Replace(found);
                        found = "";
                    }

                }
                else if (patternOption == 2)
                {
                    for (int i = 0; i < 6; i++)
                    {
                        if (i == 0) patern = Properties.Resources.pattern2;
                        else if (i == 1) patern = Properties.Resources.pattern3;
                        else if (i == 2) patern = Properties.Resources.pattern4;
                        else if (i == 3) patern = Properties.Resources.pattern5;
                        else if (i == 4) patern = Properties.Resources.pattern6;
                        else if (i == 5) patern = Properties.Resources.pattern7;

                        match();
                        Found = Replace(found);
                        if (i == 0) compName = Found;
                        else if (i == 1) name = Found;
                        else if (i == 2) surtName = Found;
                        else if (i == 3) street = Found;
                        else if (i == 4) zipCode = Found;
                        else if (i == 5) city = Found;

                        found = "";
                    }

                    
                    if(sql.CompareWithDataBase(compName) != true) sql.AddData(compName, name, surtName, street, zipCode, city);



                }
                else if (patternOption == 3)
                {
                    patern = Properties.Resources.patternSideLink1;
                    text = sideLink;
                    match();
                    Found = Replace(found);
                    found = "";
                }

            }
            catch (Exception aa)
            {
                MessageBox.Show(aa.ToString());
            }
        }

        /// <summary>
        /// Method to match
        /// </summary>
        private void match() 
        {

            Match match = Regex.Match(text, patern);
            if (match.Success) // first match
            {
                found += match.Value;
            }
        }
        /// <summary>
        /// Method replace letters in string to Germatny letters
        /// </summary>
        private string Replace(string str)
        {
            string input = str.Trim();
            string tmp = input.Replace("&szlig;", "ß"); //B
            tmp = tmp.Replace("&Auml;", "Ä");
            tmp = tmp.Replace("&auml;", "ä");
            tmp = tmp.Replace("&Ouml;", "Ö");
            tmp = tmp.Replace("&ouml;", "ö");
            tmp = tmp.Replace("&Uuml;", "Ü");
            tmp = tmp.Replace("&uuml;", "ü");
            tmp = tmp.Replace("</", "");



            string output = tmp.Replace("&amp;", "&");
            return output;
        }
        /// <summary>
        /// Replace string method
        /// </summary>
        private string ReplacePattern(string str) 
        {
            string input = str.Trim();
            input.Replace("/", "");
            return input;
        }


    }
}
