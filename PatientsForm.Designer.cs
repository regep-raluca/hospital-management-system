namespace HospitalManagementSystem.Forms
{
    partial class PatientsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PatientsForm));
            this.lblLastName = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.labelPhoneNumber = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnModify = new System.Windows.Forms.Button();
            this.dgvPatients = new System.Windows.Forms.DataGridView();
            this.panelNavbar = new System.Windows.Forms.Panel();
            this.btnAppointments = new System.Windows.Forms.Button();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.pbPatientLogo = new System.Windows.Forms.PictureBox();
            this.btnDoctors = new System.Windows.Forms.Button();
            this.btnPatients = new System.Windows.Forms.Button();
            this.panelTop = new System.Windows.Forms.Panel();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.lblDashboard = new System.Windows.Forms.Label();
            this.lblPatients = new System.Windows.Forms.Label();
            this.panelBottom = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPatients)).BeginInit();
            this.panelNavbar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPatientLogo)).BeginInit();
            this.panelHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblLastName.Location = new System.Drawing.Point(281, 207);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(107, 28);
            this.lblLastName.TabIndex = 2;
            this.lblLastName.Text = "Last Name:";
            // 
            // txtLastName
            // 
            this.txtLastName.BackColor = System.Drawing.Color.LightGray;
            this.txtLastName.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtLastName.Location = new System.Drawing.Point(286, 250);
            this.txtLastName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(275, 30);
            this.txtLastName.TabIndex = 3;
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblFirstName.Location = new System.Drawing.Point(600, 207);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(110, 28);
            this.lblFirstName.TabIndex = 4;
            this.lblFirstName.Text = "First Name:";
            // 
            // txtFirstName
            // 
            this.txtFirstName.BackColor = System.Drawing.Color.LightGray;
            this.txtFirstName.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtFirstName.Location = new System.Drawing.Point(605, 250);
            this.txtFirstName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(275, 30);
            this.txtFirstName.TabIndex = 5;
            // 
            // labelPhoneNumber
            // 
            this.labelPhoneNumber.AutoSize = true;
            this.labelPhoneNumber.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelPhoneNumber.Location = new System.Drawing.Point(281, 312);
            this.labelPhoneNumber.Name = "labelPhoneNumber";
            this.labelPhoneNumber.Size = new System.Drawing.Size(148, 28);
            this.labelPhoneNumber.TabIndex = 8;
            this.labelPhoneNumber.Text = "Phone Number:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblEmail.Location = new System.Drawing.Point(598, 312);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(63, 28);
            this.lblEmail.TabIndex = 9;
            this.lblEmail.Text = "Email:";
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.BackColor = System.Drawing.Color.LightGray;
            this.txtPhoneNumber.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtPhoneNumber.Location = new System.Drawing.Point(286, 360);
            this.txtPhoneNumber.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(275, 30);
            this.txtPhoneNumber.TabIndex = 10;
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.LightGray;
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtEmail.Location = new System.Drawing.Point(603, 360);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(275, 30);
            this.txtEmail.TabIndex = 11;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(286, 432);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(130, 50);
            this.btnAdd.TabIndex = 12;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            this.btnAdd.MouseEnter += new System.EventHandler(this.btnAdd_MouseEnter);
            this.btnAdd.MouseLeave += new System.EventHandler(this.btnAdd_MouseLeave);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(484, 432);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(130, 50);
            this.btnDelete.TabIndex = 13;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            this.btnDelete.MouseEnter += new System.EventHandler(this.btnDelete_MouseEnter);
            this.btnDelete.MouseLeave += new System.EventHandler(this.btnDelete_MouseLeave);
            // 
            // btnModify
            // 
            this.btnModify.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnModify.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModify.FlatAppearance.BorderSize = 0;
            this.btnModify.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModify.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnModify.ForeColor = System.Drawing.Color.White;
            this.btnModify.Location = new System.Drawing.Point(682, 432);
            this.btnModify.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(130, 50);
            this.btnModify.TabIndex = 14;
            this.btnModify.Text = "Modify";
            this.btnModify.UseVisualStyleBackColor = false;
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            this.btnModify.MouseEnter += new System.EventHandler(this.btnModify_MouseEnter);
            this.btnModify.MouseLeave += new System.EventHandler(this.btnModify_MouseLeave);
            // 
            // dgvPatients
            // 
            this.dgvPatients.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPatients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPatients.Location = new System.Drawing.Point(282, 521);
            this.dgvPatients.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvPatients.Name = "dgvPatients";
            this.dgvPatients.RowHeadersWidth = 51;
            this.dgvPatients.RowTemplate.Height = 24;
            this.dgvPatients.Size = new System.Drawing.Size(776, 138);
            this.dgvPatients.TabIndex = 15;
            this.dgvPatients.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPatients_CellClick);
            // 
            // panelNavbar
            // 
            this.panelNavbar.BackColor = System.Drawing.Color.MidnightBlue;
            this.panelNavbar.Controls.Add(this.btnAppointments);
            this.panelNavbar.Controls.Add(this.btnLogOut);
            this.panelNavbar.Controls.Add(this.pbPatientLogo);
            this.panelNavbar.Controls.Add(this.btnDoctors);
            this.panelNavbar.Controls.Add(this.btnPatients);
            this.panelNavbar.Location = new System.Drawing.Point(0, 36);
            this.panelNavbar.Name = "panelNavbar";
            this.panelNavbar.Size = new System.Drawing.Size(225, 658);
            this.panelNavbar.TabIndex = 16;
            // 
            // btnAppointments
            // 
            this.btnAppointments.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnAppointments.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAppointments.FlatAppearance.BorderSize = 0;
            this.btnAppointments.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAppointments.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnAppointments.ForeColor = System.Drawing.Color.White;
            this.btnAppointments.Location = new System.Drawing.Point(14, 276);
            this.btnAppointments.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.btnAppointments.Name = "btnAppointments";
            this.btnAppointments.Size = new System.Drawing.Size(200, 50);
            this.btnAppointments.TabIndex = 24;
            this.btnAppointments.Text = "Appointments";
            this.btnAppointments.UseVisualStyleBackColor = false;
            this.btnAppointments.Click += new System.EventHandler(this.btnAppointments_Click);
            this.btnAppointments.MouseEnter += new System.EventHandler(this.btnAppointments_MouseEnter);
            this.btnAppointments.MouseLeave += new System.EventHandler(this.btnAppointments_MouseLeave);
            // 
            // btnLogOut
            // 
            this.btnLogOut.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnLogOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogOut.FlatAppearance.BorderSize = 0;
            this.btnLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogOut.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnLogOut.ForeColor = System.Drawing.Color.White;
            this.btnLogOut.Location = new System.Drawing.Point(14, 562);
            this.btnLogOut.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(200, 50);
            this.btnLogOut.TabIndex = 23;
            this.btnLogOut.Text = "Logout";
            this.btnLogOut.UseVisualStyleBackColor = false;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            this.btnLogOut.MouseEnter += new System.EventHandler(this.btnLogOut_MouseEnter);
            this.btnLogOut.MouseLeave += new System.EventHandler(this.btnLogOut_MouseLeave);
            // 
            // pbPatientLogo
            // 
            this.pbPatientLogo.Image = ((System.Drawing.Image)(resources.GetObject("pbPatientLogo.Image")));
            this.pbPatientLogo.Location = new System.Drawing.Point(52, 30);
            this.pbPatientLogo.Name = "pbPatientLogo";
            this.pbPatientLogo.Size = new System.Drawing.Size(120, 70);
            this.pbPatientLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbPatientLogo.TabIndex = 0;
            this.pbPatientLogo.TabStop = false;
            // 
            // btnDoctors
            // 
            this.btnDoctors.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnDoctors.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDoctors.FlatAppearance.BorderSize = 0;
            this.btnDoctors.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDoctors.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDoctors.ForeColor = System.Drawing.Color.White;
            this.btnDoctors.Location = new System.Drawing.Point(14, 214);
            this.btnDoctors.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.btnDoctors.Name = "btnDoctors";
            this.btnDoctors.Size = new System.Drawing.Size(200, 50);
            this.btnDoctors.TabIndex = 21;
            this.btnDoctors.Text = "Doctors";
            this.btnDoctors.UseVisualStyleBackColor = false;
            this.btnDoctors.Click += new System.EventHandler(this.btnDoctors_Click);
            this.btnDoctors.MouseEnter += new System.EventHandler(this.btnDoctors_MouseEnter);
            this.btnDoctors.MouseLeave += new System.EventHandler(this.btnDoctors_MouseLeave);
            // 
            // btnPatients
            // 
            this.btnPatients.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnPatients.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPatients.FlatAppearance.BorderSize = 0;
            this.btnPatients.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPatients.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnPatients.ForeColor = System.Drawing.Color.White;
            this.btnPatients.Location = new System.Drawing.Point(14, 149);
            this.btnPatients.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.btnPatients.Name = "btnPatients";
            this.btnPatients.Size = new System.Drawing.Size(200, 50);
            this.btnPatients.TabIndex = 20;
            this.btnPatients.Text = "Patients";
            this.btnPatients.UseVisualStyleBackColor = false;
            this.btnPatients.Click += new System.EventHandler(this.btnPatients_Click);
            this.btnPatients.MouseEnter += new System.EventHandler(this.btnPatients_MouseEnter);
            this.btnPatients.MouseLeave += new System.EventHandler(this.btnPatients_MouseLeave);
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.SteelBlue;
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1082, 38);
            this.panelTop.TabIndex = 17;
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panelHeader.Controls.Add(this.lblDashboard);
            this.panelHeader.Controls.Add(this.lblPatients);
            this.panelHeader.Location = new System.Drawing.Point(225, 36);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(872, 132);
            this.panelHeader.TabIndex = 18;
            // 
            // lblDashboard
            // 
            this.lblDashboard.AutoSize = true;
            this.lblDashboard.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDashboard.ForeColor = System.Drawing.Color.White;
            this.lblDashboard.Location = new System.Drawing.Point(345, 78);
            this.lblDashboard.Name = "lblDashboard";
            this.lblDashboard.Size = new System.Drawing.Size(108, 22);
            this.lblDashboard.TabIndex = 1;
            this.lblDashboard.Text = "Dashboard";
            // 
            // lblPatients
            // 
            this.lblPatients.AutoSize = true;
            this.lblPatients.Font = new System.Drawing.Font("Segoe Print", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblPatients.ForeColor = System.Drawing.Color.White;
            this.lblPatients.Location = new System.Drawing.Point(270, 30);
            this.lblPatients.Name = "lblPatients";
            this.lblPatients.Size = new System.Drawing.Size(148, 54);
            this.lblPatients.TabIndex = 0;
            this.lblPatients.Text = "Patients";
            // 
            // panelBottom
            // 
            this.panelBottom.BackColor = System.Drawing.Color.SteelBlue;
            this.panelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBottom.Location = new System.Drawing.Point(0, 665);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Size = new System.Drawing.Size(1082, 38);
            this.panelBottom.TabIndex = 19;
            // 
            // PatientsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1082, 703);
            this.Controls.Add(this.panelBottom);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.panelNavbar);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.btnModify);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.dgvPatients);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtPhoneNumber);
            this.Controls.Add(this.labelPhoneNumber);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximumSize = new System.Drawing.Size(1100, 750);
            this.MinimumSize = new System.Drawing.Size(1100, 750);
            this.Name = "PatientsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PatientsForm";
            this.Load += new System.EventHandler(this.PatientsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPatients)).EndInit();
            this.panelNavbar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbPatientLogo)).EndInit();
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label labelPhoneNumber;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnModify;
        private System.Windows.Forms.DataGridView dgvPatients;
        private System.Windows.Forms.Panel panelNavbar;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Panel panelBottom;
        private System.Windows.Forms.PictureBox pbPatientLogo;
        private System.Windows.Forms.Label lblPatients;
        private System.Windows.Forms.Label lblDashboard;
        private System.Windows.Forms.Button btnPatients;
        private System.Windows.Forms.Button btnDoctors;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Button btnAppointments;
    }
}