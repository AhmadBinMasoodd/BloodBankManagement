namespace Blood_Bnk_Management_System
{
    partial class Employee
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
            EPhoneTb = new TextBox();
            salarytb = new TextBox();
            ENameTb = new TextBox();
            EAddressRtb = new RichTextBox();
            EBGroupCb = new ComboBox();
            label16 = new Label();
            label15 = new Label();
            label14 = new Label();
            EGenderCb = new ComboBox();
            label13 = new Label();
            label12 = new Label();
            label11 = new Label();
            PSaveB = new Button();
            panel1 = new Panel();
            label5 = new Label();
            panel3 = new Panel();
            label9 = new Label();
            label1 = new Label();
            label2 = new Label();
            usernametb = new TextBox();
            passwordtb = new TextBox();
            label3 = new Label();
            panel2 = new Panel();
            label4 = new Label();
            label10 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // EPhoneTb
            // 
            EPhoneTb.Location = new Point(255, 197);
            EPhoneTb.Name = "EPhoneTb";
            EPhoneTb.Size = new Size(182, 23);
            EPhoneTb.TabIndex = 50;
            EPhoneTb.TextChanged += PPhoneTb_TextChanged;
            // 
            // salarytb
            // 
            salarytb.Location = new Point(457, 115);
            salarytb.Name = "salarytb";
            salarytb.Size = new Size(158, 23);
            salarytb.TabIndex = 49;
            // 
            // ENameTb
            // 
            ENameTb.Location = new Point(255, 115);
            ENameTb.Name = "ENameTb";
            ENameTb.Size = new Size(174, 23);
            ENameTb.TabIndex = 48;
            // 
            // EAddressRtb
            // 
            EAddressRtb.Location = new Point(593, 197);
            EAddressRtb.Name = "EAddressRtb";
            EAddressRtb.Size = new Size(205, 90);
            EAddressRtb.TabIndex = 46;
            EAddressRtb.Text = "";
            // 
            // EBGroupCb
            // 
            EBGroupCb.FormattingEnabled = true;
            EBGroupCb.Items.AddRange(new object[] { "A+", "A-", "B+", "B-", "O+", "O-", "AB+", "AB-" });
            EBGroupCb.Location = new Point(457, 197);
            EBGroupCb.Name = "EBGroupCb";
            EBGroupCb.Size = new Size(121, 23);
            EBGroupCb.TabIndex = 45;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.BackColor = Color.WhiteSmoke;
            label16.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label16.ForeColor = Color.DarkRed;
            label16.Location = new Point(255, 158);
            label16.Name = "label16";
            label16.Size = new Size(113, 23);
            label16.TabIndex = 44;
            label16.Text = "Phone Number";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.BackColor = Color.WhiteSmoke;
            label15.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label15.ForeColor = Color.DarkRed;
            label15.Location = new Point(457, 158);
            label15.Name = "label15";
            label15.Size = new Size(99, 23);
            label15.TabIndex = 43;
            label15.Text = "Blood Group";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.BackColor = Color.WhiteSmoke;
            label14.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label14.ForeColor = Color.DarkRed;
            label14.Location = new Point(593, 157);
            label14.Name = "label14";
            label14.Size = new Size(70, 23);
            label14.TabIndex = 42;
            label14.Text = "Address";
            // 
            // EGenderCb
            // 
            EGenderCb.FormattingEnabled = true;
            EGenderCb.Items.AddRange(new object[] { "Male", "Female" });
            EGenderCb.Location = new Point(677, 115);
            EGenderCb.Name = "EGenderCb";
            EGenderCb.Size = new Size(121, 23);
            EGenderCb.TabIndex = 41;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.BackColor = Color.WhiteSmoke;
            label13.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label13.ForeColor = Color.DarkRed;
            label13.Location = new Point(667, 85);
            label13.Name = "label13";
            label13.Size = new Size(62, 23);
            label13.TabIndex = 40;
            label13.Text = "Gender";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.WhiteSmoke;
            label12.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label12.ForeColor = Color.DarkRed;
            label12.Location = new Point(457, 85);
            label12.Name = "label12";
            label12.Size = new Size(59, 23);
            label12.TabIndex = 39;
            label12.Text = "Salary";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.WhiteSmoke;
            label11.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.DarkRed;
            label11.Location = new Point(255, 85);
            label11.Name = "label11";
            label11.Size = new Size(50, 23);
            label11.TabIndex = 38;
            label11.Text = "Name";
            // 
            // PSaveB
            // 
            PSaveB.BackColor = Color.Red;
            PSaveB.FlatStyle = FlatStyle.Popup;
            PSaveB.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PSaveB.ForeColor = Color.WhiteSmoke;
            PSaveB.Location = new Point(461, 390);
            PSaveB.Name = "PSaveB";
            PSaveB.Size = new Size(124, 33);
            PSaveB.TabIndex = 47;
            PSaveB.Text = "Save";
            PSaveB.UseVisualStyleBackColor = false;
            PSaveB.Click += PSaveB_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Red;
            panel1.Controls.Add(label5);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(194, 492);
            panel1.TabIndex = 51;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Red;
            label5.Font = new Font("Comic Sans MS", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(28, 158);
            label5.Name = "label5";
            label5.Size = new Size(151, 29);
            label5.TabIndex = 16;
            label5.Text = "Edit Employee";
            label5.Click += label5_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Aquamarine;
            panel3.Location = new Point(12, 109);
            panel3.Name = "panel3";
            panel3.Size = new Size(10, 35);
            panel3.TabIndex = 15;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Red;
            label9.Font = new Font("Comic Sans MS", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.White;
            label9.Location = new Point(50, 493);
            label9.Name = "label9";
            label9.Size = new Size(85, 29);
            label9.TabIndex = 5;
            label9.Text = "Log out";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Red;
            label1.Font = new Font("Comic Sans MS", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(28, 115);
            label1.Name = "label1";
            label1.Size = new Size(103, 29);
            label1.TabIndex = 4;
            label1.Text = "Employee";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.WhiteSmoke;
            label2.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.DarkRed;
            label2.Location = new Point(255, 232);
            label2.Name = "label2";
            label2.Size = new Size(80, 23);
            label2.TabIndex = 52;
            label2.Text = "Username";
            // 
            // usernametb
            // 
            usernametb.Location = new Point(255, 264);
            usernametb.Name = "usernametb";
            usernametb.Size = new Size(142, 23);
            usernametb.TabIndex = 53;
            // 
            // passwordtb
            // 
            passwordtb.Location = new Point(424, 264);
            passwordtb.Name = "passwordtb";
            passwordtb.Size = new Size(142, 23);
            passwordtb.TabIndex = 55;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.WhiteSmoke;
            label3.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.DarkRed;
            label3.Location = new Point(424, 232);
            label3.Name = "label3";
            label3.Size = new Size(76, 23);
            label3.TabIndex = 54;
            label3.Text = "Password";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Aqua;
            panel2.Controls.Add(label4);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(194, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(728, 37);
            panel2.TabIndex = 56;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Comic Sans MS", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.DarkRed;
            label4.Location = new Point(215, 4);
            label4.Name = "label4";
            label4.Size = new Size(341, 30);
            label4.TabIndex = 3;
            label4.Text = "Blood Bank Management System";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.White;
            label10.Font = new Font("Comic Sans MS", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.DarkRed;
            label10.Location = new Point(479, 40);
            label10.Name = "label10";
            label10.Size = new Size(106, 30);
            label10.TabIndex = 26;
            label10.Text = "Employee";
            // 
            // Employee
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(922, 492);
            Controls.Add(label10);
            Controls.Add(panel2);
            Controls.Add(passwordtb);
            Controls.Add(label3);
            Controls.Add(usernametb);
            Controls.Add(label2);
            Controls.Add(panel1);
            Controls.Add(EPhoneTb);
            Controls.Add(salarytb);
            Controls.Add(ENameTb);
            Controls.Add(EAddressRtb);
            Controls.Add(EBGroupCb);
            Controls.Add(label16);
            Controls.Add(label15);
            Controls.Add(label14);
            Controls.Add(EGenderCb);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(PSaveB);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Employee";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Employee";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox EPhoneTb;
        private TextBox salarytb;
        private TextBox ENameTb;
        private RichTextBox EAddressRtb;
        private ComboBox EBGroupCb;
        private Label label16;
        private Label label15;
        private Label label14;
        private ComboBox EGenderCb;
        private Label label13;
        private Label label12;
        private Label label11;
        private Button PSaveB;
        private Panel panel1;
        private Panel panel3;
        private Label label9;
        private Label label1;
        private Label label2;
        private TextBox usernametb;
        private TextBox passwordtb;
        private Label label3;
        private Panel panel2;
        private Label label4;
        private Label label10;
        private Label label5;
    }
}