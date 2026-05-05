namespace SchoolManagementSystem.Forms
{
    partial class StudentRegistrationForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.DateTimePicker dtpBirthday;
        private System.Windows.Forms.ComboBox cmbClass;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtMobile;
        private System.Windows.Forms.ComboBox cmbParent;
        private System.Windows.Forms.Button btnRegister;

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
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.dtpBirthday = new System.Windows.Forms.DateTimePicker();
            this.cmbClass = new System.Windows.Forms.ComboBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtMobile = new System.Windows.Forms.TextBox();
            this.cmbParent = new System.Windows.Forms.ComboBox();
            this.btnRegister = new System.Windows.Forms.Button();
            this.SuspendLayout();
            //
            // lblTitle
            //
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(30, 20);
            this.lblTitle.Text = "Register Student";
            //
            // txtName
            //
            this.txtName.Location = new System.Drawing.Point(30, 70);
            this.txtName.Size = new System.Drawing.Size(250, 25);
            //
            // dtpBirthday
            //
            this.dtpBirthday.Location = new System.Drawing.Point(30, 110);
            this.dtpBirthday.Size = new System.Drawing.Size(250, 25);
            //
            // cmbClass
            //
            this.cmbClass.Location = new System.Drawing.Point(30, 150);
            this.cmbClass.Size = new System.Drawing.Size(250, 25);
            //
            // txtAddress
            //
            this.txtAddress.Location = new System.Drawing.Point(30, 190);
            this.txtAddress.Size = new System.Drawing.Size(250, 60);
            this.txtAddress.Multiline = true;
            //
            // txtMobile
            //
            this.txtMobile.Location = new System.Drawing.Point(30, 260);
            this.txtMobile.Size = new System.Drawing.Size(250, 25);
            //
            // cmbParent
            //
            this.cmbParent.Location = new System.Drawing.Point(30, 300);
            this.cmbParent.Size = new System.Drawing.Size(250, 25);
            //
            // btnRegister
            //
            this.btnRegister.Location = new System.Drawing.Point(30, 350);
            this.btnRegister.Size = new System.Drawing.Size(250, 45);
            this.btnRegister.Text = " REGISTER";
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            //
            // StudentRegistrationForm
            //
            this.ClientSize = new System.Drawing.Size(320, 430);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.dtpBirthday);
            this.Controls.Add(this.cmbClass);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtMobile);
            this.Controls.Add(this.cmbParent);
            this.Controls.Add(this.btnRegister);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Student Registration";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
