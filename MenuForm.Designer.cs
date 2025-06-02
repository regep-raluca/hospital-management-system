namespace HospitalManagementSystem.Forms
{
    partial class MenuForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuForm));
            this.panelContent = new System.Windows.Forms.Panel();
            this.groupBoxTopDoctors = new System.Windows.Forms.GroupBox();
            this.dgvTopDoctors = new System.Windows.Forms.DataGridView();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.lblManagementSystem = new System.Windows.Forms.Label();
            this.pbHospitalLogo = new System.Windows.Forms.PictureBox();
            this.lblHospital = new System.Windows.Forms.Label();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.btnAppointments = new System.Windows.Forms.Button();
            this.btnPatients = new System.Windows.Forms.Button();
            this.btnDoctors = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panelContent.SuspendLayout();
            this.groupBoxTopDoctors.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTopDoctors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHospitalLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // panelContent
            // 
            this.panelContent.BackColor = System.Drawing.Color.MidnightBlue;
            this.panelContent.Controls.Add(this.groupBoxTopDoctors);
            this.panelContent.Controls.Add(this.lblWelcome);
            this.panelContent.Controls.Add(this.lblManagementSystem);
            this.panelContent.Controls.Add(this.pbHospitalLogo);
            this.panelContent.Controls.Add(this.lblHospital);
            this.panelContent.Controls.Add(this.btnLogOut);
            this.panelContent.Controls.Add(this.btnAppointments);
            this.panelContent.Controls.Add(this.btnPatients);
            this.panelContent.Controls.Add(this.btnDoctors);
            this.panelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContent.Location = new System.Drawing.Point(0, 0);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(1082, 703);
            this.panelContent.TabIndex = 7;
            // 
            // groupBoxTopDoctors
            // 
            this.groupBoxTopDoctors.Controls.Add(this.dgvTopDoctors);
            this.groupBoxTopDoctors.ForeColor = System.Drawing.Color.Teal;
            this.groupBoxTopDoctors.Location = new System.Drawing.Point(230, 313);
            this.groupBoxTopDoctors.Name = "groupBoxTopDoctors";
            this.groupBoxTopDoctors.Size = new System.Drawing.Size(610, 254);
            this.groupBoxTopDoctors.TabIndex = 9;
            this.groupBoxTopDoctors.TabStop = false;
            this.groupBoxTopDoctors.Text = "Top 10 Doctors";
            // 
            // dgvTopDoctors
            // 
            this.dgvTopDoctors.AllowUserToAddRows = false;
            this.dgvTopDoctors.AllowUserToDeleteRows = false;
            this.dgvTopDoctors.AllowUserToOrderColumns = true;
            this.dgvTopDoctors.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTopDoctors.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvTopDoctors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTopDoctors.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTopDoctors.Location = new System.Drawing.Point(3, 18);
            this.dgvTopDoctors.Name = "dgvTopDoctors";
            this.dgvTopDoctors.ReadOnly = true;
            this.dgvTopDoctors.RowHeadersWidth = 51;
            this.dgvTopDoctors.RowTemplate.Height = 24;
            this.dgvTopDoctors.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTopDoctors.Size = new System.Drawing.Size(604, 233);
            this.dgvTopDoctors.TabIndex = 0;
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblWelcome.ForeColor = System.Drawing.Color.White;
            this.lblWelcome.Location = new System.Drawing.Point(362, 139);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(350, 45);
            this.lblWelcome.TabIndex = 8;
            this.lblWelcome.Text = "Welcome back, Admin!";
            // 
            // lblManagementSystem
            // 
            this.lblManagementSystem.AutoSize = true;
            this.lblManagementSystem.BackColor = System.Drawing.Color.MidnightBlue;
            this.lblManagementSystem.Font = new System.Drawing.Font("Britannic Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblManagementSystem.ForeColor = System.Drawing.Color.White;
            this.lblManagementSystem.Location = new System.Drawing.Point(390, 62);
            this.lblManagementSystem.Name = "lblManagementSystem";
            this.lblManagementSystem.Size = new System.Drawing.Size(287, 33);
            this.lblManagementSystem.TabIndex = 1;
            this.lblManagementSystem.Text = "Management System";
            // 
            // pbHospitalLogo
            // 
            this.pbHospitalLogo.Image = ((System.Drawing.Image)(resources.GetObject("pbHospitalLogo.Image")));
            this.pbHospitalLogo.Location = new System.Drawing.Point(12, 23);
            this.pbHospitalLogo.Name = "pbHospitalLogo";
            this.pbHospitalLogo.Size = new System.Drawing.Size(173, 100);
            this.pbHospitalLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbHospitalLogo.TabIndex = 7;
            this.pbHospitalLogo.TabStop = false;
            // 
            // lblHospital
            // 
            this.lblHospital.AutoSize = true;
            this.lblHospital.BackColor = System.Drawing.Color.MidnightBlue;
            this.lblHospital.Font = new System.Drawing.Font("Segoe Print", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblHospital.ForeColor = System.Drawing.Color.White;
            this.lblHospital.Location = new System.Drawing.Point(428, 9);
            this.lblHospital.Name = "lblHospital";
            this.lblHospital.Size = new System.Drawing.Size(208, 71);
            this.lblHospital.TabIndex = 0;
            this.lblHospital.Text = "Hospital ";
            // 
            // btnLogOut
            // 
            this.btnLogOut.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnLogOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogOut.FlatAppearance.BorderSize = 0;
            this.btnLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogOut.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnLogOut.ForeColor = System.Drawing.Color.White;
            this.btnLogOut.Location = new System.Drawing.Point(12, 602);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(202, 63);
            this.btnLogOut.TabIndex = 4;
            this.btnLogOut.Text = "Logout";
            this.btnLogOut.UseVisualStyleBackColor = false;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogout_Click);
            this.btnLogOut.MouseEnter += new System.EventHandler(this.btnLogout_MouseEnter);
            this.btnLogOut.MouseLeave += new System.EventHandler(this.btnLogout_MouseLeave);
            // 
            // btnAppointments
            // 
            this.btnAppointments.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnAppointments.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAppointments.FlatAppearance.BorderSize = 0;
            this.btnAppointments.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAppointments.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnAppointments.ForeColor = System.Drawing.Color.White;
            this.btnAppointments.Location = new System.Drawing.Point(683, 212);
            this.btnAppointments.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.btnAppointments.Name = "btnAppointments";
            this.btnAppointments.Size = new System.Drawing.Size(200, 50);
            this.btnAppointments.TabIndex = 3;
            this.btnAppointments.Text = "Appointments";
            this.btnAppointments.UseVisualStyleBackColor = false;
            this.btnAppointments.Click += new System.EventHandler(this.btnAppointments_Click);
            this.btnAppointments.MouseEnter += new System.EventHandler(this.btnAppointments_MouseEnter);
            this.btnAppointments.MouseLeave += new System.EventHandler(this.btnAppointments_MouseLeave);
            // 
            // btnPatients
            // 
            this.btnPatients.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnPatients.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPatients.FlatAppearance.BorderSize = 0;
            this.btnPatients.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPatients.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnPatients.ForeColor = System.Drawing.Color.White;
            this.btnPatients.Location = new System.Drawing.Point(189, 212);
            this.btnPatients.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.btnPatients.Name = "btnPatients";
            this.btnPatients.Size = new System.Drawing.Size(200, 50);
            this.btnPatients.TabIndex = 1;
            this.btnPatients.Text = "Patients";
            this.btnPatients.UseVisualStyleBackColor = false;
            this.btnPatients.Click += new System.EventHandler(this.btnPatients_Click);
            this.btnPatients.MouseEnter += new System.EventHandler(this.btnPatients_MouseEnter);
            this.btnPatients.MouseLeave += new System.EventHandler(this.btnPatients_MouseLeave);
            // 
            // btnDoctors
            // 
            this.btnDoctors.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnDoctors.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDoctors.FlatAppearance.BorderSize = 0;
            this.btnDoctors.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDoctors.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDoctors.ForeColor = System.Drawing.Color.White;
            this.btnDoctors.Location = new System.Drawing.Point(436, 212);
            this.btnDoctors.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.btnDoctors.Name = "btnDoctors";
            this.btnDoctors.Size = new System.Drawing.Size(200, 50);
            this.btnDoctors.TabIndex = 2;
            this.btnDoctors.Text = "Doctors";
            this.btnDoctors.UseVisualStyleBackColor = false;
            this.btnDoctors.Click += new System.EventHandler(this.btnDoctors_Click);
            this.btnDoctors.MouseEnter += new System.EventHandler(this.btnDoctors_MouseEnter);
            this.btnDoctors.MouseLeave += new System.EventHandler(this.btnDoctors_MouseLeave);
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 703);
            this.Controls.Add(this.panelContent);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximumSize = new System.Drawing.Size(1100, 750);
            this.MinimumSize = new System.Drawing.Size(1100, 750);
            this.Name = "MenuForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MenuForm";
            this.panelContent.ResumeLayout(false);
            this.panelContent.PerformLayout();
            this.groupBoxTopDoctors.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTopDoctors)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHospitalLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelContent;
        private System.Windows.Forms.Label lblHospital;
        private System.Windows.Forms.Label lblManagementSystem;
        private System.Windows.Forms.PictureBox pbHospitalLogo;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Button btnAppointments;
        private System.Windows.Forms.Button btnDoctors;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Button btnPatients;
        private System.Windows.Forms.GroupBox groupBoxTopDoctors;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DataGridView dgvTopDoctors;
    }
}