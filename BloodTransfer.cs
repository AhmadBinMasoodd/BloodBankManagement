using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using System.Data.SqlClient;
using Microsoft.Data.SqlClient;
namespace Blood_Bnk_Management_System
{
    public partial class BloodTransfer : Form
    {
        SqlConnection con;
        public BloodTransfer()
        {
            InitializeComponent();
            try
            {
                con = new SqlConnection(@"Data Source=DESKTOP-LI6HKCV\SQLEXPRESS;Initial Catalog=blood_Bank_system;Integrated Security=True;TrustServerCertificate=True");
            }
            catch (Exception ex) { }
            fillPatientCb();
        }
        private void fillPatient()
        {
            if (PatientIdCb.SelectedValue != null)
            {
                string query = "Select * from patient where pId = @pId";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@pId", PatientIdCb.SelectedValue.ToString());

                DataTable data = new DataTable();
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                sda.Fill(data);

                if (data.Rows.Count > 0)
                {
                    DataRow dr = data.Rows[0];
                    PNametb.Text = dr["pName"].ToString();
                    PBloodGrouptb.Text = dr["pBGroop"].ToString();
                }
                else
                {
                    MessageBox.Show("No patient found with the selected ID.");
                    PNametb.Text = "";
                    PBloodGrouptb.Text = "";
                }
                con.Close();
            }
            else
            {
                MessageBox.Show("Please select a patient ID.");
            }
        }

        int Stock =0;
        private void GetBloodStock(string Bgroup)
        {
            con.Open();
            string query = "select * from BloodStock where [Group]='" + Bgroup + "'";
            SqlCommand cmd = new SqlCommand(query, con);
            DataTable data = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(data);
            foreach (DataRow dr in data.Rows)
            {
                Stock = Convert.ToInt32(dr["Stock"].ToString());
            }
            con.Close();
        }
        void Reset()
        {
            PNametb.Text = "";
            PBloodGrouptb.Text = "";
            TransfertB.Visible = false;
            AvailableLbl.Text = "Availability";

        }
        private void fillPatientCb()
        {
            con.Open();
            string query = "select pId from patient";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("PId", typeof(string));
            dt.Load(dr);
            PatientIdCb.ValueMember = "PId";
            PatientIdCb.DataSource = dt;

            con.Close();
        }
        private void BloodTransfer_Load(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void TransfertB_Click(object sender, EventArgs e)
        {
            if (PNametb.Text == "")
            {
                MessageBox.Show("Missing Informations");
            }
            else
            {
                try
                {
                    string query = "insert into Transfer values('" + PNametb.Text + "','" + PBloodGrouptb.Text + "')";
                    con.Open();
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Blood Transfer Successfully");
                    con.Close();
                    getBloodStock(PBloodGrouptb.Text);
                    updateStock();
                    Reset();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        int stock = 0;
        private void getBloodStock(string bGroup)
        {
            con.Open();
            string query = "select * from BloodStock where Group='" + PBloodGrouptb.Text + "'";
            SqlCommand cmd = new SqlCommand(query, con);
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                stock = Convert.ToInt32(dr["BStock"].ToString());
            }
            con.Close();
        }
        private void updateStock()
        {
            int newstock = stock - 1;
            try
            {
                string query = "UPDATE BloodStock SET Stock=" + newstock + " WHERE [Group]='" + PBloodGrouptb.Text + "';";

                con.Open();
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                // MessageBox.Show("Patient Successfully Updated");
                con.Close();
                Reset();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void label5_Click(object sender, EventArgs e)
        {
            Blood_Stock blood_Stok = new Blood_Stock();
            blood_Stok.Show();
            this.Hide();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            Patient pat = new Patient();
            pat.Show();
            this.Hide();
        }

        private void PatientIdCb_SelectionChangeCommitted(object sender, EventArgs e)
        {
            fillPatient();
            GetBloodStock(PBloodGrouptb.Text);
            if (Stock > 0)
            {
                TransfertB.Visible = true;
                AvailableLbl.Text = "Available Stock";
                AvailableLbl.Visible = true;
            }
            else
            {
                AvailableLbl.Text = "Unavailable Stock";
                //Available.Visible = false;
            }
            con.Close();
        }

        private void PatientIdCb_SelectedIndexChanged(object sender, EventArgs e)
        {
            var a = PatientIdCb.SelectedValue;
        }

        private void Dashboardlbl_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            dashboard.Show();
            this.Hide();
        }

        private void BStockLbl_Click(object sender, EventArgs e)
        {
            Blood_Stock blood_Stock = new Blood_Stock();
            blood_Stock.Show();
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

        private void Donatelbl_Click(object sender, EventArgs e)
        {
            Donate donate = new Donate();
            donate.Show();
            this.Hide();
        }
    }
}
