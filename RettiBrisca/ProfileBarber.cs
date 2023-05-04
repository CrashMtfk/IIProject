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
    public partial class ProfileBarber : Form
    {
        private SqlConnection DbConnection = new SqlConnection("Data Source=" +
              "DESKTOP-GTQ68AU\\SQLEXPRESS01;Initial Catalog=BDD;Integrated Security=True");

        public ProfileBarber()
        {
            InitializeComponent();
            textBox1.Text = GetBarberFullName();
            GetAppointments(Data.Username);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private string GetBarberFullName()
        {
            string name = "";
            try
            {
                DbConnection.Open();
                SqlCommand comanda = new SqlCommand("SELECT FullName FROM Frizer WHERE Frizer.Username = @Username",DbConnection);
                comanda.Parameters.AddWithValue("@Username", Data.Username);
                name = comanda.ExecuteScalar().ToString();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                DbConnection.Close();
            }
            return name;
        }

        private void GetAppointments(string usernameFrizer)
        {
            DataTable dt = new DataTable();
            try
            {
                DbConnection.Open();
                SqlDataAdapter da = new SqlDataAdapter();
                SqlCommand comanda2 = new SqlCommand("SELECT ID_Frizer FROM Frizer WHERE Frizer.Username = @Username", DbConnection);
                comanda2.Parameters.AddWithValue("@Username", Data.Username);
                object val = comanda2.ExecuteScalar();
                if(val != null)
                {
                    SqlCommand cmd = new SqlCommand("SELECT Client.FullName, Appointment.AppointmentDateAndTime FROM Client INNER JOIN Appointment ON Client.ID_Client = Appointment.ID_Client WHERE Appointment.ID_Frizer = @ID_Frizer AND Appointment.AppointmentDateAndTime >= DATEADD(hour, -3, GETDATE())", DbConnection);
                    cmd.Parameters.AddWithValue("@ID_Frizer", val);
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    sda.Fill(dt);
                    dataGridView1.DataSource = dt;
                    dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    dataGridView1.Columns[0].HeaderText = "Client";
                    dataGridView1.Columns[1].HeaderText = "Data si Ora";
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                DbConnection.Close();
            }
        }
    }
}
