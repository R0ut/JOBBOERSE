using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JOBBOERSE
{
    
    public partial class DataPresent : Form
    {
        SQL sql;

        public DataPresent()
        {
            InitializeComponent();
            sql = new SQL();
        }

        private void DataPresent_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dbSetContact.Contact' table. You can move, or remove it, as needed.
            this.contactTableAdapter1.Fill(this.dbSetContact.Contact);
           
            sql.RefreshData(contactDataGridView);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            sql.RefreshData(contactDataGridView);
        }
    }
}
