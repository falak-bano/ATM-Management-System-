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
    public partial class Ministatement : Form
    {
        public Ministatement()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=.\sqlexpress;Initial Catalog=ATM_DB;Integrated Security=True;Encrypt=True;TrustServerCertificate=True");
        string Acc = Login.AccNumber;
        private void populate()
        {

            Con.Open();
            string query = "select * from TransactionTbl where AccNum='" + Acc + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            MinistatementGDV.DataSource = ds.Tables[0];

            Con.Close();
        }
        private void ministatement_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void label12_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            HOME home = new HOME();
            this.Hide();
            home.Show();
        }

        private void btnLogout_Click_1(object sender, EventArgs e)
        {
            HOME home = new HOME();
            this.Hide();
            home.Show();
        }
    }
}
