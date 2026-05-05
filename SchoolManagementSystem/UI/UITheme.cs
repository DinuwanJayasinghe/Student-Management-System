using System.Drawing;
using System.Windows.Forms;

namespace SchoolManagementSystem.UI
{
    public static class UITheme
    {
        // Color Palette
        public static Color PrimaryColor = Color.FromArgb(63, 81, 181); // Indigo
        public static Color PrimaryDark = Color.FromArgb(48, 63, 159);
        public static Color SecondaryColor = Color.FromArgb(255, 193, 7); // Amber
        public static Color BackgroundColor = Color.FromArgb(240, 242, 245); // Soft Gray
        public static Color SidebarColor = Color.FromArgb(33, 37, 41); // Dark Gray
        public static Color White = Color.White;
        public static Color TextColor = Color.FromArgb(33, 33, 33);
        public static Color LightTextColor = Color.FromArgb(117, 117, 117);

        public static void ApplyButtonStyle(Button btn)
        {
            btn.BackColor = PrimaryColor;
            btn.ForeColor = Color.White;
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
            btn.Font = new Font("Segoe UI Semibold", 10f);
            btn.Cursor = Cursors.Hand;
            btn.TextAlign = ContentAlignment.MiddleCenter;
            btn.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn.Padding = new Padding(10, 5, 10, 5);
        }

        public static void ApplySidebarButtonStyle(Button btn)
        {
            btn.BackColor = SidebarColor;
            btn.ForeColor = Color.FromArgb(224, 224, 224);
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
            btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(52, 58, 64);
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
            lbl.Font = new Font("Segoe UI Semibold", 16f);
            lbl.ForeColor = PrimaryDark;
        }

        public static void ApplyDataGridViewStyle(DataGridView dgv)
        {
            dgv.BackgroundColor = Color.White;
            dgv.BorderStyle = BorderStyle.None;
            dgv.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;

            dgv.EnableHeadersVisualStyles = false;
            dgv.ColumnHeadersDefaultCellStyle.BackColor = PrimaryColor;
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI Semibold", 10f);
            dgv.ColumnHeadersHeight = 40;

            dgv.DefaultCellStyle.SelectionBackColor = Color.FromArgb(232, 234, 246);
            dgv.DefaultCellStyle.SelectionForeColor = PrimaryColor;
            dgv.DefaultCellStyle.Font = new Font("Segoe UI", 9f);
            dgv.RowTemplate.Height = 35;

            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(250, 250, 250);
        }

        public static Panel CreateCard()
        {
            Panel p = new Panel();
            p.BackColor = Color.White;
            p.Padding = new Padding(15);
            return p;
        }

        public static void ApplyCardStyle(Panel p)
        {
            p.BackColor = Color.White;
            // Border simulation
            p.Paint += (s, e) => {
                ControlPaint.DrawBorder(e.Graphics, p.ClientRectangle, Color.FromArgb(224, 224, 224), ButtonBorderStyle.Solid);
            };
        }
    }
}
