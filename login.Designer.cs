namespace Blood_Bnk_Management_System
{
    partial class login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login));
            label2 = new Label();
            label1 = new Label();
            label3 = new Label();
            usernametb = new TextBox();
            passwordTb = new TextBox();
            loginBtn = new Button();
            label4 = new Label();
            pictureBox2 = new PictureBox();
            ContinueAdmin = new Label();
            label5 = new Label();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.Location = new Point(0, 0);
            label2.Name = "label2";
            label2.Size = new Size(100, 23);
            label2.TabIndex = 14;
            // 
            // label1
            // 
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(100, 23);
            label1.TabIndex = 13;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Red;
            label3.Location = new Point(40, 196);
            label3.Name = "label3";
            label3.Size = new Size(76, 23);
            label3.TabIndex = 6;
            label3.Text = "Password";
            // 
            // usernametb
            // 
            usernametb.CausesValidation = false;
            usernametb.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            usernametb.Location = new Point(163, 131);
            usernametb.Name = "usernametb";
            usernametb.PlaceholderText = "Enter Your Username";
            usernametb.Size = new Size(196, 27);
            usernametb.TabIndex = 7;
            // 
            // passwordTb
            // 
            passwordTb.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            passwordTb.Location = new Point(163, 192);
            passwordTb.Name = "passwordTb";
            passwordTb.PlaceholderText = "Enter Your  Password";
            passwordTb.Size = new Size(196, 27);
            passwordTb.TabIndex = 8;
            passwordTb.Text = "\r\n";
            // 
            // loginBtn
            // 
            loginBtn.BackColor = Color.Red;
            loginBtn.FlatStyle = FlatStyle.Popup;
            loginBtn.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            loginBtn.ForeColor = Color.WhiteSmoke;
            loginBtn.Location = new Point(95, 290);
            loginBtn.Name = "loginBtn";
            loginBtn.Size = new Size(203, 33);
            loginBtn.TabIndex = 9;
            loginBtn.Text = "Login";
            loginBtn.UseVisualStyleBackColor = false;
            loginBtn.Click += loginBtn_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Red;
            label4.Location = new Point(558, 9);
            label4.Name = "label4";
            label4.Size = new Size(22, 23);
            label4.TabIndex = 10;
            label4.Text = "X";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(405, 75);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(175, 260);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 11;
            pictureBox2.TabStop = false;
            // 
            // ContinueAdmin
            // 
            ContinueAdmin.AutoSize = true;
            ContinueAdmin.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ContinueAdmin.ForeColor = Color.Red;
            ContinueAdmin.Location = new Point(118, 336);
            ContinueAdmin.Name = "ContinueAdmin";
            ContinueAdmin.Size = new Size(146, 23);
            ContinueAdmin.TabIndex = 12;
            ContinueAdmin.Text = "Continue As Admin";
            ContinueAdmin.Click += ContinueAdmin_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Comic Sans MS", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Red;
            label5.Location = new Point(95, 9);
            label5.Name = "label5";
            label5.Size = new Size(373, 33);
            label5.TabIndex = 15;
            label5.Text = "Blood Bank Management System";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Red;
            label6.Location = new Point(40, 131);
            label6.Name = "label6";
            label6.Size = new Size(80, 23);
            label6.TabIndex = 16;
            label6.Text = "Username";
            // 
            // login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(592, 379);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(ContinueAdmin);
            Controls.Add(pictureBox2);
            Controls.Add(label4);
            Controls.Add(loginBtn);
            Controls.Add(passwordTb);
            Controls.Add(usernametb);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(label2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "login";
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label label1;
        private Label label3;
        private TextBox usernametb;
        private TextBox passwordTb;
        private Button loginBtn;
        private Label label4;
        private PictureBox pictureBox2;
        private Label ContinueAdmin;
        private Label label5;
        private Label label6;
    }
}