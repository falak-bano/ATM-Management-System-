namespace ATM_System_
{
    partial class HOME
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
            panel2 = new Panel();
            btnMiniStatement = new Button();
            btnWithdraw = new Button();
            btnBalance = new Button();
            btnDeposit = new Button();
            button1 = new Button();
            button2 = new Button();
            panelTop = new Panel();
            label1 = new Label();
            lblTitle = new Label();
            btnLogout = new Button();
            AccNumlbl = new Label();
            panelTop.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.DarkSlateGray;
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 487);
            panel2.Name = "panel2";
            panel2.Size = new Size(705, 21);
            panel2.TabIndex = 22;
            // 
            // btnMiniStatement
            // 
            btnMiniStatement.BackColor = Color.DarkSlateGray;
            btnMiniStatement.Font = new Font("Microsoft YaHei UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnMiniStatement.ForeColor = Color.White;
            btnMiniStatement.Location = new Point(421, 249);
            btnMiniStatement.Name = "btnMiniStatement";
            btnMiniStatement.Size = new Size(212, 48);
            btnMiniStatement.TabIndex = 17;
            btnMiniStatement.Text = "Mini Statement";
            btnMiniStatement.UseVisualStyleBackColor = false;
            btnMiniStatement.Click += btnMiniStatement_Click;
            // 
            // btnWithdraw
            // 
            btnWithdraw.BackColor = Color.DarkSlateGray;
            btnWithdraw.Font = new Font("Microsoft YaHei UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnWithdraw.ForeColor = Color.White;
            btnWithdraw.Location = new Point(422, 154);
            btnWithdraw.Name = "btnWithdraw";
            btnWithdraw.Size = new Size(212, 48);
            btnWithdraw.TabIndex = 19;
            btnWithdraw.Text = "Withdraw";
            btnWithdraw.UseVisualStyleBackColor = false;
            btnWithdraw.Click += btnWithdraw_Click;
            // 
            // btnBalance
            // 
            btnBalance.BackColor = Color.DarkSlateGray;
            btnBalance.Font = new Font("Microsoft YaHei UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBalance.ForeColor = Color.White;
            btnBalance.Location = new Point(421, 351);
            btnBalance.Name = "btnBalance";
            btnBalance.Size = new Size(212, 48);
            btnBalance.TabIndex = 20;
            btnBalance.Text = "Balance";
            btnBalance.UseVisualStyleBackColor = false;
            btnBalance.Click += btnBalance_Click;
            // 
            // btnDeposit
            // 
            btnDeposit.BackColor = Color.DarkSlateGray;
            btnDeposit.Font = new Font("Microsoft YaHei UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDeposit.ForeColor = Color.White;
            btnDeposit.Location = new Point(72, 154);
            btnDeposit.Name = "btnDeposit";
            btnDeposit.Size = new Size(212, 48);
            btnDeposit.TabIndex = 21;
            btnDeposit.Text = "Deposit";
            btnDeposit.UseVisualStyleBackColor = false;
            btnDeposit.Click += btnDeposit_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.DarkSlateGray;
            button1.Font = new Font("Microsoft YaHei UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(72, 351);
            button1.Name = "button1";
            button1.Size = new Size(212, 48);
            button1.TabIndex = 23;
            button1.Text = "ChangePin";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.DarkSlateGray;
            button2.Font = new Font("Microsoft YaHei UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.Location = new Point(74, 249);
            button2.Name = "button2";
            button2.Size = new Size(210, 48);
            button2.TabIndex = 24;
            button2.Text = "Fastcash";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // panelTop
            // 
            panelTop.BackColor = Color.DarkSlateGray;
            panelTop.Controls.Add(label1);
            panelTop.Controls.Add(lblTitle);
            panelTop.Dock = DockStyle.Top;
            panelTop.ForeColor = Color.DarkSlateGray;
            panelTop.Location = new Point(0, 0);
            panelTop.Margin = new Padding(3, 4, 3, 4);
            panelTop.Name = "panelTop";
            panelTop.Size = new Size(705, 76);
            panelTop.TabIndex = 25;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft YaHei UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(651, 8);
            label1.Name = "label1";
            label1.Size = new Size(48, 50);
            label1.TabIndex = 2;
            label1.Text = "X";
            label1.Click += label1_Click;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Microsoft YaHei UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(89, 14);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(541, 45);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Select Your Transection Please";
            lblTitle.Click += lblTitle_Click;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.White;
            btnLogout.Font = new Font("Microsoft YaHei UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogout.ForeColor = Color.DarkSlateGray;
            btnLogout.Location = new Point(277, 436);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(146, 48);
            btnLogout.TabIndex = 19;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // AccNumlbl
            // 
            AccNumlbl.AutoSize = true;
            AccNumlbl.Font = new Font("Microsoft YaHei UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AccNumlbl.ForeColor = SystemColors.GrayText;
            AccNumlbl.Location = new Point(150, 88);
            AccNumlbl.Name = "AccNumlbl";
            AccNumlbl.Size = new Size(265, 37);
            AccNumlbl.TabIndex = 26;
            AccNumlbl.Text = "Account Number:";
            AccNumlbl.Click += AccNumlbl_Click;
            // 
            // HOME
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(705, 508);
            Controls.Add(AccNumlbl);
            Controls.Add(btnLogout);
            Controls.Add(panelTop);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(panel2);
            Controls.Add(btnMiniStatement);
            Controls.Add(btnWithdraw);
            Controls.Add(btnBalance);
            Controls.Add(btnDeposit);
            FormBorderStyle = FormBorderStyle.None;
            Name = "HOME";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "HOME";
            Load += HOME_Load;
            panelTop.ResumeLayout(false);
            panelTop.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel2;
        private Button btnMiniStatement;
        private Button btnWithdraw;
        private Button btnBalance;
        private Button btnDeposit;
        private Button button1;
        private Button button2;
        private Panel panelTop;
        private Label lblTitle;
      //  private Button btnClose;
        private Label label1;
        private Button btnLogout;
        private Label label2;
        private Label AccNumlbl;
    }
}