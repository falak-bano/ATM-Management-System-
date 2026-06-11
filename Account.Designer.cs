using System.Windows.Forms;

namespace ATM_System_
{
    partial class Account
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
            label3 = new Label();
            label1 = new Label();
            label2 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label11 = new Label();
            label12 = new Label();
            panelTop = new Panel();
            lblTitle = new Label();
            pintb = new TextBox();
            Addresstb = new TextBox();
            PhoneTb = new TextBox();
            DobDate = new DateTimePicker();
            AccNumTb = new TextBox();
            FanameTb = new TextBox();
            AccNametb = new TextBox();
            btnLogin = new Button();
            btnLogout = new Button();
            panel1 = new Panel();
            educationcb = new ComboBox();
            occupationtb = new TextBox();
            panelTop.SuspendLayout();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft YaHei UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.DarkSlateGray;
            label3.Location = new Point(75, 152);
            label3.Name = "label3";
            label3.Size = new Size(115, 30);
            label3.TabIndex = 20;
            label3.Text = "Acc Num";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft YaHei UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DarkSlateGray;
            label1.Location = new Point(463, 256);
            label1.Name = "label1";
            label1.Size = new Size(142, 30);
            label1.TabIndex = 21;
            label1.Text = "Occupation";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft YaHei UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.DarkSlateGray;
            label2.Location = new Point(465, 314);
            label2.Name = "label2";
            label2.Size = new Size(83, 30);
            label2.TabIndex = 22;
            label2.Text = "Phone";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft YaHei UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.DarkSlateGray;
            label4.Location = new Point(621, 268);
            label4.Name = "label4";
            label4.Size = new Size(0, 39);
            label4.TabIndex = 56;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft YaHei UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.DarkSlateGray;
            label5.Location = new Point(75, 261);
            label5.Name = "label5";
            label5.Size = new Size(105, 30);
            label5.TabIndex = 24;
            label5.Text = "FaName";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft YaHei UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.DarkSlateGray;
            label6.Location = new Point(81, 206);
            label6.Name = "label6";
            label6.Size = new Size(80, 30);
            label6.TabIndex = 25;
            label6.Text = "Name";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft YaHei UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.DarkSlateGray;
            label7.Location = new Point(466, 371);
            label7.Name = "label7";
            label7.Size = new Size(64, 30);
            label7.TabIndex = 26;
            label7.Text = "DOB";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft YaHei UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.DarkSlateGray;
            label8.Location = new Point(72, 323);
            label8.Name = "label8";
            label8.Size = new Size(103, 30);
            label8.TabIndex = 27;
            label8.Text = "Address";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Microsoft YaHei UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.DarkSlateGray;
            label9.Location = new Point(466, 202);
            label9.Name = "label9";
            label9.Size = new Size(131, 30);
            label9.TabIndex = 28;
            label9.Text = "Education ";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Microsoft YaHei UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.DarkSlateGray;
            label11.Location = new Point(472, 152);
            label11.Name = "label11";
            label11.Size = new Size(53, 30);
            label11.TabIndex = 30;
            label11.Text = "PIN";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Microsoft YaHei UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.ForeColor = Color.Red;
            label12.Location = new Point(794, 20);
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
            panelTop.Size = new Size(854, 91);
            panelTop.TabIndex = 40;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Microsoft YaHei UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(177, 20);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(515, 50);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "ATM Management System";
            // 
            // pintb
            // 
            pintb.Font = new Font("Microsoft YaHei UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            pintb.Location = new Point(609, 149);
            pintb.Margin = new Padding(3, 4, 3, 4);
            pintb.Name = "pintb";
            pintb.Size = new Size(195, 37);
            pintb.TabIndex = 41;
            pintb.TextChanged += pintb_TextChanged;
            // 
            // Addresstb
            // 
            Addresstb.Font = new Font("Microsoft YaHei UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Addresstb.Location = new Point(202, 316);
            Addresstb.Margin = new Padding(3, 4, 3, 4);
            Addresstb.Multiline = true;
            Addresstb.Name = "Addresstb";
            Addresstb.Size = new Size(195, 101);
            Addresstb.TabIndex = 42;
            // 
            // PhoneTb
            // 
            PhoneTb.Font = new Font("Microsoft YaHei UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PhoneTb.Location = new Point(607, 311);
            PhoneTb.Margin = new Padding(3, 4, 3, 4);
            PhoneTb.Name = "PhoneTb";
            PhoneTb.Size = new Size(195, 37);
            PhoneTb.TabIndex = 43;
            // 
            // DobDate
            // 
            DobDate.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DobDate.Location = new Point(609, 375);
            DobDate.Name = "DobDate";
            DobDate.Size = new Size(195, 27);
            DobDate.TabIndex = 50;
            // 
            // AccNumTb
            // 
            AccNumTb.Font = new Font("Microsoft YaHei UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AccNumTb.Location = new Point(204, 145);
            AccNumTb.Margin = new Padding(3, 4, 3, 4);
            AccNumTb.Name = "AccNumTb";
            AccNumTb.Size = new Size(199, 37);
            AccNumTb.TabIndex = 31;
            // 
            // FanameTb
            // 
            FanameTb.Font = new Font("Microsoft YaHei UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FanameTb.Location = new Point(204, 252);
            FanameTb.Margin = new Padding(3, 4, 3, 4);
            FanameTb.Name = "FanameTb";
            FanameTb.Size = new Size(195, 37);
            FanameTb.TabIndex = 44;
            // 
            // AccNametb
            // 
            AccNametb.Font = new Font("Microsoft YaHei UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AccNametb.Location = new Point(204, 199);
            AccNametb.Margin = new Padding(3, 4, 3, 4);
            AccNametb.Name = "AccNametb";
            AccNametb.Size = new Size(197, 37);
            AccNametb.TabIndex = 45;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.DarkSlateGray;
            btnLogin.Font = new Font("Microsoft YaHei UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(228, 456);
            btnLogin.Margin = new Padding(3, 4, 3, 4);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(135, 40);
            btnLogin.TabIndex = 51;
            btnLogin.Text = "Submitt";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.White;
            btnLogout.Font = new Font("Microsoft YaHei UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogout.ForeColor = Color.DarkSlateGray;
            btnLogout.Location = new Point(637, 454);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(135, 48);
            btnLogout.TabIndex = 52;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkSlateGray;
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 543);
            panel1.Name = "panel1";
            panel1.Size = new Size(854, 21);
            panel1.TabIndex = 53;
            // 
            // educationcb
            // 
            educationcb.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            educationcb.FormattingEnabled = true;
            educationcb.Items.AddRange(new object[] { "Non Graduate", "Under Graduate", "Post Graduate" });
            educationcb.Location = new Point(610, 204);
            educationcb.Name = "educationcb";
            educationcb.Size = new Size(193, 28);
            educationcb.TabIndex = 54;
            // 
            // occupationtb
            // 
            occupationtb.Font = new Font("Microsoft YaHei UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            occupationtb.Location = new Point(608, 254);
            occupationtb.Margin = new Padding(3, 4, 3, 4);
            occupationtb.Name = "occupationtb";
            occupationtb.Size = new Size(195, 37);
            occupationtb.TabIndex = 55;
            // 
            // Account
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(854, 564);
            Controls.Add(occupationtb);
            Controls.Add(educationcb);
            Controls.Add(panel1);
            Controls.Add(btnLogout);
            Controls.Add(btnLogin);
            Controls.Add(DobDate);
            Controls.Add(AccNametb);
            Controls.Add(FanameTb);
            Controls.Add(PhoneTb);
            Controls.Add(Addresstb);
            Controls.Add(pintb);
            Controls.Add(panelTop);
            Controls.Add(AccNumTb);
            Controls.Add(label11);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(label3);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Account";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "account";
            panelTop.ResumeLayout(false);
            panelTop.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private Label label1;
        private Label label2;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label11;
        /*    private TextBox txtAccountNumber;*/
        private Label label12;
        private Panel panelTop;
        private Label lblTitle;
       // private Button btnClose;
        private TextBox pintb;
        private TextBox Addresstb;
        private TextBox PhoneTb;
        private DateTimePicker DobDate;
        /*  private Label label13;*/
        /*  private Label label14;*/
        private TextBox AccNumTb;
        private TextBox FanameTb;
        private TextBox AccNametb;
        private Button btnLogin;
        private Button btnLogout;
        private Panel panel1;
        private ComboBox educationcb;
        private TextBox occupationtb;
    }
}