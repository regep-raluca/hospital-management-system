// --------------------------------------------------------
// DoctorsForm.cs
// Form for managing doctors in the Hospital Management System.
// Allows adding, editing, displaying, and deleting doctors.
// Includes navigation to Patients and Appointments forms.
// --------------------------------------------------------

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

namespace HospitalManagementSystem.Forms
{
    // The form used to manage doctor records in the system
    public partial class DoctorsForm : Form
    {
        public DoctorsForm()
        {
            InitializeComponent();
        }

        // Loads the doctor list when the form is opened
        private void DoctorsForm_Load(object sender, EventArgs e)
        {
            dgvDoctors.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; // asigură afișare completă
            DisplayDoctors();
        }

        // Retrieves and displays all doctors from the database
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
                MessageBox.Show("Error loading doctors: " + ex.Message);
            }
        }

        // Validates input fields for doctors
        private bool ValidateDoctorFields()
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Please enter the doctor's name.");
                txtName.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtSpecialty.Text))
            {
                MessageBox.Show("Please enter the doctor's specialty.");
                txtSpecialty.Focus();
                return false;
            }

            return true;
        }

        // Adds a new doctor to the database
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
                MessageBox.Show("The doctor was added successfully!");
                DisplayDoctors();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        // Deletes the selected doctor from the database
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
                    MessageBox.Show("Doctor deleted successfully!");
                    DisplayDoctors();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Please select a doctor to delete.");
            }
        }

        // Modifies the selected doctor's data
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
                    MessageBox.Show("Doctor updated successfully.");
                    DisplayDoctors();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Please select a doctor to modify.");
                return;
            }
        }

        // Fills textboxes when a row in the grid is clicked
        private void dgvDoctors_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvDoctors.Rows[e.RowIndex];

                txtName.Text = row.Cells["Name"].Value.ToString();
                txtSpecialty.Text = row.Cells["Specialty"].Value.ToString();
            }
        }

        // Opens the Patients form and hides the Appointments Dashboard
        private void btnPatients_Click(object sender, EventArgs e)
        {
            PatientsForm patientsForm = new PatientsForm();
            patientsForm.Show();
            this.Hide();
        }

        // Displays a message indicating that the Doctors Dashboard is active
        private void btnDoctors_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This is the Doctors Dashboard.");
        }

        // Opens the Appointments form and hides the Appointments Dashboard
        private void btnAppointments_Click(object sender, EventArgs e)
        {
            AppointmentsForm appointmentsForm = new AppointmentsForm();
            appointmentsForm.Show();
            this.Hide();
        }

        // Handles user logout and returns to the Login screen
        private void btnLogOut_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Close();
        }

        // Highlight button on mouse hover - Patients
        private void btnPatients_MouseEnter(object sender, EventArgs e)
        {
            btnPatients.BackColor = Color.LightSteelBlue;
            btnPatients.ForeColor = Color.White;
        }

        // Reset button color on mouse leave - Patients
        private void btnPatients_MouseLeave(object sender, EventArgs e)
        {
            btnPatients.BackColor = Color.MidnightBlue;
            btnPatients.ForeColor = Color.White;
        }

        // Highlight button on mouse hover - Doctors
        private void btnDoctors_MouseEnter(object sender, EventArgs e)
        {
            btnDoctors.BackColor = Color.LightSteelBlue;
            btnDoctors.ForeColor = Color.White;
        }

        // Reset button color on mouse leave - Doctors
        private void btnDoctors_MouseLeave(object sender, EventArgs e)
        {
            btnDoctors.BackColor = Color.MidnightBlue;
            btnDoctors.ForeColor = Color.White;
        }

        // Highlight button on mouse hover - Appointments
        private void btnAppointments_MouseEnter(object sender, EventArgs e)
        {
            btnAppointments.BackColor = Color.LightSteelBlue;
            btnAppointments.ForeColor = Color.White;
        }

        // Reset button color on mouse leave - Appointments
        private void btnAppointments_MouseLeave(object sender, EventArgs e)
        {
            btnAppointments.BackColor = Color.MidnightBlue;
            btnAppointments.ForeColor = Color.White;
        }

        // Highlight button on mouse hover - Logout
        private void btnLogOut_MouseEnter(object sender, EventArgs e)
        {
            btnLogOut.BackColor = Color.LightSteelBlue;
            btnLogOut.ForeColor = Color.White;
        }

        // Reset button color on mouse leave - Logout
        private void btnLogOut_MouseLeave(object sender, EventArgs e)
        {
            btnLogOut.BackColor = Color.MidnightBlue;
            btnLogOut.ForeColor = Color.White;
        }

        // Changes add button color on mouse hover
        private void btnAdd_MouseEnter(object sender, EventArgs e)
        {
            btnAdd.BackColor = Color.LightSteelBlue;
            btnAdd.ForeColor = Color.White;
        }

        // Restores add button color when mouse leaves
        private void btnAdd_MouseLeave(object sender, EventArgs e)
        {
            btnAdd.BackColor = Color.RoyalBlue;
            btnAdd.ForeColor = Color.White;
        }

        // Changes delete button color on mouse hover
        private void btnDelete_MouseEnter(object sender, EventArgs e)
        {
            btnDelete.BackColor = Color.LightSteelBlue;
            btnDelete.ForeColor = Color.White;
        }

        // Restores delete button color when mouse leaves
        private void btnDelete_MouseLeave(object sender, EventArgs e)
        {
            btnDelete.BackColor = Color.RoyalBlue;
            btnDelete.ForeColor = Color.White;
        }

        // Changes modify button color on mouse hover
        private void btnModify_MouseEnter(object sender, EventArgs e)
        {
            btnModify.BackColor = Color.LightSteelBlue;
            btnModify.ForeColor = Color.White;
        }

        // Restores modify button color when mouse leaves
        private void btnModify_MouseLeave(object sender, EventArgs e)
        {
            btnModify.BackColor = Color.RoyalBlue;
            btnModify.ForeColor = Color.White;
        }
    }
}

