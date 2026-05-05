using System;
using System.Data;
using System.Windows.Forms;
using SchoolManagementSystem.BLL;
using SchoolManagementSystem.DAL;
using SchoolManagementSystem.UI;

namespace SchoolManagementSystem.Forms
{
    public partial class StudentRegistrationForm : Form
    {
        private StudentService studentService = new StudentService();

        public StudentRegistrationForm()
        {
            InitializeComponent();
            ApplyStyles();
            LoadInitialData();
        }

        private void ApplyStyles()
        {
            this.BackColor = UITheme.BackgroundColor;
            UITheme.ApplyButtonStyle(btnRegister);
            UITheme.ApplyHeaderStyle(lblTitle);
        }

        private void LoadInitialData()
        {
            // Load Classes
            cmbClass.DataSource = DatabaseHelper.ExecuteQuery("SELECT id, name FROM Class");
            cmbClass.DisplayMember = "name";
            cmbClass.ValueMember = "id";

            // Load Parents
            cmbParent.DataSource = DatabaseHelper.ExecuteQuery("SELECT id, name FROM Parent");
            cmbParent.DisplayMember = "name";
            cmbParent.ValueMember = "id";
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            DateTime birthday = dtpBirthday.Value;
            int classId = (int)cmbClass.SelectedValue;
            string address = txtAddress.Text;
            string mobile = txtMobile.Text;
            int parentId = (int)cmbParent.SelectedValue;

            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(mobile))
            {
                MessageBox.Show("Please fill all required fields", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (studentService.RegisterStudent(name, birthday, classId, address, mobile, parentId))
            {
                MessageBox.Show("Student registered successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Failed to register student.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
