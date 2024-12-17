using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace Blood_Bnk_Management_System
{
    public partial class login : Form
    {
        SqlConnection con;
        public login()
        {
            InitializeComponent();
            try
            {
                con = new SqlConnection(@"Data Source=DESKTOP-LI6HKCV\SQLEXPRESS;Initial Catalog=blood_Bank_system;Integrated Security=True;TrustServerCertificate=True");
            }
            catch (Exception ex) { }
        }

   

        private void loginBtn_Click(object sender, EventArgs e)
        {
            string username = usernametb.Text;
            string password = passwordTb.Text;

            // Validate Username
            if (string.IsNullOrEmpty(username))
            {
                MessageBox.Show("Username cannot be empty");
                return;
            }
            if (string.IsNullOrEmpty(password))
            {
                MessageBox.Show("passowrd cannot be empty");
                return;
            }

            if (username.Any(c => char.IsPunctuation(c) && c != '.'))
            {
                MessageBox.Show("Invalid Username. Only the period (.) is allowed as a special character.");
                return;
            }
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select count(*) from Employee where username='" + username + "' and password='" + password + "'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            if (dt.Rows.Count > 0 && dt.Rows[0][0].ToString() == "1")
            {
                MainForm main = new MainForm();
                main.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Wrong UserName or Password");
                usernametb.Text = "";
                passwordTb.Text = "";
            }

            con.Close();
        }

        private void ContinueAdmin_Click(object sender, EventArgs e)
        {
            AdminLogin login = new AdminLogin();
            login.Show();
            this.Hide();
        }
    }
}
