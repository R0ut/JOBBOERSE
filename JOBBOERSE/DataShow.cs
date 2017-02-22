using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JOBBOERSE
{
    public partial class DataShow : Form
    {
        SQL sql;
        public DataShow()
        {
            InitializeComponent();
            sql = new SQL();
        }

      

        private void contactBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.contactBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dbContact);
        }

        private void DataShow_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dbContact.Contact' table. You can move, or remove it, as needed.
            this.contactTableAdapter.Fill(this.dbContact.Contact);
            sql.RefreshData(contactDataGridView);
        }

        /// <summary>
        /// Refresh data in form
        /// </summary>
        private void tbtnRefresh_Click(object sender, EventArgs e)
        {
            sql.RefreshData(contactDataGridView);
        }
    }
}
