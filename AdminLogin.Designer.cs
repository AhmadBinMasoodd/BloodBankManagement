namespace Blood_Bnk_Management_System
{
    partial class AdminLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminLogin));
            label5 = new Label();
            pictureBox2 = new PictureBox();
            label4 = new Label();
            loginBtn = new Button();
            ApasswordTb = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label6 = new Label();
            cancel_Lbl = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Red;
            label5.Location = new Point(208, 377);
            label5.Name = "label5";
            label5.Size = new Size(146, 23);
            label5.TabIndex = 21;
            label5.Text = "Continue As Admin";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(400, 82);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(175, 260);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 20;
            pictureBox2.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Red;
            label4.Location = new Point(648, 50);
            label4.Name = "label4";
            label4.Size = new Size(22, 23);
            label4.TabIndex = 19;
            label4.Text = "X";
            // 
            // loginBtn
            // 
            loginBtn.BackColor = Color.Red;
            loginBtn.FlatStyle = FlatStyle.Popup;
            loginBtn.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            loginBtn.ForeColor = Color.WhiteSmoke;
            loginBtn.Location = new Point(91, 274);
            loginBtn.Name = "loginBtn";
            loginBtn.Size = new Size(203, 33);
            loginBtn.TabIndex = 18;
            loginBtn.Text = "Login";
            loginBtn.UseVisualStyleBackColor = false;
            loginBtn.Click += loginBtn_Click;
            // 
            // ApasswordTb
            // 
            ApasswordTb.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ApasswordTb.Location = new Point(174, 168);
            ApasswordTb.Name = "ApasswordTb";
            ApasswordTb.Size = new Size(196, 27);
            ApasswordTb.TabIndex = 17;
            ApasswordTb.Text = "Enter Your Password";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Red;
            label3.Location = new Point(51, 172);
            label3.Name = "label3";
            label3.Size = new Size(76, 23);
            label3.TabIndex = 15;
            label3.Text = "Password";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Comic Sans MS", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Red;
            label2.Location = new Point(113, 29);
            label2.Name = "label2";
            label2.Size = new Size(327, 29);
            label2.TabIndex = 13;
            label2.Text = "Blood Bank Management System";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Red;
            label6.Location = new Point(558, 9);
            label6.Name = "label6";
            label6.Size = new Size(22, 23);
            label6.TabIndex = 22;
            label6.Text = "X";
            // 
            // cancel_Lbl
            // 
            cancel_Lbl.AutoSize = true;
            cancel_Lbl.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cancel_Lbl.ForeColor = Color.Red;
            cancel_Lbl.Location = new Point(152, 319);
            cancel_Lbl.Name = "cancel_Lbl";
            cancel_Lbl.Size = new Size(57, 23);
            cancel_Lbl.TabIndex = 23;
            cancel_Lbl.Text = "Cancel";
            cancel_Lbl.Click += cancel_Lbl_Click;
            // 
            // AdminLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(592, 379);
            Controls.Add(cancel_Lbl);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(pictureBox2);
            Controls.Add(label4);
            Controls.Add(loginBtn);
            Controls.Add(ApasswordTb);
            Controls.Add(label3);
            Controls.Add(label2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AdminLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AdminLogin";
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label5;
        private PictureBox pictureBox2;
        private Label label4;
        private Button loginBtn;
        private TextBox ApasswordTb;
        private Label label3;
        private Label label2;
        private Label label6;
        private Label cancel_Lbl;
    }
}