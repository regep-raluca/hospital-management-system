// --------------------------------------------------------
// MenuForm.cs
// Main navigation form of the Hospital Management System.
// Provides access to Patients, Doctors, Appointments,
// and Logout functionality.
// --------------------------------------------------------

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalManagementSystem.Forms
{
    // The main menu form for navigating between different sections of the Hospital Management System
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
        }

        // Opens the Patients form and hides the menu
        private void btnPatients_Click(object sender, EventArgs e)
        {
            PatientsForm patientsForm = new PatientsForm();
            patientsForm.Show();
            this.Hide();
        }

        // Opens the Doctors form and hides the menu
        private void btnDoctors_Click(object sender, EventArgs e)
        {
            DoctorsForm doctorsForm = new DoctorsForm();
            doctorsForm.Show();
            this.Hide();
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
            btnPatients.BackColor = Color.RoyalBlue;
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
            btnDoctors.BackColor = Color.RoyalBlue;
            btnDoctors.ForeColor = Color.White;
        }

        // Highlight button on mouse hover - Appointments
        private void btnAppointments_MouseEnter(object sender, EventArgs e)
        {
            btnAppointments.BackColor = Color.LightSteelBlue;
            btnAppointments.ForeColor = Color.White;
        }

        // // Reset button color on mouse leave - Appointments
        private void btnAppointments_MouseLeave(object sender, EventArgs e)
        {
            btnAppointments.BackColor = Color.RoyalBlue;
            btnAppointments.ForeColor = Color.White;
        }

        //  Handles user logout and returns to the Login screen
        private void btnLogout_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Close();
        }

        // Highlight button on mouse hover - Logout
        private void btnLogout_MouseEnter(object sender, EventArgs e)
        {
            btnLogOut.BackColor = Color.LightSteelBlue;
            btnLogOut.ForeColor = Color.White;
        }

        // Reset button color on mouse leave - Logout
        private void btnLogout_MouseLeave(object sender, EventArgs e)
        {
            btnLogOut.BackColor = Color.RoyalBlue;
            btnLogOut.ForeColor = Color.White;
        }

        // Opens the Appointments form and hides the Menu
        private void btnAppointments_Click(object sender, EventArgs e)
        {
            AppointmentsForm appointmentsForm = new AppointmentsForm();
            appointmentsForm.Show();
            this.Hide();
        }
    }
}
