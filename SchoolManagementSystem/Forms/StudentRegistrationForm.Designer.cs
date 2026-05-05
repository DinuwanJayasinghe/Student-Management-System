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
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblBirthday;
        private System.Windows.Forms.Label lblClass;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblMobile;
        private System.Windows.Forms.Label lblParent;
        private System.Windows.Forms.Panel pnlCard;

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
            this.lblName = new System.Windows.Forms.Label();
            this.lblBirthday = new System.Windows.Forms.Label();
            this.lblClass = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblMobile = new System.Windows.Forms.Label();
            this.lblParent = new System.Windows.Forms.Label();
            this.pnlCard = new System.Windows.Forms.Panel();
            this.pnlCard.SuspendLayout();
            this.SuspendLayout();
            //
            // pnlCard
            //
            this.pnlCard.BackColor = System.Drawing.Color.White;
            this.pnlCard.Controls.Add(this.lblTitle);
            this.pnlCard.Controls.Add(this.lblName);
            this.pnlCard.Controls.Add(this.txtName);
            this.pnlCard.Controls.Add(this.lblBirthday);
            this.pnlCard.Controls.Add(this.dtpBirthday);
            this.pnlCard.Controls.Add(this.lblClass);
            this.pnlCard.Controls.Add(this.cmbClass);
            this.pnlCard.Controls.Add(this.lblAddress);
            this.pnlCard.Controls.Add(this.txtAddress);
            this.pnlCard.Controls.Add(this.lblMobile);
            this.pnlCard.Controls.Add(this.txtMobile);
            this.pnlCard.Controls.Add(this.lblParent);
            this.pnlCard.Controls.Add(this.cmbParent);
            this.pnlCard.Controls.Add(this.btnRegister);
            this.pnlCard.Location = new System.Drawing.Point(20, 20);
            this.pnlCard.Name = "pnlCard";
            this.pnlCard.Size = new System.Drawing.Size(360, 520);
            //
            // lblTitle
            //
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(20, 20);
            this.lblTitle.Text = "Register New Student";
            //
            // lblName
            //
            this.lblName.Location = new System.Drawing.Point(20, 65);
            this.lblName.Text = "Full Name";
            //
            // txtName
            //
            this.txtName.Location = new System.Drawing.Point(20, 85);
            this.txtName.Size = new System.Drawing.Size(320, 25);
            //
            // lblBirthday
            //
            this.lblBirthday.Location = new System.Drawing.Point(20, 120);
            this.lblBirthday.Text = "Birthday";
            //
            // dtpBirthday
            //
            this.dtpBirthday.Location = new System.Drawing.Point(20, 140);
            this.dtpBirthday.Size = new System.Drawing.Size(320, 25);
            //
            // lblClass
            //
            this.lblClass.Location = new System.Drawing.Point(20, 175);
            this.lblClass.Text = "Assign Class";
            //
            // cmbClass
            //
            this.cmbClass.Location = new System.Drawing.Point(20, 195);
            this.cmbClass.Size = new System.Drawing.Size(320, 25);
            this.cmbClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            //
            // lblAddress
            //
            this.lblAddress.Location = new System.Drawing.Point(20, 230);
            this.lblAddress.Text = "Residential Address";
            //
            // txtAddress
            //
            this.txtAddress.Location = new System.Drawing.Point(20, 250);
            this.txtAddress.Size = new System.Drawing.Size(320, 60);
            this.txtAddress.Multiline = true;
            //
            // lblMobile
            //
            this.lblMobile.Location = new System.Drawing.Point(20, 320);
            this.lblMobile.Text = "Mobile Number";
            //
            // txtMobile
            //
            this.txtMobile.Location = new System.Drawing.Point(20, 340);
            this.txtMobile.Size = new System.Drawing.Size(320, 25);
            //
            // lblParent
            //
            this.lblParent.Location = new System.Drawing.Point(20, 375);
            this.lblParent.Text = "Parent / Guardian";
            //
            // cmbParent
            //
            this.cmbParent.Location = new System.Drawing.Point(20, 395);
            this.cmbParent.Size = new System.Drawing.Size(320, 25);
            this.cmbParent.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            //
            // btnRegister
            //
            this.btnRegister.Location = new System.Drawing.Point(20, 450);
            this.btnRegister.Size = new System.Drawing.Size(320, 45);
            this.btnRegister.Text = " 💾 REGISTER STUDENT";
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            //
            // StudentRegistrationForm
            //
            this.ClientSize = new System.Drawing.Size(400, 560);
            this.Controls.Add(this.pnlCard);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Student Registration";
            this.pnlCard.ResumeLayout(false);
            this.pnlCard.PerformLayout();
            this.ResumeLayout(false);
        }
    }
}
