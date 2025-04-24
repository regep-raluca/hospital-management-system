namespace HospitalManagementSystem.Forms
{
    partial class DoctorsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DoctorsForm));
            this.dgvDoctors = new System.Windows.Forms.DataGridView();
            this.lblName = new System.Windows.Forms.Label();
            this.lblSpecialty = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtSpecialty = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnModify = new System.Windows.Forms.Button();
            this.panelNavbar = new System.Windows.Forms.Panel();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.btnAppointments = new System.Windows.Forms.Button();
            this.btnDoctors = new System.Windows.Forms.Button();
            this.btnPatients = new System.Windows.Forms.Button();
            this.pbDoctor = new System.Windows.Forms.PictureBox();
            this.panelTop = new System.Windows.Forms.Panel();
            this.panelBottom = new System.Windows.Forms.Panel();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.lblDashboard = new System.Windows.Forms.Label();
            this.lblDoctors = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDoctors)).BeginInit();
            this.panelNavbar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbDoctor)).BeginInit();
            this.panelHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvDoctors
            // 
            this.dgvDoctors.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDoctors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDoctors.Location = new System.Drawing.Point(282, 521);
            this.dgvDoctors.Name = "dgvDoctors";
            this.dgvDoctors.RowHeadersWidth = 51;
            this.dgvDoctors.RowTemplate.Height = 24;
            this.dgvDoctors.Size = new System.Drawing.Size(776, 138);
            this.dgvDoctors.TabIndex = 0;
            this.dgvDoctors.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDoctors_CellClick);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblName.Location = new System.Drawing.Point(281, 207);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(68, 28);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Name:";
            // 
            // lblSpecialty
            // 
            this.lblSpecialty.AutoSize = true;
            this.lblSpecialty.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblSpecialty.Location = new System.Drawing.Point(281, 312);
            this.lblSpecialty.Name = "lblSpecialty";
            this.lblSpecialty.Size = new System.Drawing.Size(95, 28);
            this.lblSpecialty.TabIndex = 2;
            this.lblSpecialty.Text = "Specialty:";
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.LightGray;
            this.txtName.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtName.Location = new System.Drawing.Point(286, 250);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(275, 30);
            this.txtName.TabIndex = 3;
            // 
            // txtSpecialty
            // 
            this.txtSpecialty.BackColor = System.Drawing.Color.LightGray;
            this.txtSpecialty.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtSpecialty.Location = new System.Drawing.Point(286, 360);
            this.txtSpecialty.Name = "txtSpecialty";
            this.txtSpecialty.Size = new System.Drawing.Size(275, 30);
            this.txtSpecialty.TabIndex = 4;
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
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(130, 50);
            this.btnAdd.TabIndex = 5;
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
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(130, 50);
            this.btnDelete.TabIndex = 6;
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
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(130, 50);
            this.btnModify.TabIndex = 7;
            this.btnModify.Text = "Modify";
            this.btnModify.UseVisualStyleBackColor = false;
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            this.btnModify.MouseEnter += new System.EventHandler(this.btnModify_MouseEnter);
            this.btnModify.MouseLeave += new System.EventHandler(this.btnModify_MouseLeave);
            // 
            // panelNavbar
            // 
            this.panelNavbar.BackColor = System.Drawing.Color.MidnightBlue;
            this.panelNavbar.Controls.Add(this.btnLogOut);
            this.panelNavbar.Controls.Add(this.btnAppointments);
            this.panelNavbar.Controls.Add(this.btnDoctors);
            this.panelNavbar.Controls.Add(this.btnPatients);
            this.panelNavbar.Controls.Add(this.pbDoctor);
            this.panelNavbar.Location = new System.Drawing.Point(0, 36);
            this.panelNavbar.Name = "panelNavbar";
            this.panelNavbar.Size = new System.Drawing.Size(225, 658);
            this.panelNavbar.TabIndex = 8;
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
            this.btnLogOut.TabIndex = 24;
            this.btnLogOut.Text = "Logout";
            this.btnLogOut.UseVisualStyleBackColor = false;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            this.btnLogOut.MouseEnter += new System.EventHandler(this.btnLogOut_MouseEnter);
            this.btnLogOut.MouseLeave += new System.EventHandler(this.btnLogOut_MouseLeave);
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
            this.btnAppointments.TabIndex = 25;
            this.btnAppointments.Text = "Appointments";
            this.btnAppointments.UseVisualStyleBackColor = false;
            this.btnAppointments.Click += new System.EventHandler(this.btnAppointments_Click);
            this.btnAppointments.MouseEnter += new System.EventHandler(this.btnAppointments_MouseEnter);
            this.btnAppointments.MouseLeave += new System.EventHandler(this.btnAppointments_MouseLeave);
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
            this.btnDoctors.TabIndex = 22;
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
            this.btnPatients.TabIndex = 21;
            this.btnPatients.Text = "Patients";
            this.btnPatients.UseVisualStyleBackColor = false;
            this.btnPatients.Click += new System.EventHandler(this.btnPatients_Click);
            this.btnPatients.MouseEnter += new System.EventHandler(this.btnPatients_MouseEnter);
            this.btnPatients.MouseLeave += new System.EventHandler(this.btnPatients_MouseLeave);
            // 
            // pbDoctor
            // 
            this.pbDoctor.Image = ((System.Drawing.Image)(resources.GetObject("pbDoctor.Image")));
            this.pbDoctor.Location = new System.Drawing.Point(52, 30);
            this.pbDoctor.Name = "pbDoctor";
            this.pbDoctor.Size = new System.Drawing.Size(120, 70);
            this.pbDoctor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbDoctor.TabIndex = 0;
            this.pbDoctor.TabStop = false;
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.SteelBlue;
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1082, 38);
            this.panelTop.TabIndex = 9;
            // 
            // panelBottom
            // 
            this.panelBottom.BackColor = System.Drawing.Color.SteelBlue;
            this.panelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBottom.Location = new System.Drawing.Point(0, 665);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Size = new System.Drawing.Size(1082, 38);
            this.panelBottom.TabIndex = 10;
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panelHeader.Controls.Add(this.lblDashboard);
            this.panelHeader.Controls.Add(this.lblDoctors);
            this.panelHeader.Location = new System.Drawing.Point(225, 36);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(872, 132);
            this.panelHeader.TabIndex = 11;
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
            // lblDoctors
            // 
            this.lblDoctors.AutoSize = true;
            this.lblDoctors.Font = new System.Drawing.Font("Segoe Print", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblDoctors.ForeColor = System.Drawing.Color.White;
            this.lblDoctors.Location = new System.Drawing.Point(270, 30);
            this.lblDoctors.Name = "lblDoctors";
            this.lblDoctors.Size = new System.Drawing.Size(138, 54);
            this.lblDoctors.TabIndex = 0;
            this.lblDoctors.Text = "Doctors";
            // 
            // DoctorsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1082, 703);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.panelBottom);
            this.Controls.Add(this.panelNavbar);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.btnModify);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtSpecialty);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblSpecialty);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.dgvDoctors);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximumSize = new System.Drawing.Size(1100, 750);
            this.MinimumSize = new System.Drawing.Size(1100, 750);
            this.Name = "DoctorsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DoctorsForm";
            this.Load += new System.EventHandler(this.DoctorsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDoctors)).EndInit();
            this.panelNavbar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbDoctor)).EndInit();
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDoctors;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblSpecialty;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtSpecialty;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnModify;
        private System.Windows.Forms.Panel panelNavbar;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Panel panelBottom;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblDoctors;
        private System.Windows.Forms.Label lblDashboard;
        private System.Windows.Forms.PictureBox pbDoctor;
        private System.Windows.Forms.Button btnPatients;
        private System.Windows.Forms.Button btnDoctors;
        private System.Windows.Forms.Button btnAppointments;
        private System.Windows.Forms.Button btnLogOut;
    }
}