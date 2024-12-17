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
using static Guna.UI2.Native.WinApi;
namespace Blood_Bnk_Management_System
{
    public partial class Dashboard : Form
    {
        SqlConnection con;
        public Dashboard()
        {

            InitializeComponent();
            try
            {
                con = new SqlConnection(@"Data Source=DESKTOP-LI6HKCV\SQLEXPRESS;Initial Catalog=blood_Bank_system;Integrated Security=True;TrustServerCertificate=True");
            }
            catch (Exception ex) { }
            GetData();
        }
        private void GetData()
        {
            con.Open();
            // First query for Donor count
            string query = "select count(*) from Donor";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            NoDonorlbl.Text = dt.Rows[0][0].ToString();

            // Second query for Transfer count (for patients)
            string query1 = "select count(*) from Transfer";
            SqlDataAdapter sda1 = new SqlDataAdapter(query1, con);
            DataTable dt1 = new DataTable();
            sda1.Fill(dt1);
            NoPatientlbl.Text = dt1.Rows[0][0].ToString();

            // Third query for Employee count (for users)
            string query2 = "select count(*) from Employee";
            SqlDataAdapter sda2 = new SqlDataAdapter(query2, con);
            DataTable dt2 = new DataTable();
            sda2.Fill(dt2);
            NoUserlbl.Text = dt2.Rows[0][0].ToString();

            SqlDataAdapter sda3 = new SqlDataAdapter("select sum(Stock) from BloodStock ", con);
            DataTable dt3 = new DataTable();
            sda3.Fill(dt3);
            int bstock = Convert.ToInt32(dt3.Rows[0][0].ToString());
            totalLbl.Text = "" + bstock;
            try
            {
                // Query for A+
                SqlDataAdapter sda4 = new SqlDataAdapter("SELECT Stock FROM BloodStock WHERE [Group] = 'A+'", con);
                DataTable dt4 = new DataTable();
                sda4.Fill(dt4);

                if (dt4.Rows.Count > 0)
                {
                    double stockValue = Convert.ToDouble(dt4.Rows[0][0]);
                    AplusNum.Text = stockValue.ToString(); // Update Label
                    Apluspb.Value = bstock > 0 ? Convert.ToInt32((stockValue / bstock) * 100) : 0; // Update ProgressBar
                }
                else
                {
                    AplusNum.Text = "0";
                    Apluspb.Value = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error for A+: " + ex.Message);
            }

            try
            {
                // Query for A-
                SqlDataAdapter sda5 = new SqlDataAdapter("SELECT Stock FROM BloodStock WHERE [Group] = 'A-'", con);
                DataTable dt5 = new DataTable();
                sda5.Fill(dt5);

                if (dt5.Rows.Count > 0)
                {
                    double stockValue = Convert.ToDouble(dt5.Rows[0][0]);
                    AnegNum.Text = stockValue.ToString(); // Update Label
                    AnegPb.Value = bstock > 0 ? Convert.ToInt32((stockValue / bstock) * 100) : 0; // Update ProgressBar
                }
                else
                {
                    AnegNum.Text = "0";
                    AnegPb.Value = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error for A-: " + ex.Message);
            }

            try
            {
                // Query for B+
                SqlDataAdapter sda6 = new SqlDataAdapter("SELECT Stock FROM BloodStock WHERE [Group] = 'B+'", con);
                DataTable dt6 = new DataTable();
                sda6.Fill(dt6);

                if (dt6.Rows.Count > 0)
                {
                    double stockValue = Convert.ToDouble(dt6.Rows[0][0]);
                    BposNum.Text = stockValue.ToString(); // Update Label
                    Bpluspb.Value = bstock > 0 ? Convert.ToInt32((stockValue / bstock) * 100) : 0; // Update ProgressBar
                }
                else
                {
                    BposNum.Text = "0";
                    Bpluspb.Value = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error for B+: " + ex.Message);
            }

            try
            {
                // Query for B-
                SqlDataAdapter sda7 = new SqlDataAdapter("SELECT Stock FROM BloodStock WHERE [Group] = 'B-'", con);
                DataTable dt7 = new DataTable();
                sda7.Fill(dt7);

                if (dt7.Rows.Count > 0)
                {
                    double stockValue = Convert.ToDouble(dt7.Rows[0][0]);
                    BnegNum.Text = stockValue.ToString(); // Update Label
                    BnegPb.Value = bstock > 0 ? Convert.ToInt32((stockValue / bstock) * 100) : 0; // Update ProgressBar
                }
                else
                {
                    BnegNum.Text = "0";
                    BnegPb.Value = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error for B-: " + ex.Message);
            }


            con.Close();
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void NoPatientlbl_Click(object sender, EventArgs e)
        {

        }

        private void AplusNum_Click(object sender, EventArgs e)
        {

        }

        private void Donatelbl_Click(object sender, EventArgs e)
        {
            Donate donate = new Donate();
            donate.Show();
            this.Hide();
        }

        private void Donorlbl_Click(object sender, EventArgs e)
        {
            Donor donor = new Donor();
            donor.Show();
            this.Hide();
        }

        private void vDonorLbl_Click(object sender, EventArgs e)
        {
            ViewDonor viewDonor = new ViewDonor();
            viewDonor.Show();
            this.Hide();
        }

        private void patientlbl_Click(object sender, EventArgs e)
        {
            Patient patient = new Patient();
            patient.Show();
            this.Hide();
        }

        private void vPatient_Click(object sender, EventArgs e)
        {
            ViewPatient viewPatient = new ViewPatient();
            viewPatient.Show();
            this.Hide();
        }

        private void BStockLbl_Click(object sender, EventArgs e)
        {
            Blood_Stock blood_Stock = new Blood_Stock();
            blood_Stock.Show();
            this.Hide();
        }

        private void BTransferLbl_Click(object sender, EventArgs e)
        {
            BloodTransfer bloodTransfer = new BloodTransfer();
            bloodTransfer.Show();
            this.Hide();
        }
    }
}
