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
    public partial class Profile : Form
    {
        private SqlConnection DbConnection = new SqlConnection("Data Source=" +
                "DESKTOP-GTQ68AU\\SQLEXPRESS01;Initial Catalog=BDD;Integrated Security=True");

        public Profile()
        {
            InitializeComponent();
            txtUserName.Text = GetFullName(Data.Username);
            txtUserPoints.Text = GetNOPoints(Data.Username).ToString();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtUserName_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnMakeAppointment_Click(object sender, EventArgs e)
        {
            MakeAppointment appointmentPage = new MakeAppointment();
            appointmentPage.Show();
            this.Hide();
        }

        private int GetNOPoints(string username)
        {
            int result = 0;
            try
            {
                DbConnection.Open();
                SqlCommand comanda = new SqlCommand("SELECT Points.NumberOfPoints FROM Points INNER JOIN Client ON Points.ID_Client = Client.ID_Client WHERE Client.Username = @username", DbConnection);
                comanda.Parameters.AddWithValue("@Username", username);
                result = Convert.ToInt32(comanda.ExecuteScalar());
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                DbConnection.Close();
            }
            return result;
        }

        private string GetFullName(string username)
        {
            string result = "";
            try
            {
                DbConnection.Open();
                SqlCommand comanda = new SqlCommand("SELECT FullName FROM Client WHERE Client.Username = @username", DbConnection);
                comanda.Parameters.AddWithValue("@Username", username);

                result = (string)comanda.ExecuteScalar();      
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                DbConnection.Close();
            }
            return result;
        }

        private void btnPrices_Click(object sender, EventArgs e)
        {
            if (Data.Username != null && Data.Password != null)
            {
                Prices pricesPage = new Prices();
                pricesPage.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("First you have to login to see the prices page.");
            }
        }
    }
}
