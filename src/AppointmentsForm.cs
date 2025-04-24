// --------------------------------------------------------
// AppointmentsForm.cs
// Form for managing appointments in the Hospital Management System.
// Allows adding, editing, displaying, and deleting appointments.
// --------------------------------------------------------

using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace HospitalManagementSystem.Forms
{
    // The form used to manage appointment records in the system
    public partial class AppointmentsForm : Form
    {
        public AppointmentsForm()
        {
            InitializeComponent();
        }

        // Load appointments when the form is opened
        private void AppointmentsForm_Load(object sender, EventArgs e)
        {
            DisplayAppointments();
            PopulateStatusComboBox();
        }

        // Retrieves and displays all appointments from the database
        private void DisplayAppointments()
        {
            try
            {
                using (SqlConnection conn = DatabaseConnection.GetConnection())
                {
                    conn.Open();
                    string query = "SELECT * FROM Appointments";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dgvAppointments.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading appointments: " + ex.Message);
            }
        }

        // Populates the Status ComboBox with predefined statuses
        private void PopulateStatusComboBox()
        {
            cmbStatus.Items.Clear();
            cmbStatus.Items.Add("Scheduled");
            cmbStatus.Items.Add("Completed");
            cmbStatus.Items.Add("Cancelled");
            cmbStatus.SelectedIndex = 0;
        }

        // Adds a new appointment to the database
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = DatabaseConnection.GetConnection())
                {
                    conn.Open();
                    string query = "INSERT INTO Appointments (PatientID, DoctorID, AppointmentDate, Status) VALUES (@PatientID, @DoctorID, @AppointmentDate, @Status)";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@PatientID", txtPatientID.Text);
                        cmd.Parameters.AddWithValue("@DoctorID", txtDoctorID.Text);
                        cmd.Parameters.AddWithValue("@AppointmentDate", dtpAppointmentDate.Value);
                        cmd.Parameters.AddWithValue("@Status", cmbStatus.SelectedItem.ToString());
                        cmd.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("Appointment added successfully!");
                DisplayAppointments();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding appointment: " + ex.Message);
            }
        }

        // Deletes the selected appointment from the database
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvAppointments.SelectedRows.Count > 0)
            {
                int appointmentID = Convert.ToInt32(dgvAppointments.SelectedRows[0].Cells["AppointmentID"].Value);
                try
                {
                    using (SqlConnection conn = DatabaseConnection.GetConnection())
                    {
                        conn.Open();
                        string query = "DELETE FROM Appointments WHERE AppointmentID = @AppointmentID";
                        using (SqlCommand cmd = new SqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@AppointmentID", appointmentID);
                            cmd.ExecuteNonQuery();
                        }
                    }
                    MessageBox.Show("Appointment deleted successfully!");
                    DisplayAppointments();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error deleting appointment: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Please select an appointment to delete.");
            }
        }

        // Modifies the selected appointment's details
        private void btnModify_Click(object sender, EventArgs e)
        {
            if (dgvAppointments.SelectedRows.Count > 0)
            {
                int appointmentID = Convert.ToInt32(dgvAppointments.SelectedRows[0].Cells["AppointmentID"].Value);
                try
                {
                    using (SqlConnection conn = DatabaseConnection.GetConnection())
                    {
                        conn.Open();
                        string query = "UPDATE Appointments SET PatientID = @PatientID, DoctorID = @DoctorID, AppointmentDate = @AppointmentDate, Status = @Status WHERE AppointmentID = @AppointmentID";
                        using (SqlCommand cmd = new SqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@PatientID", txtPatientID.Text);
                            cmd.Parameters.AddWithValue("@DoctorID", txtDoctorID.Text);
                            cmd.Parameters.AddWithValue("@AppointmentDate", dtpAppointmentDate.Value);
                            cmd.Parameters.AddWithValue("@Status", cmbStatus.SelectedItem.ToString());
                            cmd.Parameters.AddWithValue("@AppointmentID", appointmentID);
                            cmd.ExecuteNonQuery();
                        }
                    }
                    MessageBox.Show("Appointment updated successfully!");
                    DisplayAppointments();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error updating appointment: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Please select an appointment to modify.");
            }
        }

        // Fills textboxes when a row in the grid is clicked
        private void dgvAppointments_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvAppointments.Rows[e.RowIndex];
                txtPatientID.Text = row.Cells["PatientID"].Value.ToString();
                txtDoctorID.Text = row.Cells["DoctorID"].Value.ToString();
                dtpAppointmentDate.Value = Convert.ToDateTime(row.Cells["AppointmentDate"].Value);
                cmbStatus.SelectedItem = row.Cells["Status"].Value.ToString();
            }
        }

        // Opens the Patients form and hides the Appointments Dashboard
        private void btnPatients_Click(object sender, EventArgs e)
        {
            PatientsForm patientsForm = new PatientsForm();
            patientsForm.Show();
            this.Hide();
        }

        // Opens the Doctors form and hides the Appointments Dashboard
        private void btnDoctors_Click(object sender, EventArgs e)
        {
            DoctorsForm doctorsForm = new DoctorsForm();
            doctorsForm.Show();
            this.Hide();
        }

        // Displays a message indicating that the Appointments Dashboard is active
        private void btnAppointments_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This is the Appointments Dashboard.");
        }

        //  Handles user logout and returns to the Login screen
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
