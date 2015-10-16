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
            this.txtStudentID = new System.Windows.Forms.TextBox();
            this.lblStudentID = new System.Windows.Forms.Label();
            this.ltvRegCourseDetail = new System.Windows.Forms.ListView();
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CourseID_r = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Weekday_r = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.StartMonth_r = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.startPeriod_r = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
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
            this.ltvRegCourseList = new System.Windows.Forms.ListView();
            this.Category = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CourseID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CourseName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Weekday = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.StartMonth = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.StartTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.StartPeriod = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Price = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Room = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblTotal_d = new System.Windows.Forms.Label();
            this.lblDiscount_d = new System.Windows.Forms.Label();
            this.lblOriginalTotal_d = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblDiscount = new System.Windows.Forms.Label();
            this.lblOriginalTotal = new System.Windows.Forms.Label();
            this.llbRegStudent = new System.Windows.Forms.LinkLabel();
            this.masterDBDataSet = new FunHomeClub.res.db.masterDBDataSet();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblPromotionDiscount_d = new System.Windows.Forms.Label();
            this.lblPromotionDiscount = new System.Windows.Forms.Label();
            this.lblPromotionName_d = new System.Windows.Forms.Label();
            this.lblPromotionID_d = new System.Windows.Forms.Label();
            this.lblPromotionName = new System.Windows.Forms.Label();
            this.lblPromotionID = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnDiscountView = new FunHomeClub.XButton();
            this.btnDiscountClear = new FunHomeClub.XButton();
            this.btnDiscountAdd = new FunHomeClub.XButton();
            this.btnStudIDEnter = new FunHomeClub.XButton();
            this.btnReset = new FunHomeClub.XButton();
            this.btnCancel = new FunHomeClub.XButton();
            this.btnClear = new FunHomeClub.XButton();
            this.btnView = new FunHomeClub.XButton();
            this.btnDel = new FunHomeClub.XButton();
            this.btnAdd = new FunHomeClub.XButton();
            this.btnRegister = new FunHomeClub.XButton();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.gpbStudentInfo.SuspendLayout();
            this.gpbCourseReg.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.masterDBDataSet)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtStudentID
            // 
            this.txtStudentID.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtStudentID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtStudentID.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtStudentID.Location = new System.Drawing.Point(115, 83);
            this.txtStudentID.Name = "txtStudentID";
            this.txtStudentID.Size = new System.Drawing.Size(100, 22);
            this.txtStudentID.TabIndex = 2;
            this.txtStudentID.TextChanged += new System.EventHandler(this.txtStudentID_TextChanged);
            // 
            // lblStudentID
            // 
            this.lblStudentID.AutoSize = true;
            this.lblStudentID.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblStudentID.Location = new System.Drawing.Point(10, 86);
            this.lblStudentID.Name = "lblStudentID";
            this.lblStudentID.Size = new System.Drawing.Size(90, 19);
            this.lblStudentID.TabIndex = 5;
            this.lblStudentID.Text = "Student ID: ";
            // 
            // ltvRegCourseDetail
            // 
            this.ltvRegCourseDetail.AutoArrange = false;
            this.ltvRegCourseDetail.BackColor = System.Drawing.SystemColors.Control;
            this.ltvRegCourseDetail.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader11,
            this.CourseID_r,
            this.columnHeader2,
            this.Weekday_r,
            this.StartMonth_r,
            this.columnHeader6,
            this.startPeriod_r,
            this.columnHeader4,
            this.columnHeader10});
            this.ltvRegCourseDetail.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ltvRegCourseDetail.FullRowSelect = true;
            this.ltvRegCourseDetail.GridLines = true;
            this.ltvRegCourseDetail.Location = new System.Drawing.Point(10, 85);
            this.ltvRegCourseDetail.MultiSelect = false;
            this.ltvRegCourseDetail.Name = "ltvRegCourseDetail";
            this.ltvRegCourseDetail.Size = new System.Drawing.Size(680, 81);
            this.ltvRegCourseDetail.TabIndex = 6;
            this.ltvRegCourseDetail.UseCompatibleStateImageBehavior = false;
            this.ltvRegCourseDetail.View = System.Windows.Forms.View.Details;
            this.ltvRegCourseDetail.DoubleClick += new System.EventHandler(this.ltvRegCourseDetail_DoubleClick);
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "Category";
            this.columnHeader11.Width = 79;
            // 
            // CourseID_r
            // 
            this.CourseID_r.Text = "CourseID";
            this.CourseID_r.Width = 71;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Course Name";
            this.columnHeader2.Width = 96;
            // 
            // Weekday_r
            // 
            this.Weekday_r.Text = "Weekday";
            this.Weekday_r.Width = 71;
            // 
            // StartMonth_r
            // 
            this.StartMonth_r.Text = "Month";
            this.StartMonth_r.Width = 56;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Time";
            this.columnHeader6.Width = 88;
            // 
            // startPeriod_r
            // 
            this.startPeriod_r.Text = "Enrolled Period";
            this.startPeriod_r.Width = 104;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Room";
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Teacher";
            this.columnHeader10.Width = 73;
            // 
            // lblRegCourseDetail
            // 
            this.lblRegCourseDetail.AutoSize = true;
            this.lblRegCourseDetail.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblRegCourseDetail.Location = new System.Drawing.Point(8, 61);
            this.lblRegCourseDetail.Name = "lblRegCourseDetail";
            this.lblRegCourseDetail.Size = new System.Drawing.Size(220, 19);
            this.lblRegCourseDetail.TabIndex = 7;
            this.lblRegCourseDetail.Text = "The registered courses details:";
            this.lblRegCourseDetail.Click += new System.EventHandler(this.lblRegCourseDetail_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(11, 116);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.gpbStudentInfo);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.gpbCourseReg);
            this.splitContainer1.Size = new System.Drawing.Size(702, 351);
            this.splitContainer1.SplitterDistance = 178;
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
            this.gpbStudentInfo.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.gpbStudentInfo.Location = new System.Drawing.Point(3, 3);
            this.gpbStudentInfo.Name = "gpbStudentInfo";
            this.gpbStudentInfo.Size = new System.Drawing.Size(696, 172);
            this.gpbStudentInfo.TabIndex = 8;
            this.gpbStudentInfo.TabStop = false;
            this.gpbStudentInfo.Text = "Student Information";
            // 
            // lblEmailAddress_d
            // 
            this.lblEmailAddress_d.AutoSize = true;
            this.lblEmailAddress_d.Location = new System.Drawing.Point(474, 38);
            this.lblEmailAddress_d.Name = "lblEmailAddress_d";
            this.lblEmailAddress_d.Size = new System.Drawing.Size(21, 19);
            this.lblEmailAddress_d.TabIndex = 15;
            this.lblEmailAddress_d.Text = "--";
            // 
            // lblContactNum_d
            // 
            this.lblContactNum_d.AutoSize = true;
            this.lblContactNum_d.Location = new System.Drawing.Point(474, 19);
            this.lblContactNum_d.Name = "lblContactNum_d";
            this.lblContactNum_d.Size = new System.Drawing.Size(21, 19);
            this.lblContactNum_d.TabIndex = 14;
            this.lblContactNum_d.Text = "--";
            // 
            // lblMembership_d
            // 
            this.lblMembership_d.AutoSize = true;
            this.lblMembership_d.Location = new System.Drawing.Point(127, 42);
            this.lblMembership_d.Name = "lblMembership_d";
            this.lblMembership_d.Size = new System.Drawing.Size(21, 19);
            this.lblMembership_d.TabIndex = 13;
            this.lblMembership_d.Text = "--";
            // 
            // lblStudName_d
            // 
            this.lblStudName_d.AutoSize = true;
            this.lblStudName_d.Location = new System.Drawing.Point(127, 23);
            this.lblStudName_d.Name = "lblStudName_d";
            this.lblStudName_d.Size = new System.Drawing.Size(21, 19);
            this.lblStudName_d.TabIndex = 12;
            this.lblStudName_d.Text = "--";
            // 
            // lblEmailAddress
            // 
            this.lblEmailAddress.AutoSize = true;
            this.lblEmailAddress.Location = new System.Drawing.Point(341, 38);
            this.lblEmailAddress.Name = "lblEmailAddress";
            this.lblEmailAddress.Size = new System.Drawing.Size(112, 19);
            this.lblEmailAddress.TabIndex = 11;
            this.lblEmailAddress.Text = "Email Address:";
            // 
            // lblContactNum
            // 
            this.lblContactNum.AutoSize = true;
            this.lblContactNum.Location = new System.Drawing.Point(341, 19);
            this.lblContactNum.Name = "lblContactNum";
            this.lblContactNum.Size = new System.Drawing.Size(127, 19);
            this.lblContactNum.TabIndex = 10;
            this.lblContactNum.Text = "Contact Number:";
            // 
            // lblMembership
            // 
            this.lblMembership.AutoSize = true;
            this.lblMembership.Location = new System.Drawing.Point(8, 42);
            this.lblMembership.Name = "lblMembership";
            this.lblMembership.Size = new System.Drawing.Size(100, 19);
            this.lblMembership.TabIndex = 9;
            this.lblMembership.Text = "Membership:";
            // 
            // lblStudentName
            // 
            this.lblStudentName.AutoSize = true;
            this.lblStudentName.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblStudentName.Location = new System.Drawing.Point(8, 22);
            this.lblStudentName.Name = "lblStudentName";
            this.lblStudentName.Size = new System.Drawing.Size(113, 19);
            this.lblStudentName.TabIndex = 8;
            this.lblStudentName.Text = "Student Name:";
            // 
            // gpbCourseReg
            // 
            this.gpbCourseReg.Controls.Add(this.btnClear);
            this.gpbCourseReg.Controls.Add(this.btnView);
            this.gpbCourseReg.Controls.Add(this.btnDel);
            this.gpbCourseReg.Controls.Add(this.btnAdd);
            this.gpbCourseReg.Controls.Add(this.ltvRegCourseList);
            this.gpbCourseReg.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.gpbCourseReg.Location = new System.Drawing.Point(2, 2);
            this.gpbCourseReg.Name = "gpbCourseReg";
            this.gpbCourseReg.Size = new System.Drawing.Size(697, 164);
            this.gpbCourseReg.TabIndex = 11;
            this.gpbCourseReg.TabStop = false;
            this.gpbCourseReg.Text = "Course Registration";
            // 
            // ltvRegCourseList
            // 
            this.ltvRegCourseList.AutoArrange = false;
            this.ltvRegCourseList.BackColor = System.Drawing.SystemColors.Control;
            this.ltvRegCourseList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Category,
            this.CourseID,
            this.CourseName,
            this.Weekday,
            this.StartMonth,
            this.StartTime,
            this.StartPeriod,
            this.Price,
            this.Room});
            this.ltvRegCourseList.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ltvRegCourseList.FullRowSelect = true;
            this.ltvRegCourseList.GridLines = true;
            this.ltvRegCourseList.Location = new System.Drawing.Point(6, 45);
            this.ltvRegCourseList.Name = "ltvRegCourseList";
            this.ltvRegCourseList.Size = new System.Drawing.Size(685, 112);
            this.ltvRegCourseList.TabIndex = 9;
            this.ltvRegCourseList.UseCompatibleStateImageBehavior = false;
            this.ltvRegCourseList.View = System.Windows.Forms.View.Details;
            this.ltvRegCourseList.DoubleClick += new System.EventHandler(this.ltvRegCourseList_DoubleClick);
            // 
            // Category
            // 
            this.Category.Text = "Category";
            this.Category.Width = 77;
            // 
            // CourseID
            // 
            this.CourseID.Text = "CourseID";
            this.CourseID.Width = 75;
            // 
            // CourseName
            // 
            this.CourseName.Text = "Course Name";
            this.CourseName.Width = 96;
            // 
            // Weekday
            // 
            this.Weekday.Text = "Weekday";
            this.Weekday.Width = 70;
            // 
            // StartMonth
            // 
            this.StartMonth.Text = "Month";
            // 
            // StartTime
            // 
            this.StartTime.Text = "Time";
            this.StartTime.Width = 90;
            // 
            // StartPeriod
            // 
            this.StartPeriod.Text = "Enrolled Period";
            this.StartPeriod.Width = 108;
            // 
            // Price
            // 
            this.Price.Text = "Price";
            // 
            // Room
            // 
            this.Room.Text = "Room";
            // 
            // lblTotal_d
            // 
            this.lblTotal_d.AutoSize = true;
            this.lblTotal_d.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblTotal_d.Location = new System.Drawing.Point(552, 27);
            this.lblTotal_d.Name = "lblTotal_d";
            this.lblTotal_d.Size = new System.Drawing.Size(21, 19);
            this.lblTotal_d.TabIndex = 19;
            this.lblTotal_d.Text = "--";
            // 
            // lblDiscount_d
            // 
            this.lblDiscount_d.AutoSize = true;
            this.lblDiscount_d.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblDiscount_d.Location = new System.Drawing.Point(312, 27);
            this.lblDiscount_d.Name = "lblDiscount_d";
            this.lblDiscount_d.Size = new System.Drawing.Size(21, 19);
            this.lblDiscount_d.TabIndex = 18;
            this.lblDiscount_d.Text = "--";
            // 
            // lblOriginalTotal_d
            // 
            this.lblOriginalTotal_d.AutoSize = true;
            this.lblOriginalTotal_d.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblOriginalTotal_d.Location = new System.Drawing.Point(128, 27);
            this.lblOriginalTotal_d.Name = "lblOriginalTotal_d";
            this.lblOriginalTotal_d.Size = new System.Drawing.Size(21, 19);
            this.lblOriginalTotal_d.TabIndex = 17;
            this.lblOriginalTotal_d.Text = "--";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblTotal.Location = new System.Drawing.Point(466, 27);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(84, 19);
            this.lblTotal.TabIndex = 16;
            this.lblTotal.Text = "Total Price:";
            // 
            // lblDiscount
            // 
            this.lblDiscount.AutoSize = true;
            this.lblDiscount.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblDiscount.Location = new System.Drawing.Point(233, 27);
            this.lblDiscount.Name = "lblDiscount";
            this.lblDiscount.Size = new System.Drawing.Size(73, 19);
            this.lblDiscount.TabIndex = 15;
            this.lblDiscount.Text = "Discount:";
            // 
            // lblOriginalTotal
            // 
            this.lblOriginalTotal.AutoSize = true;
            this.lblOriginalTotal.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblOriginalTotal.Location = new System.Drawing.Point(9, 27);
            this.lblOriginalTotal.Name = "lblOriginalTotal";
            this.lblOriginalTotal.Size = new System.Drawing.Size(107, 19);
            this.lblOriginalTotal.TabIndex = 14;
            this.lblOriginalTotal.Text = "Original Total:";
            // 
            // llbRegStudent
            // 
            this.llbRegStudent.AutoSize = true;
            this.llbRegStudent.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.llbRegStudent.LinkColor = System.Drawing.Color.Teal;
            this.llbRegStudent.Location = new System.Drawing.Point(388, 83);
            this.llbRegStudent.Name = "llbRegStudent";
            this.llbRegStudent.Size = new System.Drawing.Size(167, 20);
            this.llbRegStudent.TabIndex = 9;
            this.llbRegStudent.TabStop = true;
            this.llbRegStudent.Text = "Register new student";
            this.llbRegStudent.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbRegStudent_LinkClicked);
            // 
            // masterDBDataSet
            // 
            this.masterDBDataSet.DataSetName = "masterDBDataSet";
            this.masterDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblTotal_d);
            this.groupBox1.Controls.Add(this.lblDiscount);
            this.groupBox1.Controls.Add(this.lblDiscount_d);
            this.groupBox1.Controls.Add(this.lblOriginalTotal);
            this.groupBox1.Controls.Add(this.lblOriginalTotal_d);
            this.groupBox1.Controls.Add(this.lblTotal);
            this.groupBox1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox1.Location = new System.Drawing.Point(14, 556);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(699, 58);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Payment";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblPromotionDiscount_d);
            this.groupBox2.Controls.Add(this.lblPromotionDiscount);
            this.groupBox2.Controls.Add(this.lblPromotionName_d);
            this.groupBox2.Controls.Add(this.lblPromotionID_d);
            this.groupBox2.Controls.Add(this.lblPromotionName);
            this.groupBox2.Controls.Add(this.lblPromotionID);
            this.groupBox2.Controls.Add(this.btnDiscountView);
            this.groupBox2.Controls.Add(this.btnDiscountClear);
            this.groupBox2.Controls.Add(this.btnDiscountAdd);
            this.groupBox2.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox2.Location = new System.Drawing.Point(12, 470);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(702, 81);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Additional Discount";
            // 
            // lblPromotionDiscount_d
            // 
            this.lblPromotionDiscount_d.AutoSize = true;
            this.lblPromotionDiscount_d.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblPromotionDiscount_d.Location = new System.Drawing.Point(555, 55);
            this.lblPromotionDiscount_d.Name = "lblPromotionDiscount_d";
            this.lblPromotionDiscount_d.Size = new System.Drawing.Size(21, 19);
            this.lblPromotionDiscount_d.TabIndex = 10;
            this.lblPromotionDiscount_d.Text = "--";
            // 
            // lblPromotionDiscount
            // 
            this.lblPromotionDiscount.AutoSize = true;
            this.lblPromotionDiscount.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblPromotionDiscount.Location = new System.Drawing.Point(469, 54);
            this.lblPromotionDiscount.Name = "lblPromotionDiscount";
            this.lblPromotionDiscount.Size = new System.Drawing.Size(73, 19);
            this.lblPromotionDiscount.TabIndex = 9;
            this.lblPromotionDiscount.Text = "Discount:";
            // 
            // lblPromotionName_d
            // 
            this.lblPromotionName_d.AutoSize = true;
            this.lblPromotionName_d.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblPromotionName_d.Location = new System.Drawing.Point(315, 54);
            this.lblPromotionName_d.Name = "lblPromotionName_d";
            this.lblPromotionName_d.Size = new System.Drawing.Size(21, 19);
            this.lblPromotionName_d.TabIndex = 8;
            this.lblPromotionName_d.Text = "--";
            // 
            // lblPromotionID_d
            // 
            this.lblPromotionID_d.AutoSize = true;
            this.lblPromotionID_d.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblPromotionID_d.Location = new System.Drawing.Point(131, 54);
            this.lblPromotionID_d.Name = "lblPromotionID_d";
            this.lblPromotionID_d.Size = new System.Drawing.Size(21, 19);
            this.lblPromotionID_d.TabIndex = 7;
            this.lblPromotionID_d.Text = "--";
            // 
            // lblPromotionName
            // 
            this.lblPromotionName.AutoSize = true;
            this.lblPromotionName.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblPromotionName.Location = new System.Drawing.Point(236, 53);
            this.lblPromotionName.Name = "lblPromotionName";
            this.lblPromotionName.Size = new System.Drawing.Size(54, 19);
            this.lblPromotionName.TabIndex = 6;
            this.lblPromotionName.Text = "Name:";
            // 
            // lblPromotionID
            // 
            this.lblPromotionID.AutoSize = true;
            this.lblPromotionID.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblPromotionID.Location = new System.Drawing.Point(10, 53);
            this.lblPromotionID.Name = "lblPromotionID";
            this.lblPromotionID.Size = new System.Drawing.Size(105, 19);
            this.lblPromotionID.TabIndex = 5;
            this.lblPromotionID.Text = "Promotion ID:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(95, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(343, 44);
            this.label1.TabIndex = 1;
            this.label1.Text = "Course Registration";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DimGray;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(726, 71);
            this.panel1.TabIndex = 14;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::FunHomeClub.Properties.Resources.GUI_Assignment_smallIcon;
            this.pictureBox1.Location = new System.Drawing.Point(11, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(78, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnDiscountView
            // 
            this.btnDiscountView.BackColor = System.Drawing.Color.Coral;
            this.btnDiscountView.Enabled = false;
            this.btnDiscountView.FlatAppearance.BorderSize = 0;
            this.btnDiscountView.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDiscountView.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnDiscountView.ForeColor = System.Drawing.Color.White;
            this.btnDiscountView.Location = new System.Drawing.Point(539, 19);
            this.btnDiscountView.Name = "btnDiscountView";
            this.btnDiscountView.Size = new System.Drawing.Size(75, 23);
            this.btnDiscountView.TabIndex = 4;
            this.btnDiscountView.Text = "View";
            this.btnDiscountView.UseVisualStyleBackColor = false;
            this.btnDiscountView.Click += new System.EventHandler(this.btnDiscountView_Click);
            // 
            // btnDiscountClear
            // 
            this.btnDiscountClear.BackColor = System.Drawing.Color.Coral;
            this.btnDiscountClear.Enabled = false;
            this.btnDiscountClear.FlatAppearance.BorderSize = 0;
            this.btnDiscountClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDiscountClear.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnDiscountClear.ForeColor = System.Drawing.Color.White;
            this.btnDiscountClear.Location = new System.Drawing.Point(620, 19);
            this.btnDiscountClear.Name = "btnDiscountClear";
            this.btnDiscountClear.Size = new System.Drawing.Size(75, 23);
            this.btnDiscountClear.TabIndex = 2;
            this.btnDiscountClear.Text = "Clear";
            this.btnDiscountClear.UseVisualStyleBackColor = false;
            this.btnDiscountClear.Click += new System.EventHandler(this.btnDiscountClear_Click);
            // 
            // btnDiscountAdd
            // 
            this.btnDiscountAdd.BackColor = System.Drawing.Color.Coral;
            this.btnDiscountAdd.Enabled = false;
            this.btnDiscountAdd.FlatAppearance.BorderSize = 0;
            this.btnDiscountAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDiscountAdd.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnDiscountAdd.ForeColor = System.Drawing.Color.White;
            this.btnDiscountAdd.Location = new System.Drawing.Point(458, 19);
            this.btnDiscountAdd.Name = "btnDiscountAdd";
            this.btnDiscountAdd.Size = new System.Drawing.Size(75, 23);
            this.btnDiscountAdd.TabIndex = 0;
            this.btnDiscountAdd.Text = "Select";
            this.btnDiscountAdd.UseVisualStyleBackColor = false;
            this.btnDiscountAdd.Click += new System.EventHandler(this.btnDiscountAdd_Click);
            // 
            // btnStudIDEnter
            // 
            this.btnStudIDEnter.BackColor = System.Drawing.Color.Coral;
            this.btnStudIDEnter.Enabled = false;
            this.btnStudIDEnter.FlatAppearance.BorderSize = 0;
            this.btnStudIDEnter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStudIDEnter.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnStudIDEnter.ForeColor = System.Drawing.Color.White;
            this.btnStudIDEnter.Location = new System.Drawing.Point(226, 82);
            this.btnStudIDEnter.Name = "btnStudIDEnter";
            this.btnStudIDEnter.Size = new System.Drawing.Size(75, 23);
            this.btnStudIDEnter.TabIndex = 11;
            this.btnStudIDEnter.Text = "Enter";
            this.btnStudIDEnter.UseVisualStyleBackColor = false;
            this.btnStudIDEnter.Click += new System.EventHandler(this.btnStudIDEnter_Click);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.Coral;
            this.btnReset.FlatAppearance.BorderSize = 0;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnReset.ForeColor = System.Drawing.Color.White;
            this.btnReset.Location = new System.Drawing.Point(307, 81);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 24);
            this.btnReset.TabIndex = 10;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Coral;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(635, 620);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 25);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Coral;
            this.btnClear.Enabled = false;
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(616, 16);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 13;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnView
            // 
            this.btnView.BackColor = System.Drawing.Color.Coral;
            this.btnView.Enabled = false;
            this.btnView.FlatAppearance.BorderSize = 0;
            this.btnView.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnView.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnView.ForeColor = System.Drawing.Color.White;
            this.btnView.Location = new System.Drawing.Point(454, 16);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(75, 23);
            this.btnView.TabIndex = 12;
            this.btnView.Text = "View";
            this.btnView.UseVisualStyleBackColor = false;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // btnDel
            // 
            this.btnDel.BackColor = System.Drawing.Color.Coral;
            this.btnDel.Enabled = false;
            this.btnDel.FlatAppearance.BorderSize = 0;
            this.btnDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDel.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnDel.ForeColor = System.Drawing.Color.White;
            this.btnDel.Location = new System.Drawing.Point(535, 16);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(75, 23);
            this.btnDel.TabIndex = 11;
            this.btnDel.Text = "Del";
            this.btnDel.UseVisualStyleBackColor = false;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Coral;
            this.btnAdd.Enabled = false;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(373, 16);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 10;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnRegister
            // 
            this.btnRegister.BackColor = System.Drawing.Color.Coral;
            this.btnRegister.Enabled = false;
            this.btnRegister.FlatAppearance.BorderSize = 0;
            this.btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegister.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnRegister.ForeColor = System.Drawing.Color.White;
            this.btnRegister.Location = new System.Drawing.Point(551, 620);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(75, 25);
            this.btnRegister.TabIndex = 0;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = false;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // CourseRegForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(726, 654);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
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
            ((System.ComponentModel.ISupportInitialize)(this.masterDBDataSet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private XButton btnRegister;
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
        private XButton btnView;
        private XButton btnDel;
        private XButton btnAdd;
        public System.Windows.Forms.ListView ltvRegCourseList;
        private XButton btnCancel;
        private System.Windows.Forms.LinkLabel llbRegStudent;
        private XButton btnReset;
        private System.Windows.Forms.Label lblEmailAddress;
        private System.Windows.Forms.Label lblContactNum;
        private System.Windows.Forms.Label lblOriginalTotal;
        private XButton btnClear;
        private XButton btnStudIDEnter;
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
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader Category;
        private System.Windows.Forms.ColumnHeader CourseName;
        private System.Windows.Forms.ColumnHeader CourseID;
        private System.Windows.Forms.ColumnHeader Weekday;
        private System.Windows.Forms.ColumnHeader StartMonth;
        private System.Windows.Forms.ColumnHeader StartTime;
        private System.Windows.Forms.ColumnHeader Room;
        private System.Windows.Forms.ColumnHeader Price;
        public System.Windows.Forms.Label lblTotal_d;
        public System.Windows.Forms.Label lblDiscount_d;
        public System.Windows.Forms.Label lblOriginalTotal_d;
        private System.Windows.Forms.ColumnHeader StartPeriod;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private XButton btnDiscountClear;
        private XButton btnDiscountAdd;
        private XButton btnDiscountView;
        private System.Windows.Forms.Label lblPromotionDiscount;
        private System.Windows.Forms.Label lblPromotionName;
        private System.Windows.Forms.Label lblPromotionID;
        public System.Windows.Forms.Label lblPromotionDiscount_d;
        public System.Windows.Forms.Label lblPromotionName_d;
        public System.Windows.Forms.Label lblPromotionID_d;
        private System.Windows.Forms.ColumnHeader startPeriod_r;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ColumnHeader StartMonth_r;
    }
}