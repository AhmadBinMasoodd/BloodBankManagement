using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Blood_Bnk_Management_System
{
    public partial class Donate : Form
    {
        SqlConnection con;
        public Donate()
        {
            InitializeComponent();
            try
            {
                con = new SqlConnection(@"Data Source=DESKTOP-LI6HKCV\SQLEXPRESS;Initial Catalog=blood_Bank_system;Integrated Security=True;TrustServerCertificate=True");
            }
            catch (Exception ex) { }
            populate();
            populate_blood();
            reset();
        }
        private void populate()
        {
            con.Open();
            string query = "select * from Donor";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            DonorGV.DataSource = ds.Tables[0];

            con.Close();
        }
        private void populate_blood()
        {
            con.Open();
            string query = "select * from BloodStock";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            BloodStockGV.DataSource = ds.Tables[0];

            con.Close();
        }
        private void reset()
        {
            DBgrouptb.Text = "";
            DNametb.Text = "";
        }
        private void Donate_Load(object sender, EventArgs e)
        {

        }
        private int getStock(string Bgroup)
        {
            int stock = 0;
            try
            {
                con.Open();
                string query = "SELECT Stock FROM BloodStock WHERE [Group] = @Bgroup";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Bgroup", Bgroup);

                // Use ExecuteScalar for a single value
                object result = cmd.ExecuteScalar();
                if (result != null)
                {
                    stock = Convert.ToInt32(result);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
            return stock;
        }
        private void TransfertB_Click(object sender, EventArgs e)
        {
            if (DNametb.Text == "" || DBgrouptb.Text == "")
            {
                MessageBox.Show("Missing Information! Please Select a Donor");
            }
            else
            {
                try
                {
                    // Get the current stock
                    int Stock = getStock(DBgrouptb.Text) + 1;
                    // Update the stock in the database
                    string query = "UPDATE BloodStock SET Stock = '" + Stock + "' WHERE [Group] = '" + DBgrouptb.Text + "'";
                    con.Open();
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Donation Sucessful");
                    con.Close();
                    reset();
                    populate_blood();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
                finally
                {
                    con.Close();
                }

                reset();
                populate_blood();
            }
        }

        private void DonorGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DNametb.Text = DonorGV.SelectedRows[0].Cells[1].Value.ToString();
            DBgrouptb.Text = DonorGV.SelectedRows[0].Cells[6].Value.ToString();
        }

        private void Dashboardlbl_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            dashboard.Show();
            this.Hide();
        }

        private void BTransferLbl_Click(object sender, EventArgs e)
        {
            BloodTransfer bloodTransfer = new BloodTransfer();
            bloodTransfer.Show();
            this.Hide();
        }

        private void BStockLbl_Click(object sender, EventArgs e)
        {
            Blood_Stock bloodStock = new Blood_Stock();
            bloodStock.Show();
            this.Hide();
        }

        private void vPatient_Click(object sender, EventArgs e)
        {
            ViewPatient viewPatient = new ViewPatient();
            viewPatient.Show();
            this.Hide();
        }

        private void patientlbl_Click(object sender, EventArgs e)
        {
            Patient patient = new Patient();
            patient.Show();
            this.Hide();
        }

        private void vDonorLbl_Click(object sender, EventArgs e)
        {
            ViewDonor viewDonor = new ViewDonor();
            viewDonor.Show();
            this.Hide();
        }

        private void Donorlbl_Click(object sender, EventArgs e)
        {
            Donor donor = new Donor();
            donor.Show();
            this.Hide();
        }
    }
}
