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
            lblUser.Text = $"Welcome, {AuthService.CurrentUser?.Name} (Student)";

            UITheme.ApplySidebarButtonStyle(btnProfile);
            UITheme.ApplySidebarButtonStyle(btnAttendance);
            UITheme.ApplySidebarButtonStyle(btnLogout);
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            AuthService.Logout();
            new LoginForm().Show();
            this.Close();
        }
    }
}
