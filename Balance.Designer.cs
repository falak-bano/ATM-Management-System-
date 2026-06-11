namespace ATM_System_
{
    partial class Balance
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
            label13 = new Label();
            label1 = new Label();
            Balancelbl = new Label();
            AccNumberlbl = new Label();
            panel1 = new Panel();
            btnLogout = new Button();
            panelTop.SuspendLayout();
            SuspendLayout();
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Microsoft YaHei UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.ForeColor = Color.Red;
            label12.Location = new Point(567, 14);
            label12.Name = "label12";
            label12.Size = new Size(48, 50);
            label12.TabIndex = 3;
            label12.Text = "X";
            label12.Click += label12_Click;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Microsoft YaHei UI", 20F, FontStyle.Bold);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(73, 14);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(475, 45);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "ATM Management System";
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
            panelTop.Size = new Size(620, 79);
            panelTop.TabIndex = 41;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Microsoft YaHei UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label13.ForeColor = Color.DarkSlateGray;
            label13.Location = new Point(139, 149);
            label13.Name = "label13";
            label13.Size = new Size(210, 30);
            label13.TabIndex = 42;
            label13.Text = "Account Number:";
            label13.Click += label13_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft YaHei UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DarkSlateGray;
            label1.Location = new Point(139, 211);
            label1.Name = "label1";
            label1.Size = new Size(163, 30);
            label1.TabIndex = 43;
            label1.Text = "Your Balance:";
            // 
            // Balancelbl
            // 
            Balancelbl.AutoSize = true;
            Balancelbl.Font = new Font("Microsoft YaHei UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Balancelbl.ForeColor = Color.DarkSlateGray;
            Balancelbl.Location = new Point(336, 211);
            Balancelbl.Name = "Balancelbl";
            Balancelbl.Size = new Size(144, 30);
            Balancelbl.TabIndex = 44;
            Balancelbl.Text = "BalanceinRs";
            Balancelbl.Click += Balancelbl_Click;
            // 
            // AccNumberlbl
            // 
            AccNumberlbl.AutoSize = true;
            AccNumberlbl.Font = new Font("Microsoft YaHei UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AccNumberlbl.ForeColor = Color.DarkSlateGray;
            AccNumberlbl.Location = new Point(372, 149);
            AccNumberlbl.Name = "AccNumberlbl";
            AccNumberlbl.Size = new Size(108, 30);
            AccNumberlbl.TabIndex = 45;
            AccNumberlbl.Text = "AccNum";
            AccNumberlbl.Click += AccNumberlbl_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkSlateGray;
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 356);
            panel1.Name = "panel1";
            panel1.Size = new Size(620, 21);
            panel1.TabIndex = 46;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.Transparent;
            btnLogout.Font = new Font("Microsoft YaHei UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogout.ForeColor = Color.DarkSlateGray;
            btnLogout.Location = new Point(254, 307);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(109, 48);
            btnLogout.TabIndex = 53;
            btnLogout.Text = "Back";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // Balance
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(620, 377);
            Controls.Add(btnLogout);
            Controls.Add(panel1);
            Controls.Add(AccNumberlbl);
            Controls.Add(Balancelbl);
            Controls.Add(label1);
            Controls.Add(label13);
            Controls.Add(panelTop);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Balance";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Balance";
            Load += Balance_Load;
            panelTop.ResumeLayout(false);
            panelTop.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label12;
        private Label lblTitle;
        private Panel panelTop;
       // private Button btnClose;
        private Label label13;
        private Label label1;
      /*  private Label label2;*/
       /* private Label label3;*/
        private Panel panel1;
        private Button btnLogout;
        private Label Balancelbl;
        private Label AccNumberlbl;
    }
}