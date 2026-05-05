using System.Drawing;
using System.Windows.Forms;

namespace SchoolManagementSystem.UI
{
    public class StatCard : Panel
    {
        public StatCard(string title, string value, Color iconColor, string icon)
        {
            this.Size = new Size(180, 100);
            this.BackColor = Color.White;
            this.Padding = new Padding(10);

            Label lblValue = new Label {
                Text = value,
                Font = new Font("Segoe UI", 18f, FontStyle.Bold),
                ForeColor = UITheme.PrimaryDark,
                AutoSize = true,
                Location = new Point(10, 10)
            };

            Label lblTitle = new Label {
                Text = title,
                Font = new Font("Segoe UI", 9f),
                ForeColor = UITheme.LightTextColor,
                AutoSize = true,
                Location = new Point(10, 50)
            };

            Label lblIcon = new Label {
                Text = icon,
                Font = new Font("Segoe UI", 20f),
                ForeColor = iconColor,
                AutoSize = true,
                Location = new Point(130, 10)
            };

            this.Controls.Add(lblValue);
            this.Controls.Add(lblTitle);
            this.Controls.Add(lblIcon);

            this.Paint += (s, e) => {
                ControlPaint.DrawBorder(e.Graphics, this.ClientRectangle, Color.FromArgb(224, 224, 224), ButtonBorderStyle.Solid);
            };
        }
    }
}
