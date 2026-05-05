using System;
using System.Drawing;
using System.Windows.Forms;
using SchoolManagementSystem.BLL;
using SchoolManagementSystem.UI;

namespace SchoolManagementSystem.Forms
{
    public partial class ReportsForm : Form
    {
        private ReportService reportService = new ReportService();

        public ReportsForm()
        {
            InitializeComponent();
            ApplyStyles();
        }

        private void ApplyStyles()
        {
            this.BackColor = UITheme.BackgroundColor;
            UITheme.ApplyHeaderStyle(lblTitle);
            UITheme.ApplyButtonStyle(btnStudentReport);
            UITheme.ApplyButtonStyle(btnContactList);
            dgvReports.BackgroundColor = Color.White;
        }

        private void btnStudentReport_Click(object sender, EventArgs e)
        {
            dgvReports.DataSource = reportService.GetFullStudentReport();
        }

        private void btnContactList_Click(object sender, EventArgs e)
        {
            dgvReports.DataSource = reportService.GetContactList();
        }
    }
}
