// --------------------------------------------------------
// LoginForm.cs
// Handles user authentication for the Hospital Management System.
// Validates credentials and connects to the database.
// On success, redirects to the main menu.
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
using System.Drawing.Drawing2D;

namespace HospitalManagementSystem.Forms
{
    // LoginForm - responsible for user authentication and database connection
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            RoundPanelCorners(panelLogIn, 65);
            RoundButton(btnLogIn, 20);
        }

        // Validates user credentials and opens the main menu on successful login
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            if (username == "admin" && password == "admin")
            {
                using (SqlConnection conn = DatabaseConnection.GetConnection())
                {
                    try
                    {
                        conn.Open(); 

                        MessageBox.Show("Successful login and login to the database!");

                        MenuForm menuForm = new MenuForm();
                        this.Hide();
                        menuForm.Show();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Successful authentication, but error connecting to the database: " + ex.Message);
                    }
                }
            }
            else if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Please fill in both fields!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                MessageBox.Show("Invalid credentials!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        // Changes login button color on mouse hover
        private void btnLogIn_MouseEnter(object sender, EventArgs e)
        {
            btnLogIn.BackColor = Color.LightSteelBlue;
            btnLogIn.ForeColor = Color.White;
        }

        // Restores login button color when mouse leaves
        private void btnLogIn_MouseLeave(object sender, EventArgs e)
        {
            btnLogIn.BackColor = Color.RoyalBlue;
            btnLogIn.ForeColor = Color.White;
        }

        // Applies rounded corners to a panel for a smoother, modern look
        private void RoundPanelCorners(Panel panel, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            path.StartFigure();
            path.AddArc(new Rectangle(0, 0, radius, radius), 180, 90);
            path.AddArc(new Rectangle(panel.Width - radius, 0, radius, radius), 270, 90);
            path.AddArc(new Rectangle(panel.Width - radius, panel.Height - radius, radius, radius), 0, 90);
            path.AddArc(new Rectangle(0, panel.Height - radius, radius, radius), 90, 90);
            path.CloseFigure();

            panel.Region = new Region(path);

            panel.Paint += (s, e) =>
            {
                e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                using (Pen pen = new Pen(panel.BackColor, 1))
                {
                    e.Graphics.DrawPath(pen, path);
                }
            };
        }

        // Applies rounded corners to a button with anti-aliasing for smoother edges
        private void RoundButton(Button button, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            path.AddArc(0, 0, radius, radius, 180, 90); 
            path.AddArc(button.Width - radius, 0, radius, radius, 270, 90); 
            path.AddArc(button.Width - radius, button.Height - radius, radius, radius, 0, 90); 
            path.AddArc(0, button.Height - radius, radius, radius, 90, 90); 
            path.CloseAllFigures(); 

            button.Region = new Region(path);

            button.Paint += (sender, e) =>
            {
                e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias; 
                using (Pen pen = new Pen(button.BackColor, 1)) 
                {
                    e.Graphics.DrawPath(pen, path); 
                }
            };
        }
    }
}
