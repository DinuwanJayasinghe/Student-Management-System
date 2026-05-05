namespace SchoolManagementSystem.Forms
{
    partial class ManageParentsForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.DataGridView dgvParents;
        private System.Windows.Forms.Button btnAddParent;

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
            this.dgvParents = new System.Windows.Forms.DataGridView();
            this.btnAddParent = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvParents)).BeginInit();
            this.SuspendLayout();
            //
            // lblTitle
            //
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(20, 20);
            this.lblTitle.Text = "Parent Management";
            //
            // dgvParents
            //
            this.dgvParents.AllowUserToAddRows = false;
            this.dgvParents.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvParents.Location = new System.Drawing.Point(20, 70);
            this.dgvParents.Size = new System.Drawing.Size(740, 400);
            //
            // btnAddParent
            //
            this.btnAddParent.Location = new System.Drawing.Point(560, 485);
            this.btnAddParent.Size = new System.Drawing.Size(200, 40);
            this.btnAddParent.Text = " ➕ ADD PARENT";
            this.btnAddParent.Click += new System.EventHandler(this.btnAddParent_Click);
            //
            // ManageParentsForm
            //
            this.ClientSize = new System.Drawing.Size(780, 540);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.dgvParents);
            this.Controls.Add(this.btnAddParent);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            ((System.ComponentModel.ISupportInitialize)(this.dgvParents)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
