using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RettiBrisca
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            Register register = new Register();
            register.Show();
            this.Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            LogIn logIn = new LogIn();
            logIn.Show();
            this.Hide();
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
