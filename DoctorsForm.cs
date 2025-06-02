// --------------------------------------------------------
// DoctorsForm.cs
// Form for managing doctors in the Hospital Management System.
// Allows adding, editing, displaying, deleting, and searching doctors.
// Includes navigation to Patients and Appointments forms.
// --------------------------------------------------------

using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace HospitalManagementSystem.Forms
{
    public partial class DoctorsForm : Form
    {
        public DoctorsForm()
        {
            InitializeComponent();
        }

        private void DoctorsForm_Load(object sender, EventArgs e)
        {
            dgvDoctors.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DisplayDoctors();
        }

        private void DisplayDoctors()
        {
            try
            {
                using (SqlConnection conn = DatabaseConnection.GetConnection())
                {
                    conn.Open();
                    string query = "SELECT * FROM Doctors";

                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    dgvDoctors.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading doctors: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidateDoctorFields()
        {
            string romanianLettersPattern = @"^[a-zA-ZăâîșțĂÂÎȘȚ\- ]+$";

            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Please enter the doctor's name.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtName.Focus();
                return false;
            }

            if (!Regex.IsMatch(txtName.Text, romanianLettersPattern))
            {
                MessageBox.Show("Name can only contain English letters, spaces and hyphens.", "Invalid Name", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtName.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtSpecialty.Text))
            {
                MessageBox.Show("Please enter the doctor's specialty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSpecialty.Focus();
                return false;
            }

            if (!Regex.IsMatch(txtSpecialty.Text, romanianLettersPattern))
            {
                MessageBox.Show("Specialty can only contain English letters, spaces and hyphens.", "Invalid Specialty", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSpecialty.Focus();
                return false;
            }

            return true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!ValidateDoctorFields())
                return;

            try
            {
                using (SqlConnection conn = DatabaseConnection.GetConnection())
                {
                    conn.Open();
                    string name = txtName.Text.Trim();
                    string specialty = txtSpecialty.Text.Trim();

                    string query = "INSERT INTO Doctors (Name, Specialty) VALUES (@Name, @Specialty)";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Name", name);
                        cmd.Parameters.AddWithValue("@Specialty", specialty);

                        cmd.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("Doctor added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DisplayDoctors();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding doctor: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvDoctors.SelectedRows.Count > 0)
            {
                int selectedId = Convert.ToInt32(dgvDoctors.SelectedRows[0].Cells["DoctorID"].Value);

                try
                {
                    using (SqlConnection conn = DatabaseConnection.GetConnection())
                    {
                        conn.Open();
                        string query = "DELETE FROM Doctors WHERE DoctorID = @id";

                        using (SqlCommand cmd = new SqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@id", selectedId);
                            cmd.ExecuteNonQuery();
                        }
                    }
                    MessageBox.Show("Doctor deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DisplayDoctors();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error deleting doctor: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please select a doctor to delete.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            if (dgvDoctors.SelectedRows.Count > 0)
            {
                if (!ValidateDoctorFields())
                    return;

                int selectedId = Convert.ToInt32(dgvDoctors.SelectedRows[0].Cells["DoctorID"].Value);
                string name = txtName.Text.Trim();
                string specialty = txtSpecialty.Text.Trim();

                try
                {
                    using (SqlConnection conn = DatabaseConnection.GetConnection())
                    {
                        conn.Open();

                        string query = "UPDATE Doctors SET Name = @Name, Specialty = @Specialty WHERE DoctorID = @DoctorID";

                        using (SqlCommand cmd = new SqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@Name", name);
                            cmd.Parameters.AddWithValue("@Specialty", specialty);
                            cmd.Parameters.AddWithValue("@DoctorID", selectedId);

                            cmd.ExecuteNonQuery();
                        }
                    }
                    MessageBox.Show("Doctor updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DisplayDoctors();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error updating doctor: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please select a doctor to modify.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dgvDoctors_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvDoctors.Rows[e.RowIndex];

                txtName.Text = row.Cells["Name"].Value.ToString();
                txtSpecialty.Text = row.Cells["Specialty"].Value.ToString();
            }
        }

        private void btnPatients_Click(object sender, EventArgs e)
        {
            PatientsForm patientsForm = new PatientsForm();
            patientsForm.Show();
            this.Hide();
        }

        private void btnDoctors_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This is the Doctors Dashboard.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnAppointments_Click(object sender, EventArgs e)
        {
            AppointmentsForm appointmentsForm = new AppointmentsForm();
            appointmentsForm.Show();
            this.Hide();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Close();
        }

        private void btnPatients_MouseEnter(object sender, EventArgs e)
        {
            btnPatients.BackColor = Color.LightSteelBlue;
            btnPatients.ForeColor = Color.White;
        }

        private void btnPatients_MouseLeave(object sender, EventArgs e)
        {
            btnPatients.BackColor = Color.MidnightBlue;
            btnPatients.ForeColor = Color.White;
        }

        private void btnDoctors_MouseEnter(object sender, EventArgs e)
        {
            btnDoctors.BackColor = Color.LightSteelBlue;
            btnDoctors.ForeColor = Color.White;
        }

        private void btnDoctors_MouseLeave(object sender, EventArgs e)
        {
            btnDoctors.BackColor = Color.MidnightBlue;
            btnDoctors.ForeColor = Color.White;
        }

        private void btnAppointments_MouseEnter(object sender, EventArgs e)
        {
            btnAppointments.BackColor = Color.LightSteelBlue;
            btnAppointments.ForeColor = Color.White;
        }

        private void btnAppointments_MouseLeave(object sender, EventArgs e)
        {
            btnAppointments.BackColor = Color.MidnightBlue;
            btnAppointments.ForeColor = Color.White;
        }

        private void btnLogOut_MouseEnter(object sender, EventArgs e)
        {
            btnLogOut.BackColor = Color.LightSteelBlue;
            btnLogOut.ForeColor = Color.White;
        }

        private void btnLogOut_MouseLeave(object sender, EventArgs e)
        {
            btnLogOut.BackColor = Color.MidnightBlue;
            btnLogOut.ForeColor = Color.White;
        }

        private void btnAdd_MouseEnter(object sender, EventArgs e)
        {
            btnAdd.BackColor = Color.LightSteelBlue;
            btnAdd.ForeColor = Color.White;
        }

        private void btnAdd_MouseLeave(object sender, EventArgs e)
        {
            btnAdd.BackColor = Color.RoyalBlue;
            btnAdd.ForeColor = Color.White;
        }

        private void btnDelete_MouseEnter(object sender, EventArgs e)
        {
            btnDelete.BackColor = Color.LightSteelBlue;
            btnDelete.ForeColor = Color.White;
        }

        private void btnDelete_MouseLeave(object sender, EventArgs e)
        {
            btnDelete.BackColor = Color.RoyalBlue;
            btnDelete.ForeColor = Color.White;
        }

        private void btnModify_MouseEnter(object sender, EventArgs e)
        {
            btnModify.BackColor = Color.LightSteelBlue;
            btnModify.ForeColor = Color.White;
        }

        private void btnModify_MouseLeave(object sender, EventArgs e)
        {
            btnModify.BackColor = Color.RoyalBlue;
            btnModify.ForeColor = Color.White;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string name = txtName.Text.Trim();
            string specialty = txtSpecialty.Text.Trim();

            if (string.IsNullOrEmpty(name) && string.IsNullOrEmpty(specialty))
            {
                MessageBox.Show("Please fill in at least one field: Name or Specialty.", "Invalid Search", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SqlConnection conn = DatabaseConnection.GetConnection())
                {
                    conn.Open();

                    string query = "SELECT * FROM Doctors WHERE 1=1";

                    if (!string.IsNullOrEmpty(name))
                        query += " AND Name LIKE @Name";

                    if (!string.IsNullOrEmpty(specialty))
                        query += " AND Specialty LIKE @Specialty";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        if (!string.IsNullOrEmpty(name))
                            cmd.Parameters.AddWithValue("@Name", "%" + name + "%");

                        if (!string.IsNullOrEmpty(specialty))
                            cmd.Parameters.AddWithValue("@Specialty", "%" + specialty + "%");

                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);

                        dgvDoctors.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Search error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
