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
            LoadStats();
        }

        private void ApplyStyles()
        {
            pnlSidebar.BackColor = UITheme.SidebarColor;
            pnlHeader.BackColor = Color.White;
            lblUser.Text = $"Welcome, {AuthService.CurrentUser?.Name}";
            lblUser.ForeColor = UITheme.PrimaryDark;
            lblUser.Cursor = Cursors.Hand;
            lblUser.Click += (s, e) => ShowForm(new ProfileForm(AuthService.CurrentUser));

            UITheme.ApplySidebarButtonStyle(btnStudents);
            UITheme.ApplySidebarButtonStyle(btnTeachers);
            UITheme.ApplySidebarButtonStyle(btnParents);
            UITheme.ApplySidebarButtonStyle(btnReports);
            UITheme.ApplySidebarButtonStyle(btnLogout);
        }

        private void LoadStats()
        {
            pnlContent.Controls.Clear();

            FlowLayoutPanel flp = new FlowLayoutPanel {
                Dock = DockStyle.Top,
                Height = 150,
                Padding = new Padding(20),
                BackColor = Color.Transparent
            };

            flp.Controls.Add(new StatCard("Students", "1,240", Color.Blue, "👥"));
            flp.Controls.Add(new StatCard("Teachers", "84", Color.Green, "👨‍🏫"));
            flp.Controls.Add(new StatCard("Classes", "32", Color.Orange, "🏫"));
            flp.Controls.Add(new StatCard("Attendance", "98%", Color.Purple, "📈"));

            pnlContent.Controls.Add(flp);

            Label lblWelcome = new Label {
                Text = "School Overview",
                Font = new Font("Segoe UI Semibold", 14f),
                ForeColor = UITheme.PrimaryDark,
                Location = new Point(25, 160),
                AutoSize = true
            };
            pnlContent.Controls.Add(lblWelcome);
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
            ShowForm(new ManageTeachersForm());
        }

        private void btnParents_Click(object sender, EventArgs e)
        {
            ShowForm(new ManageParentsForm());
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
