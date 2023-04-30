using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace RettiBrisca
{
    public partial class Register : Form
    {
        private SqlConnection DbConnection = new SqlConnection("Data Source=" +
                "DESKTOP-GTQ68AU\\SQLEXPRESS01;Initial Catalog=BDD;Integrated Security=True");

        public Register()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnGoHome_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }

        private void btnGoLogIn_Click(object sender, EventArgs e)
        {
            LogIn logIn = new LogIn();
            logIn.Show();
            this.Hide();
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            string username = textUsernameRegister.Text;
            string password = txtPasswordRegister.Text;
            string fullName = txtFullNameRegister.Text;
            string phoneNumber = txtPhoneRegister.Text;
            RegisterUser(username,password,fullName,phoneNumber);
        }

        private Boolean UsernameExists(string username)
        {
            int ok = 1;
            try
            {
                DbConnection.Open();
                using(SqlCommand comanda = new SqlCommand("SELECT COUNT(*) FROM Client WHERE Username = @username", DbConnection))
                {
                    comanda.Parameters.AddWithValue("@username", username);
                    int count = (int)comanda.ExecuteScalar();
                    if(count > 0)
                    {
                        ok = 0;
                    }
                    
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
            if(ok == 0)
            {
                return true;
            }
            else
            {
                return false;
            }   
        }

        private Boolean isNumeric(string phoneNumber)
        {
            foreach(char caracter in phoneNumber)
            {
                if(!(caracter >= '0' && caracter <= '9'))
                {
                    return false;
                }
            }
            return true;
        }

        private Boolean RegisterUser(string username, string password, string fullName, string phoneNumber)
        {
            int ok = 0;     
            if (UsernameExists(username))
            {
                MessageBox.Show("Exista deja un utilizator cu acest username. Te rugam alege alt username pentru a proceda mai departe.");
            }
            else
            {
                if (username.Length < 5)
                {
                    MessageBox.Show("Username trebuie sa contina minim 6 caractere.");
                }
                else if (password.Length < 7)
                {
                    MessageBox.Show("Password trebuie sa contina minim 8 caractere.");
                }
                else if (fullName.Length < 5)
                {
                    MessageBox.Show("Full Name trebuie sa contina minim 6 caractere.");
                }
                else if (phoneNumber.Length != 10)
                {
                    MessageBox.Show("Numarul de telefon nu este de 10 cifre, corecteaza inainte de a proceda mai departe.");
                }
                else if (!isNumeric(phoneNumber))
                {
                    MessageBox.Show("Aveti voie intorducerea numai a numerelor. Verificati inainte de a proceda mai departe.");
                }
                else
                {
                    try
                    {
                        DbConnection.Open();
                        SqlCommand comanda = new SqlCommand("INSERT INTO Client (Username, Password, PhoneNumber, FullName) VALUES(@username, @password, @phoneNumber, @fullName)", DbConnection);
                        comanda.Parameters.AddWithValue("@Username", username);
                        comanda.Parameters.AddWithValue("@Password", password);
                        comanda.Parameters.AddWithValue("@PhoneNumber", phoneNumber);
                        comanda.Parameters.AddWithValue("@FullName", fullName);
                        comanda.ExecuteNonQuery();

                        SqlCommand comandaID = new SqlCommand("SELECT IDENT_CURRENT('Client')", DbConnection);
                        int ID_Client = Convert.ToInt32(comandaID.ExecuteScalar());

                        SqlCommand comandaPuncte = new SqlCommand("INSERT INTO Points (ID_Client, NumberOfPoints) VALUES (@ID_Client, 0)", DbConnection);
                        comandaPuncte.Parameters.AddWithValue("@ID_Client", ID_Client);
                        comandaPuncte.Parameters.AddWithValue("0", 0);
                        comandaPuncte.ExecuteNonQuery();

                        MessageBox.Show("Inregistrare facuta cu succes!");
                        ok = 1;
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
            }
            if(ok == 1)
            {
                return true;
            }
            return false;
        }
    }
}
