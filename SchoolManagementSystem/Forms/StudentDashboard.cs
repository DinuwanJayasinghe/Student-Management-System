using System;
using System.Drawing;
using System.Windows.Forms;
using SchoolManagementSystem.UI;
using SchoolManagementSystem.BLL;

namespace SchoolManagementSystem.Forms
{
    public partial class StudentDashboard : Form
    {
        public StudentDashboard()
        {
            InitializeComponent();
            ApplyStyles();
        }

        private void ApplyStyles()
        {
            pnlSidebar.BackColor = UITheme.SidebarColor;
            pnlHeader.BackColor = Color.White;
            lblUser.Text = $"Welcome, {AuthService.CurrentUser?.Name}";
            lblUser.ForeColor = UITheme.PrimaryDark;

            UITheme.ApplySidebarButtonStyle(btnProfile);
            UITheme.ApplySidebarButtonStyle(btnAttendance);
            UITheme.ApplySidebarButtonStyle(btnLogout);
        }

        private void ShowForm(Form form)
        {
            pnlContent.Controls.Clear();
            form.TopLevel = false;
            form.Dock = DockStyle.Fill;
            pnlContent.Controls.Add(form);
            form.Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            AuthService.Logout();
            new LoginForm().Show();
            this.Close();
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            ShowForm(new ProfileForm(AuthService.CurrentUser));
        }

        private void btnAttendance_Click(object sender, EventArgs e)
        {
            ShowForm(new StudentAttendanceViewForm(AuthService.CurrentUser.Id));
        }
    }
}
