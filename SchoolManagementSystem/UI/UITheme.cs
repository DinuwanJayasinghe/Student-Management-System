using System.Drawing;
using System.Windows.Forms;

namespace SchoolManagementSystem.UI
{
    public static class UITheme
    {
        public static Color PrimaryColor = Color.FromArgb(63, 81, 181); // Indigo
        public static Color SecondaryColor = Color.FromArgb(255, 193, 7); // Amber
        public static Color BackgroundColor = Color.FromArgb(245, 245, 245); // Light Gray
        public static Color SidebarColor = Color.FromArgb(48, 63, 159); // Darker Indigo
        public static Color TextColor = Color.White;
        public static Color ContentTextColor = Color.FromArgb(33, 33, 33);

        public static void ApplyButtonStyle(Button btn)
        {
            btn.BackColor = PrimaryColor;
            btn.ForeColor = Color.White;
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
            btn.Font = new Font("Segoe UI", 10f, FontStyle.Bold);
            btn.Cursor = Cursors.Hand;
            btn.TextAlign = ContentAlignment.MiddleRight;
            btn.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn.Padding = new Padding(10, 0, 10, 0);
        }

        public static void ApplySidebarButtonStyle(Button btn)
        {
            btn.BackColor = SidebarColor;
            btn.ForeColor = Color.White;
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
            btn.Font = new Font("Segoe UI", 11f);
            btn.Cursor = Cursors.Hand;
            btn.TextAlign = ContentAlignment.MiddleLeft;
            btn.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn.Padding = new Padding(20, 0, 0, 0);
            btn.Height = 50;
            btn.Dock = DockStyle.Top;
        }

        public static void ApplyHeaderStyle(Label lbl)
        {
            lbl.Font = new Font("Segoe UI", 18f, FontStyle.Bold);
            lbl.ForeColor = PrimaryColor;
        }
    }
}
