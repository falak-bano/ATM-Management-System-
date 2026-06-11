using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace ATM_System_
{
    public partial class Deposit : Form
    {
        public Deposit()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=.\sqlexpress;Initial Catalog=ATM_DB;Integrated Security=True;Encrypt=True;TrustServerCertificate=True");

        string Acc = Login.AccNumber;
        int oldbalance, newbalance;

        private void getbalance()
        {
            try
            {
                Con.Open();
                SqlDataAdapter sda = new SqlDataAdapter("SELECT Balance FROM AccountTbl WHERE AccNum = @AccNum", Con);
                sda.SelectCommand.Parameters.AddWithValue("@AccNum", Acc);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    oldbalance = Convert.ToInt32(dt.Rows[0][0]);
                }
                Con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error fetching balance: " + ex.Message);
                Con.Close();
            }
        }

        private void Deposit_Load(object sender, EventArgs e)
        {
            getbalance();
        }

        private void addtransaction()
        {
            string TrType = "Deposit";
            try
            {
                Con.Open();
                string query = "INSERT INTO TransactionTbl (AccNum, Type, Amount, TDate) VALUES (@AccNum, @Type, @Amount, @Date)";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.Parameters.AddWithValue("@AccNum", Acc);
                cmd.Parameters.AddWithValue("@Type", TrType);
                cmd.Parameters.AddWithValue("@Amount", Convert.ToInt32(DepoAmtTb.Text));
                cmd.Parameters.AddWithValue("@Date", DateTime.Today.Date);
                cmd.ExecuteNonQuery();
                Con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Transaction insert error: " + ex.Message);
                Con.Close();
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (DepoAmtTb.Text == "" || Convert.ToInt32(DepoAmtTb.Text) <= 0)
            {
                MessageBox.Show("Enter the amount to deposit");
                return;
            }

            newbalance = oldbalance + Convert.ToInt32(DepoAmtTb.Text);
            try
            {
                Con.Open();
                string query = "UPDATE AccountTbl SET Balance = @Balance WHERE AccNum = @Acc";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.Parameters.AddWithValue("@Balance", newbalance);
                cmd.Parameters.AddWithValue("@Acc", Acc);
                cmd.ExecuteNonQuery();
                Con.Close();

                addtransaction();
                MessageBox.Show("Deposit successful!");
                HOME home = new HOME();
                home.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error during deposit: " + ex.Message);
                Con.Close();
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            HOME home = new HOME();
            home.Show();
            this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // No implementation needed (optional)
        }

        private void label12_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
