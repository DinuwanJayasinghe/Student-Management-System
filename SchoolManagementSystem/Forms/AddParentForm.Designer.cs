namespace SchoolManagementSystem.Forms
{
    partial class AddParentForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnlCard;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtContact;
        private System.Windows.Forms.TextBox txtOccupation;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblContact;
        private System.Windows.Forms.Label lblOccupation;

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
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtContact = new System.Windows.Forms.TextBox();
            this.txtOccupation = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.lblContact = new System.Windows.Forms.Label();
            this.lblOccupation = new System.Windows.Forms.Label();
            this.pnlCard.SuspendLayout();
            this.SuspendLayout();
            //
            // lblTitle
            //
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(20, 20);
            this.lblTitle.Text = "Add Parent";
            //
            // pnlCard
            //
            this.pnlCard.BackColor = System.Drawing.Color.White;
            this.pnlCard.Controls.Add(this.lblName);
            this.pnlCard.Controls.Add(this.txtName);
            this.pnlCard.Controls.Add(this.lblContact);
            this.pnlCard.Controls.Add(this.txtContact);
            this.pnlCard.Controls.Add(this.lblOccupation);
            this.pnlCard.Controls.Add(this.txtOccupation);
            this.pnlCard.Controls.Add(this.btnSave);
            this.pnlCard.Location = new System.Drawing.Point(20, 70);
            this.pnlCard.Name = "pnlCard";
            this.pnlCard.Size = new System.Drawing.Size(340, 300);
            //
            // lblName
            //
            this.lblName.Location = new System.Drawing.Point(20, 20);
            this.lblName.Text = "Full Name";
            //
            // txtName
            //
            this.txtName.Location = new System.Drawing.Point(20, 40);
            this.txtName.Size = new System.Drawing.Size(300, 25);
            //
            // lblContact
            //
            this.lblContact.Location = new System.Drawing.Point(20, 80);
            this.lblContact.Text = "Contact Number";
            //
            // txtContact
            //
            this.txtContact.Location = new System.Drawing.Point(20, 100);
            this.txtContact.Size = new System.Drawing.Size(300, 25);
            //
            // lblOccupation
            //
            this.lblOccupation.Location = new System.Drawing.Point(20, 140);
            this.lblOccupation.Text = "Occupation";
            //
            // txtOccupation
            //
            this.txtOccupation.Location = new System.Drawing.Point(20, 160);
            this.txtOccupation.Size = new System.Drawing.Size(300, 25);
            //
            // btnSave
            //
            this.btnSave.Location = new System.Drawing.Point(20, 220);
            this.btnSave.Size = new System.Drawing.Size(300, 45);
            this.btnSave.Text = " 💾 SAVE PARENT";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            //
            // AddParentForm
            //
            this.ClientSize = new System.Drawing.Size(380, 400);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.pnlCard);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add Parent";
            this.pnlCard.ResumeLayout(false);
            this.pnlCard.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
