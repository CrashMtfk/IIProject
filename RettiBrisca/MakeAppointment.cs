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
    public partial class MakeAppointment : Form
    {
        public MakeAppointment()
        {
            InitializeComponent();
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
    }
}
