namespace Blood_Bnk_Management_System
{
    partial class ViewDonor
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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewDonor));
            label10 = new Label();
            label11 = new Label();
            DonorGV = new Guna.UI2.WinForms.Guna2DataGridView();
            DviewSaveB = new Button();
            textBox1 = new TextBox();
            panel1 = new Panel();
            pictureBox9 = new PictureBox();
            pictureBox10 = new PictureBox();
            pictureBox8 = new PictureBox();
            pictureBox7 = new PictureBox();
            pictureBox6 = new PictureBox();
            pictureBox5 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            Donatelbl = new Label();
            label9 = new Label();
            BTransferLbl = new Label();
            patientlbl = new Label();
            vPatient = new Label();
            BStockLbl = new Label();
            Dashboardlbl = new Label();
            Donorlbl = new Label();
            vDonorLbl = new Label();
            panel2 = new Panel();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)DonorGV).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox10).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.White;
            label10.Font = new Font("Comic Sans MS", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.DarkRed;
            label10.Location = new Point(552, 50);
            label10.Name = "label10";
            label10.Size = new Size(126, 30);
            label10.TabIndex = 6;
            label10.Text = "View Donor";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.WhiteSmoke;
            label11.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.DarkRed;
            label11.Location = new Point(243, 96);
            label11.Name = "label11";
            label11.Size = new Size(50, 23);
            label11.TabIndex = 9;
            label11.Text = "Name";
            // 
            // DonorGV
            // 
            dataGridViewCellStyle1.BackColor = Color.White;
            DonorGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            DonorGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            DonorGV.ColumnHeadersHeight = 29;
            DonorGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            DonorGV.DefaultCellStyle = dataGridViewCellStyle3;
            DonorGV.GridColor = Color.FromArgb(231, 229, 255);
            DonorGV.Location = new Point(241, 138);
            DonorGV.Name = "DonorGV";
            DonorGV.RowHeadersVisible = false;
            DonorGV.Size = new Size(676, 331);
            DonorGV.TabIndex = 10;
            DonorGV.ThemeStyle.AlternatingRowsStyle.BackColor = Color.Red;
            DonorGV.ThemeStyle.AlternatingRowsStyle.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DonorGV.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.White;
            DonorGV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            DonorGV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            DonorGV.ThemeStyle.BackColor = Color.White;
            DonorGV.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            DonorGV.ThemeStyle.HeaderStyle.BackColor = Color.Red;
            DonorGV.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            DonorGV.ThemeStyle.HeaderStyle.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DonorGV.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            DonorGV.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            DonorGV.ThemeStyle.HeaderStyle.Height = 29;
            DonorGV.ThemeStyle.ReadOnly = false;
            DonorGV.ThemeStyle.RowsStyle.BackColor = Color.Red;
            DonorGV.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            DonorGV.ThemeStyle.RowsStyle.Font = new Font("Century", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DonorGV.ThemeStyle.RowsStyle.ForeColor = Color.White;
            DonorGV.ThemeStyle.RowsStyle.Height = 25;
            DonorGV.ThemeStyle.RowsStyle.SelectionBackColor = Color.Crimson;
            DonorGV.ThemeStyle.RowsStyle.SelectionForeColor = Color.WhiteSmoke;
            DonorGV.CellContentClick += DonorGV_CellContentClick;
            // 
            // DviewSaveB
            // 
            DviewSaveB.BackColor = Color.Red;
            DviewSaveB.FlatStyle = FlatStyle.Popup;
            DviewSaveB.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DviewSaveB.ForeColor = Color.WhiteSmoke;
            DviewSaveB.Location = new Point(241, 486);
            DviewSaveB.Name = "DviewSaveB";
            DviewSaveB.Size = new Size(203, 33);
            DviewSaveB.TabIndex = 19;
            DviewSaveB.Text = "Save";
            DviewSaveB.UseVisualStyleBackColor = false;
            DviewSaveB.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(309, 96);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(178, 23);
            textBox1.TabIndex = 20;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Red;
            panel1.Controls.Add(pictureBox9);
            panel1.Controls.Add(pictureBox10);
            panel1.Controls.Add(pictureBox8);
            panel1.Controls.Add(pictureBox7);
            panel1.Controls.Add(pictureBox6);
            panel1.Controls.Add(pictureBox5);
            panel1.Controls.Add(pictureBox4);
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(Donatelbl);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(BTransferLbl);
            panel1.Controls.Add(patientlbl);
            panel1.Controls.Add(vPatient);
            panel1.Controls.Add(BStockLbl);
            panel1.Controls.Add(Dashboardlbl);
            panel1.Controls.Add(Donorlbl);
            panel1.Controls.Add(vDonorLbl);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(223, 531);
            panel1.TabIndex = 21;
            // 
            // pictureBox9
            // 
            pictureBox9.Image = (Image)resources.GetObject("pictureBox9.Image");
            pictureBox9.Location = new Point(12, 503);
            pictureBox9.Name = "pictureBox9";
            pictureBox9.Size = new Size(41, 29);
            pictureBox9.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox9.TabIndex = 26;
            pictureBox9.TabStop = false;
            // 
            // pictureBox10
            // 
            pictureBox10.Image = (Image)resources.GetObject("pictureBox10.Image");
            pictureBox10.Location = new Point(12, 403);
            pictureBox10.Name = "pictureBox10";
            pictureBox10.Size = new Size(41, 29);
            pictureBox10.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox10.TabIndex = 25;
            pictureBox10.TabStop = false;
            // 
            // pictureBox8
            // 
            pictureBox8.Image = (Image)resources.GetObject("pictureBox8.Image");
            pictureBox8.Location = new Point(12, 205);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(41, 29);
            pictureBox8.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox8.TabIndex = 24;
            pictureBox8.TabStop = false;
            // 
            // pictureBox7
            // 
            pictureBox7.Image = (Image)resources.GetObject("pictureBox7.Image");
            pictureBox7.Location = new Point(12, 253);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(41, 29);
            pictureBox7.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox7.TabIndex = 23;
            pictureBox7.TabStop = false;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(11, 301);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(41, 29);
            pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox6.TabIndex = 22;
            pictureBox6.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(12, 352);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(41, 29);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 21;
            pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(12, 161);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(41, 29);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 20;
            pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(12, 62);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(41, 29);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 19;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(12, 110);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(41, 29);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 18;
            pictureBox2.TabStop = false;
            // 
            // Donatelbl
            // 
            Donatelbl.AutoSize = true;
            Donatelbl.BackColor = Color.Red;
            Donatelbl.Font = new Font("Comic Sans MS", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Donatelbl.ForeColor = Color.White;
            Donatelbl.Location = new Point(63, 62);
            Donatelbl.Name = "Donatelbl";
            Donatelbl.Size = new Size(82, 29);
            Donatelbl.TabIndex = 17;
            Donatelbl.Text = "Donate";
            Donatelbl.Click += Donatelbl_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Red;
            label9.Font = new Font("Comic Sans MS", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.White;
            label9.Location = new Point(64, 503);
            label9.Name = "label9";
            label9.Size = new Size(85, 29);
            label9.TabIndex = 5;
            label9.Text = "Log out";
            // 
            // BTransferLbl
            // 
            BTransferLbl.AutoSize = true;
            BTransferLbl.BackColor = Color.Red;
            BTransferLbl.Font = new Font("Comic Sans MS", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BTransferLbl.ForeColor = Color.White;
            BTransferLbl.Location = new Point(63, 352);
            BTransferLbl.Name = "BTransferLbl";
            BTransferLbl.Size = new Size(161, 29);
            BTransferLbl.TabIndex = 14;
            BTransferLbl.Text = "Blood Transfer";
            BTransferLbl.Click += BTransferLbl_Click;
            // 
            // patientlbl
            // 
            patientlbl.AutoSize = true;
            patientlbl.BackColor = Color.Red;
            patientlbl.Font = new Font("Comic Sans MS", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            patientlbl.ForeColor = Color.White;
            patientlbl.Location = new Point(64, 205);
            patientlbl.Name = "patientlbl";
            patientlbl.Size = new Size(83, 29);
            patientlbl.TabIndex = 13;
            patientlbl.Text = "Patient";
            patientlbl.Click += label7_Click;
            // 
            // vPatient
            // 
            vPatient.AutoSize = true;
            vPatient.BackColor = Color.Red;
            vPatient.Font = new Font("Comic Sans MS", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            vPatient.ForeColor = Color.White;
            vPatient.Location = new Point(64, 253);
            vPatient.Name = "vPatient";
            vPatient.Size = new Size(134, 29);
            vPatient.TabIndex = 12;
            vPatient.Text = "View Patient";
            vPatient.Click += vPatient_Click;
            // 
            // BStockLbl
            // 
            BStockLbl.AutoSize = true;
            BStockLbl.BackColor = Color.Red;
            BStockLbl.Font = new Font("Comic Sans MS", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BStockLbl.ForeColor = Color.White;
            BStockLbl.Location = new Point(63, 301);
            BStockLbl.Name = "BStockLbl";
            BStockLbl.Size = new Size(132, 29);
            BStockLbl.TabIndex = 11;
            BStockLbl.Text = "Blood Stock";
            BStockLbl.Click += BStockLbl_Click;
            // 
            // Dashboardlbl
            // 
            Dashboardlbl.AutoSize = true;
            Dashboardlbl.BackColor = Color.Red;
            Dashboardlbl.Font = new Font("Comic Sans MS", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Dashboardlbl.ForeColor = Color.White;
            Dashboardlbl.Location = new Point(63, 403);
            Dashboardlbl.Name = "Dashboardlbl";
            Dashboardlbl.Size = new Size(117, 29);
            Dashboardlbl.TabIndex = 10;
            Dashboardlbl.Text = "Dashboard";
            Dashboardlbl.Click += Dashboardlbl_Click;
            // 
            // Donorlbl
            // 
            Donorlbl.AutoSize = true;
            Donorlbl.BackColor = Color.Red;
            Donorlbl.Font = new Font("Comic Sans MS", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Donorlbl.ForeColor = Color.White;
            Donorlbl.Location = new Point(64, 110);
            Donorlbl.Name = "Donorlbl";
            Donorlbl.Size = new Size(71, 29);
            Donorlbl.TabIndex = 4;
            Donorlbl.Text = "Donor";
            Donorlbl.Click += Donorlbl_Click;
            // 
            // vDonorLbl
            // 
            vDonorLbl.AutoSize = true;
            vDonorLbl.BackColor = Color.Red;
            vDonorLbl.Font = new Font("Comic Sans MS", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            vDonorLbl.ForeColor = Color.Black;
            vDonorLbl.Location = new Point(63, 161);
            vDonorLbl.Name = "vDonorLbl";
            vDonorLbl.Size = new Size(122, 29);
            vDonorLbl.TabIndex = 5;
            vDonorLbl.Text = "View Donor";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Aqua;
            panel2.Controls.Add(label2);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(223, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(715, 47);
            panel2.TabIndex = 22;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Comic Sans MS", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Red;
            label2.Location = new Point(240, 9);
            label2.Name = "label2";
            label2.Size = new Size(327, 29);
            label2.TabIndex = 3;
            label2.Text = "Blood Bank Management System";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(490, 50);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(41, 29);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 23;
            pictureBox1.TabStop = false;
            // 
            // ViewDonor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(938, 531);
            Controls.Add(pictureBox1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(textBox1);
            Controls.Add(DviewSaveB);
            Controls.Add(DonorGV);
            Controls.Add(label11);
            Controls.Add(label10);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ViewDonor";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ViewDonor";
            Load += ViewDonor_Load;
            ((System.ComponentModel.ISupportInitialize)DonorGV).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox10).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label10;
        private Label label11;
        private Guna.UI2.WinForms.Guna2DataGridView DonorGV;
        private Button DviewSaveB;
        private TextBox textBox1;
        private Panel panel1;
        private PictureBox pictureBox9;
        private PictureBox pictureBox10;
        private PictureBox pictureBox8;
        private PictureBox pictureBox7;
        private PictureBox pictureBox6;
        private PictureBox pictureBox5;
        private PictureBox pictureBox4;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private Label Donatelbl;
        private Label label9;
        private Label BTransferLbl;
        private Label patientlbl;
        private Label vPatient;
        private Label BStockLbl;
        private Label Dashboardlbl;
        private Label Donorlbl;
        private Label vDonorLbl;
        private Panel panel2;
        private Label label2;
        private PictureBox pictureBox1;
    }
}