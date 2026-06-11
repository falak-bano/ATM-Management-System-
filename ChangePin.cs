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
    public partial class ChangePin : Form
    {
        public ChangePin()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=.\sqlexpress;Initial Catalog=ATM_DB;Integrated Security=True;Encrypt=True;TrustServerCertificate=True");
        string Acc = Login.AccNumber;
        private void ChangePin_Load(object sender, EventArgs e)
        {

        }

        private void txtAccountNumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (Pin1Tb.Text == "" || Pin2Tb.Text == "")
            {
                MessageBox.Show("Enter And Comfirm the New Pin");

            }
            else if (Pin2Tb.Text != Pin1Tb.Text)
            {
                MessageBox.Show("Pin1 And Pin2 are Different");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "UPDATE AccountTbl SET PIN = @PIN WHERE AccNum = @Acc";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.Parameters.AddWithValue("@PIN", Pin1Tb.Text);
                    cmd.Parameters.AddWithValue("@Acc", Acc);
                    cmd.ExecuteNonQuery();
                    Con.Close();

                    MessageBox.Show("PIN Succesfully Updated");
                    Login home = new Login();
                    home.Show();
                    this.Hide();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error during deposit: " + ex.Message);
                    Con.Close();
                }
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {

            HOME home = new HOME();
            this.Hide();
            home.Show();
        }

        private void label12_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
