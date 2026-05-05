using System;
using System.Drawing;
using System.Windows.Forms;
using SchoolManagementSystem.Models;
using SchoolManagementSystem.UI;

namespace SchoolManagementSystem.Forms
{
    public partial class ProfileForm : Form
    {
        public ProfileForm(User user)
        {
            InitializeComponent();
            ApplyStyles();
            DisplayUserInfo(user);
        }

        private void ApplyStyles()
        {
            this.BackColor = UITheme.BackgroundColor;
            UITheme.ApplyHeaderStyle(lblTitle);
            UITheme.ApplyCardStyle(pnlCard);
        }

        private void DisplayUserInfo(User user)
        {
            lblTitle.Text = $"{user.Role} Profile";
            lblNameValue.Text = user.Name;
            lblIdValue.Text = string.IsNullOrEmpty(user.RegNo) ? user.Email : user.RegNo;
            lblRoleValue.Text = user.Role;

            if (user is Teacher teacher)
            {
                lblExtraLabel.Text = "Subject:";
                lblExtraValue.Text = teacher.Subject;
            }
            else if (user is Student student)
            {
                lblExtraLabel.Text = "Address:";
                lblExtraValue.Text = student.Address;
            }
        }
    }
}
