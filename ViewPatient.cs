using System.Data;
using System.Data.SqlClient;
namespace Blood_Bnk_Management_System
{
    public partial class ViewPatient : Form
    {
        SqlConnection con;
        private bool IsIntializeData = false;
        public ViewPatient()
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
            string query = "select * from Patient";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            PaientGV.DataSource = ds.Tables[0];

            con.Close();

            IsIntializeData = true;
        }
        int key = 0;
        private void PaientGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }



        private void guna2DataGridView_CellContentClicked(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Ensure a valid row is selected
            {
                DataGridViewRow row = PaientGV.Rows[e.RowIndex];
                PNametb.Text = row.Cells[1].Value?.ToString();
                PAgetb.Text = row.Cells[2].Value?.ToString();
                PPhoneTb.Text = row.Cells[3].Value?.ToString();
                PGenderCb.SelectedItem = row.Cells[4].Value?.ToString();
                PBGroupCb.SelectedItem = row.Cells[5].Value?.ToString();
                PAddressRtb.Text = row.Cells[6].Value?.ToString();
            }
            if (PNametb.Text == "")
            {
                key = 0;
            }
            else
            {
                key = Convert.ToInt32(PaientGV.SelectedRows[0].Cells[0].Value.ToString());
            }
        }
        private void Reset()
        {
            PNametb.Text = "";
            PAgetb.Text = "";
            PPhoneTb.Text = "";
            PGenderCb.SelectedIndex = -1;
            PBGroupCb.SelectedIndex = -1;
            PAddressRtb.Text = "";
            key = 0;
        }
        private void PDeleteB_Click(object sender, EventArgs e)
        {
            if (key == 0)
            {
                MessageBox.Show("Select the patient to Delete");
            }
            else
            {
                try
                {
                    string query = "Delete from Patient where pId=" + key + "";
                    con.Open();
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Patient Successfully Deleted");
                    con.Close();
                    Reset();
                    populate();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void PEditB_Click(object sender, EventArgs e)
        {
            if (PNametb.Text == "" || PPhoneTb.Text == "" || PAgetb.Text == "" || PGenderCb.SelectedIndex == -1 || PBGroupCb.SelectedIndex == -1 || PAddressRtb.Text == "")
            {
                MessageBox.Show("Missing Information of Patient for Edit/Updating");
            }
            else
            {
                try
                {
                    string query = "UPDATE Patient SET " +
                                   "pName = '" + PNametb.Text + "', " +
                                   "pAge = " + PAgetb.Text + ", " +
                                   "pPhone = '" + PPhoneTb.Text + "', " +
                                   "pGender = '" + PGenderCb.SelectedItem.ToString() + "', " +
                                   "pBGroup = '" + PBGroupCb.SelectedItem.ToString() + "', " +
                                   "pAddress = '" + PAddressRtb.Text + "' " +
                                   "WHERE pId = " + key;
                    con.Open();
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Patient Successfully Deleted");
                    con.Close();
                    Reset();
                    populate();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void PNametb_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {
            Patient patient = new Patient();
            patient.Show();
            this.Hide();
        }

        //private void PaientGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        //{

        //}

        private void PaientGV_SelectionChanged1(object sender, EventArgs e)
        {
            //try
            //{
            //    if (!IsIntializeData)
            //        return;

            //    if (PaientGV.SelectedRows != null) // Ensure a valid row is selected
            //    {
            //        PNametb.Text = PaientGV.SelectedRows[0].Cells[0].Value.ToString();
            //        PAgetb.Text = PaientGV.SelectedRows[0].Cells[1].Value.ToString();
            //        //PPhoneTb.Text = row.Cells[3].Value?.ToString();
            //        //PGenderCb.SelectedItem = row.Cells[4].Value?.ToString();
            //        //PBGroupCb.SelectedItem = row.Cells[5].Value?.ToString();
            //        //PAddressRtb.Text = row.Cells[6].Value?.ToString();
            //    }
            //}
            //catch { }
            //if (PNametb.Text == "")
            //{
            //    key = 0;
            //}
            //else
            //{
            //    key = Convert.ToInt32(PaientGV.SelectedRows[0].Cells[0].Value.ToString());
            //}
        }

        private void label17_Click(object sender, EventArgs e)
        {
            Donate donate = new Donate();
            donate.Show();
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

        private void BStockLbl_Click(object sender, EventArgs e)
        {
            Blood_Stock blood_Stock = new Blood_Stock();
            blood_Stock.Show();
            this.Hide();
        }

        private void Patientlbl_Click(object sender, EventArgs e)
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

        private void PaientGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (PaientGV.SelectedRows != null) // Ensure a valid row is selected
                {
                    key = Convert.ToInt32(PaientGV.SelectedRows[0].Cells[0].Value.ToString());
                    PNametb.Text = PaientGV.SelectedRows[0].Cells[1].Value.ToString();
                    PAgetb.Text = PaientGV.SelectedRows[0].Cells[2].Value.ToString();
                    PPhoneTb.Text = PaientGV.SelectedRows[0].Cells[3].Value?.ToString();

                    // Fix for ComboBoxes
                    string gender = PaientGV.SelectedRows[0].Cells[4].Value?.ToString().Trim();
                    if (PGenderCb.Items.Contains(gender))
                        PGenderCb.SelectedItem = gender;

                    string bloodGroup = PaientGV.SelectedRows[0].Cells[5].Value?.ToString().Trim();
                    if (PBGroupCb.Items.Contains(bloodGroup))
                        PBGroupCb.SelectedItem = bloodGroup;

                    PAddressRtb.Text = PaientGV.SelectedRows[0].Cells[6].Value?.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }
    }
}
