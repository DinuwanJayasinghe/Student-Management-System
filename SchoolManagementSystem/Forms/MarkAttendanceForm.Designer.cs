namespace SchoolManagementSystem.Forms
{
    partial class MarkAttendanceForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.DataGridView dgvAttendance;
        private System.Windows.Forms.Button btnSave;

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
            this.btnSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAttendance)).BeginInit();
            this.SuspendLayout();
            //
            // lblTitle
            //
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(20, 20);
            this.lblTitle.Text = "Mark Student Attendance";
            //
            // dgvAttendance
            //
            this.dgvAttendance.AllowUserToAddRows = false;
            this.dgvAttendance.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAttendance.Location = new System.Drawing.Point(20, 70);
            this.dgvAttendance.Size = new System.Drawing.Size(740, 400);
            //
            // btnSave
            //
            this.btnSave.Location = new System.Drawing.Point(560, 485);
            this.btnSave.Size = new System.Drawing.Size(200, 40);
            this.btnSave.Text = " 💾 SAVE ATTENDANCE";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            //
            // MarkAttendanceForm
            //
            this.ClientSize = new System.Drawing.Size(780, 540);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.dgvAttendance);
            this.Controls.Add(this.btnSave);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            ((System.ComponentModel.ISupportInitialize)(this.dgvAttendance)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
