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
using System.Globalization;

namespace RettiBrisca
{
    public partial class MakeAppointment : Form
    {
        private SqlConnection DbConnection = new SqlConnection("Data Source=" +
              "DESKTOP-GTQ68AU\\SQLEXPRESS01;Initial Catalog=BDD;Integrated Security=True");
        //private SqlConnection DbConnection = new SqlConnection("Data Source=" +
        //        "LAPTOP-GPJH9TCQ\\SQLEXPRESS01;Initial Catalog=BDD;Integrated Security=True");


        public MakeAppointment()
        {
            InitializeComponent();
            SqlDataAdapter da = new SqlDataAdapter("SELECT FullName FROM Frizer", DbConnection);
            PopulateComboBox(da);
            comboBox1.SelectedIndex = -1;
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
                comboBox1.DisplayMember = "FullName";

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

        private void btnCreateAppointment_Click(object sender, EventArgs e)
        {
            Appointment();
        }

        private Boolean Appointment()
        {
            int ok = 0;
            int selInd = comboBox1.SelectedIndex;

            if (selInd != -1)
            {
                string nameFrizer = comboBox1.Text;
                string usernameClient = Data.Username;

                if (dateTimePicker1.Value < DateTime.Now)
                {
                    MessageBox.Show("Selecteaza o data corecta.");
                }
                else
                {
                    try
                    {
                        DbConnection.Open();
                        SqlCommand comanda = new SqlCommand("SELECT ID_Frizer from Frizer WHERE Frizer.FullName = @nameFrizer", DbConnection);
                        comanda.Parameters.AddWithValue("@nameFrizer", nameFrizer);
                        SqlCommand comanda2 = new SqlCommand("SELECT ID_Client from Client WHERE Client.Username = @usernameClient", DbConnection);
                        comanda2.Parameters.AddWithValue("@usernameClient", usernameClient);
                        object result = comanda.ExecuteScalar();
                        object result2 = comanda2.ExecuteScalar();
                        if (result != null && result2 != null)
                        {
                            DateTime AppointmentDateAndTime = dateTimePicker1.Value;
                            int ID_Client = (int)result2;
                            int ID_Frizer = (int)result;
                            SqlCommand cmd = new SqlCommand("INSERT INTO Appointment (ID_Frizer, ID_Client, AppointmentDateAndTime) VALUES (@ID_Frizer, @ID_Client, @AppointmentDateAndTime)", DbConnection);
                            cmd.Parameters.AddWithValue("@ID_Frizer", ID_Frizer);
                            cmd.Parameters.AddWithValue("@ID_Client", ID_Client);
                            cmd.Parameters.AddWithValue("@AppointmentDateAndTime", AppointmentDateAndTime);              
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Programarea a fost facuta.");
                            ok = 1;

                            SqlCommand pointsIncrease = new SqlCommand("UPDATE Points SET NumberOfPoints = NumberOfPoints + 35 WHERE ID_Client = @ID_Client", DbConnection);
                            pointsIncrease.Parameters.AddWithValue("@ID_Client", ID_Client);
                            pointsIncrease.ExecuteNonQuery();
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
            else
            {
                MessageBox.Show("Selecteaza un frizer inainte de a face o programare.");
            }
            if (ok == 1)
            {
                return true;
            }
            else return false;
        }

        public Boolean AppointmentT(string nameFrizer, DateTime dt, string usernameClient)
        {
            int ok = 0;
            int selInd = comboBox1.SelectedIndex;

          
                
                {
                    try
                    {
                        DbConnection.Open();
                        SqlCommand comanda = new SqlCommand("SELECT ID_Frizer from Frizer WHERE Frizer.FullName = @nameFrizer", DbConnection);
                        comanda.Parameters.AddWithValue("@nameFrizer", nameFrizer);
                        SqlCommand comanda2 = new SqlCommand("SELECT ID_Client from Client WHERE Client.Username = @usernameClient", DbConnection);
                        comanda2.Parameters.AddWithValue("@usernameClient", usernameClient);
                        object result = comanda.ExecuteScalar();
                        object result2 = comanda2.ExecuteScalar();
                        if (result != null && result2 != null)
                        {
                            DateTime AppointmentDateAndTime = dt;
                            int ID_Client = (int)result2;
                            int ID_Frizer = (int)result;
                            SqlCommand cmd = new SqlCommand("INSERT INTO Appointment (ID_Frizer, ID_Client, AppointmentDateAndTime) VALUES (@ID_Frizer, @ID_Client, @AppointmentDateAndTime)", DbConnection);
                            cmd.Parameters.AddWithValue("@ID_Frizer", ID_Frizer);
                            cmd.Parameters.AddWithValue("@ID_Client", ID_Client);
                            cmd.Parameters.AddWithValue("@AppointmentDateAndTime", AppointmentDateAndTime);
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Programarea a fost facuta.");
                            ok = 1;

                            SqlCommand pointsIncrease = new SqlCommand("UPDATE Points SET NumberOfPoints = NumberOfPoints + 35 WHERE ID_Client = @ID_Client", DbConnection);
                            pointsIncrease.Parameters.AddWithValue("@ID_Client", ID_Client);
                            pointsIncrease.ExecuteNonQuery();
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

                }
            
            
            if (ok == 1)
            {
                return true;
            }
            else return false;
        }
    }
}
