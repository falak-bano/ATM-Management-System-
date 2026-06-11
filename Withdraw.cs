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
    public partial class Withdraw : Form

    {
        public Withdraw()
        {
            InitializeComponent();
        }
        string Acc = Login.AccNumber;
        SqlConnection Con = new SqlConnection(@"Data Source=.\sqlexpress;Initial Catalog=ATM_DB;Integrated Security=True;Encrypt=True;TrustServerCertificate=True");
        int bal;
        private void getbalance()
        {

            Con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("SELECT Balance FROM AccountTbl WHERE AccNum = '" + Acc + "'", Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                balancelbl.Text = "Balance Rs " + dt.Rows[0][0].ToString();
                bal = Convert.ToInt32(dt.Rows[0][0].ToString());
            }
            else
            {
                MessageBox.Show("Account not found.");
            }
            Con.Close();
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void addtransaction()
        {
            string TrType = "Withdraw";
            try
            {
                Con.Open();
                string query = "INSERT INTO TransactionTbl (AccNum, Type, Amount, TDate) VALUES (@AccNum, @Type, @Amount, @Date)";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.Parameters.AddWithValue("@AccNum", Acc);
                cmd.Parameters.AddWithValue("@Type", TrType);
                cmd.Parameters.AddWithValue("@Amount", Convert.ToInt32(wdamtTb.Text));
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

        private void Withdraw_Load(object sender, EventArgs e)
        {
            getbalance();
        }
        int newbalance;
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (wdamtTb.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else if (Convert.ToInt32(wdamtTb.Text) <= 0)
            {
                MessageBox.Show("Enter a valid Amount");
            }
            else if (Convert.ToInt32(wdamtTb.Text) > bal)
            {
                MessageBox.Show("Balance Can not be.negative");
            }
            else
            {
                try
                {
                    newbalance = bal - Convert.ToInt32(wdamtTb.Text);
                    try
                    {
                        Con.Open();
                        string query = "UPDATE AccountTbl SET Balance = @Balance WHERE AccNum = @Acc";
                        SqlCommand cmd = new SqlCommand(query, Con);
                        cmd.Parameters.AddWithValue("@Balance", newbalance);
                        cmd.Parameters.AddWithValue("@Acc", Acc);
                        cmd.ExecuteNonQuery();
                        Con.Close();

                        MessageBox.Show("Successfully Withdraw");
                        addtransaction();

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
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

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

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }
    }
}
