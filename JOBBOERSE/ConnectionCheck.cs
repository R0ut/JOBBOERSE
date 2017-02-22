using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JOBBOERSE
{

   
    class ConnectionCheck
    {
        /// <summary>
        /// Method return true when connection to internet is enable
        /// </summary>
        /// <returns>return true when connection to internet is enable</returns>
        public bool Internet()
        {
            try
            {
                var ping = new System.Net.NetworkInformation.Ping();

                var result = ping.Send("www.google.pl");

                if (result.Status != System.Net.NetworkInformation.IPStatus.Success)
                    return false;
                else return true;

            }
            catch (PingException ad)
            {
                MessageBox.Show("Internet connection problem, check your connection");
                return false;
            }
        }
    }
}
