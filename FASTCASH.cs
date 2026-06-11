using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace ATM_System_
{
    public partial class FASTCASH : Form
    {
        public FASTCASH()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=.\sqlexpress;Initial Catalog=ATM_DB;Integrated Security=True;Encrypt=True;TrustServerCertificate=True");
        string Acc = Login.AccNumber;
        int bal;

        private void FASTCASH_Load(object sender, EventArgs e)
        {
            GetBalance();
        }

        private void GetBalance()
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
                    bal = Convert.ToInt32(dt.Rows[0][0]);
                    balancelbl.Text = $"Balance Rs {bal}";
                }
                else
                {
                    MessageBox.Show("Account not found.");
                }
            }
            finally
            {
                Con.Close();
            }
        }

        private void Withdraw(int amount)
        {
            if (bal < amount)
            {
                MessageBox.Show("Insufficient Balance.");
                return;
            }

            int newBalance = bal - amount;
            try
            {
                Con.Open();

                // Log transaction
                string insertQuery = "INSERT INTO TransactionTbl (AccNum, Type, Amount, TDate) VALUES (@AccNum, 'Withdraw', @Amount, @Date)";
                SqlCommand insertCmd = new SqlCommand(insertQuery, Con);
                insertCmd.Parameters.AddWithValue("@AccNum", Acc);
                insertCmd.Parameters.AddWithValue("@Amount", amount);
                insertCmd.Parameters.AddWithValue("@Date", DateTime.Today.Date);
                insertCmd.ExecuteNonQuery();

                // Update balance
                string updateQuery = "UPDATE AccountTbl SET Balance = @Balance WHERE AccNum = @Acc";
                SqlCommand updateCmd = new SqlCommand(updateQuery, Con);
                updateCmd.Parameters.AddWithValue("@Balance", newBalance);
                updateCmd.Parameters.AddWithValue("@Acc", Acc);
                updateCmd.ExecuteNonQuery();

                MessageBox.Show("Withdrawal Successful");

                HOME home = new HOME();
                home.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error during withdrawal: " + ex.Message);
            }
            finally
            {
                Con.Close();
            }
        }

        // Button Click Handlers - call Withdraw with appropriate amount
        private void btnDeposit_Click_1(object sender, EventArgs e) => Withdraw(100);
        private void btnWithdraw_Click(object sender, EventArgs e) => Withdraw(500);
        private void button2_Click(object sender, EventArgs e) => Withdraw(1000);
        private void btnMiniStatement_Click(object sender, EventArgs e) => Withdraw(2000);
        private void button1_Click(object sender, EventArgs e) => Withdraw(5000);
        private void btnBalance_Click(object sender, EventArgs e) => Withdraw(10000);

        private void btnLogout_Click(object sender, EventArgs e)
        {
            HOME home = new HOME();
            home.Show();
            this.Hide();
        }

        private void label12_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lblTitle_Click(object sender, EventArgs e) { }
    }
}
