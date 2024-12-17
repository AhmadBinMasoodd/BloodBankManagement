using System.Data;
using Microsoft.Data.SqlClient;
namespace Blood_Bnk_Management_System
{
    public partial class Blood_Stock : Form
    {
        SqlConnection con;
        public Blood_Stock()
        {
            InitializeComponent();
            try
            {
                con = new SqlConnection(@"Data Source=DESKTOP-LI6HKCV\SQLEXPRESS;Initial Catalog=blood_Bank_system;Integrated Security=True;TrustServerCertificate=True");
            }
            catch (Exception ex) { }
            BloodStockView();
        }
        //int oldStock;
        //private void GetBloodStock(string Bgroup)
        //{
        //    con.Open();
        //    string query = "select * from BloodStock where Group='" + Bgroup + "'";
        //    SqlCommand cmd = new SqlCommand(query, con);
        //    DataTable data = new DataTable();
        //    SqlDataAdapter sda = new SqlDataAdapter(cmd);
        //    sda.Fill(data);
        //    foreach (DataRow dr in data.Rows)
        //    {
        //        oldStock = Convert.ToInt32(dr["Stock"].ToString());
        //    }
        //    con.Close();
        //}
        private void BloodStockView()
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
        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void BloodStockGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {
            BloodTransfer bloodTrans = new BloodTransfer();
            bloodTrans.Show();
            this.Hide();
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
