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
        private string text,patern,found;
        

        public string Found { get; private set; }


        // uruchomienie metody dla głównej a potem dla pojedynczych ofert. pattern 1 uruchamia pattern dla głównej(pobranie stronek) a 2 uruchamia pattern dla ofert(wyciaga adresy)
        public void LoadFile(string file,int patternOption) 
        {
            if (patternOption == 1) patern = Properties.Resources.pattern1;
            else patern = Properties.Resources.pattern2;
                try
                {
                string projectPath = (Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName) + "/Resources/" + file + ".txt"; // path of project
                text = System.IO.File.ReadAllText(projectPath);

                
                match();
                Found = found;
                found = "";
                if (patternOption == 2) saveInformation(Found);
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

        private void saveInformation(string html)
        {
            string projectPath = (Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName) + "/Resources/htmlOffer.txt"; 
            System.IO.File.WriteAllText(projectPath, html);
        }
    }
}
