using System;
using System.Drawing;
using System.Windows.Forms;
using SchoolManagementSystem.BLL;
using SchoolManagementSystem.UI;

namespace SchoolManagementSystem.Forms
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            ApplyStyles();
        }

        private void ApplyStyles()
        {
            this.BackColor = UITheme.BackgroundColor;
            UITheme.ApplyButtonStyle(btnLogin);
            lblTitle.ForeColor = UITheme.PrimaryColor;
            UITheme.ApplyCardStyle(panel1);

            lblUsername.Font = new Font("Segoe UI", 9f);
            lblPassword.Font = new Font("Segoe UI", 9f);
            lblRole.Font = new Font("Segoe UI", 9f);

            txtUsername.BorderStyle = BorderStyle.FixedSingle;
            txtPassword.BorderStyle = BorderStyle.FixedSingle;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            string role = cmbRole.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(role))
            {
                MessageBox.Show("Please fill all fields", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (AuthService.Login(username, password, role))
            {
                Form dashboard;
                if (role == "Admin") dashboard = new AdminDashboard();
                else if (role == "Teacher") dashboard = new TeacherDashboard();
                else dashboard = new StudentDashboard();

                this.Hide();
                dashboard.Show();
            }
            else
            {
                MessageBox.Show("Invalid credentials", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
