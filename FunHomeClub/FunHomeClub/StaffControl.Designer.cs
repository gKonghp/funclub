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
            this.btnDeleteStaff = new XButton();
            this.btnMaintainStaff = new XButton();
            this.btnAddStaff = new XButton();
            this.SuspendLayout();
            // 
            // lstStaff
            // 
            this.lstStaff.BackColor = System.Drawing.SystemColors.Control;
            this.lstStaff.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.employeeIdHeader,
            this.usernameHeader,
            this.passwordHeader,
            this.positionHeader});
            this.lstStaff.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lstStaff.Location = new System.Drawing.Point(13, 11);
            this.lstStaff.Name = "lstStaff";
            this.lstStaff.Size = new System.Drawing.Size(351, 195);
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
            this.btnDeleteStaff.BackColor = System.Drawing.Color.Coral;
            this.btnDeleteStaff.Enabled = false;
            this.btnDeleteStaff.FlatAppearance.BorderSize = 0;
            this.btnDeleteStaff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteStaff.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnDeleteStaff.ForeColor = System.Drawing.Color.White;
            this.btnDeleteStaff.Location = new System.Drawing.Point(384, 89);
            this.btnDeleteStaff.Name = "btnDeleteStaff";
            this.btnDeleteStaff.Size = new System.Drawing.Size(97, 26);
            this.btnDeleteStaff.TabIndex = 9;
            this.btnDeleteStaff.Text = "Delete";
            this.btnDeleteStaff.UseVisualStyleBackColor = false;
            this.btnDeleteStaff.Click += new System.EventHandler(this.btnDeleteStaff_Click);
            // 
            // btnMaintainStaff
            // 
            this.btnMaintainStaff.BackColor = System.Drawing.Color.Coral;
            this.btnMaintainStaff.Enabled = false;
            this.btnMaintainStaff.FlatAppearance.BorderSize = 0;
            this.btnMaintainStaff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaintainStaff.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnMaintainStaff.ForeColor = System.Drawing.Color.White;
            this.btnMaintainStaff.Location = new System.Drawing.Point(384, 50);
            this.btnMaintainStaff.Name = "btnMaintainStaff";
            this.btnMaintainStaff.Size = new System.Drawing.Size(97, 26);
            this.btnMaintainStaff.TabIndex = 8;
            this.btnMaintainStaff.Text = "Maintain";
            this.btnMaintainStaff.UseVisualStyleBackColor = false;
            this.btnMaintainStaff.Click += new System.EventHandler(this.btnMaintainStaff_Click);
            // 
            // btnAddStaff
            // 
            this.btnAddStaff.BackColor = System.Drawing.Color.Coral;
            this.btnAddStaff.FlatAppearance.BorderSize = 0;
            this.btnAddStaff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddStaff.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnAddStaff.ForeColor = System.Drawing.Color.White;
            this.btnAddStaff.Location = new System.Drawing.Point(384, 11);
            this.btnAddStaff.Name = "btnAddStaff";
            this.btnAddStaff.Size = new System.Drawing.Size(97, 26);
            this.btnAddStaff.TabIndex = 7;
            this.btnAddStaff.Text = "Add";
            this.btnAddStaff.UseVisualStyleBackColor = false;
            this.btnAddStaff.Click += new System.EventHandler(this.btnAddStaff_Click);
            // 
            // StaffControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnDeleteStaff);
            this.Controls.Add(this.btnMaintainStaff);
            this.Controls.Add(this.btnAddStaff);
            this.Controls.Add(this.lstStaff);
            this.Name = "StaffControl";
            this.Size = new System.Drawing.Size(495, 217);
            this.Load += new System.EventHandler(this.StaffControl_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lstStaff;
        private System.Windows.Forms.ColumnHeader employeeIdHeader;
        private System.Windows.Forms.ColumnHeader usernameHeader;
        private System.Windows.Forms.ColumnHeader passwordHeader;
        private System.Windows.Forms.ColumnHeader positionHeader;
        private XButton btnDeleteStaff;
        private XButton btnMaintainStaff;
        private XButton btnAddStaff;
    }
}
