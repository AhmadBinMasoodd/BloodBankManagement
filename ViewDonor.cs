using System.Data;
using System.Data.SqlClient;

namespace Blood_Bnk_Management_System
{
    public partial class ViewDonor : Form
    {
        SqlConnection con;
        public ViewDonor()
        {
            InitializeComponent();
            try
            {
                con = new SqlConnection(@"Data Source=DESKTOP-LI6HKCV\SQLEXPRESS;Initial Catalog=blood_Bank_system;Integrated Security=True;TrustServerCertificate=True");
            }
            catch (Exception ex) { }
            populate();
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
        private void ViewDonor_Load(object sender, EventArgs e)
        {
            //con.Open();
            //string query = "select * from Donor";
            //SqlDataAdapter sda = new SqlDataAdapter(query, con);
            //SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            //var ds = new DataSet();
            //sda.Fill(ds);
            //DonorGV.DataSource = ds.Tables[0];

            //con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void DonorGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Dashboardlbl_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            dashboard.Show();
            this.Hide();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            Patient patient = new Patient();
            patient.Show();
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
            ViewPatient patient = new ViewPatient();
            patient.Show();
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
