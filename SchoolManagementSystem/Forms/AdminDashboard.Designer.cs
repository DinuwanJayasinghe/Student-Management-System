namespace SchoolManagementSystem.Forms
{
    partial class AdminDashboard
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Panel pnlSidebar;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Panel pnlContent;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Button btnStudents;
        private System.Windows.Forms.Button btnTeachers;
        private System.Windows.Forms.Button btnParents;
        private System.Windows.Forms.Button btnReports;
        private System.Windows.Forms.Button btnLogout;

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
            this.pnlSidebar = new System.Windows.Forms.Panel();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.pnlContent = new System.Windows.Forms.Panel();
            this.lblUser = new System.Windows.Forms.Label();
            this.btnStudents = new System.Windows.Forms.Button();
            this.btnTeachers = new System.Windows.Forms.Button();
            this.btnParents = new System.Windows.Forms.Button();
            this.btnReports = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.pnlSidebar.SuspendLayout();
            this.pnlHeader.SuspendLayout();
            this.SuspendLayout();
            //
            // pnlSidebar
            //
            this.pnlSidebar.Controls.Add(this.btnLogout);
            this.pnlSidebar.Controls.Add(this.btnReports);
            this.pnlSidebar.Controls.Add(this.btnParents);
            this.pnlSidebar.Controls.Add(this.btnTeachers);
            this.pnlSidebar.Controls.Add(this.btnStudents);
            this.pnlSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSidebar.Location = new System.Drawing.Point(0, 0);
            this.pnlSidebar.Name = "pnlSidebar";
            this.pnlSidebar.Size = new System.Drawing.Size(220, 600);
            //
            // pnlHeader
            //
            this.pnlHeader.Controls.Add(this.lblUser);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(220, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(780, 60);
            //
            // lblUser
            //
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblUser.Location = new System.Drawing.Point(20, 20);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(100, 21);
            this.lblUser.Text = "Welcome";
            //
            // pnlContent
            //
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContent.Location = new System.Drawing.Point(220, 60);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size = new System.Drawing.Size(780, 540);
            this.pnlContent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(242)))), ((int)(((byte)(245)))));
            //
            // btnStudents
            //
            this.btnStudents.Text = " 👥 Students";
            this.btnStudents.Click += new System.EventHandler(this.btnStudents_Click);
            //
            // btnTeachers
            //
            this.btnTeachers.Text = " 👨‍🏫 Teachers";
            this.btnTeachers.Click += new System.EventHandler(this.btnTeachers_Click);
            //
            // btnParents
            //
            this.btnParents.Text = " 👪 Parents";
            this.btnParents.Click += new System.EventHandler(this.btnParents_Click);
            //
            // btnReports
            //
            this.btnReports.Text = " 📊 Reports";
            this.btnReports.Click += new System.EventHandler(this.btnReports_Click);
            //
            // btnLogout
            //
            this.btnLogout.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnLogout.Text = " 🚪 Logout";
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            //
            // AdminDashboard
            //
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.pnlContent);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.pnlSidebar);
            this.Text = "Admin Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.pnlSidebar.ResumeLayout(false);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.ResumeLayout(false);
        }
    }
}
