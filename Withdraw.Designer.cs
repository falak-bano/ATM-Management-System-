namespace ATM_System_
{
    partial class Withdraw
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label12 = new Label();
            lblTitle = new Label();
            panelTop = new Panel();
            label1 = new Label();
            btnLogout = new Button();
            btnLogin = new Button();
            label13 = new Label();
            wdamtTb = new TextBox();
            balancelbl = new Label();
            panel2 = new Panel();
            panelTop.SuspendLayout();
            SuspendLayout();
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Microsoft YaHei UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.ForeColor = Color.Red;
            label12.Location = new Point(547, 9);
            label12.Name = "label12";
            label12.Size = new Size(48, 50);
            label12.TabIndex = 3;
            label12.Text = "X";
            label12.Click += label12_Click;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Microsoft YaHei UI", 20.2F, FontStyle.Bold);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(66, 13);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(475, 45);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "ATM Management System";
            lblTitle.Click += lblTitle_Click;
            // 
            // panelTop
            // 
            panelTop.BackColor = Color.DarkSlateGray;
            panelTop.Controls.Add(label12);
            panelTop.Controls.Add(lblTitle);
            panelTop.Dock = DockStyle.Top;
            panelTop.ForeColor = Color.DarkSlateGray;
            panelTop.Location = new Point(0, 0);
            panelTop.Margin = new Padding(3, 4, 3, 4);
            panelTop.Name = "panelTop";
            panelTop.Size = new Size(596, 71);
            panelTop.TabIndex = 44;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft YaHei UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DarkSlateGray;
            label1.Location = new Point(235, 85);
            label1.Name = "label1";
            label1.Size = new Size(156, 31);
            label1.TabIndex = 56;
            label1.Text = "WITHDRAW";
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.White;
            btnLogout.Font = new Font("Microsoft YaHei UI", 16.2F, FontStyle.Bold);
            btnLogout.ForeColor = Color.DarkSlateGray;
            btnLogout.Location = new Point(226, 303);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(131, 50);
            btnLogout.TabIndex = 61;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.DarkSlateGray;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Microsoft YaHei UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(266, 240);
            btnLogin.Margin = new Padding(3, 4, 3, 4);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(240, 40);
            btnLogin.TabIndex = 60;
            btnLogin.Text = "Deposit";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Microsoft YaHei UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label13.ForeColor = Color.DarkSlateGray;
            label13.Location = new Point(137, 198);
            label13.Name = "label13";
            label13.Size = new Size(109, 30);
            label13.TabIndex = 57;
            label13.Text = "Amount:";
            // 
            // wdamtTb
            // 
            wdamtTb.Font = new Font("Microsoft YaHei UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            wdamtTb.Location = new Point(266, 195);
            wdamtTb.Margin = new Padding(3, 4, 3, 4);
            wdamtTb.Name = "wdamtTb";
            wdamtTb.Size = new Size(240, 37);
            wdamtTb.TabIndex = 58;
            // 
            // balancelbl
            // 
            balancelbl.AutoSize = true;
            balancelbl.Font = new Font("Microsoft YaHei UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            balancelbl.ForeColor = Color.DarkSlateGray;
            balancelbl.Location = new Point(176, 137);
            balancelbl.Name = "balancelbl";
            balancelbl.Size = new Size(215, 31);
            balancelbl.TabIndex = 62;
            balancelbl.Text = "Available Balance";
            balancelbl.Click += label2_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.DarkSlateGray;
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 356);
            panel2.Name = "panel2";
            panel2.Size = new Size(596, 21);
            panel2.TabIndex = 63;
            // 
            // Withdraw
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(596, 377);
            Controls.Add(panel2);
            Controls.Add(balancelbl);
            Controls.Add(label1);
            Controls.Add(panelTop);
            Controls.Add(btnLogout);
            Controls.Add(btnLogin);
            Controls.Add(wdamtTb);
            Controls.Add(label13);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Withdraw";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Available Balance";
            Load += Withdraw_Load;
            panelTop.ResumeLayout(false);
            panelTop.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label12;
        private Label lblTitle;
        private Panel panelTop;
       /* private Button btnClose;*/
        private Label label1;
        private Button btnLogout;
        private Button btnLogin;
        private TextBox textBox1;
        private Label label13;
        private TextBox txtAccountNumber;
        private Label label2;
        private Label balancelbl;
        private TextBox wdamtTb;
        private Panel panel2;
    }
}