namespace HospitalManagementSystem.Forms
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnLogIn = new System.Windows.Forms.Button();
            this.panelLogIn = new System.Windows.Forms.Panel();
            this.pbUserIcon = new System.Windows.Forms.PictureBox();
            this.lblAdmin = new System.Windows.Forms.Label();
            this.panelLogIn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbUserIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblUsername.Location = new System.Drawing.Point(80, 185);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(148, 38);
            this.lblUsername.TabIndex = 0;
            this.lblUsername.Text = "Username:";
            this.lblUsername.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblPassword.Location = new System.Drawing.Point(80, 285);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(138, 38);
            this.lblPassword.TabIndex = 1;
            this.lblPassword.Text = "Password:";
            this.lblPassword.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtUsername
            // 
            this.txtUsername.BackColor = System.Drawing.Color.LightGray;
            this.txtUsername.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtUsername.Location = new System.Drawing.Point(87, 237);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(401, 30);
            this.txtUsername.TabIndex = 2;
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.LightGray;
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtPassword.Location = new System.Drawing.Point(87, 336);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(401, 30);
            this.txtPassword.TabIndex = 3;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // btnLogIn
            // 
            this.btnLogIn.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnLogIn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogIn.FlatAppearance.BorderSize = 0;
            this.btnLogIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogIn.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnLogIn.ForeColor = System.Drawing.Color.White;
            this.btnLogIn.Location = new System.Drawing.Point(87, 398);
            this.btnLogIn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLogIn.Name = "btnLogIn";
            this.btnLogIn.Size = new System.Drawing.Size(401, 56);
            this.btnLogIn.TabIndex = 4;
            this.btnLogIn.Text = "Login";
            this.btnLogIn.UseVisualStyleBackColor = false;
            this.btnLogIn.Click += new System.EventHandler(this.btnLogin_Click);
            this.btnLogIn.MouseEnter += new System.EventHandler(this.btnLogIn_MouseEnter);
            this.btnLogIn.MouseLeave += new System.EventHandler(this.btnLogIn_MouseLeave);
            // 
            // panelLogIn
            // 
            this.panelLogIn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelLogIn.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelLogIn.Controls.Add(this.pbUserIcon);
            this.panelLogIn.Controls.Add(this.lblAdmin);
            this.panelLogIn.Controls.Add(this.txtPassword);
            this.panelLogIn.Controls.Add(this.lblPassword);
            this.panelLogIn.Controls.Add(this.btnLogIn);
            this.panelLogIn.Controls.Add(this.lblUsername);
            this.panelLogIn.Controls.Add(this.txtUsername);
            this.panelLogIn.Location = new System.Drawing.Point(272, 91);
            this.panelLogIn.Margin = new System.Windows.Forms.Padding(4);
            this.panelLogIn.Name = "panelLogIn";
            this.panelLogIn.Size = new System.Drawing.Size(559, 515);
            this.panelLogIn.TabIndex = 5;
            // 
            // pbUserIcon
            // 
            this.pbUserIcon.Image = ((System.Drawing.Image)(resources.GetObject("pbUserIcon.Image")));
            this.pbUserIcon.Location = new System.Drawing.Point(209, 47);
            this.pbUserIcon.Name = "pbUserIcon";
            this.pbUserIcon.Size = new System.Drawing.Size(131, 61);
            this.pbUserIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbUserIcon.TabIndex = 6;
            this.pbUserIcon.TabStop = false;
            // 
            // lblAdmin
            // 
            this.lblAdmin.AutoSize = true;
            this.lblAdmin.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblAdmin.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblAdmin.Location = new System.Drawing.Point(159, 111);
            this.lblAdmin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAdmin.Name = "lblAdmin";
            this.lblAdmin.Size = new System.Drawing.Size(217, 45);
            this.lblAdmin.TabIndex = 5;
            this.lblAdmin.Text = "Admin Login";
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1082, 703);
            this.Controls.Add(this.panelLogIn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximumSize = new System.Drawing.Size(1100, 750);
            this.MinimumSize = new System.Drawing.Size(1100, 750);
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginForm";
            this.panelLogIn.ResumeLayout(false);
            this.panelLogIn.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbUserIcon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnLogIn;
        private System.Windows.Forms.Panel panelLogIn;
        private System.Windows.Forms.Label lblAdmin;
        private System.Windows.Forms.PictureBox pbUserIcon;
    }
}

