using System.Data.SqlClient;

namespace Blood_Bnk_Management_System
{
    public partial class Donor : Form
    {

        SqlConnection con;

        public Donor()
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
            DNametb.Text = "";
            DAgetb.Text = "";
            DPhone.Text = "";
            DGenderCb.SelectedIndex = -1;
            DBGroupCb.SelectedIndex = -1;
            DAddressRtb.Text = "";
        }
        private void DSaveB_Click(object sender, EventArgs e)
        {
            if (DNametb.Text == "" || DPhone.Text == "" || DAgetb.Text == "" || DGenderCb.SelectedIndex == -1 || DBGroupCb.SelectedIndex == -1)
            {
                MessageBox.Show("Missing Informations");
            }
            else
            {
                try
                {
                    string query = "insert into Donor values('" + DNametb.Text + "'," + DAgetb.Text + ",'" + DGenderCb.SelectedItem.ToString() + "','" + DPhone.Text + "','" + DAddressRtb.Text + "','" + DBGroupCb.SelectedItem.ToString() + "')";
                    con.Open();
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Donor Successfully Saved");
                    con.Close();
                    Reset();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
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

        private void Donatelbl_Click(object sender, EventArgs e)
        {
            Donate donate = new Donate();
            donate.Show();
            this.Hide();
        }
    }
}