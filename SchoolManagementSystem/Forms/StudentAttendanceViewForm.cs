using System;
using System.Data;
using System.Windows.Forms;
using SchoolManagementSystem.DAL;
using SchoolManagementSystem.UI;

namespace SchoolManagementSystem.Forms
{
    public partial class StudentAttendanceViewForm : Form
    {
        public StudentAttendanceViewForm(int studentId)
        {
            InitializeComponent();
            ApplyStyles();
            LoadAttendance(studentId);
        }

        private void ApplyStyles()
        {
            this.BackColor = UITheme.BackgroundColor;
            UITheme.ApplyHeaderStyle(lblTitle);
            UITheme.ApplyDataGridViewStyle(dgvAttendance);
        }

        private void LoadAttendance(int studentId)
        {
            string query = "SELECT date, status FROM Attendance WHERE student_id = @sid ORDER BY date DESC";
            dgvAttendance.DataSource = DatabaseHelper.ExecuteQuery(query, new System.Data.SqlClient.SqlParameter[] {
                new System.Data.SqlClient.SqlParameter("@sid", studentId)
            });
        }
    }
}
