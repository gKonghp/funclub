namespace FunHomeClub
{
    partial class CourseControl
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
            this.lstCourse = new System.Windows.Forms.ListView();
            this.CourseHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.nameHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.weekdayHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.roomHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.startTimeHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.endTimeHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.teacherRateHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.operationChargesHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.categoryHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.teacherHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.startMonthHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.endMonthHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.descHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnDeleteCourse = new System.Windows.Forms.Button();
            this.btnMaintainCourse = new System.Windows.Forms.Button();
            this.btnAddCourse = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstCourse
            // 
            this.lstCourse.BackColor = System.Drawing.SystemColors.Control;
            this.lstCourse.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.CourseHeader,
            this.nameHeader,
            this.weekdayHeader,
            this.roomHeader,
            this.startTimeHeader,
            this.endTimeHeader,
            this.teacherRateHeader,
            this.operationChargesHeader,
            this.categoryHeader,
            this.teacherHeader,
            this.startMonthHeader,
            this.endMonthHeader,
            this.descHeader});
            this.lstCourse.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lstCourse.Location = new System.Drawing.Point(13, 11);
            this.lstCourse.Name = "lstCourse";
            this.lstCourse.Size = new System.Drawing.Size(903, 238);
            this.lstCourse.TabIndex = 1;
            this.lstCourse.UseCompatibleStateImageBehavior = false;
            this.lstCourse.View = System.Windows.Forms.View.Details;
            this.lstCourse.SelectedIndexChanged += new System.EventHandler(this.lstCourse_SelectedIndexChanged);
            // 
            // CourseHeader
            // 
            this.CourseHeader.Text = "CourseID";
            // 
            // nameHeader
            // 
            this.nameHeader.Text = "Name";
            // 
            // weekdayHeader
            // 
            this.weekdayHeader.Text = "WeekDay";
            // 
            // roomHeader
            // 
            this.roomHeader.Text = "Room";
            // 
            // startTimeHeader
            // 
            this.startTimeHeader.Text = "StartTime";
            // 
            // endTimeHeader
            // 
            this.endTimeHeader.Text = "EndTime";
            // 
            // teacherRateHeader
            // 
            this.teacherRateHeader.Text = "TeacherRate";
            this.teacherRateHeader.Width = 80;
            // 
            // operationChargesHeader
            // 
            this.operationChargesHeader.Text = "OperationCharges";
            // 
            // categoryHeader
            // 
            this.categoryHeader.Text = "CategoryName";
            // 
            // teacherHeader
            // 
            this.teacherHeader.Text = "TeacherName";
            this.teacherHeader.Width = 85;
            // 
            // startMonthHeader
            // 
            this.startMonthHeader.Text = "StartMonth";
            // 
            // endMonthHeader
            // 
            this.endMonthHeader.Text = "EndMonth";
            this.endMonthHeader.Width = 64;
            // 
            // descHeader
            // 
            this.descHeader.Text = "Description";
            this.descHeader.Width = 70;
            // 
            // btnDeleteCourse
            // 
            this.btnDeleteCourse.BackColor = System.Drawing.Color.Coral;
            this.btnDeleteCourse.Enabled = false;
            this.btnDeleteCourse.FlatAppearance.BorderSize = 0;
            this.btnDeleteCourse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteCourse.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnDeleteCourse.ForeColor = System.Drawing.Color.White;
            this.btnDeleteCourse.Location = new System.Drawing.Point(818, 255);
            this.btnDeleteCourse.Name = "btnDeleteCourse";
            this.btnDeleteCourse.Size = new System.Drawing.Size(97, 26);
            this.btnDeleteCourse.TabIndex = 6;
            this.btnDeleteCourse.Text = "Delete";
            this.btnDeleteCourse.UseVisualStyleBackColor = false;
            this.btnDeleteCourse.Click += new System.EventHandler(this.btnDeleteCourse_Click);
            // 
            // btnMaintainCourse
            // 
            this.btnMaintainCourse.BackColor = System.Drawing.Color.Coral;
            this.btnMaintainCourse.Enabled = false;
            this.btnMaintainCourse.FlatAppearance.BorderSize = 0;
            this.btnMaintainCourse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaintainCourse.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnMaintainCourse.ForeColor = System.Drawing.Color.White;
            this.btnMaintainCourse.Location = new System.Drawing.Point(715, 255);
            this.btnMaintainCourse.Name = "btnMaintainCourse";
            this.btnMaintainCourse.Size = new System.Drawing.Size(97, 26);
            this.btnMaintainCourse.TabIndex = 5;
            this.btnMaintainCourse.Text = "Maintain";
            this.btnMaintainCourse.UseVisualStyleBackColor = false;
            this.btnMaintainCourse.Click += new System.EventHandler(this.btnMaintainCourse_Click);
            // 
            // btnAddCourse
            // 
            this.btnAddCourse.BackColor = System.Drawing.Color.Coral;
            this.btnAddCourse.FlatAppearance.BorderSize = 0;
            this.btnAddCourse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddCourse.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnAddCourse.ForeColor = System.Drawing.Color.White;
            this.btnAddCourse.Location = new System.Drawing.Point(612, 255);
            this.btnAddCourse.Name = "btnAddCourse";
            this.btnAddCourse.Size = new System.Drawing.Size(97, 26);
            this.btnAddCourse.TabIndex = 4;
            this.btnAddCourse.Text = "Add";
            this.btnAddCourse.UseVisualStyleBackColor = false;
            this.btnAddCourse.Click += new System.EventHandler(this.btnAddCourse_Click);
            // 
            // CourseControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnDeleteCourse);
            this.Controls.Add(this.btnMaintainCourse);
            this.Controls.Add(this.btnAddCourse);
            this.Controls.Add(this.lstCourse);
            this.Name = "CourseControl";
            this.Size = new System.Drawing.Size(930, 286);
            this.Load += new System.EventHandler(this.CourseControl_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lstCourse;
        private System.Windows.Forms.ColumnHeader CourseHeader;
        private System.Windows.Forms.ColumnHeader nameHeader;
        private System.Windows.Forms.ColumnHeader weekdayHeader;
        private System.Windows.Forms.ColumnHeader roomHeader;
        private System.Windows.Forms.ColumnHeader startTimeHeader;
        private System.Windows.Forms.ColumnHeader endTimeHeader;
        private System.Windows.Forms.ColumnHeader teacherRateHeader;
        private System.Windows.Forms.ColumnHeader operationChargesHeader;
        private System.Windows.Forms.ColumnHeader categoryHeader;
        private System.Windows.Forms.ColumnHeader teacherHeader;
        private System.Windows.Forms.ColumnHeader startMonthHeader;
        private System.Windows.Forms.ColumnHeader endMonthHeader;
        private System.Windows.Forms.ColumnHeader descHeader;
        private System.Windows.Forms.Button btnDeleteCourse;
        private System.Windows.Forms.Button btnMaintainCourse;
        private System.Windows.Forms.Button btnAddCourse;
    }
}
