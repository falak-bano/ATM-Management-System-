using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
namespace ATM_System_
{
    public partial class HOME : Form
    {
        public HOME()
        {
            InitializeComponent();
            this.ControlBox = false;
        }


        private void lblTitle_Click(object sender, EventArgs e)
        {

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            log.Show();
            this.Hide();
        }

        public static string AccNumber = "";
        private void HOME_Load(object sender, EventArgs e)
        {
            AccNumber = Login.AccNumber;

            AccNumlbl.Text = "Account Number: " + Login.AccNumber;
            //  AccNumlbl.Text = "Account Number: " + Login.AccNumber;
            //   AccNumlbl.Text = Login.AccNumber;
        }

        private void btnBalance_Click(object sender, EventArgs e)
        {
            Balance bal = new Balance();
            this.Hide();
            bal.Show();
        }

        private void AccNumlbl_Click(object sender, EventArgs e)
        {

        }

        private void btnMiniStatement_Click(object sender, EventArgs e)
        {
            Ministatement mini = new Ministatement();
            mini.Show();
            this.Hide();

        }

        private void btnDeposit_Click(object sender, EventArgs e)
        {
            Deposit depo = new Deposit();
            depo.Show();
            this.Hide();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ChangePin pin = new ChangePin();
            pin.Show();
            this.Hide();
        }


        private void btnWithdraw_Click(object sender, EventArgs e)
        {
            Withdraw wd = new Withdraw();
            wd.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FASTCASH Fcash = new FASTCASH();
            Fcash.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
