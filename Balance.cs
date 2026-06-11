using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;

using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace ATM_System_
{
    public partial class Balance : Form
    {
        public Balance()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=.\sqlexpress;Initial Catalog=ATM_DB;Integrated Security=True;Encrypt=True;TrustServerCertificate=True");
        private void getbalance()
        {
         
            Con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("SELECT Balance FROM AccountTbl WHERE AccNum = '" + AccNumberlbl.Text + "'", Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            if (dt.Rows.Count > 0)
                Balancelbl.Text = "Rs " +dt.Rows[0][0].ToString();
            else
                MessageBox.Show("Account not found.");

            Con.Close();
        }

        private void Balance_Load(object sender, EventArgs e)
        {
            AccNumberlbl.Text = HOME.AccNumber;
            getbalance();
        }

        private void label12_Click(object sender, EventArgs e)
        {
            HOME home = new HOME();
            this.Hide();
            home.Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            HOME home = new HOME();
            this.Hide();
            home.Show();
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void AccNumberlbl_Click(object sender, EventArgs e)
        {

        }

        private void Balancelbl_Click(object sender, EventArgs e)
        {

        }
    }
}
