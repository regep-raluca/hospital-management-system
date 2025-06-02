// --------------------------------------------------------
// AppointmentsForm.cs
// Form for managing appointments in the Hospital Management System.
// Allows adding, editing, displaying, deleting, and searching appointments.
// Includes navigation to Patients and Doctors forms.
// --------------------------------------------------------

using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace HospitalManagementSystem.Forms
{
    public partial class AppointmentsForm : Form
    {
        public delegate void AppointmentChangedHandler(object sender, EventArgs e);
        public event AppointmentChangedHandler AppointmentChanged;

        protected virtual void OnAppointmentChanged()
        {
            AppointmentChanged?.Invoke(this, EventArgs.Empty);
        }

        public AppointmentsForm()
        {
            InitializeComponent();
            this.AppointmentChanged += AppointmentsForm_AppointmentChanged;  
        }

        private void AppointmentsForm_AppointmentChanged(object sender, EventArgs e)
        {
            MessageBox.Show("The appointments have been modified!", "Notification");
        }

        private void AppointmentsForm_Load(object sender, EventArgs e)
        {
            DisplayAppointments();
            PopulateStatusComboBox();
        }

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

        private void PopulateStatusComboBox()
        {
            cmbStatus.Items.Clear();
            cmbStatus.Items.Add("Scheduled");
            cmbStatus.Items.Add("Completed");
            cmbStatus.Items.Add("Cancelled");
            cmbStatus.SelectedIndex = 0;
        }

        private bool ValidateIDs()
        {
            if (!int.TryParse(txtPatientID.Text, out _))
            {
                MessageBox.Show("Patient ID must be a number.", "Validation Error");
                txtPatientID.Focus();
                return false;
            }

            if (!int.TryParse(txtDoctorID.Text, out _))
            {
                MessageBox.Show("Doctor ID must be a number.", "Validation Error");
                txtDoctorID.Focus();
                return false;
            }

            return true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!ValidateIDs()) return;

            try
            {
                using (SqlConnection conn = DatabaseConnection.GetConnection())
                {
                    conn.Open();
                    string query = "INSERT INTO Appointments (PatientID, DoctorID, AppointmentDate, Status) VALUES (@PatientID, @DoctorID, @AppointmentDate, @Status)";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@PatientID", int.Parse(txtPatientID.Text));
                        cmd.Parameters.AddWithValue("@DoctorID", int.Parse(txtDoctorID.Text));
                        cmd.Parameters.AddWithValue("@AppointmentDate", dtpAppointmentDate.Value);
                        cmd.Parameters.AddWithValue("@Status", cmbStatus.SelectedItem.ToString());
                        cmd.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("Appointment added successfully!");
                DisplayAppointments();

                OnAppointmentChanged(); // Notificare schimbare
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding appointment: " + ex.Message);
            }
        }

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

                    OnAppointmentChanged(); 
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

        private void btnModify_Click(object sender, EventArgs e)
        {
            if (dgvAppointments.SelectedRows.Count > 0)
            {
                if (!ValidateIDs()) return;

                int appointmentID = Convert.ToInt32(dgvAppointments.SelectedRows[0].Cells["AppointmentID"].Value);
                try
                {
                    using (SqlConnection conn = DatabaseConnection.GetConnection())
                    {
                        conn.Open();
                        string query = "UPDATE Appointments SET PatientID = @PatientID, DoctorID = @DoctorID, AppointmentDate = @AppointmentDate, Status = @Status WHERE AppointmentID = @AppointmentID";
                        using (SqlCommand cmd = new SqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@PatientID", int.Parse(txtPatientID.Text));
                            cmd.Parameters.AddWithValue("@DoctorID", int.Parse(txtDoctorID.Text));
                            cmd.Parameters.AddWithValue("@AppointmentDate", dtpAppointmentDate.Value);
                            cmd.Parameters.AddWithValue("@Status", cmbStatus.SelectedItem.ToString());
                            cmd.Parameters.AddWithValue("@AppointmentID", appointmentID);
                            cmd.ExecuteNonQuery();
                        }
                    }
                    MessageBox.Show("Appointment updated successfully!");
                    DisplayAppointments();

                    OnAppointmentChanged(); 
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

        private void btnPatients_Click(object sender, EventArgs e)
        {
            PatientsForm patientsForm = new PatientsForm();
            patientsForm.Show();
            this.Hide();
        }

        private void btnDoctors_Click(object sender, EventArgs e)
        {
            DoctorsForm doctorsForm = new DoctorsForm();
            doctorsForm.Show();
            this.Hide();
        }

        private void btnAppointments_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This is the Appointments Dashboard.");
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
            if (!string.IsNullOrWhiteSpace(txtPatientID.Text) && !int.TryParse(txtPatientID.Text, out _))
            {
                MessageBox.Show("Patient ID must be a number.", "Validation Error");
                return;
            }

            if (!string.IsNullOrWhiteSpace(txtDoctorID.Text) && !int.TryParse(txtDoctorID.Text, out _))
            {
                MessageBox.Show("Doctor ID must be a number.", "Validation Error");
                return;
            }

            try
            {
                using (SqlConnection conn = DatabaseConnection.GetConnection())
                {
                    conn.Open();
                    string query = "SELECT * FROM Appointments WHERE 1=1";

                    if (!string.IsNullOrEmpty(txtPatientID.Text))
                        query += " AND PatientID = @PatientID";

                    if (!string.IsNullOrEmpty(txtDoctorID.Text))
                        query += " AND DoctorID = @DoctorID";

                    if (cmbStatus.SelectedIndex > -1)
                        query += " AND Status = @Status";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        if (!string.IsNullOrEmpty(txtPatientID.Text))
                            cmd.Parameters.AddWithValue("@PatientID", int.Parse(txtPatientID.Text));
                        if (!string.IsNullOrEmpty(txtDoctorID.Text))
                            cmd.Parameters.AddWithValue("@DoctorID", int.Parse(txtDoctorID.Text));
                        if (cmbStatus.SelectedIndex > -1)
                            cmd.Parameters.AddWithValue("@Status", cmbStatus.SelectedItem.ToString());

                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        dgvAppointments.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error searching appointments: " + ex.Message);
            }
        }
    }
}
