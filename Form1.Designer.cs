namespace ATM_System_
{
    partial class Form1
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            lblTitle = new Label();
            Myprogress = new ProgressBar();
            pictureBox1 = new PictureBox();
            Percentage = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Microsoft YaHei UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(54, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(515, 50);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "ATM Management System";
            // 
            // Myprogress
            // 
            Myprogress.Location = new Point(-3, 354);
            Myprogress.Name = "Myprogress";
            Myprogress.Size = new Size(592, 16);
            Myprogress.TabIndex = 3;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(208, 91);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(190, 182);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // Percentage
            // 
            Percentage.AutoSize = true;
            Percentage.Font = new Font("Microsoft YaHei UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Percentage.ForeColor = Color.White;
            Percentage.Location = new Point(276, 311);
            Percentage.Name = "Percentage";
            Percentage.Size = new Size(45, 40);
            Percentage.TabIndex = 5;
            Percentage.Text = "%";
            Percentage.Click += label1_Click;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSlateGray;
            ClientSize = new Size(590, 372);
            Controls.Add(Percentage);
            Controls.Add(pictureBox1);
            Controls.Add(Myprogress);
            Controls.Add(lblTitle);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private ProgressBar Myprogress;
        private PictureBox pictureBox1;
        private Label Percentage;
        private System.Windows.Forms.Timer timer1;
    }
}