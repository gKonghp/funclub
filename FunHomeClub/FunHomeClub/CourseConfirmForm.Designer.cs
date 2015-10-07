namespace FunHomeClub
{
    partial class CourseConfirmForm
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
            this.btnConfirm = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblStudentID = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.gpbStudentInfo = new System.Windows.Forms.GroupBox();
            this.lblStudentID_d = new System.Windows.Forms.Label();
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
            this.EndMonth = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.StartTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.EndTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Price = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Room = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.startPeriod = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.endPeriod = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.masterDBDataSet1 = new FunHomeClub.res.db.masterDBDataSet();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblPromotionDiscount_d = new System.Windows.Forms.Label();
            this.lblPromotionDiscount = new System.Windows.Forms.Label();
            this.lblPromotionName_d = new System.Windows.Forms.Label();
            this.lblPromotionID_d = new System.Windows.Forms.Label();
            this.lblPromotionName = new System.Windows.Forms.Label();
            this.lblPromotionID = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblTotal_d = new System.Windows.Forms.Label();
            this.lblDiscount = new System.Windows.Forms.Label();
            this.lblDiscount_d = new System.Windows.Forms.Label();
            this.lblOriginalTotal = new System.Windows.Forms.Label();
            this.lblOriginalTotal_d = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.gpbStudentInfo.SuspendLayout();
            this.gpbCourseReg.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.masterDBDataSet1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnConfirm
            // 
            this.btnConfirm.BackColor = System.Drawing.Color.Coral;
            this.btnConfirm.FlatAppearance.BorderSize = 0;
            this.btnConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirm.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnConfirm.ForeColor = System.Drawing.Color.White;
            this.btnConfirm.Location = new System.Drawing.Point(620, 456);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(75, 23);
            this.btnConfirm.TabIndex = 0;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = false;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Coral;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(537, 456);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblStudentID
            // 
            this.lblStudentID.AutoSize = true;
            this.lblStudentID.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblStudentID.Location = new System.Drawing.Point(8, 21);
            this.lblStudentID.Name = "lblStudentID";
            this.lblStudentID.Size = new System.Drawing.Size(90, 19);
            this.lblStudentID.TabIndex = 12;
            this.lblStudentID.Text = "Student ID: ";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(12, 89);
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
            this.splitContainer1.Size = new System.Drawing.Size(688, 253);
            this.splitContainer1.SplitterDistance = 107;
            this.splitContainer1.TabIndex = 13;
            // 
            // gpbStudentInfo
            // 
            this.gpbStudentInfo.Controls.Add(this.lblStudentID_d);
            this.gpbStudentInfo.Controls.Add(this.lblEmailAddress_d);
            this.gpbStudentInfo.Controls.Add(this.lblStudentID);
            this.gpbStudentInfo.Controls.Add(this.lblContactNum_d);
            this.gpbStudentInfo.Controls.Add(this.lblMembership_d);
            this.gpbStudentInfo.Controls.Add(this.lblStudName_d);
            this.gpbStudentInfo.Controls.Add(this.lblEmailAddress);
            this.gpbStudentInfo.Controls.Add(this.lblContactNum);
            this.gpbStudentInfo.Controls.Add(this.lblMembership);
            this.gpbStudentInfo.Controls.Add(this.lblStudentName);
            this.gpbStudentInfo.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.gpbStudentInfo.Location = new System.Drawing.Point(3, 6);
            this.gpbStudentInfo.Name = "gpbStudentInfo";
            this.gpbStudentInfo.Size = new System.Drawing.Size(680, 96);
            this.gpbStudentInfo.TabIndex = 8;
            this.gpbStudentInfo.TabStop = false;
            this.gpbStudentInfo.Text = "Student Information";
            // 
            // lblStudentID_d
            // 
            this.lblStudentID_d.AutoSize = true;
            this.lblStudentID_d.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblStudentID_d.Location = new System.Drawing.Point(118, 21);
            this.lblStudentID_d.Name = "lblStudentID_d";
            this.lblStudentID_d.Size = new System.Drawing.Size(21, 19);
            this.lblStudentID_d.TabIndex = 16;
            this.lblStudentID_d.Text = "--";
            // 
            // lblEmailAddress_d
            // 
            this.lblEmailAddress_d.AutoSize = true;
            this.lblEmailAddress_d.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblEmailAddress_d.Location = new System.Drawing.Point(469, 72);
            this.lblEmailAddress_d.Name = "lblEmailAddress_d";
            this.lblEmailAddress_d.Size = new System.Drawing.Size(21, 19);
            this.lblEmailAddress_d.TabIndex = 15;
            this.lblEmailAddress_d.Text = "--";
            // 
            // lblContactNum_d
            // 
            this.lblContactNum_d.AutoSize = true;
            this.lblContactNum_d.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblContactNum_d.Location = new System.Drawing.Point(469, 45);
            this.lblContactNum_d.Name = "lblContactNum_d";
            this.lblContactNum_d.Size = new System.Drawing.Size(21, 19);
            this.lblContactNum_d.TabIndex = 14;
            this.lblContactNum_d.Text = "--";
            // 
            // lblMembership_d
            // 
            this.lblMembership_d.AutoSize = true;
            this.lblMembership_d.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblMembership_d.Location = new System.Drawing.Point(118, 72);
            this.lblMembership_d.Name = "lblMembership_d";
            this.lblMembership_d.Size = new System.Drawing.Size(21, 19);
            this.lblMembership_d.TabIndex = 13;
            this.lblMembership_d.Text = "--";
            // 
            // lblStudName_d
            // 
            this.lblStudName_d.AutoSize = true;
            this.lblStudName_d.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblStudName_d.Location = new System.Drawing.Point(118, 45);
            this.lblStudName_d.Name = "lblStudName_d";
            this.lblStudName_d.Size = new System.Drawing.Size(21, 19);
            this.lblStudName_d.TabIndex = 12;
            this.lblStudName_d.Text = "--";
            // 
            // lblEmailAddress
            // 
            this.lblEmailAddress.AutoSize = true;
            this.lblEmailAddress.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblEmailAddress.Location = new System.Drawing.Point(336, 72);
            this.lblEmailAddress.Name = "lblEmailAddress";
            this.lblEmailAddress.Size = new System.Drawing.Size(112, 19);
            this.lblEmailAddress.TabIndex = 11;
            this.lblEmailAddress.Text = "Email Address:";
            // 
            // lblContactNum
            // 
            this.lblContactNum.AutoSize = true;
            this.lblContactNum.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblContactNum.Location = new System.Drawing.Point(336, 45);
            this.lblContactNum.Name = "lblContactNum";
            this.lblContactNum.Size = new System.Drawing.Size(127, 19);
            this.lblContactNum.TabIndex = 10;
            this.lblContactNum.Text = "Contact Number:";
            // 
            // lblMembership
            // 
            this.lblMembership.AutoSize = true;
            this.lblMembership.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblMembership.Location = new System.Drawing.Point(8, 72);
            this.lblMembership.Name = "lblMembership";
            this.lblMembership.Size = new System.Drawing.Size(100, 19);
            this.lblMembership.TabIndex = 9;
            this.lblMembership.Text = "Membership:";
            // 
            // lblStudentName
            // 
            this.lblStudentName.AutoSize = true;
            this.lblStudentName.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblStudentName.Location = new System.Drawing.Point(8, 45);
            this.lblStudentName.Name = "lblStudentName";
            this.lblStudentName.Size = new System.Drawing.Size(113, 19);
            this.lblStudentName.TabIndex = 8;
            this.lblStudentName.Text = "Student Name:";
            // 
            // gpbCourseReg
            // 
            this.gpbCourseReg.Controls.Add(this.ltvRegCourseList);
            this.gpbCourseReg.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.gpbCourseReg.Location = new System.Drawing.Point(3, 3);
            this.gpbCourseReg.Name = "gpbCourseReg";
            this.gpbCourseReg.Size = new System.Drawing.Size(680, 137);
            this.gpbCourseReg.TabIndex = 11;
            this.gpbCourseReg.TabStop = false;
            this.gpbCourseReg.Text = "Course Registration";
            // 
            // ltvRegCourseList
            // 
            this.ltvRegCourseList.BackColor = System.Drawing.SystemColors.Control;
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
            this.Room,
            this.startPeriod,
            this.endPeriod});
            this.ltvRegCourseList.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ltvRegCourseList.FullRowSelect = true;
            this.ltvRegCourseList.GridLines = true;
            this.ltvRegCourseList.Location = new System.Drawing.Point(6, 21);
            this.ltvRegCourseList.Name = "ltvRegCourseList";
            this.ltvRegCourseList.Size = new System.Drawing.Size(667, 113);
            this.ltvRegCourseList.TabIndex = 9;
            this.ltvRegCourseList.UseCompatibleStateImageBehavior = false;
            this.ltvRegCourseList.View = System.Windows.Forms.View.Details;
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
            // Room
            // 
            this.Room.Text = "Room";
            // 
            // startPeriod
            // 
            this.startPeriod.Text = "Start Period";
            // 
            // endPeriod
            // 
            this.endPeriod.Text = "End Period";
            // 
            // masterDBDataSet1
            // 
            this.masterDBDataSet1.DataSetName = "masterDBDataSet";
            this.masterDBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblPromotionDiscount_d);
            this.groupBox2.Controls.Add(this.lblPromotionDiscount);
            this.groupBox2.Controls.Add(this.lblPromotionName_d);
            this.groupBox2.Controls.Add(this.lblPromotionID_d);
            this.groupBox2.Controls.Add(this.lblPromotionName);
            this.groupBox2.Controls.Add(this.lblPromotionID);
            this.groupBox2.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox2.Location = new System.Drawing.Point(15, 348);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(680, 53);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Additional Discount";
            // 
            // lblPromotionDiscount_d
            // 
            this.lblPromotionDiscount_d.AutoSize = true;
            this.lblPromotionDiscount_d.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblPromotionDiscount_d.Location = new System.Drawing.Point(603, 25);
            this.lblPromotionDiscount_d.Name = "lblPromotionDiscount_d";
            this.lblPromotionDiscount_d.Size = new System.Drawing.Size(21, 19);
            this.lblPromotionDiscount_d.TabIndex = 10;
            this.lblPromotionDiscount_d.Text = "--";
            // 
            // lblPromotionDiscount
            // 
            this.lblPromotionDiscount.AutoSize = true;
            this.lblPromotionDiscount.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblPromotionDiscount.Location = new System.Drawing.Point(513, 25);
            this.lblPromotionDiscount.Name = "lblPromotionDiscount";
            this.lblPromotionDiscount.Size = new System.Drawing.Size(73, 19);
            this.lblPromotionDiscount.TabIndex = 9;
            this.lblPromotionDiscount.Text = "Discount:";
            // 
            // lblPromotionName_d
            // 
            this.lblPromotionName_d.AutoSize = true;
            this.lblPromotionName_d.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblPromotionName_d.Location = new System.Drawing.Point(355, 23);
            this.lblPromotionName_d.Name = "lblPromotionName_d";
            this.lblPromotionName_d.Size = new System.Drawing.Size(21, 19);
            this.lblPromotionName_d.TabIndex = 8;
            this.lblPromotionName_d.Text = "--";
            // 
            // lblPromotionID_d
            // 
            this.lblPromotionID_d.AutoSize = true;
            this.lblPromotionID_d.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblPromotionID_d.Location = new System.Drawing.Point(119, 25);
            this.lblPromotionID_d.Name = "lblPromotionID_d";
            this.lblPromotionID_d.Size = new System.Drawing.Size(21, 19);
            this.lblPromotionID_d.TabIndex = 7;
            this.lblPromotionID_d.Text = "--";
            // 
            // lblPromotionName
            // 
            this.lblPromotionName.AutoSize = true;
            this.lblPromotionName.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblPromotionName.Location = new System.Drawing.Point(265, 23);
            this.lblPromotionName.Name = "lblPromotionName";
            this.lblPromotionName.Size = new System.Drawing.Size(54, 19);
            this.lblPromotionName.TabIndex = 6;
            this.lblPromotionName.Text = "Name:";
            // 
            // lblPromotionID
            // 
            this.lblPromotionID.AutoSize = true;
            this.lblPromotionID.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblPromotionID.Location = new System.Drawing.Point(8, 25);
            this.lblPromotionID.Name = "lblPromotionID";
            this.lblPromotionID.Size = new System.Drawing.Size(105, 19);
            this.lblPromotionID.TabIndex = 5;
            this.lblPromotionID.Text = "Promotion ID:";
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
            this.groupBox1.Location = new System.Drawing.Point(15, 407);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(680, 43);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Payment";
            // 
            // lblTotal_d
            // 
            this.lblTotal_d.AutoSize = true;
            this.lblTotal_d.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblTotal_d.Location = new System.Drawing.Point(603, 18);
            this.lblTotal_d.Name = "lblTotal_d";
            this.lblTotal_d.Size = new System.Drawing.Size(21, 19);
            this.lblTotal_d.TabIndex = 19;
            this.lblTotal_d.Text = "--";
            // 
            // lblDiscount
            // 
            this.lblDiscount.AutoSize = true;
            this.lblDiscount.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblDiscount.Location = new System.Drawing.Point(265, 18);
            this.lblDiscount.Name = "lblDiscount";
            this.lblDiscount.Size = new System.Drawing.Size(73, 19);
            this.lblDiscount.TabIndex = 15;
            this.lblDiscount.Text = "Discount:";
            // 
            // lblDiscount_d
            // 
            this.lblDiscount_d.AutoSize = true;
            this.lblDiscount_d.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblDiscount_d.Location = new System.Drawing.Point(355, 18);
            this.lblDiscount_d.Name = "lblDiscount_d";
            this.lblDiscount_d.Size = new System.Drawing.Size(21, 19);
            this.lblDiscount_d.TabIndex = 18;
            this.lblDiscount_d.Text = "--";
            // 
            // lblOriginalTotal
            // 
            this.lblOriginalTotal.AutoSize = true;
            this.lblOriginalTotal.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblOriginalTotal.Location = new System.Drawing.Point(8, 18);
            this.lblOriginalTotal.Name = "lblOriginalTotal";
            this.lblOriginalTotal.Size = new System.Drawing.Size(107, 19);
            this.lblOriginalTotal.TabIndex = 14;
            this.lblOriginalTotal.Text = "Original Total:";
            // 
            // lblOriginalTotal_d
            // 
            this.lblOriginalTotal_d.AutoSize = true;
            this.lblOriginalTotal_d.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblOriginalTotal_d.Location = new System.Drawing.Point(118, 18);
            this.lblOriginalTotal_d.Name = "lblOriginalTotal_d";
            this.lblOriginalTotal_d.Size = new System.Drawing.Size(21, 19);
            this.lblOriginalTotal_d.TabIndex = 17;
            this.lblOriginalTotal_d.Text = "--";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblTotal.Location = new System.Drawing.Point(513, 18);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(84, 19);
            this.lblTotal.TabIndex = 16;
            this.lblTotal.Text = "Total Price:";
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DimGray;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(711, 71);
            this.panel1.TabIndex = 22;
            // 
            // CourseConfirmForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(711, 484);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnConfirm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CourseConfirmForm";
            this.Text = "CourseConfirm";
            this.Load += new System.EventHandler(this.CourseConfirmForm_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.gpbStudentInfo.ResumeLayout(false);
            this.gpbStudentInfo.PerformLayout();
            this.gpbCourseReg.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.masterDBDataSet1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblStudentID;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox gpbStudentInfo;
        private System.Windows.Forms.Label lblEmailAddress_d;
        private System.Windows.Forms.Label lblContactNum_d;
        private System.Windows.Forms.Label lblMembership_d;
        private System.Windows.Forms.Label lblStudName_d;
        private System.Windows.Forms.Label lblEmailAddress;
        private System.Windows.Forms.Label lblContactNum;
        private System.Windows.Forms.Label lblMembership;
        private System.Windows.Forms.Label lblStudentName;
        private System.Windows.Forms.GroupBox gpbCourseReg;
        public System.Windows.Forms.ListView ltvRegCourseList;
        private System.Windows.Forms.ColumnHeader Category;
        private System.Windows.Forms.ColumnHeader CourseID;
        private System.Windows.Forms.ColumnHeader CourseName;
        private System.Windows.Forms.ColumnHeader Weekday;
        private System.Windows.Forms.ColumnHeader StartMonth;
        private System.Windows.Forms.ColumnHeader EndMonth;
        private System.Windows.Forms.ColumnHeader StartTime;
        private System.Windows.Forms.ColumnHeader EndTime;
        private System.Windows.Forms.ColumnHeader Price;
        private System.Windows.Forms.ColumnHeader Room;
        private System.Windows.Forms.Label lblStudentID_d;
        private res.db.masterDBDataSet masterDBDataSet1;
        private System.Windows.Forms.GroupBox groupBox2;
        public System.Windows.Forms.Label lblPromotionDiscount_d;
        private System.Windows.Forms.Label lblPromotionDiscount;
        public System.Windows.Forms.Label lblPromotionName_d;
        public System.Windows.Forms.Label lblPromotionID_d;
        private System.Windows.Forms.Label lblPromotionName;
        private System.Windows.Forms.Label lblPromotionID;
        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.Label lblTotal_d;
        private System.Windows.Forms.Label lblDiscount;
        public System.Windows.Forms.Label lblDiscount_d;
        private System.Windows.Forms.Label lblOriginalTotal;
        public System.Windows.Forms.Label lblOriginalTotal_d;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.ColumnHeader startPeriod;
        private System.Windows.Forms.ColumnHeader endPeriod;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
    }
}