namespace FunHomeClub
{
    partial class TeacherControl
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
            this.lstTeacher = new System.Windows.Forms.ListView();
            this.TeacherIDHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TeacherNameHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TeacherGenderHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TeacherContactHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnDeleteTeacher = new XButton();
            this.btnMaintainTeacher = new XButton();
            this.btnAddTeacher = new XButton();
            this.SuspendLayout();
            // 
            // lstTeacher
            // 
            this.lstTeacher.BackColor = System.Drawing.SystemColors.Control;
            this.lstTeacher.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.TeacherIDHeader,
            this.TeacherNameHeader,
            this.TeacherGenderHeader,
            this.TeacherContactHeader});
            this.lstTeacher.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lstTeacher.Location = new System.Drawing.Point(12, 11);
            this.lstTeacher.Name = "lstTeacher";
            this.lstTeacher.Size = new System.Drawing.Size(363, 238);
            this.lstTeacher.TabIndex = 3;
            this.lstTeacher.UseCompatibleStateImageBehavior = false;
            this.lstTeacher.View = System.Windows.Forms.View.Details;
            this.lstTeacher.SelectedIndexChanged += new System.EventHandler(this.lstTeacher_SelectedIndexChanged);
            // 
            // TeacherIDHeader
            // 
            this.TeacherIDHeader.Text = "teacherID";
            this.TeacherIDHeader.Width = 96;
            // 
            // TeacherNameHeader
            // 
            this.TeacherNameHeader.Text = "Name";
            this.TeacherNameHeader.Width = 95;
            // 
            // TeacherGenderHeader
            // 
            this.TeacherGenderHeader.Text = "Gender";
            this.TeacherGenderHeader.Width = 85;
            // 
            // TeacherContactHeader
            // 
            this.TeacherContactHeader.Text = "Contact";
            this.TeacherContactHeader.Width = 74;
            // 
            // btnDeleteTeacher
            // 
            this.btnDeleteTeacher.BackColor = System.Drawing.Color.Coral;
            this.btnDeleteTeacher.Enabled = false;
            this.btnDeleteTeacher.FlatAppearance.BorderSize = 0;
            this.btnDeleteTeacher.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteTeacher.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnDeleteTeacher.ForeColor = System.Drawing.Color.White;
            this.btnDeleteTeacher.Location = new System.Drawing.Point(395, 95);
            this.btnDeleteTeacher.Name = "btnDeleteTeacher";
            this.btnDeleteTeacher.Size = new System.Drawing.Size(97, 26);
            this.btnDeleteTeacher.TabIndex = 12;
            this.btnDeleteTeacher.Text = "Delete";
            this.btnDeleteTeacher.UseVisualStyleBackColor = false;
            this.btnDeleteTeacher.Click += new System.EventHandler(this.btnDeleteTeacher_Click);
            // 
            // btnMaintainTeacher
            // 
            this.btnMaintainTeacher.BackColor = System.Drawing.Color.Coral;
            this.btnMaintainTeacher.Enabled = false;
            this.btnMaintainTeacher.FlatAppearance.BorderSize = 0;
            this.btnMaintainTeacher.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaintainTeacher.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnMaintainTeacher.ForeColor = System.Drawing.Color.White;
            this.btnMaintainTeacher.Location = new System.Drawing.Point(395, 54);
            this.btnMaintainTeacher.Name = "btnMaintainTeacher";
            this.btnMaintainTeacher.Size = new System.Drawing.Size(97, 26);
            this.btnMaintainTeacher.TabIndex = 11;
            this.btnMaintainTeacher.Text = "Maintain";
            this.btnMaintainTeacher.UseVisualStyleBackColor = false;
            this.btnMaintainTeacher.Click += new System.EventHandler(this.btnMaintainTeacher_Click);
            // 
            // btnAddTeacher
            // 
            this.btnAddTeacher.BackColor = System.Drawing.Color.Coral;
            this.btnAddTeacher.FlatAppearance.BorderSize = 0;
            this.btnAddTeacher.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddTeacher.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnAddTeacher.ForeColor = System.Drawing.Color.White;
            this.btnAddTeacher.Location = new System.Drawing.Point(395, 11);
            this.btnAddTeacher.Name = "btnAddTeacher";
            this.btnAddTeacher.Size = new System.Drawing.Size(97, 26);
            this.btnAddTeacher.TabIndex = 10;
            this.btnAddTeacher.Text = "Add";
            this.btnAddTeacher.UseVisualStyleBackColor = false;
            this.btnAddTeacher.Click += new System.EventHandler(this.btnAddTeacher_Click);
            // 
            // TeacherControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnDeleteTeacher);
            this.Controls.Add(this.btnMaintainTeacher);
            this.Controls.Add(this.btnAddTeacher);
            this.Controls.Add(this.lstTeacher);
            this.Name = "TeacherControl";
            this.Size = new System.Drawing.Size(504, 261);
            this.Load += new System.EventHandler(this.TeacherControl_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lstTeacher;
        private System.Windows.Forms.ColumnHeader TeacherIDHeader;
        private System.Windows.Forms.ColumnHeader TeacherNameHeader;
        private System.Windows.Forms.ColumnHeader TeacherGenderHeader;
        private System.Windows.Forms.ColumnHeader TeacherContactHeader;
        private XButton btnDeleteTeacher;
        private XButton btnMaintainTeacher;
        private XButton btnAddTeacher;
    }
}
