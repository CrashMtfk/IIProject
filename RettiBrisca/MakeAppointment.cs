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
    public partial class MakeAppointment : Form
    {
        //private SqlConnection DbConnection = new SqlConnection("Data Source=" +
        //      "DESKTOP-GTQ68AU\\SQLEXPRESS01;Initial Catalog=BDD;Integrated Security=True");
        private SqlConnection DbConnection = new SqlConnection("Data Source=" +
                "LAPTOP-GPJH9TCQ\\SQLEXPRESS01;Initial Catalog=BDD;Integrated Security=True");


        public MakeAppointment()
        {
            InitializeComponent();
            SqlDataAdapter da = new SqlDataAdapter("SELECT Name FROM Frizer", DbConnection);
            PopulateComboBox(da);
        }

        private void btnGoProfile_Click(object sender, EventArgs e)
        {
            ProfilePageCall(); 
        }

        public void ProfilePageCall()
        {
            this.Hide();
            Profile profilePage = new Profile();
            profilePage.Show();
        }

        public Boolean PopulateComboBox(SqlDataAdapter da)
        {
            int ok = 0;
            try
            {
                DbConnection.Open();
                DataTable dt = new DataTable();
                da.Fill(dt);

                comboBox1.DataSource = dt;
                comboBox1.DisplayMember = "Name";

                if(comboBox1.Items.Count > 0)
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
            if(ok == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
