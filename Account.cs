using System;
using System.Data;
using System.Drawing;
using System.Net.NetworkInformation;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using Microsoft.VisualBasic;

namespace ATM_System_
{
    public partial class Account : Form
    {
        public Account()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=.\sqlexpress;Initial Catalog=ATM_DB;Integrated Security=True;Encrypt=True;TrustServerCertificate=True");


        private void btnLogout_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            int bal = 0;

            if (AccNametb.Text == "" || AccNumTb.Text == "" || FanameTb.Text == "" || PhoneTb.Text == "" || Addresstb.Text == "" || occupationtb.Text == "" || pintb.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "INSERT INTO AccountTbl (AccNum, AccName, FaName, Dob, Phone, Address, Education, Occupation, Pin, Balance) " +
                                   "VALUES (@AccNum, @AccName, @FaName, @Dob, @Phone, @Address, @Education, @Occupation, @Pin, @Balance)";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.Parameters.AddWithValue("@AccNum", AccNumTb.Text);
                    cmd.Parameters.AddWithValue("@AccName", AccNametb.Text);
                    cmd.Parameters.AddWithValue("@FaName", FanameTb.Text);
                    cmd.Parameters.AddWithValue("@Dob", DobDate.Value.Date);
                    cmd.Parameters.AddWithValue("@Phone", PhoneTb.Text);
                    cmd.Parameters.AddWithValue("@Address", Addresstb.Text);
                    cmd.Parameters.AddWithValue("@Education", educationcb.SelectedItem?.ToString() ?? "");
                    cmd.Parameters.AddWithValue("@Occupation", occupationtb.Text);
                    cmd.Parameters.AddWithValue("@Pin", pintb.Text);
                    cmd.Parameters.AddWithValue("@Balance", bal);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Account Created Successfully");
                    Con.Close();
                    Login log = new Login();
                    log.Show();
                    this.Hide();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void label12_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pintb_TextChanged(object sender, EventArgs e)
        {

        }
    }
}