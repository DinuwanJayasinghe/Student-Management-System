namespace SchoolManagementSystem.Forms
{
    partial class ProfileForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnlCard;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblNameValue;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblIdValue;
        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.Label lblRoleValue;
        private System.Windows.Forms.Label lblExtraLabel;
        private System.Windows.Forms.Label lblExtraValue;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlCard = new System.Windows.Forms.Panel();
            this.lblName = new System.Windows.Forms.Label();
            this.lblNameValue = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.lblIdValue = new System.Windows.Forms.Label();
            this.lblRole = new System.Windows.Forms.Label();
            this.lblRoleValue = new System.Windows.Forms.Label();
            this.lblExtraLabel = new System.Windows.Forms.Label();
            this.lblExtraValue = new System.Windows.Forms.Label();
            this.pnlCard.SuspendLayout();
            this.SuspendLayout();
            //
            // lblTitle
            //
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(20, 20);
            this.lblTitle.Text = "User Profile";
            //
            // pnlCard
            //
            this.pnlCard.BackColor = System.Drawing.Color.White;
            this.pnlCard.Controls.Add(this.lblName);
            this.pnlCard.Controls.Add(this.lblNameValue);
            this.pnlCard.Controls.Add(this.lblId);
            this.pnlCard.Controls.Add(this.lblIdValue);
            this.pnlCard.Controls.Add(this.lblRole);
            this.pnlCard.Controls.Add(this.lblRoleValue);
            this.pnlCard.Controls.Add(this.lblExtraLabel);
            this.pnlCard.Controls.Add(this.lblExtraValue);
            this.pnlCard.Location = new System.Drawing.Point(20, 70);
            this.pnlCard.Name = "pnlCard";
            this.pnlCard.Size = new System.Drawing.Size(340, 250);
            //
            // lblName
            //
            this.lblName.Location = new System.Drawing.Point(20, 20);
            this.lblName.Text = "Full Name:";
            this.lblName.Font = new System.Drawing.Font("Segoe UI", 9f, System.Drawing.FontStyle.Bold);
            //
            // lblNameValue
            //
            this.lblNameValue.Location = new System.Drawing.Point(120, 20);
            this.lblNameValue.Size = new System.Drawing.Size(200, 20);
            //
            // lblId
            //
            this.lblId.Location = new System.Drawing.Point(20, 60);
            this.lblId.Text = "Reg No / Email:";
            this.lblId.Font = new System.Drawing.Font("Segoe UI", 9f, System.Drawing.FontStyle.Bold);
            //
            // lblIdValue
            //
            this.lblIdValue.Location = new System.Drawing.Point(120, 60);
            this.lblIdValue.Size = new System.Drawing.Size(200, 20);
            //
            // lblRole
            //
            this.lblRole.Location = new System.Drawing.Point(20, 100);
            this.lblRole.Text = "Role:";
            this.lblRole.Font = new System.Drawing.Font("Segoe UI", 9f, System.Drawing.FontStyle.Bold);
            //
            // lblRoleValue
            //
            this.lblRoleValue.Location = new System.Drawing.Point(120, 100);
            this.lblRoleValue.Size = new System.Drawing.Size(200, 20);
            //
            // lblExtraLabel
            //
            this.lblExtraLabel.Location = new System.Drawing.Point(20, 140);
            this.lblExtraLabel.Text = "Details:";
            this.lblExtraLabel.Font = new System.Drawing.Font("Segoe UI", 9f, System.Drawing.FontStyle.Bold);
            //
            // lblExtraValue
            //
            this.lblExtraValue.Location = new System.Drawing.Point(120, 140);
            this.lblExtraValue.Size = new System.Drawing.Size(200, 60);
            //
            // ProfileForm
            //
            this.ClientSize = new System.Drawing.Size(380, 350);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.pnlCard);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.pnlCard.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
