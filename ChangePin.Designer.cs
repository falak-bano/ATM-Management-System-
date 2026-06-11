namespace ATM_System_
{
    partial class ChangePin
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
            panelTop = new Panel();
            label12 = new Label();
            lblTitle = new Label();
            label3 = new Label();
            label13 = new Label();
            Pin1Tb = new TextBox();
            Pin2Tb = new TextBox();
            btnLogin = new Button();
            btnLogout = new Button();
            panel2 = new Panel();
            panelTop.SuspendLayout();
            SuspendLayout();
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
            panelTop.Size = new Size(620, 80);
            panelTop.TabIndex = 42;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Microsoft YaHei UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.ForeColor = Color.Red;
            label12.Location = new Point(569, 14);
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
            lblTitle.Location = new Point(74, 14);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(475, 45);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "ATM Management System";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft YaHei UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.DarkSlateGray;
            label3.Location = new Point(128, 215);
            label3.Name = "label3";
            label3.Size = new Size(175, 30);
            label3.TabIndex = 46;
            label3.Text = "CONFIRM PIN:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Microsoft YaHei UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label13.ForeColor = Color.DarkSlateGray;
            label13.Location = new Point(128, 153);
            label13.Name = "label13";
            label13.Size = new Size(121, 30);
            label13.TabIndex = 45;
            label13.Text = "NEW PIN:";
            // 
            // Pin1Tb
            // 
            Pin1Tb.Font = new Font("Microsoft YaHei UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Pin1Tb.Location = new Point(309, 150);
            Pin1Tb.Margin = new Padding(3, 4, 3, 4);
            Pin1Tb.Name = "Pin1Tb";
            Pin1Tb.Size = new Size(240, 37);
            Pin1Tb.TabIndex = 47;
            Pin1Tb.TextChanged += txtAccountNumber_TextChanged;
            // 
            // Pin2Tb
            // 
            Pin2Tb.Font = new Font("Microsoft YaHei UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Pin2Tb.Location = new Point(309, 208);
            Pin2Tb.Margin = new Padding(3, 4, 3, 4);
            Pin2Tb.Name = "Pin2Tb";
            Pin2Tb.Size = new Size(240, 37);
            Pin2Tb.TabIndex = 48;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.DarkSlateGray;
            btnLogin.Font = new Font("Microsoft YaHei UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(343, 253);
            btnLogin.Margin = new Padding(3, 4, 3, 4);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(175, 40);
            btnLogin.TabIndex = 49;
            btnLogin.Text = "Change";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.White;
            btnLogout.Font = new Font("Microsoft YaHei UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogout.ForeColor = Color.DarkSlateGray;
            btnLogout.Location = new Point(276, 317);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(96, 35);
            btnLogout.TabIndex = 50;
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
            panel2.TabIndex = 58;
            // 
            // ChangePin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(620, 377);
            Controls.Add(panel2);
            Controls.Add(btnLogout);
            Controls.Add(btnLogin);
            Controls.Add(Pin2Tb);
            Controls.Add(Pin1Tb);
            Controls.Add(label3);
            Controls.Add(label13);
            Controls.Add(panelTop);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ChangePin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ChangePin";
            Load += ChangePin_Load;
            panelTop.ResumeLayout(false);
            panelTop.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelTop;
        private Label label12;
        private Label lblTitle;
     //   private Button btnClose;
        private Label label3;
        private Label label13;
        private TextBox txtAccountNumber;
        private TextBox textBox1;
        private Button btnLogin;
        private Button btnLogout;
        private TextBox Pin1Tb;
        private TextBox Pin2Tb;
        private Panel panel2;
    }
}