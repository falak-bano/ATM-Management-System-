namespace ATM_System_
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            lblAccountNumber = new Label();
            AccNumTb = new TextBox();
            btnClear = new Button();
            btnLogin = new Button();
            pictureBox1 = new PictureBox();
            PinTb = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            btnClose = new Button();
            panelTop = new Panel();
            label4 = new Label();
            lblTitle = new Label();
            panel2 = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelTop.SuspendLayout();
            SuspendLayout();
            // 
            // lblAccountNumber
            // 
            lblAccountNumber.AutoSize = true;
            lblAccountNumber.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAccountNumber.ForeColor = Color.DarkSlateGray;
            lblAccountNumber.Location = new Point(256, 152);
            lblAccountNumber.Name = "lblAccountNumber";
            lblAccountNumber.Size = new Size(112, 31);
            lblAccountNumber.TabIndex = 9;
            lblAccountNumber.Text = "Acc Num:";
            // 
            // AccNumTb
            // 
            AccNumTb.Font = new Font("Microsoft YaHei UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AccNumTb.Location = new Point(256, 187);
            AccNumTb.Margin = new Padding(3, 4, 3, 4);
            AccNumTb.Name = "AccNumTb";
            AccNumTb.Size = new Size(265, 37);
            AccNumTb.TabIndex = 10;
            AccNumTb.TextChanged += AccNumTb_TextChanged;
            // 
            // btnClear
            // 
            btnClear.Font = new Font("Segoe UI", 12F);
            btnClear.Location = new Point(452, 230);
            btnClear.Margin = new Padding(3, 4, 3, 4);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(69, 40);
            btnClear.TabIndex = 13;
            btnClear.Text = "Clear";
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.DarkSlateGray;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Microsoft YaHei UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(386, 319);
            btnLogin.Margin = new Padding(3, 4, 3, 4);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(135, 40);
            btnLogin.TabIndex = 14;
            btnLogin.Text = "LOGIN";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(33, 165);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(160, 146);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 15;
            pictureBox1.TabStop = false;
            // 
            // PinTb
            // 
            PinTb.Font = new Font("Microsoft YaHei UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PinTb.Location = new Point(253, 274);
            PinTb.Margin = new Padding(3, 4, 3, 4);
            PinTb.Name = "PinTb";
            PinTb.PasswordChar = '*';
            PinTb.Size = new Size(268, 37);
            PinTb.TabIndex = 16;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DarkSlateGray;
            label1.Location = new Point(253, 239);
            label1.Name = "label1";
            label1.Size = new Size(119, 31);
            label1.TabIndex = 17;
            label1.Text = "PIN CODE:";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft YaHei UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.DarkSlateGray;
            label2.Location = new Point(256, 80);
            label2.Name = "label2";
            label2.Size = new Size(133, 45);
            label2.TabIndex = 18;
            label2.Text = "LOGIN";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.DarkSlateGray;
            label3.Location = new Point(253, 324);
            label3.Name = "label3";
            label3.Size = new Size(92, 31);
            label3.TabIndex = 19;
            label3.Text = "Signup ";
            label3.Click += label3_Click;
            // 
            // btnClose
            // 
            btnClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.ForeColor = Color.Red;
            btnClose.Location = new Point(1452, 13);
            btnClose.Margin = new Padding(3, 4, 3, 4);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(55, 40);
            btnClose.TabIndex = 1;
            btnClose.Text = "X";
            // 
            // panelTop
            // 
            panelTop.BackColor = Color.DarkSlateGray;
            panelTop.Controls.Add(label4);
            panelTop.Controls.Add(lblTitle);
            panelTop.Controls.Add(btnClose);
            panelTop.Dock = DockStyle.Top;
            panelTop.ForeColor = Color.DarkSlateGray;
            panelTop.Location = new Point(0, 0);
            panelTop.Margin = new Padding(3, 4, 3, 4);
            panelTop.Name = "panelTop";
            panelTop.Size = new Size(623, 67);
            panelTop.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft YaHei UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Red;
            label4.Location = new Point(577, 8);
            label4.Name = "label4";
            label4.Size = new Size(48, 50);
            label4.TabIndex = 3;
            label4.Text = "X";
            label4.Click += label4_Click;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Microsoft YaHei UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(71, 6);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(475, 45);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "ATM Management System";
            // 
            // panel2
            // 
            panel2.BackColor = Color.DarkSlateGray;
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 400);
            panel2.Name = "panel2";
            panel2.Size = new Size(623, 21);
            panel2.TabIndex = 23;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(623, 421);
            Controls.Add(panel2);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(PinTb);
            Controls.Add(pictureBox1);
            Controls.Add(panelTop);
            Controls.Add(lblAccountNumber);
            Controls.Add(AccNumTb);
            Controls.Add(btnClear);
            Controls.Add(btnLogin);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelTop.ResumeLayout(false);
            panelTop.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Panel panelTop;
        private Button btnClose;
        private Label lblAccountNumber;
        private TextBox txtAccountNumber;
        private Button btnClear;
        private Button btnLogin;
        private PictureBox pictureBox1;
        private TextBox textBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Panel panel1;
        private TextBox AccNumTb;
        private TextBox PinTb;
        private Panel panel2;
    }
}