using System;
using System.Drawing;
using System.Windows.Forms;
using SchoolManagementSystem.UI;
using SchoolManagementSystem.BLL;

namespace SchoolManagementSystem.Forms
{
    public partial class TeacherDashboard : Form
    {
        private AttendanceService attendanceService = new AttendanceService();

        public TeacherDashboard()
        {
            InitializeComponent();
            ApplyStyles();
        }

        private void ApplyStyles()
        {
            pnlSidebar.BackColor = UITheme.SidebarColor;
            pnlHeader.BackColor = Color.White;
            lblUser.Text = $"Welcome, {AuthService.CurrentUser?.Name} (Teacher)";

            UITheme.ApplySidebarButtonStyle(btnAttendance);
            UITheme.ApplySidebarButtonStyle(btnMarkMyAttendance);
            UITheme.ApplySidebarButtonStyle(btnStudents);
            UITheme.ApplySidebarButtonStyle(btnLogout);
        }

        private void btnMarkMyAttendance_Click(object sender, EventArgs e)
        {
            if (attendanceService.MarkTeacherAttendance(AuthService.CurrentUser.Id))
            {
                MessageBox.Show("Attendance marked successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Cannot mark attendance. It must be before 7:30 AM on a weekday.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            AuthService.Logout();
            new LoginForm().Show();
            this.Close();
        }

        private void btnStudents_Click(object sender, EventArgs e)
        {
            ShowForm(new ManageStudentsForm());
        }

        private void ShowForm(Form form)
        {
            pnlContent.Controls.Clear();
            form.TopLevel = false;
            form.Dock = DockStyle.Fill;
            pnlContent.Controls.Add(form);
            form.Show();
        }
    }
}
