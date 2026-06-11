using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace ATM_System_
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Account acc = new Account();
            acc.Show();
            this.Hide();
        }



        public static string AccNumber = "";

        SqlConnection Con = new SqlConnection(@"Data Source=.\sqlexpress;Initial Catalog=ATM_DB;Integrated Security=True;Encrypt=True;TrustServerCertificate=True");

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                Con.Open();
                string query = "SELECT COUNT(*) FROM AccountTbl WHERE Accnum=@accnum AND PIN=@pin";
                SqlDataAdapter sda = new SqlDataAdapter(query, Con);
                sda.SelectCommand.Parameters.AddWithValue("@accnum", AccNumTb.Text);
                sda.SelectCommand.Parameters.AddWithValue("@pin", PinTb.Text);

                DataTable dt = new DataTable();
                sda.Fill(dt);

                if (dt.Rows[0][0].ToString() == "1")
                {
                    AccNumber = AccNumTb.Text;
                    HOME home = new HOME();
                    home.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Wrong Account Number or PIN Code");
                }
            }
            finally
            {
                Con.Close();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void AccNumTb_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
