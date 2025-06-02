// --------------------------------------------------------
// PatientsForm.cs
// Form for managing patients in the Hospital Management System.
// Allows adding, editing, displaying, deleting, and searching patients.
// Includes navigation to Doctors and Appointments forms.
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

        private void PatientsForm_Load(object sender, EventArgs e)
        {
            DisplayPatients();
        }

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

        private bool ValidateFields()
        {
            if (string.IsNullOrWhiteSpace(txtLastName.Text) ||
                string.IsNullOrWhiteSpace(txtFirstName.Text) ||
                string.IsNullOrWhiteSpace(txtPhoneNumber.Text) ||
                string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                MessageBox.Show("All fields are required.");
                return false;
            }

            
            var namePattern = @"^[a-zA-ZăâîșțĂÂÎȘȚ \-]+$"; 
            if (!Regex.IsMatch(txtLastName.Text, namePattern))
            {
                MessageBox.Show("Last name can only contain letters, spaces, and hyphens.");
                return false;
            }
            if (!Regex.IsMatch(txtFirstName.Text, namePattern))
            {
                MessageBox.Show("First name can only contain letters, spaces, and hyphens.");
                return false;
            }

            if (!Regex.IsMatch(txtPhoneNumber.Text, @"^\d+$"))
            {
                MessageBox.Show("Phone number must be numeric.");
                return false;
            }

            var emailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            if (!Regex.IsMatch(txtEmail.Text, emailPattern))
            {
                MessageBox.Show("Please enter a valid email address.");
                return false;
            }

            return true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!ValidateFields())
                return;

            try
            {
                using (SqlConnection conn = DatabaseConnection.GetConnection())
                {
                    conn.Open();
                    string lastname = txtLastName.Text.Trim();
                    string firstname = txtFirstName.Text.Trim();
                    string phone = txtPhoneNumber.Text.Trim();
                    string email = txtEmail.Text.Trim();
                    string query = "INSERT INTO Patients (LastName, FirstName, Phone, Email) VALUES (@lastname, @firstname, @phone, @email)";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@lastname", lastname);
                        cmd.Parameters.AddWithValue("@firstname", firstname);
                        cmd.Parameters.AddWithValue("@phone", phone);
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

        private void btnModify_Click(object sender, EventArgs e)
        {
            if (!ValidateFields())
                return;

            if (dgvPatients.SelectedRows.Count > 0)
            {
                int selectedId = Convert.ToInt32(dgvPatients.SelectedRows[0].Cells["PatientID"].Value);
                string lastName = txtLastName.Text.Trim();
                string firstname = txtFirstName.Text.Trim();
                string phone = txtPhoneNumber.Text.Trim();
                string email = txtEmail.Text.Trim();

                try
                {
                    using (SqlConnection conn = DatabaseConnection.GetConnection())
                    {
                        conn.Open();

                        string query = "UPDATE Patients SET LastName = @LastName, FirstName = @FirstName, Phone = @Phone, Email = @Email WHERE PatientID = @PatientID";

                        using (SqlCommand cmd = new SqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@LastName", lastName);
                            cmd.Parameters.AddWithValue("@FirstName", firstname);
                            cmd.Parameters.AddWithValue("@Phone", phone);
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

        private void dgvPatients_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvPatients.Rows[e.RowIndex];

                txtLastName.Text = row.Cells["LastName"].Value.ToString();
                txtFirstName.Text = row.Cells["FirstName"].Value.ToString();
                txtPhoneNumber.Text = row.Cells["Phone"].Value.ToString();
                txtEmail.Text = row.Cells["Email"].Value.ToString();
            }
        }

        private void btnPatients_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This is the Patients Dashboard.");
        }

        private void btnDoctors_Click(object sender, EventArgs e)
        {
            DoctorsForm doctorsForm = new DoctorsForm();
            doctorsForm.Show();
            this.Hide();
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
            string searchTerm = txtLastName.Text.Trim();

            if (string.IsNullOrEmpty(searchTerm))
            {
                MessageBox.Show("Please enter a search term in the Last Name field.");
                return;
            }

            try
            {
                using (SqlConnection conn = DatabaseConnection.GetConnection())
                {
                    conn.Open();
                    string query = "SELECT * FROM Patients WHERE LastName LIKE @search";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@search", "%" + searchTerm + "%");

                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);

                        dgvPatients.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while searching: " + ex.Message);
            }
        }

        private void txtLastName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != ' ' && e.KeyChar != '-' && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtFirstName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != ' ' && e.KeyChar != '-' && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
