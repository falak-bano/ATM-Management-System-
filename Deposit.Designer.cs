namespace ATM_System_
{
    partial class Deposit
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
            panelTop = new Panel();
            lblTitle = new Label();
            btnLogin = new Button();
            DepoAmtTb = new TextBox();
            label13 = new Label();
            label1 = new Label();
            btnLogout = new Button();
            panel2 = new Panel();
            panelTop.SuspendLayout();
            SuspendLayout();
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Microsoft YaHei UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.ForeColor = Color.Red;
            label12.Location = new Point(566, 8);
            label12.Name = "label12";
            label12.Size = new Size(48, 50);
            label12.TabIndex = 3;
            label12.Text = "X";
            label12.Click += label12_Click;
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
            panelTop.Size = new Size(620, 78);
            panelTop.TabIndex = 43;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Microsoft YaHei UI", 20.2F, FontStyle.Bold);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(73, 13);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(475, 45);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "ATM Management System";
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.DarkSlateGray;
            btnLogin.Font = new Font("Microsoft YaHei UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(316, 230);
            btnLogin.Margin = new Padding(3, 4, 3, 4);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(163, 40);
            btnLogin.TabIndex = 54;
            btnLogin.Text = "Deposit";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // DepoAmtTb
            // 
            DepoAmtTb.Font = new Font("Microsoft YaHei UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DepoAmtTb.Location = new Point(278, 172);
            DepoAmtTb.Margin = new Padding(3, 4, 3, 4);
            DepoAmtTb.Name = "DepoAmtTb";
            DepoAmtTb.Size = new Size(240, 37);
            DepoAmtTb.TabIndex = 52;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Microsoft YaHei UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label13.ForeColor = Color.DarkSlateGray;
            label13.Location = new Point(144, 175);
            label13.Name = "label13";
            label13.Size = new Size(109, 30);
            label13.TabIndex = 51;
            label13.Text = "Amount:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft YaHei UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DarkSlateGray;
            label1.Location = new Point(244, 90);
            label1.Name = "label1";
            label1.Size = new Size(140, 37);
            label1.TabIndex = 4;
            label1.Text = "DEPOSIT";
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.White;
            btnLogout.Font = new Font("Microsoft YaHei UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogout.ForeColor = Color.DarkSlateGray;
            btnLogout.Location = new Point(256, 314);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(90, 36);
            btnLogout.TabIndex = 56;
            btnLogout.Text = "Back";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.DarkSlateGray;
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 356);
            panel2.Name = "panel2";
            panel2.Size = new Size(620, 21);
            panel2.TabIndex = 57;
            // 
            // Deposit
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(620, 377);
            Controls.Add(panel2);
            Controls.Add(btnLogout);
            Controls.Add(label1);
            Controls.Add(panelTop);
            Controls.Add(btnLogin);
            Controls.Add(label13);
            Controls.Add(DepoAmtTb);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Deposit";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Deposit";
            Load += Deposit_Load;
            panelTop.ResumeLayout(false);
            panelTop.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label12;
        private Panel panelTop;
        private Label lblTitle;
       // private Button btnClose;
        private Button btnLogin;
        private TextBox textBox1;
        private TextBox txtAccountNumber;
        private Label label13;
        private Label label1;
        private Button btnLogout;
        private Panel panel2;
        private TextBox DepoAmtTb;
    }
}