using System;
using System.Data;
using System.Windows.Forms;
using SchoolManagementSystem.DAL;
using SchoolManagementSystem.UI;

namespace SchoolManagementSystem.Forms
{
    public partial class ManageTeachersForm : Form
    {
        public ManageTeachersForm()
        {
            InitializeComponent();
            ApplyStyles();
            LoadTeachers();
        }

        private void ApplyStyles()
        {
            this.BackColor = UITheme.BackgroundColor;
            UITheme.ApplyHeaderStyle(lblTitle);
            UITheme.ApplyDataGridViewStyle(dgvTeachers);
            UITheme.ApplyButtonStyle(btnAddTeacher);
        }

        private void LoadTeachers()
        {
            dgvTeachers.DataSource = DatabaseHelper.ExecuteQuery("SELECT reg_no, name, email, mobile, subject FROM Teacher");
        }

        private void btnAddTeacher_Click(object sender, EventArgs e)
        {
            new TeacherRegistrationForm().ShowDialog();
            LoadTeachers();
        }
    }
}
