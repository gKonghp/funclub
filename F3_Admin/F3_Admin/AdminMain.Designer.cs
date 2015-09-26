namespace F3_Admin
{
    partial class Admin
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器
        /// 修改這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.coursePage = new System.Windows.Forms.TabPage();
            this.lstCourse = new System.Windows.Forms.ListView();
            this.CourseHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.nameHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.quotaHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
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
            this.lstCourseMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.staffPage = new System.Windows.Forms.TabPage();
            this.lstStaff = new System.Windows.Forms.ListView();
            this.employeeIdHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.usernameHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.passwordHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.positionHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lstStaffMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addStaffMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.maintainStaffMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteStaffMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.teacherPage = new System.Windows.Forms.TabPage();
            this.studentPage = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.coursePage.SuspendLayout();
            this.lstCourseMenuStrip.SuspendLayout();
            this.staffPage.SuspendLayout();
            this.lstStaffMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.coursePage);
            this.tabControl1.Controls.Add(this.staffPage);
            this.tabControl1.Controls.Add(this.teacherPage);
            this.tabControl1.Controls.Add(this.studentPage);
            this.tabControl1.Location = new System.Drawing.Point(3, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(853, 305);
            this.tabControl1.TabIndex = 0;
            // 
            // coursePage
            // 
            this.coursePage.Controls.Add(this.lstCourse);
            this.coursePage.Location = new System.Drawing.Point(4, 22);
            this.coursePage.Name = "coursePage";
            this.coursePage.Padding = new System.Windows.Forms.Padding(3);
            this.coursePage.Size = new System.Drawing.Size(845, 279);
            this.coursePage.TabIndex = 0;
            this.coursePage.Text = "Course";
            this.coursePage.UseVisualStyleBackColor = true;
            // 
            // lstCourse
            // 
            this.lstCourse.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.CourseHeader,
            this.nameHeader,
            this.quotaHeader,
            this.weekdayHeader,
            this.roomHeader,
            this.startTimeHeader,
            this.endTimeHeader,
            this.teacherRateHeader,
            this.operationChargesHeader,
            this.categoryHeader,
            this.teacherHeader,
            this.startMonthHeader,
            this.endMonthHeader});
            this.lstCourse.ContextMenuStrip = this.lstCourseMenuStrip;
            this.lstCourse.Location = new System.Drawing.Point(8, 9);
            this.lstCourse.Name = "lstCourse";
            this.lstCourse.Size = new System.Drawing.Size(831, 264);
            this.lstCourse.TabIndex = 0;
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
            // quotaHeader
            // 
            this.quotaHeader.Text = "Quota";
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
            // lstCourseMenuStrip
            // 
            this.lstCourseMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem,
            this.aToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.lstCourseMenuStrip.Name = "lstCourseMenuStrip";
            this.lstCourseMenuStrip.Size = new System.Drawing.Size(125, 70);
            this.lstCourseMenuStrip.Opening += new System.ComponentModel.CancelEventHandler(this.lstCourseMenuStrip_Opening);
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.addToolStripMenuItem.Text = "Add";
            this.addToolStripMenuItem.Click += new System.EventHandler(this.addToolStripMenuItem_Click);
            // 
            // aToolStripMenuItem
            // 
            this.aToolStripMenuItem.Name = "aToolStripMenuItem";
            this.aToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.aToolStripMenuItem.Text = "Maintain";
            this.aToolStripMenuItem.Click += new System.EventHandler(this.aToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // staffPage
            // 
            this.staffPage.Controls.Add(this.lstStaff);
            this.staffPage.Location = new System.Drawing.Point(4, 22);
            this.staffPage.Name = "staffPage";
            this.staffPage.Padding = new System.Windows.Forms.Padding(3);
            this.staffPage.Size = new System.Drawing.Size(845, 279);
            this.staffPage.TabIndex = 1;
            this.staffPage.Text = "Staff";
            this.staffPage.UseVisualStyleBackColor = true;
            // 
            // lstStaff
            // 
            this.lstStaff.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.employeeIdHeader,
            this.usernameHeader,
            this.passwordHeader,
            this.positionHeader});
            this.lstStaff.ContextMenuStrip = this.lstStaffMenuStrip1;
            this.lstStaff.Location = new System.Drawing.Point(7, 7);
            this.lstStaff.Name = "lstStaff";
            this.lstStaff.Size = new System.Drawing.Size(831, 264);
            this.lstStaff.TabIndex = 1;
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
            // lstStaffMenuStrip1
            // 
            this.lstStaffMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addStaffMenuItem,
            this.maintainStaffMenuItem,
            this.deleteStaffMenuItem});
            this.lstStaffMenuStrip1.Name = "lstCourseMenuStrip";
            this.lstStaffMenuStrip1.Size = new System.Drawing.Size(153, 92);
            this.lstStaffMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.lstStaffMenuStrip1_Opening);
            // 
            // addStaffMenuItem
            // 
            this.addStaffMenuItem.Name = "addStaffMenuItem";
            this.addStaffMenuItem.Size = new System.Drawing.Size(152, 22);
            this.addStaffMenuItem.Text = "Add";
            this.addStaffMenuItem.Click += new System.EventHandler(this.addStaffMenuItem_Click);
            // 
            // maintainStaffMenuItem
            // 
            this.maintainStaffMenuItem.Name = "maintainStaffMenuItem";
            this.maintainStaffMenuItem.Size = new System.Drawing.Size(152, 22);
            this.maintainStaffMenuItem.Text = "Maintain";
            this.maintainStaffMenuItem.Click += new System.EventHandler(this.maintainStaffMenuItem_Click);
            // 
            // deleteStaffMenuItem
            // 
            this.deleteStaffMenuItem.Name = "deleteStaffMenuItem";
            this.deleteStaffMenuItem.Size = new System.Drawing.Size(152, 22);
            this.deleteStaffMenuItem.Text = "Delete";
            this.deleteStaffMenuItem.Click += new System.EventHandler(this.deleteStaffMenuItem_Click);
            // 
            // teacherPage
            // 
            this.teacherPage.Location = new System.Drawing.Point(4, 22);
            this.teacherPage.Name = "teacherPage";
            this.teacherPage.Size = new System.Drawing.Size(845, 279);
            this.teacherPage.TabIndex = 2;
            this.teacherPage.Text = "Teacher";
            this.teacherPage.UseVisualStyleBackColor = true;
            // 
            // studentPage
            // 
            this.studentPage.Location = new System.Drawing.Point(4, 22);
            this.studentPage.Name = "studentPage";
            this.studentPage.Size = new System.Drawing.Size(845, 279);
            this.studentPage.TabIndex = 3;
            this.studentPage.Text = "Student";
            this.studentPage.UseVisualStyleBackColor = true;
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(868, 314);
            this.Controls.Add(this.tabControl1);
            this.Name = "Admin";
            this.Text = "Admin";
            this.Load += new System.EventHandler(this.Admin_Load);
            this.tabControl1.ResumeLayout(false);
            this.coursePage.ResumeLayout(false);
            this.lstCourseMenuStrip.ResumeLayout(false);
            this.staffPage.ResumeLayout(false);
            this.lstStaffMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage coursePage;
        private System.Windows.Forms.ListView lstCourse;
        private System.Windows.Forms.TabPage staffPage;
        private System.Windows.Forms.TabPage teacherPage;
        private System.Windows.Forms.TabPage studentPage;
        private System.Windows.Forms.ColumnHeader CourseHeader;
        private System.Windows.Forms.ColumnHeader nameHeader;
        private System.Windows.Forms.ColumnHeader quotaHeader;
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
        private System.Windows.Forms.ContextMenuStrip lstCourseMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem aToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ListView lstStaff;
        private System.Windows.Forms.ColumnHeader employeeIdHeader;
        private System.Windows.Forms.ColumnHeader usernameHeader;
        private System.Windows.Forms.ColumnHeader passwordHeader;
        private System.Windows.Forms.ColumnHeader positionHeader;
        private System.Windows.Forms.ContextMenuStrip lstStaffMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem addStaffMenuItem;
        private System.Windows.Forms.ToolStripMenuItem maintainStaffMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteStaffMenuItem;
    }
}

