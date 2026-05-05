namespace SchoolManagementSystem.Forms
{
    partial class StudentAttendanceViewForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.DataGridView dgvAttendance;

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
            this.dgvAttendance = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAttendance)).BeginInit();
            this.SuspendLayout();
            //
            // lblTitle
            //
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(20, 20);
            this.lblTitle.Text = "My Attendance History";
            //
            // dgvAttendance
            //
            this.dgvAttendance.AllowUserToAddRows = false;
            this.dgvAttendance.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAttendance.Location = new System.Drawing.Point(20, 70);
            this.dgvAttendance.Size = new System.Drawing.Size(740, 440);
            //
            // StudentAttendanceViewForm
            //
            this.ClientSize = new System.Drawing.Size(780, 540);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.dgvAttendance);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            ((System.ComponentModel.ISupportInitialize)(this.dgvAttendance)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
