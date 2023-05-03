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

        private SqlConnection DbConnection = new SqlConnection("Data Source=" +
              "DESKTOP-GTQ68AU\\SQLEXPRESS01;Initial Catalog=BDD;Integrated Security=True");
        //private SqlConnection DbConnection = new SqlConnection("Data Source=" +
        //        "LAPTOP-GPJH9TCQ\\SQLEXPRESS01;Initial Catalog=BDD;Integrated Security=True");


        public Prices()
        {
            InitializeComponent();
            SqlDataAdapter da = new SqlDataAdapter("SELECT FullName FROM Frizer", DbConnection);
            PopulateComboBox(da);
            boxFrizeri.SelectedIndex = -1;
            DataTable dt = new DataTable();
            dt.Columns.Add("Nume cupon");
            dt.Columns.Add("Puncte necesare");
            dt.Rows.Add("Reducere 15%", 100);
            dt.Rows.Add("Reducere 45%", 250);
            dt.Rows.Add("Reducere 65%", 475);
            dt.Rows.Add("Reducere 80%", 1000);  
            couponList.DataSource = dt;
            couponList.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            couponList.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
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
                boxFrizeri.DisplayMember = "FullName";

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

        private Boolean PopulateDataGrid(string name)
        {
            int ok = 0;
            if (DbConnection.State == ConnectionState.Open)
            {
                DbConnection.Close();
            }
            try
            {
                DbConnection.Open();
                SqlCommand comanda = new SqlCommand("SELECT ID_Frizer from Frizer WHERE Frizer.FullName = @name", DbConnection);
                comanda.Parameters.AddWithValue("@name", name);
                DataTable dt = new DataTable();
                object result = comanda.ExecuteScalar();
                if (result != null)
                {
                    int ID_Frizer = (int)result;
                    string query = "SELECT Service,Price FROM Prices INNER JOIN Frizer ON Prices.ID_Frizer = Frizer.ID_Frizer WHERE Frizer.ID_Frizer = " + ID_Frizer;
                    SqlDataAdapter da2 = new SqlDataAdapter(query, DbConnection);
                    da2.Fill(dt);
                    dataPreturi.DataSource = dt;
                    dataPreturi.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    dataPreturi.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    ok = 1;
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

        private void boxFrizeri_SelectedIndexChanged(object sender, EventArgs e)
        {
            string name = boxFrizeri.Text;
            PopulateDataGrid(name);
        }
    }
}
