namespace FunHomeClub
{
    partial class CourseRegForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnRegister = new System.Windows.Forms.Button();
            this.txtStudentID = new System.Windows.Forms.TextBox();
            this.lblStudentID = new System.Windows.Forms.Label();
            this.ltvRegCourseDetail = new System.Windows.Forms.ListView();
            this.CourseID_r = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Weekday_r = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.StartMonth_r = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.EndMonth_r = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblRegCourseDetail = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.gpbStudentInfo = new System.Windows.Forms.GroupBox();
            this.lblEmailAddress_d = new System.Windows.Forms.Label();
            this.lblContactNum_d = new System.Windows.Forms.Label();
            this.lblMembership_d = new System.Windows.Forms.Label();
            this.lblStudName_d = new System.Windows.Forms.Label();
            this.lblEmailAddress = new System.Windows.Forms.Label();
            this.lblContactNum = new System.Windows.Forms.Label();
            this.lblMembership = new System.Windows.Forms.Label();
            this.lblStudentName = new System.Windows.Forms.Label();
            this.gpbCourseReg = new System.Windows.Forms.GroupBox();
            this.lblTotal_d = new System.Windows.Forms.Label();
            this.lblDiscount_d = new System.Windows.Forms.Label();
            this.lblOriginalTotal_d = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblDiscount = new System.Windows.Forms.Label();
            this.lblOriginalTotal = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnView = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.ltvRegCourseList = new System.Windows.Forms.ListView();
            this.Category = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CourseID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CourseName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Weekday = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.StartMonth = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.EndMonth = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.StartTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.EndTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Price = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Quota = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Room = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnCancel = new System.Windows.Forms.Button();
            this.llbRegStudent = new System.Windows.Forms.LinkLabel();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnStudIDEnter = new System.Windows.Forms.Button();
            this.masterDBDataSet = new FunHomeClub.res.db.masterDBDataSet();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.gpbStudentInfo.SuspendLayout();
            this.gpbCourseReg.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.masterDBDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRegister
            // 
            this.btnRegister.Enabled = false;
            this.btnRegister.Location = new System.Drawing.Point(656, 277);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(75, 24);
            this.btnRegister.TabIndex = 0;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // txtStudentID
            // 
            this.txtStudentID.Location = new System.Drawing.Point(86, 10);
            this.txtStudentID.Name = "txtStudentID";
            this.txtStudentID.Size = new System.Drawing.Size(100, 22);
            this.txtStudentID.TabIndex = 2;
            // 
            // lblStudentID
            // 
            this.lblStudentID.AutoSize = true;
            this.lblStudentID.Location = new System.Drawing.Point(19, 15);
            this.lblStudentID.Name = "lblStudentID";
            this.lblStudentID.Size = new System.Drawing.Size(61, 12);
            this.lblStudentID.TabIndex = 5;
            this.lblStudentID.Text = "Student ID: ";
            // 
            // ltvRegCourseDetail
            // 
            this.ltvRegCourseDetail.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.CourseID_r,
            this.columnHeader11,
            this.columnHeader2,
            this.Weekday_r,
            this.columnHeader4,
            this.columnHeader6,
            this.columnHeader7,
            this.StartMonth_r,
            this.EndMonth_r,
            this.columnHeader10});
            this.ltvRegCourseDetail.FullRowSelect = true;
            this.ltvRegCourseDetail.GridLines = true;
            this.ltvRegCourseDetail.Location = new System.Drawing.Point(10, 79);
            this.ltvRegCourseDetail.MultiSelect = false;
            this.ltvRegCourseDetail.Name = "ltvRegCourseDetail";
            this.ltvRegCourseDetail.Size = new System.Drawing.Size(332, 135);
            this.ltvRegCourseDetail.TabIndex = 6;
            this.ltvRegCourseDetail.UseCompatibleStateImageBehavior = false;
            this.ltvRegCourseDetail.View = System.Windows.Forms.View.Details;
            this.ltvRegCourseDetail.DoubleClick += new System.EventHandler(this.ltvRegCourseDetail_DoubleClick);
            // 
            // CourseID_r
            // 
            this.CourseID_r.Text = "CourseID";
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "Category";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Name";
            // 
            // Weekday_r
            // 
            this.Weekday_r.Text = "Weekday";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Room";
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Start Time";
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "End Time";
            // 
            // StartMonth_r
            // 
            this.StartMonth_r.Text = "Start Month";
            // 
            // EndMonth_r
            // 
            this.EndMonth_r.Text = "End Month";
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Teacher";
            // 
            // lblRegCourseDetail
            // 
            this.lblRegCourseDetail.AutoSize = true;
            this.lblRegCourseDetail.Location = new System.Drawing.Point(8, 64);
            this.lblRegCourseDetail.Name = "lblRegCourseDetail";
            this.lblRegCourseDetail.Size = new System.Drawing.Size(143, 12);
            this.lblRegCourseDetail.TabIndex = 7;
            this.lblRegCourseDetail.Text = "The registered courses details:";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(12, 45);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.gpbStudentInfo);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.gpbCourseReg);
            this.splitContainer1.Size = new System.Drawing.Size(719, 226);
            this.splitContainer1.SplitterDistance = 367;
            this.splitContainer1.TabIndex = 8;
            // 
            // gpbStudentInfo
            // 
            this.gpbStudentInfo.Controls.Add(this.lblEmailAddress_d);
            this.gpbStudentInfo.Controls.Add(this.lblContactNum_d);
            this.gpbStudentInfo.Controls.Add(this.lblMembership_d);
            this.gpbStudentInfo.Controls.Add(this.lblStudName_d);
            this.gpbStudentInfo.Controls.Add(this.lblEmailAddress);
            this.gpbStudentInfo.Controls.Add(this.lblContactNum);
            this.gpbStudentInfo.Controls.Add(this.lblMembership);
            this.gpbStudentInfo.Controls.Add(this.lblStudentName);
            this.gpbStudentInfo.Controls.Add(this.lblRegCourseDetail);
            this.gpbStudentInfo.Controls.Add(this.ltvRegCourseDetail);
            this.gpbStudentInfo.Location = new System.Drawing.Point(3, 3);
            this.gpbStudentInfo.Name = "gpbStudentInfo";
            this.gpbStudentInfo.Size = new System.Drawing.Size(348, 220);
            this.gpbStudentInfo.TabIndex = 8;
            this.gpbStudentInfo.TabStop = false;
            this.gpbStudentInfo.Text = "Student Information";
            // 
            // lblEmailAddress_d
            // 
            this.lblEmailAddress_d.AutoSize = true;
            this.lblEmailAddress_d.Location = new System.Drawing.Point(271, 45);
            this.lblEmailAddress_d.Name = "lblEmailAddress_d";
            this.lblEmailAddress_d.Size = new System.Drawing.Size(13, 12);
            this.lblEmailAddress_d.TabIndex = 15;
            this.lblEmailAddress_d.Text = "--";
            // 
            // lblContactNum_d
            // 
            this.lblContactNum_d.AutoSize = true;
            this.lblContactNum_d.Location = new System.Drawing.Point(271, 21);
            this.lblContactNum_d.Name = "lblContactNum_d";
            this.lblContactNum_d.Size = new System.Drawing.Size(13, 12);
            this.lblContactNum_d.TabIndex = 14;
            this.lblContactNum_d.Text = "--";
            // 
            // lblMembership_d
            // 
            this.lblMembership_d.AutoSize = true;
            this.lblMembership_d.Location = new System.Drawing.Point(97, 45);
            this.lblMembership_d.Name = "lblMembership_d";
            this.lblMembership_d.Size = new System.Drawing.Size(13, 12);
            this.lblMembership_d.TabIndex = 13;
            this.lblMembership_d.Text = "--";
            // 
            // lblStudName_d
            // 
            this.lblStudName_d.AutoSize = true;
            this.lblStudName_d.Location = new System.Drawing.Point(97, 22);
            this.lblStudName_d.Name = "lblStudName_d";
            this.lblStudName_d.Size = new System.Drawing.Size(13, 12);
            this.lblStudName_d.TabIndex = 12;
            this.lblStudName_d.Text = "--";
            // 
            // lblEmailAddress
            // 
            this.lblEmailAddress.AutoSize = true;
            this.lblEmailAddress.Location = new System.Drawing.Point(179, 45);
            this.lblEmailAddress.Name = "lblEmailAddress";
            this.lblEmailAddress.Size = new System.Drawing.Size(75, 12);
            this.lblEmailAddress.TabIndex = 11;
            this.lblEmailAddress.Text = "Email Address:";
            // 
            // lblContactNum
            // 
            this.lblContactNum.AutoSize = true;
            this.lblContactNum.Location = new System.Drawing.Point(179, 22);
            this.lblContactNum.Name = "lblContactNum";
            this.lblContactNum.Size = new System.Drawing.Size(85, 12);
            this.lblContactNum.TabIndex = 10;
            this.lblContactNum.Text = "Contact Number:";
            // 
            // lblMembership
            // 
            this.lblMembership.AutoSize = true;
            this.lblMembership.Location = new System.Drawing.Point(8, 45);
            this.lblMembership.Name = "lblMembership";
            this.lblMembership.Size = new System.Drawing.Size(66, 12);
            this.lblMembership.TabIndex = 9;
            this.lblMembership.Text = "Membership:";
            // 
            // lblStudentName
            // 
            this.lblStudentName.AutoSize = true;
            this.lblStudentName.Location = new System.Drawing.Point(8, 22);
            this.lblStudentName.Name = "lblStudentName";
            this.lblStudentName.Size = new System.Drawing.Size(73, 12);
            this.lblStudentName.TabIndex = 8;
            this.lblStudentName.Text = "Student Name:";
            // 
            // gpbCourseReg
            // 
            this.gpbCourseReg.Controls.Add(this.lblTotal_d);
            this.gpbCourseReg.Controls.Add(this.lblDiscount_d);
            this.gpbCourseReg.Controls.Add(this.lblOriginalTotal_d);
            this.gpbCourseReg.Controls.Add(this.lblTotal);
            this.gpbCourseReg.Controls.Add(this.lblDiscount);
            this.gpbCourseReg.Controls.Add(this.lblOriginalTotal);
            this.gpbCourseReg.Controls.Add(this.btnClear);
            this.gpbCourseReg.Controls.Add(this.btnView);
            this.gpbCourseReg.Controls.Add(this.btnDel);
            this.gpbCourseReg.Controls.Add(this.btnAdd);
            this.gpbCourseReg.Controls.Add(this.ltvRegCourseList);
            this.gpbCourseReg.Location = new System.Drawing.Point(3, 3);
            this.gpbCourseReg.Name = "gpbCourseReg";
            this.gpbCourseReg.Size = new System.Drawing.Size(342, 220);
            this.gpbCourseReg.TabIndex = 11;
            this.gpbCourseReg.TabStop = false;
            this.gpbCourseReg.Text = "Course Registration";
            // 
            // lblTotal_d
            // 
            this.lblTotal_d.AutoSize = true;
            this.lblTotal_d.Location = new System.Drawing.Point(93, 190);
            this.lblTotal_d.Name = "lblTotal_d";
            this.lblTotal_d.Size = new System.Drawing.Size(13, 12);
            this.lblTotal_d.TabIndex = 19;
            this.lblTotal_d.Text = "--";
            // 
            // lblDiscount_d
            // 
            this.lblDiscount_d.AutoSize = true;
            this.lblDiscount_d.Location = new System.Drawing.Point(257, 166);
            this.lblDiscount_d.Name = "lblDiscount_d";
            this.lblDiscount_d.Size = new System.Drawing.Size(13, 12);
            this.lblDiscount_d.TabIndex = 18;
            this.lblDiscount_d.Text = "--";
            // 
            // lblOriginalTotal_d
            // 
            this.lblOriginalTotal_d.AutoSize = true;
            this.lblOriginalTotal_d.Location = new System.Drawing.Point(93, 166);
            this.lblOriginalTotal_d.Name = "lblOriginalTotal_d";
            this.lblOriginalTotal_d.Size = new System.Drawing.Size(13, 12);
            this.lblOriginalTotal_d.TabIndex = 17;
            this.lblOriginalTotal_d.Text = "--";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(6, 190);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(32, 12);
            this.lblTotal.TabIndex = 16;
            this.lblTotal.Text = "Total:";
            // 
            // lblDiscount
            // 
            this.lblDiscount.AutoSize = true;
            this.lblDiscount.Location = new System.Drawing.Point(202, 166);
            this.lblDiscount.Name = "lblDiscount";
            this.lblDiscount.Size = new System.Drawing.Size(49, 12);
            this.lblDiscount.TabIndex = 15;
            this.lblDiscount.Text = "Discount:";
            // 
            // lblOriginalTotal
            // 
            this.lblOriginalTotal.AutoSize = true;
            this.lblOriginalTotal.Location = new System.Drawing.Point(6, 166);
            this.lblOriginalTotal.Name = "lblOriginalTotal";
            this.lblOriginalTotal.Size = new System.Drawing.Size(73, 12);
            this.lblOriginalTotal.TabIndex = 14;
            this.lblOriginalTotal.Text = "Original Total:";
            // 
            // btnClear
            // 
            this.btnClear.Enabled = false;
            this.btnClear.Location = new System.Drawing.Point(257, 16);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 13;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnView
            // 
            this.btnView.Enabled = false;
            this.btnView.Location = new System.Drawing.Point(95, 16);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(75, 23);
            this.btnView.TabIndex = 12;
            this.btnView.Text = "View";
            this.btnView.UseVisualStyleBackColor = true;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // btnDel
            // 
            this.btnDel.Enabled = false;
            this.btnDel.Location = new System.Drawing.Point(176, 16);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(75, 23);
            this.btnDel.TabIndex = 11;
            this.btnDel.Text = "Del";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Enabled = false;
            this.btnAdd.Location = new System.Drawing.Point(14, 16);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 10;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // ltvRegCourseList
            // 
            this.ltvRegCourseList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Category,
            this.CourseID,
            this.CourseName,
            this.Weekday,
            this.StartMonth,
            this.EndMonth,
            this.StartTime,
            this.EndTime,
            this.Price,
            this.Quota,
            this.Room});
            this.ltvRegCourseList.FullRowSelect = true;
            this.ltvRegCourseList.GridLines = true;
            this.ltvRegCourseList.Location = new System.Drawing.Point(6, 45);
            this.ltvRegCourseList.Name = "ltvRegCourseList";
            this.ltvRegCourseList.Size = new System.Drawing.Size(330, 112);
            this.ltvRegCourseList.TabIndex = 9;
            this.ltvRegCourseList.UseCompatibleStateImageBehavior = false;
            this.ltvRegCourseList.View = System.Windows.Forms.View.Details;
            this.ltvRegCourseList.DoubleClick += new System.EventHandler(this.ltvRegCourseList_DoubleClick);
            // 
            // Category
            // 
            this.Category.Text = "Category";
            // 
            // CourseID
            // 
            this.CourseID.Text = "CourseID";
            // 
            // CourseName
            // 
            this.CourseName.Text = "Name";
            // 
            // Weekday
            // 
            this.Weekday.Text = "Week Day";
            // 
            // StartMonth
            // 
            this.StartMonth.Text = "Start Month";
            // 
            // EndMonth
            // 
            this.EndMonth.Text = "End Month";
            // 
            // StartTime
            // 
            this.StartTime.Text = "Start Time";
            // 
            // EndTime
            // 
            this.EndTime.Text = "End Time";
            // 
            // Price
            // 
            this.Price.Text = "Price";
            // 
            // Quota
            // 
            this.Quota.Text = "Quota";
            // 
            // Room
            // 
            this.Room.Text = "Room";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(574, 277);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 24);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // llbRegStudent
            // 
            this.llbRegStudent.AutoSize = true;
            this.llbRegStudent.Location = new System.Drawing.Point(356, 16);
            this.llbRegStudent.Name = "llbRegStudent";
            this.llbRegStudent.Size = new System.Drawing.Size(101, 12);
            this.llbRegStudent.TabIndex = 9;
            this.llbRegStudent.TabStop = true;
            this.llbRegStudent.Text = "Register new student";
            this.llbRegStudent.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbRegStudent_LinkClicked);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(273, 8);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 24);
            this.btnReset.TabIndex = 10;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnStudIDEnter
            // 
            this.btnStudIDEnter.Location = new System.Drawing.Point(192, 9);
            this.btnStudIDEnter.Name = "btnStudIDEnter";
            this.btnStudIDEnter.Size = new System.Drawing.Size(75, 23);
            this.btnStudIDEnter.TabIndex = 11;
            this.btnStudIDEnter.Text = "Enter";
            this.btnStudIDEnter.UseVisualStyleBackColor = true;
            this.btnStudIDEnter.Click += new System.EventHandler(this.btnStudIDEnter_Click);
            // 
            // masterDBDataSet
            // 
            this.masterDBDataSet.DataSetName = "masterDBDataSet";
            this.masterDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // CourseRegForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(753, 310);
            this.Controls.Add(this.btnStudIDEnter);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.llbRegStudent);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.lblStudentID);
            this.Controls.Add(this.txtStudentID);
            this.Controls.Add(this.btnRegister);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CourseRegForm";
            this.Text = "RegCourse";
            this.Load += new System.EventHandler(this.RegCourse_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.gpbStudentInfo.ResumeLayout(false);
            this.gpbStudentInfo.PerformLayout();
            this.gpbCourseReg.ResumeLayout(false);
            this.gpbCourseReg.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.masterDBDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.TextBox txtStudentID;
        private res.db.masterDBDataSet masterDBDataSet;
        private System.Windows.Forms.Label lblStudentID;
        public System.Windows.Forms.ListView ltvRegCourseDetail;
        private System.Windows.Forms.Label lblRegCourseDetail;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox gpbStudentInfo;
        private System.Windows.Forms.Label lblMembership;
        private System.Windows.Forms.Label lblStudentName;
        private System.Windows.Forms.GroupBox gpbCourseReg;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnAdd;
        public System.Windows.Forms.ListView ltvRegCourseList;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.LinkLabel llbRegStudent;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label lblEmailAddress;
        private System.Windows.Forms.Label lblContactNum;
        private System.Windows.Forms.Label lblOriginalTotal;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnStudIDEnter;
        public System.Windows.Forms.Label lblStudName_d;
        public System.Windows.Forms.Label lblEmailAddress_d;
        public System.Windows.Forms.Label lblContactNum_d;
        public System.Windows.Forms.Label lblMembership_d;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblDiscount;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ColumnHeader CourseID_r;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader Weekday_r;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader StartMonth_r;
        private System.Windows.Forms.ColumnHeader EndMonth_r;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader Category;
        private System.Windows.Forms.ColumnHeader CourseName;
        private System.Windows.Forms.ColumnHeader CourseID;
        private System.Windows.Forms.ColumnHeader Weekday;
        private System.Windows.Forms.ColumnHeader StartMonth;
        private System.Windows.Forms.ColumnHeader EndMonth;
        private System.Windows.Forms.ColumnHeader StartTime;
        private System.Windows.Forms.ColumnHeader EndTime;
        private System.Windows.Forms.ColumnHeader Quota;
        private System.Windows.Forms.ColumnHeader Room;
        private System.Windows.Forms.ColumnHeader Price;
        public System.Windows.Forms.Label lblTotal_d;
        public System.Windows.Forms.Label lblDiscount_d;
        public System.Windows.Forms.Label lblOriginalTotal_d;
    }
}