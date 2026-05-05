using System;
using System.Drawing;
using System.Windows.Forms;
using SchoolManagementSystem.DAL;
using SchoolManagementSystem.UI;

namespace SchoolManagementSystem.Forms
{
    public partial class TeacherRegistrationForm : Form
    {
        public TeacherRegistrationForm()
        {
            InitializeComponent();
            ApplyStyles();
        }

        private void ApplyStyles()
        {
            this.BackColor = UITheme.BackgroundColor;
            UITheme.ApplyHeaderStyle(lblTitle);
            UITheme.ApplyCardStyle(pnlCard);
            UITheme.ApplyButtonStyle(btnRegister);
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO Teacher (name, email, mobile, subject) VALUES (@name, @email, @mob, @sub)";
            System.Data.SqlClient.SqlParameter[] parameters = {
                new System.Data.SqlClient.SqlParameter("@name", txtName.Text),
                new System.Data.SqlClient.SqlParameter("@email", txtEmail.Text),
                new System.Data.SqlClient.SqlParameter("@mob", txtMobile.Text),
                new System.Data.SqlClient.SqlParameter("@sub", txtSubject.Text)
            };

            if (DatabaseHelper.ExecuteNonQuery(query, parameters) > 0)
            {
                MessageBox.Show("Teacher registered successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }
    }
}
