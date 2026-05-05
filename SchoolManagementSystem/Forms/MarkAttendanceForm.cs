using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using SchoolManagementSystem.DAL;
using SchoolManagementSystem.UI;
using SchoolManagementSystem.BLL;

namespace SchoolManagementSystem.Forms
{
    public partial class MarkAttendanceForm : Form
    {
        private AttendanceService attendanceService = new AttendanceService();
        private int currentTeacherId;

        public MarkAttendanceForm(int teacherId)
        {
            InitializeComponent();
            this.currentTeacherId = teacherId;
            ApplyStyles();
            LoadStudents();
        }

        private void ApplyStyles()
        {
            this.BackColor = UITheme.BackgroundColor;
            UITheme.ApplyHeaderStyle(lblTitle);
            UITheme.ApplyDataGridViewStyle(dgvAttendance);
            UITheme.ApplyButtonStyle(btnSave);
        }

        private void LoadStudents()
        {
            // Load students assigned to this teacher's class
            string query = @"SELECT s.id, s.reg_no, s.name
                             FROM Student s
                             JOIN Class c ON s.class_id = c.id
                             WHERE c.class_teacher_id = @tid";
            dgvAttendance.DataSource = DatabaseHelper.ExecuteQuery(query, new System.Data.SqlClient.SqlParameter[] {
                new System.Data.SqlClient.SqlParameter("@tid", currentTeacherId)
            });

            if (dgvAttendance.Columns["Status"] == null)
            {
                DataGridViewComboBoxColumn statusCol = new DataGridViewComboBoxColumn();
                statusCol.Name = "Status";
                statusCol.HeaderText = "Attendance Status";
                statusCol.Items.AddRange("Present", "Absent");
                dgvAttendance.Columns.Add(statusCol);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!attendanceService.IsWithinAttendanceTime())
            {
                MessageBox.Show("Attendance can only be marked before 7:30 AM on weekdays.", "Time Constraint", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int count = 0;
            foreach (DataGridViewRow row in dgvAttendance.Rows)
            {
                if (row.Cells["Status"].Value != null)
                {
                    int studentId = (int)row.Cells["id"].Value;
                    string status = row.Cells["Status"].Value.ToString();
                    attendanceService.MarkStudentAttendance(studentId, status, currentTeacherId);
                    count++;
                }
            }
            MessageBox.Show($"{count} attendance records saved.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
