using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.IO;
using System.Windows.Forms;

namespace JOBBOERSE
{
    class SQL
    {
        string connectionString;
        public SQL()
        {
            connectionString = ConfigurationManager.ConnectionStrings["JOBBOERSE.Properties.Settings.AddresBookConnectionString"].ConnectionString;
        }


        /// <summary>
        /// Method that add to database data
        /// </summary>
        public void AddData(string CompanyName,string Name, string Surtname, string Street, string ZipCode, string City)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = " + Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName + @"\AddresBook.mdf; Integrated Security = True"))
                {
                    SqlCommand cmd = new SqlCommand("INSERT INTO Contact (CompanyName, Name, Surname, Street, ZipCode, City ) VALUES (@CompanyName, @Name, @Surname, @Street, @ZipCode, @City)");
                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = connection;
                    cmd.Parameters.AddWithValue("@CompanyName", CompanyName);
                    cmd.Parameters.AddWithValue("@Name", Name);
                    cmd.Parameters.AddWithValue("@Surname", Surtname);
                    cmd.Parameters.AddWithValue("@Street", Street);
                    cmd.Parameters.AddWithValue("@ZipCode", ZipCode);
                    cmd.Parameters.AddWithValue("@City", City);
                    connection.Open();
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Problem with database");
                MessageBox.Show(ex.ToString());
            }
        }

        
        /// <summary>
        /// Method that add in data base line with actual date(dd/mm/yyyy). It helps to filter database
        /// </summary>
        public void Separator()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = " + Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName + @"\AddresBook.mdf; Integrated Security = True"))
                {
                    SqlCommand cmd = new SqlCommand("INSERT INTO Contact (CompanyName, Name, Surname, Street, ZipCode, City ) VALUES (@CompanyName, @Name, @Surname, @Street, @ZipCode, @City)");
                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = connection;
                    cmd.Parameters.AddWithValue("@CompanyName", "----------");
                    cmd.Parameters.AddWithValue("@Name", "----------");
                    cmd.Parameters.AddWithValue("@Surname", "Last update date:");
                    cmd.Parameters.AddWithValue("@Street", DateTime.Now.ToString("MM/dd/yyyy"));
                    cmd.Parameters.AddWithValue("@ZipCode", "----------");
                    cmd.Parameters.AddWithValue("@City", "----------");
                    connection.Open();
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Problem with database");
                MessageBox.Show(ex.ToString());
            }
        }

        /// <summary>
        /// Method that compare database data with data from our program
        /// </summary>
        /// <param name="toCompare">String to compare with database</param>
        /// <returns>return true when compared string are in database else false</returns>
        public bool CompareWithDataBase(string toCompare) 
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = " + Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName + @"\AddresBook.mdf; Integrated Security = True"))
                {
                    SqlCommand cmd = new SqlCommand("SELECT * FROM Contact WHERE CompanyName = @CompanyNametoCompare");
                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = connection;
                    cmd.Parameters.AddWithValue("@CompanyNametoCompare", toCompare);
                    connection.Open();
                    var search = cmd.ExecuteReader();
                    return search.Read();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Problem with database research");
                MessageBox.Show(ex.ToString());
                return true;
            }
           
        }

        /// <summary>
        /// Method to refresh data from database
        /// </summary>
        public void RefreshData(DataGridView dataGridView)
        {
            SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = " + Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName + @"\AddresBook.mdf; Integrated Security = True");
            string query = "select * from Contact";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView.DataSource = dt;
        }



    }
}
