using System;
using System.Data;
using System.Windows.Forms;
using SchoolManagementSystem.DAL;
using SchoolManagementSystem.UI;

namespace SchoolManagementSystem.Forms
{
    public partial class ManageParentsForm : Form
    {
        public ManageParentsForm()
        {
            InitializeComponent();
            ApplyStyles();
            LoadParents();
        }

        private void ApplyStyles()
        {
            this.BackColor = UITheme.BackgroundColor;
            UITheme.ApplyHeaderStyle(lblTitle);
            UITheme.ApplyDataGridViewStyle(dgvParents);
            UITheme.ApplyButtonStyle(btnAddParent);
        }

        private void LoadParents()
        {
            dgvParents.DataSource = DatabaseHelper.ExecuteQuery("SELECT * FROM Parent");
        }

        private void btnAddParent_Click(object sender, EventArgs e)
        {
            new AddParentForm().ShowDialog();
            LoadParents();
        }
    }
}
