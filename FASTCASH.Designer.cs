namespace ATM_System_
{
    partial class FASTCASH
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
            button2 = new Button();
            button1 = new Button();
            btnMiniStatement = new Button();
            btnWithdraw = new Button();
            btnBalance = new Button();
            btnDeposit = new Button();
            label1 = new Label();
            balancelbl = new Label();
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
            label12.Location = new Point(632, 14);
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
            lblTitle.Location = new Point(98, 17);
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
            panelTop.Size = new Size(692, 85);
            panelTop.TabIndex = 43;
            // 
            // button2
            // 
            button2.BackColor = Color.DarkSlateGray;
            button2.Font = new Font("Microsoft YaHei UI", 16.2F);
            button2.ForeColor = Color.White;
            button2.Location = new Point(76, 267);
            button2.Name = "button2";
            button2.Size = new Size(173, 48);
            button2.TabIndex = 50;
            button2.Text = "Rs 1000";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.DarkSlateGray;
            button1.Font = new Font("Microsoft YaHei UI", 16.2F);
            button1.ForeColor = Color.White;
            button1.Location = new Point(76, 372);
            button1.Name = "button1";
            button1.Size = new Size(173, 48);
            button1.TabIndex = 49;
            button1.Text = "Rs 5000";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // btnMiniStatement
            // 
            btnMiniStatement.BackColor = Color.DarkSlateGray;
            btnMiniStatement.Font = new Font("Microsoft YaHei UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnMiniStatement.ForeColor = Color.White;
            btnMiniStatement.Location = new Point(443, 264);
            btnMiniStatement.Name = "btnMiniStatement";
            btnMiniStatement.Size = new Size(183, 51);
            btnMiniStatement.TabIndex = 44;
            btnMiniStatement.Text = "Rs 2000";
            btnMiniStatement.UseVisualStyleBackColor = false;
            btnMiniStatement.Click += btnMiniStatement_Click;
            // 
            // btnWithdraw
            // 
            btnWithdraw.BackColor = Color.DarkSlateGray;
            btnWithdraw.Font = new Font("Microsoft YaHei UI", 16.2F);
            btnWithdraw.ForeColor = Color.White;
            btnWithdraw.Location = new Point(443, 168);
            btnWithdraw.Name = "btnWithdraw";
            btnWithdraw.Size = new Size(183, 48);
            btnWithdraw.TabIndex = 46;
            btnWithdraw.Text = "Rs 500";
            btnWithdraw.UseVisualStyleBackColor = false;
            btnWithdraw.Click += btnWithdraw_Click;
            // 
            // btnBalance
            // 
            btnBalance.BackColor = Color.DarkSlateGray;
            btnBalance.Font = new Font("Microsoft YaHei UI", 16.2F);
            btnBalance.ForeColor = Color.White;
            btnBalance.Location = new Point(443, 372);
            btnBalance.Name = "btnBalance";
            btnBalance.Size = new Size(183, 48);
            btnBalance.TabIndex = 47;
            btnBalance.Text = "Rs 10000";
            btnBalance.UseVisualStyleBackColor = false;
            btnBalance.Click += btnBalance_Click;
            // 
            // btnDeposit
            // 
            btnDeposit.BackColor = Color.DarkSlateGray;
            btnDeposit.Font = new Font("Microsoft YaHei UI", 16.2F);
            btnDeposit.ForeColor = Color.White;
            btnDeposit.Location = new Point(76, 168);
            btnDeposit.Name = "btnDeposit";
            btnDeposit.Size = new Size(173, 48);
            btnDeposit.TabIndex = 48;
            btnDeposit.Text = "Rs 100";
            btnDeposit.UseVisualStyleBackColor = false;
            btnDeposit.Click += btnDeposit_Click_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft YaHei UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DarkSlateGray;
            label1.Location = new Point(266, 98);
            label1.Name = "label1";
            label1.Size = new Size(169, 37);
            label1.TabIndex = 51;
            label1.Text = "FASTCASH";
            // 
            // balancelbl
            // 
            balancelbl.AutoSize = true;
            balancelbl.Font = new Font("Microsoft YaHei UI", 14.2F, FontStyle.Bold);
            balancelbl.ForeColor = Color.DarkSlateGray;
            balancelbl.Location = new Point(266, 225);
            balancelbl.Name = "balancelbl";
            balancelbl.Size = new Size(169, 31);
            balancelbl.TabIndex = 52;
            balancelbl.Text = "Available Bal";
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.White;
            btnLogout.Font = new Font("Microsoft YaHei UI", 14.2F, FontStyle.Bold);
            btnLogout.ForeColor = Color.DarkSlateGray;
            btnLogout.Location = new Point(291, 440);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(113, 45);
            btnLogout.TabIndex = 53;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.DarkSlateGray;
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 489);
            panel2.Name = "panel2";
            panel2.Size = new Size(692, 21);
            panel2.TabIndex = 54;
            // 
            // FASTCASH
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(692, 510);
            Controls.Add(panel2);
            Controls.Add(btnLogout);
            Controls.Add(balancelbl);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(btnMiniStatement);
            Controls.Add(btnWithdraw);
            Controls.Add(btnBalance);
            Controls.Add(btnDeposit);
            Controls.Add(panelTop);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FASTCASH";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FASTCASH";
            Load += FASTCASH_Load;
            panelTop.ResumeLayout(false);
            panelTop.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label12;
        private Label lblTitle;
        private Panel panelTop;
      //  private Button btnClose;
        private Button button2;
        private Button button1;
        private Button btnMiniStatement;
        private Button btnWithdraw;
        private Button btnBalance;
        private Button btnDeposit;
        private Label label1;
        private Label label2;
        private Button btnLogout;
        private Panel panel2;
        private Label balancelbl;
    }
}