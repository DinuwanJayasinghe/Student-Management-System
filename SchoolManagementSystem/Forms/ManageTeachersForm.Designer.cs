namespace SchoolManagementSystem.Forms
{
    partial class ManageTeachersForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.DataGridView dgvTeachers;
        private System.Windows.Forms.Button btnAddTeacher;

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
            this.dgvTeachers = new System.Windows.Forms.DataGridView();
            this.btnAddTeacher = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTeachers)).BeginInit();
            this.SuspendLayout();
            //
            // lblTitle
            //
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(20, 20);
            this.lblTitle.Text = "Teacher Management";
            //
            // dgvTeachers
            //
            this.dgvTeachers.AllowUserToAddRows = false;
            this.dgvTeachers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTeachers.Location = new System.Drawing.Point(20, 70);
            this.dgvTeachers.Size = new System.Drawing.Size(740, 400);
            //
            // btnAddTeacher
            //
            this.btnAddTeacher.Location = new System.Drawing.Point(560, 485);
            this.btnAddTeacher.Size = new System.Drawing.Size(200, 40);
            this.btnAddTeacher.Text = " ➕ ADD TEACHER";
            this.btnAddTeacher.Click += new System.EventHandler(this.btnAddTeacher_Click);
            //
            // ManageTeachersForm
            //
            this.ClientSize = new System.Drawing.Size(780, 540);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.dgvTeachers);
            this.Controls.Add(this.btnAddTeacher);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            ((System.ComponentModel.ISupportInitialize)(this.dgvTeachers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
