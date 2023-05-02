using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace RettiBrisca
{
    public partial class Prices : Form
    {

        //private SqlConnection DbConnection = new SqlConnection("Data Source=" +
        //      "DESKTOP-GTQ68AU\\SQLEXPRESS01;Initial Catalog=BDD;Integrated Security=True");
        private SqlConnection DbConnection = new SqlConnection("Data Source=" +
                "LAPTOP-GPJH9TCQ\\SQLEXPRESS01;Initial Catalog=BDD;Integrated Security=True");


        public Prices()
        {
            InitializeComponent();
            SqlDataAdapter da = new SqlDataAdapter("SELECT Name FROM Frizer", DbConnection);
            PopulateComboBox(da);
        }

        private Boolean PopulateComboBox(SqlDataAdapter da)
        {
            int ok = 0;
            try
            {
                DbConnection.Open();
                DataTable dt = new DataTable();
                da.Fill(dt);

                boxFrizeri.DataSource = dt;
                boxFrizeri.DisplayMember = "Name";

                if (boxFrizeri.Items.Count > 0)
                {
                    ok = 1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                DbConnection.Close();
            }
            if (ok == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void btnGoProfile_Click(object sender, EventArgs e)
        {
            Profile profilePage = new Profile();
            profilePage.Show();
            this.Hide();
        }
    }
}
