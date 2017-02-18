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
        //SqlConnection connection;
        public SQL()
        {
            connectionString = ConfigurationManager.ConnectionStrings["JOBBOERSE.Properties.Settings.AddresBookConnectionString"].ConnectionString;
        }

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

        public void test(string CompanyName, string Name, string Surtname, string Street, string ZipCode, string City)
        {
            string tempstr = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = " + Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName + @"\AddresBook.mdf; Integrated Security = True";
            SqlConnection con = new SqlConnection(tempstr);

            SqlCommand cmd = new SqlCommand("INSERT INTO Contact (CompanyName, Name, Surname, Street, ZipCode, City ) VALUES (@CompanyName, @Name, @Surname, @Street, @ZipCode, @City)", con);
            cmd.Parameters.AddWithValue("@CompanyName", CompanyName);
            cmd.Parameters.AddWithValue("@Name", Name);
            cmd.Parameters.AddWithValue("@Surname", Surtname);
            cmd.Parameters.AddWithValue("@Street", Street);
            cmd.Parameters.AddWithValue("@ZipCode", ZipCode);
            cmd.Parameters.AddWithValue("@City", City);
            con.Open();

            try
            {
                int affectedRows = cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

    }
}
