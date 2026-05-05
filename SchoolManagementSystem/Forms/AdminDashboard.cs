using System;
using System.Drawing;
using System.Windows.Forms;
using SchoolManagementSystem.UI;
using SchoolManagementSystem.BLL;

namespace SchoolManagementSystem.Forms
{
    public partial class AdminDashboard : Form
    {
        public AdminDashboard()
        {
            InitializeComponent();
            ApplyStyles();
        }

        private void ApplyStyles()
        {
            pnlSidebar.BackColor = UITheme.SidebarColor;
            pnlHeader.BackColor = Color.White;
            lblUser.Text = $"Welcome, {AuthService.CurrentUser?.Name} (Admin)";

            UITheme.ApplySidebarButtonStyle(btnStudents);
            UITheme.ApplySidebarButtonStyle(btnTeachers);
            UITheme.ApplySidebarButtonStyle(btnReports);
            UITheme.ApplySidebarButtonStyle(btnLogout);
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

        private void btnTeachers_Click(object sender, EventArgs e)
        {
            // Implementation for teacher management can be similar to ManageStudentsForm
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            ShowForm(new ReportsForm());
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
