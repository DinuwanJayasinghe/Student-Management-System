namespace SchoolManagementSystem.Forms
{
    partial class TeacherRegistrationForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnlCard;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtMobile;
        private System.Windows.Forms.TextBox txtSubject;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblMobile;
        private System.Windows.Forms.Label lblSubject;

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
            this.pnlCard = new System.Windows.Forms.Panel();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtMobile = new System.Windows.Forms.TextBox();
            this.txtSubject = new System.Windows.Forms.TextBox();
            this.btnRegister = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblMobile = new System.Windows.Forms.Label();
            this.lblSubject = new System.Windows.Forms.Label();
            this.pnlCard.SuspendLayout();
            this.SuspendLayout();
            //
            // lblTitle
            //
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(20, 20);
            this.lblTitle.Text = "Register Teacher";
            //
            // pnlCard
            //
            this.pnlCard.BackColor = System.Drawing.Color.White;
            this.pnlCard.Controls.Add(this.lblName);
            this.pnlCard.Controls.Add(this.txtName);
            this.pnlCard.Controls.Add(this.lblEmail);
            this.pnlCard.Controls.Add(this.txtEmail);
            this.pnlCard.Controls.Add(this.lblMobile);
            this.pnlCard.Controls.Add(this.txtMobile);
            this.pnlCard.Controls.Add(this.lblSubject);
            this.pnlCard.Controls.Add(this.txtSubject);
            this.pnlCard.Controls.Add(this.btnRegister);
            this.pnlCard.Location = new System.Drawing.Point(20, 70);
            this.pnlCard.Name = "pnlCard";
            this.pnlCard.Size = new System.Drawing.Size(340, 360);
            //
            // lblName
            //
            this.lblName.Location = new System.Drawing.Point(20, 20);
            this.lblName.Text = "Full Name";
            //
            // txtName
            //
            this.txtName.Location = new System.Drawing.Point(20, 40);
            this.txtName.Size = new System.Drawing.Size(300, 25);
            //
            // lblEmail
            //
            this.lblEmail.Location = new System.Drawing.Point(20, 80);
            this.lblEmail.Text = "Email Address";
            //
            // txtEmail
            //
            this.txtEmail.Location = new System.Drawing.Point(20, 100);
            this.txtEmail.Size = new System.Drawing.Size(300, 25);
            //
            // lblMobile
            //
            this.lblMobile.Location = new System.Drawing.Point(20, 140);
            this.lblMobile.Text = "Mobile Number";
            //
            // txtMobile
            //
            this.txtMobile.Location = new System.Drawing.Point(20, 160);
            this.txtMobile.Size = new System.Drawing.Size(300, 25);
            //
            // lblSubject
            //
            this.lblSubject.Location = new System.Drawing.Point(20, 200);
            this.lblSubject.Text = "Specialization / Subject";
            //
            // txtSubject
            //
            this.txtSubject.Location = new System.Drawing.Point(20, 220);
            this.txtSubject.Size = new System.Drawing.Size(300, 25);
            //
            // btnRegister
            //
            this.btnRegister.Location = new System.Drawing.Point(20, 280);
            this.btnRegister.Size = new System.Drawing.Size(300, 45);
            this.btnRegister.Text = " 💾 REGISTER TEACHER";
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            //
            // TeacherRegistrationForm
            //
            this.ClientSize = new System.Drawing.Size(380, 450);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.pnlCard);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Teacher Registration";
            this.pnlCard.ResumeLayout(false);
            this.pnlCard.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
