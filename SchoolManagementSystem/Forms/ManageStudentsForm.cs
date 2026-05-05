using System;
using System.Drawing;
using System.Windows.Forms;
using SchoolManagementSystem.BLL;
using SchoolManagementSystem.UI;

namespace SchoolManagementSystem.Forms
{
    public partial class ManageStudentsForm : Form
    {
        private StudentService studentService = new StudentService();

        public ManageStudentsForm()
        {
            InitializeComponent();
            ApplyStyles();
            LoadStudents();
        }

        private void ApplyStyles()
        {
            this.BackColor = UITheme.BackgroundColor;
            UITheme.ApplyHeaderStyle(lblTitle);
            dgvStudents.BackgroundColor = Color.White;
            dgvStudents.BorderStyle = BorderStyle.None;
            dgvStudents.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvStudents.MultiSelect = false;
        }

        private void LoadStudents()
        {
            dgvStudents.DataSource = studentService.GetAllStudents();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            dgvStudents.DataSource = studentService.SearchStudents(txtSearch.Text);
        }

        private void dgvStudents_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var regNo = dgvStudents.Rows[e.RowIndex].Cells["reg_no"].Value.ToString();
                var name = dgvStudents.Rows[e.RowIndex].Cells["student_name"].Value.ToString();
                MessageBox.Show($"Profile Details for {name}\nRegistration No: {regNo}", "Student Profile", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
