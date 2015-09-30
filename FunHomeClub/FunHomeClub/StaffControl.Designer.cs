namespace FunHomeClub
{
    partial class StaffControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lstStaff = new System.Windows.Forms.ListView();
            this.employeeIdHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.usernameHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.passwordHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.positionHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnDeleteStaff = new System.Windows.Forms.Button();
            this.btnMaintainStaff = new System.Windows.Forms.Button();
            this.btnAddStaff = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstStaff
            // 
            this.lstStaff.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.employeeIdHeader,
            this.usernameHeader,
            this.passwordHeader,
            this.positionHeader});
            this.lstStaff.Location = new System.Drawing.Point(13, 12);
            this.lstStaff.Name = "lstStaff";
            this.lstStaff.Size = new System.Drawing.Size(351, 211);
            this.lstStaff.TabIndex = 2;
            this.lstStaff.UseCompatibleStateImageBehavior = false;
            this.lstStaff.View = System.Windows.Forms.View.Details;
            this.lstStaff.SelectedIndexChanged += new System.EventHandler(this.lstStaff_SelectedIndexChanged);
            // 
            // employeeIdHeader
            // 
            this.employeeIdHeader.Text = "EmployeeID";
            this.employeeIdHeader.Width = 96;
            // 
            // usernameHeader
            // 
            this.usernameHeader.Text = "Username";
            this.usernameHeader.Width = 95;
            // 
            // passwordHeader
            // 
            this.passwordHeader.Text = "Password";
            this.passwordHeader.Width = 85;
            // 
            // positionHeader
            // 
            this.positionHeader.Text = "Position";
            // 
            // btnDeleteStaff
            // 
            this.btnDeleteStaff.Enabled = false;
            this.btnDeleteStaff.Location = new System.Drawing.Point(384, 96);
            this.btnDeleteStaff.Name = "btnDeleteStaff";
            this.btnDeleteStaff.Size = new System.Drawing.Size(97, 28);
            this.btnDeleteStaff.TabIndex = 9;
            this.btnDeleteStaff.Text = "Delete";
            this.btnDeleteStaff.UseVisualStyleBackColor = true;
            this.btnDeleteStaff.Click += new System.EventHandler(this.btnDeleteStaff_Click);
            // 
            // btnMaintainStaff
            // 
            this.btnMaintainStaff.Enabled = false;
            this.btnMaintainStaff.Location = new System.Drawing.Point(384, 54);
            this.btnMaintainStaff.Name = "btnMaintainStaff";
            this.btnMaintainStaff.Size = new System.Drawing.Size(97, 28);
            this.btnMaintainStaff.TabIndex = 8;
            this.btnMaintainStaff.Text = "Maintain";
            this.btnMaintainStaff.UseVisualStyleBackColor = true;
            this.btnMaintainStaff.Click += new System.EventHandler(this.btnMaintainStaff_Click);
            // 
            // btnAddStaff
            // 
            this.btnAddStaff.Location = new System.Drawing.Point(384, 12);
            this.btnAddStaff.Name = "btnAddStaff";
            this.btnAddStaff.Size = new System.Drawing.Size(97, 28);
            this.btnAddStaff.TabIndex = 7;
            this.btnAddStaff.Text = "Add";
            this.btnAddStaff.UseVisualStyleBackColor = true;
            this.btnAddStaff.Click += new System.EventHandler(this.btnAddStaff_Click);
            // 
            // StaffControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnDeleteStaff);
            this.Controls.Add(this.btnMaintainStaff);
            this.Controls.Add(this.btnAddStaff);
            this.Controls.Add(this.lstStaff);
            this.Name = "StaffControl";
            this.Size = new System.Drawing.Size(495, 235);
            this.Load += new System.EventHandler(this.StaffControl_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lstStaff;
        private System.Windows.Forms.ColumnHeader employeeIdHeader;
        private System.Windows.Forms.ColumnHeader usernameHeader;
        private System.Windows.Forms.ColumnHeader passwordHeader;
        private System.Windows.Forms.ColumnHeader positionHeader;
        private System.Windows.Forms.Button btnDeleteStaff;
        private System.Windows.Forms.Button btnMaintainStaff;
        private System.Windows.Forms.Button btnAddStaff;
    }
}
