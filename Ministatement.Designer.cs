namespace ATM_System_
{
    partial class Ministatement
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            panelTop = new Panel();
            label12 = new Label();
            lblTitle = new Label();
            label1 = new Label();
            MinistatementGDV = new DataGridView();
            panel2 = new Panel();
            btnLogout = new Button();
            panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)MinistatementGDV).BeginInit();
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
            panelTop.Size = new Size(690, 67);
            panelTop.TabIndex = 44;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Microsoft YaHei UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.ForeColor = Color.Red;
            label12.Location = new Point(642, 9);
            label12.Name = "label12";
            label12.Size = new Size(48, 50);
            label12.TabIndex = 3;
            label12.Text = "X";
            label12.Click += label12_Click;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Microsoft YaHei UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(80, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(515, 50);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "ATM Management System";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft YaHei UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DarkSlateGray;
            label1.Location = new Point(220, 71);
            label1.Name = "label1";
            label1.Size = new Size(273, 37);
            label1.TabIndex = 52;
            label1.Text = "MINI STATEMENT";
            // 
            // MinistatementGDV
            // 
            MinistatementGDV.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.DarkSlateGray;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            MinistatementGDV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            MinistatementGDV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            MinistatementGDV.EnableHeadersVisualStyles = false;
            MinistatementGDV.Location = new Point(0, 111);
            MinistatementGDV.Name = "MinistatementGDV";
            MinistatementGDV.RowHeadersWidth = 51;
            MinistatementGDV.Size = new Size(690, 278);
            MinistatementGDV.TabIndex = 53;
            // 
            // panel2
            // 
            panel2.BackColor = Color.DarkSlateGray;
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 435);
            panel2.Name = "panel2";
            panel2.Size = new Size(690, 21);
            panel2.TabIndex = 54;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.White;
            btnLogout.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogout.ForeColor = Color.DarkSlateGray;
            btnLogout.Location = new Point(283, 395);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(112, 34);
            btnLogout.TabIndex = 55;
            btnLogout.Text = "Back";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click_1;
            // 
            // Ministatement
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(690, 456);
            Controls.Add(btnLogout);
            Controls.Add(panel2);
            Controls.Add(MinistatementGDV);
            Controls.Add(label1);
            Controls.Add(panelTop);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Ministatement";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ministatement";
            Load += ministatement_Load;
            panelTop.ResumeLayout(false);
            panelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)MinistatementGDV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelTop;
        private Label label12;
        private Label lblTitle;
       // private Button btnClose;
        private Label label1;
        private DataGridView MinistatementGDV;
        private Panel panel2;
        private Button btnLogout;
    }
}