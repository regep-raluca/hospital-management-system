// --------------------------------------------------------
// PatientsForm.cs
// Form for managing patients in the Hospital Management System.
// Allows adding, editing, displaying, and deleting patients.
// --------------------------------------------------------

using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace HospitalManagementSystem.Forms
{
    public partial class PatientsForm : Form
    {
        public PatientsForm()
        {
            InitializeComponent();
        }

        // Loads the patient list when the form is opened
        private void PatientsForm_Load(object sender, EventArgs e)
        {
            DisplayPatients();
        }

        // Retrieves and displays all patients from the database
        private void DisplayPatients()
        {
            try
            {
                using (SqlConnection conn = DatabaseConnection.GetConnection())
                {
                    conn.Open();
                    string query = "SELECT * FROM Patients";

                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    dgvPatients.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading patients: " + ex.Message);
            }
        }

        // Validates input fields
        private bool ValidateFields()
        {
            // Check if fields are empty
            if (string.IsNullOrWhiteSpace(txtLastName.Text) ||
                string.IsNullOrWhiteSpace(txtFirstName.Text) ||
                string.IsNullOrWhiteSpace(txtPhoneNumber.Text) ||
                string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                MessageBox.Show("All fields are required.");
                return false;
            }

            // Validate phone number (must be numeric)
            if (!Regex.IsMatch(txtPhoneNumber.Text, @"^\d+$"))
            {
                MessageBox.Show("Phone number must be numeric.");
                return false;
            }

            // Validate email format
            var emailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            if (!Regex.IsMatch(txtEmail.Text, emailPattern))
            {
                MessageBox.Show("Please enter a valid email address.");
                return false;
            }

            return true;
        }

        // Adds a new patient to the database
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!ValidateFields())
                return;

            try
            {
                using (SqlConnection conn = DatabaseConnection.GetConnection())
                {
                    conn.Open();
                    string lastname = txtLastName.Text;
                    string firstname = txtFirstName.Text;
                    string phonenumber = txtPhoneNumber.Text;
                    string email = txtEmail.Text;
                    string query = "INSERT INTO Patients (LastName, FirstName, PhoneNumber, Email) VALUES (@lastname, @firstname, @phonenumber, @email)";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@lastname", lastname);
                        cmd.Parameters.AddWithValue("@firstname", firstname);
                        cmd.Parameters.AddWithValue("@phonenumber", phonenumber);
                        cmd.Parameters.AddWithValue("@email", email);

                        cmd.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("The patient was added successfully!");
                DisplayPatients();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        // Deletes the selected patient from the database
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvPatients.SelectedRows.Count > 0)
            {
                int selectedId = Convert.ToInt32(dgvPatients.SelectedRows[0].Cells["PatientID"].Value);

                try
                {
                    using (SqlConnection conn = DatabaseConnection.GetConnection())
                    {
                        conn.Open();
                        string query = "DELETE FROM Patients WHERE PatientID = @id";

                        using (SqlCommand cmd = new SqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@id", selectedId);
                            cmd.ExecuteNonQuery();
                        }
                    }
                    MessageBox.Show("Patient deleted successfully!");
                    DisplayPatients();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Please select a patient to delete.");
            }
        }

        // Modifies the selected patient's data
        private void btnModify_Click(object sender, EventArgs e)
        {
            if (!ValidateFields())
                return;

            if (dgvPatients.SelectedRows.Count > 0)
            {
                int selectedId = Convert.ToInt32(dgvPatients.SelectedRows[0].Cells["PatientID"].Value);
                string lastName = txtLastName.Text;
                string firstname = txtFirstName.Text;
                string phonenumber = txtPhoneNumber.Text;
                string email = txtEmail.Text;

                try
                {
                    using (SqlConnection conn = DatabaseConnection.GetConnection())
                    {
                        conn.Open();

                        string query = "UPDATE Patients SET LastName = @LastName, FirstName = @FirstName, PhoneNumber = @PhoneNumber, Email = @Email WHERE PatientID = @PatientID";

                        using (SqlCommand cmd = new SqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@LastName", lastName);
                            cmd.Parameters.AddWithValue("@FirstName", firstname);
                            cmd.Parameters.AddWithValue("@PhoneNumber", phonenumber);
                            cmd.Parameters.AddWithValue("@Email", email);
                            cmd.Parameters.AddWithValue("@PatientID", selectedId);

                            cmd.ExecuteNonQuery();
                        }
                    }
                    MessageBox.Show("Patient updated successfully.");
                    DisplayPatients();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Please select a patient to modify.");
                return;
            }
        }

        // Fills textboxes when a row in the grid is clicked
        private void dgvPatients_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvPatients.Rows[e.RowIndex];

                txtLastName.Text = row.Cells["LastName"].Value.ToString();
                txtFirstName.Text = row.Cells["FirstName"].Value.ToString();
                txtPhoneNumber.Text = row.Cells["PhoneNumber"].Value.ToString();
                txtEmail.Text = row.Cells["Email"].Value.ToString();
            }
        }

        // Display message when the Patients Dashboard button is clicked
        private void btnPatients_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This is the Patients Dashboard.");
        }

        // Opens the Doctors form and hides the current form
        private void btnDoctors_Click(object sender, EventArgs e)
        {
            DoctorsForm doctorsForm = new DoctorsForm();
            doctorsForm.Show();
            this.Hide();
        }

        // Opens the Appointments form and hides the current form
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

