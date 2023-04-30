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
    public partial class LogIn : Form
    {
        private SqlConnection DbConnection = new SqlConnection("Data Source=" +
                "DESKTOP-GTQ68AU\\SQLEXPRESS01;Initial Catalog=BDD;Integrated Security=True");
      
        public LogIn()
        {
            InitializeComponent();
        }

        private void btnGoHome_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnGoRegister_Click(object sender, EventArgs e)
        {
            Register register = new Register();
            register.Show();
            this.Hide();
        }

        private void btnLogUser_Click(object sender, EventArgs e)
        {
            string username = txtUsernameLogin.Text;
            string password = txtPasswordLogin.Text;
            LoginUser(username,password);
        }

        private Boolean LoginUser(string username, string password)
        {
            int ok = 0;
            try
            {
                DbConnection.Open();

                SqlCommand comanda = new SqlCommand("SELECT COUNT(*) FROM Client WHERE Username = @username AND Password = @password", DbConnection);
                comanda.Parameters.AddWithValue("@Username", username);
                comanda.Parameters.AddWithValue("@Password", password);

                int count = (int)comanda.ExecuteScalar();

                if (count > 0)
                {
                    Data.Username = username;
                    Data.Password = password;
                    ok = 1;
                    this.Hide();
                    Profile profilePage = new Profile();
                    profilePage.Show();
                }
                else
                {
                    MessageBox.Show("Credintialele sunt gresite.");
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
