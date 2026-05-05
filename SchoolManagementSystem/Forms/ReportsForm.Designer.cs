namespace SchoolManagementSystem.Forms
{
    partial class ReportsForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnStudentReport;
        private System.Windows.Forms.Button btnContactList;
        private System.Windows.Forms.DataGridView dgvReports;

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
            this.btnStudentReport = new System.Windows.Forms.Button();
            this.btnContactList = new System.Windows.Forms.Button();
            this.dgvReports = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReports)).BeginInit();
            this.SuspendLayout();
            //
            // lblTitle
            //
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(20, 20);
            this.lblTitle.Text = "Reports";
            //
            // btnStudentReport
            //
            this.btnStudentReport.Location = new System.Drawing.Point(20, 70);
            this.btnStudentReport.Size = new System.Drawing.Size(200, 40);
            this.btnStudentReport.Text = "Full Student Report";
            this.btnStudentReport.Click += new System.EventHandler(this.btnStudentReport_Click);
            //
            // btnContactList
            //
            this.btnContactList.Location = new System.Drawing.Point(240, 70);
            this.btnContactList.Size = new System.Drawing.Size(200, 40);
            this.btnContactList.Text = "Contact List";
            this.btnContactList.Click += new System.EventHandler(this.btnContactList_Click);
            //
            // dgvReports
            //
            this.dgvReports.AllowUserToAddRows = false;
            this.dgvReports.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvReports.Location = new System.Drawing.Point(20, 130);
            this.dgvReports.Size = new System.Drawing.Size(740, 390);
            //
            // ReportsForm
            //
            this.ClientSize = new System.Drawing.Size(780, 540);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnStudentReport);
            this.Controls.Add(this.btnContactList);
            this.Controls.Add(this.dgvReports);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.ResumeLayout(false);
            this.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReports)).EndInit();
        }
    }
}
