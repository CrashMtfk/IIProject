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
    public partial class Register : Form
    {
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
    }
}
