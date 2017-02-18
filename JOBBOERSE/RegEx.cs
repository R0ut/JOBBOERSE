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
        private string text,patern,found,sideLink;
        private string compName, name, surtName, street, zipCode, city;
        private TextBox txtContact;
        
        public RegEx(TextBox txt, string sideLink)
        {
            this.txtContact = txt;
            this.sideLink = sideLink;
            sql = new SQL();
        }
        public string Found { get; private set; }


        // uruchomienie metody dla głównej a potem dla pojedynczych ofert. pattern 1 uruchamia pattern dla głównej(pobranie stronek) a 2 uruchamia pattern dla ofert(wyciaga adresy). i to sa nastepne linki od 0 do 9
        public void LoadFile(string file,int patternOption,int j) 
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
                else if(patternOption == 2)
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
                        //showContact(Found + "\r\n");
                        found = "";
                    }

                    //showContact("\r\n-------------\r\n");
                    sql.AddData(compName, name, surtName, street, zipCode, city);
                    
                   

                }
                else if(patternOption == 3)
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


        private void match() // tutaj trzeba zapetlic do 10
        {
           
            Match match = Regex.Match(text, patern);
            if (match.Success) // znalezienie pierwsze
            {
                found += match.Value;
            }

            // Get second match.
            match = match.NextMatch();
            if (match.Success)//znalezienie nastepne
            {
                //found += match.Value;
                
            }

            // Get third match.
            match = match.NextMatch(); //znalezienie nastepne mozna zrobic w petli
            if (match.Success)
            {
               // found += match.Value;
            }


        }

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

        private string ReplacePattern(string str) // tutaj poprawic bo jest na tasme ;D
        {
            string input = str.Trim();
            input.Replace("/", "");
            return input;
        }

        private void showContact(string text)
        {
            txtContact.Text += text;
        } // metoda do ustawienia txtBox
    }
}
