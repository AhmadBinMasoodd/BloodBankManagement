using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Blood_Bnk_Management_System
{
    public partial class AdminLogin : Form
    {
        public AdminLogin()
        {
            InitializeComponent();
        }

        private void cancel_Lbl_Click(object sender, EventArgs e)
        {
            login log = new login();
            log.Show();
            this.Close();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            if (ApasswordTb.Text == "")
            {
                MessageBox.Show("Enter The Admin Password");
            }
            else if(ApasswordTb.Text == "password")
            {
                Employee emp=new Employee();
                emp.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Wrong Cradendial. Contact system Admin");
                ApasswordTb.Text = "";
            }
        }
    }
}
