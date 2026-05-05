namespace SchoolManagementSystem.Forms
{
    partial class LoginForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.ComboBox cmbRole;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panel1;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.cmbRole = new System.Windows.Forms.ComboBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblRole = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            //
            // panel1
            //
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.lblTitle);
            this.panel1.Controls.Add(this.lblUsername);
            this.panel1.Controls.Add(this.txtUsername);
            this.panel1.Controls.Add(this.lblPassword);
            this.panel1.Controls.Add(this.txtPassword);
            this.panel1.Controls.Add(this.lblRole);
            this.panel1.Controls.Add(this.cmbRole);
            this.panel1.Controls.Add(this.btnLogin);
            this.panel1.Location = new System.Drawing.Point(50, 40);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 420);
            this.panel1.TabIndex = 0;
            //
            // lblTitle
            //
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 22F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(60, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(180, 41);
            this.lblTitle.Text = "Welcome Back";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            //
            // lblUsername
            //
            this.lblUsername.Location = new System.Drawing.Point(30, 90);
            this.lblUsername.Text = "Reg No / Email";
            //
            // txtUsername
            //
            this.txtUsername.Location = new System.Drawing.Point(30, 115);
            this.txtUsername.Size = new System.Drawing.Size(240, 25);
            //
            // lblPassword
            //
            this.lblPassword.Location = new System.Drawing.Point(30, 160);
            this.lblPassword.Text = "Password";
            //
            // txtPassword
            //
            this.txtPassword.Location = new System.Drawing.Point(30, 185);
            this.txtPassword.Size = new System.Drawing.Size(240, 25);
            this.txtPassword.UseSystemPasswordChar = true;
            //
            // lblRole
            //
            this.lblRole.Location = new System.Drawing.Point(30, 230);
            this.lblRole.Text = "Role";
            //
            // cmbRole
            //
            this.cmbRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRole.Items.AddRange(new object[] { "Admin", "Teacher", "Student" });
            this.cmbRole.Location = new System.Drawing.Point(30, 255);
            this.cmbRole.Size = new System.Drawing.Size(240, 25);
            //
            // btnLogin
            //
            this.btnLogin.Location = new System.Drawing.Point(30, 310);
            this.btnLogin.Size = new System.Drawing.Size(240, 45);
            this.btnLogin.Text = " LOGIN";
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            //
            // LoginForm
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 500);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "School Management System - Login";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
        }
    }
}
