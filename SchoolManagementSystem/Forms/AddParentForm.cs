using System;
using System.Drawing;
using System.Windows.Forms;
using SchoolManagementSystem.DAL;
using SchoolManagementSystem.UI;

namespace SchoolManagementSystem.Forms
{
    public partial class AddParentForm : Form
    {
        public AddParentForm()
        {
            InitializeComponent();
            ApplyStyles();
        }

        private void ApplyStyles()
        {
            this.BackColor = UITheme.BackgroundColor;
            UITheme.ApplyHeaderStyle(lblTitle);
            UITheme.ApplyCardStyle(pnlCard);
            UITheme.ApplyButtonStyle(btnSave);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO Parent (name, contact_number, occupation) VALUES (@name, @contact, @occ)";
            System.Data.SqlClient.SqlParameter[] parameters = {
                new System.Data.SqlClient.SqlParameter("@name", txtName.Text),
                new System.Data.SqlClient.SqlParameter("@contact", txtContact.Text),
                new System.Data.SqlClient.SqlParameter("@occ", txtOccupation.Text)
            };

            if (DatabaseHelper.ExecuteNonQuery(query, parameters) > 0)
            {
                MessageBox.Show("Parent added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }
    }
}
