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
using System.Collections;
namespace Blood_Bnk_Management_System
{
    public partial class Employee : Form
    {
        SqlConnection con;
        public Employee()
        {
            InitializeComponent();

            try
            {
                con = new SqlConnection(@"Data Source=DESKTOP-LI6HKCV\SQLEXPRESS;Initial Catalog=blood_Bank_system;Integrated Security=True;TrustServerCertificate=True");
            }
            catch (Exception ex) { }
        }
        private void Reset()
        {
            ENameTb.Text = "";
            salarytb.Text = "";
            EPhoneTb.Text = "";
            usernametb.Text = "";
            passwordtb.Text = "";
            EGenderCb.SelectedIndex = -1;
            EBGroupCb.SelectedIndex = -1;
            EAddressRtb.Text = "";
        }

        private void PPhoneTb_TextChanged(object sender, EventArgs e)
        {

        }

        private void PSaveB_Click(object sender, EventArgs e)
        {
            if (EAddressRtb.Text == "" || ENameTb.Text == "" || EPhoneTb.Text == "" || usernametb.Text == "" || passwordtb.Text == "" || salarytb.Text == "" || EGenderCb.SelectedIndex == -1 || EBGroupCb.SelectedIndex == -1)
            {
                MessageBox.Show("Missing Informations");
            }
            else
            {
                try
                {
                    string query = "insert into Employee values('" + usernametb.Text + "','" + passwordtb.Text + "','" + ENameTb.Text + "'," + EPhoneTb.Text + ",'" + EGenderCb.SelectedItem.ToString() + "','" + EBGroupCb.SelectedItem.ToString() + "','" + EAddressRtb.Text + "','" + salarytb.Text + "')";
                    SqlCommand cmd = new SqlCommand(query, con);

                    cmd.Parameters.AddWithValue("@username", usernametb.Text.Trim());
                    cmd.Parameters.AddWithValue("@password", passwordtb.Text.Trim());
                    cmd.Parameters.AddWithValue("@name", ENameTb.Text.Trim());
                    cmd.Parameters.AddWithValue("@phone", EPhoneTb.Text.Trim());
                    cmd.Parameters.AddWithValue("@gender", EGenderCb.SelectedItem?.ToString());
                    cmd.Parameters.AddWithValue("@bloodGroup", EBGroupCb.SelectedItem?.ToString());
                    cmd.Parameters.AddWithValue("@address", EAddressRtb.Text.Trim());
                    cmd.Parameters.AddWithValue("@salary", salarytb.Text.Trim());

                    con.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Employee Saved Successfully");
                    con.Close();
                    Reset();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {
            EditEmp emp = new EditEmp();
            emp.Show();
            this.Hide();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
