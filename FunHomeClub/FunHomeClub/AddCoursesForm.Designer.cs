namespace FunHomeClub
{
    partial class AddCoursesForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.cbbWeekday = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbbSortedBy = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.nudPriceTo = new System.Windows.Forms.NumericUpDown();
            this.nudPriceFrom = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.dtpEndTime = new System.Windows.Forms.DateTimePicker();
            this.dtpStartTime = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCourseID = new System.Windows.Forms.TextBox();
            this.cbbCourseName = new System.Windows.Forms.ComboBox();
            this.btnReset = new FunHomeClub.XButton();
            this.lblCourseName = new System.Windows.Forms.Label();
            this.btnSearch = new FunHomeClub.XButton();
            this.label6 = new System.Windows.Forms.Label();
            this.cbbCategory = new System.Windows.Forms.ComboBox();
            this.nudQuota = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.cbbMonth = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.masterDBDataSet = new FunHomeClub.res.db.masterDBDataSet();
            this.lstCourseDetail = new System.Windows.Forms.ListView();
            this.Category = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CourseID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CourseName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Weekday = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.StartMonth = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.StartTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Price = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Room = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Teacher = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label3 = new System.Windows.Forms.Label();
            this.btnAdd = new FunHomeClub.XButton();
            this.btnClose = new FunHomeClub.XButton();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPriceTo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPriceFrom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuota)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.masterDBDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(228, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Weekday:";
            // 
            // cbbWeekday
            // 
            this.cbbWeekday.BackColor = System.Drawing.SystemColors.ControlLight;
            this.cbbWeekday.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbWeekday.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbbWeekday.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cbbWeekday.FormattingEnabled = true;
            this.cbbWeekday.Items.AddRange(new object[] {
            "All",
            "Monday",
            "Tuesday",
            "Wednesday",
            "Thursday",
            "Friday",
            "Saturday",
            "Sunday"});
            this.cbbWeekday.Location = new System.Drawing.Point(341, 94);
            this.cbbWeekday.MaxDropDownItems = 6;
            this.cbbWeekday.Name = "cbbWeekday";
            this.cbbWeekday.Size = new System.Drawing.Size(110, 27);
            this.cbbWeekday.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbbSortedBy);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.nudPriceTo);
            this.groupBox1.Controls.Add(this.nudPriceFrom);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.dtpEndTime);
            this.groupBox1.Controls.Add(this.dtpStartTime);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtCourseID);
            this.groupBox1.Controls.Add(this.cbbCourseName);
            this.groupBox1.Controls.Add(this.btnReset);
            this.groupBox1.Controls.Add(this.lblCourseName);
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.cbbWeekday);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.cbbCategory);
            this.groupBox1.Controls.Add(this.nudQuota);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cbbMonth);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox1.Location = new System.Drawing.Point(16, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(703, 166);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Course Filter";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // cbbSortedBy
            // 
            this.cbbSortedBy.BackColor = System.Drawing.SystemColors.ControlLight;
            this.cbbSortedBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbSortedBy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbbSortedBy.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cbbSortedBy.FormattingEnabled = true;
            this.cbbSortedBy.ItemHeight = 19;
            this.cbbSortedBy.Items.AddRange(new object[] {
            "Category",
            "CourseID",
            "Course Name",
            "Weekday",
            "Month",
            "Time",
            "Price",
            "quota"});
            this.cbbSortedBy.Location = new System.Drawing.Point(341, 128);
            this.cbbSortedBy.Name = "cbbSortedBy";
            this.cbbSortedBy.Size = new System.Drawing.Size(110, 27);
            this.cbbSortedBy.TabIndex = 10;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label11.Location = new System.Drawing.Point(228, 131);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(80, 19);
            this.label11.TabIndex = 28;
            this.label11.Text = "Sorted By:";
            // 
            // nudPriceTo
            // 
            this.nudPriceTo.BackColor = System.Drawing.SystemColors.ControlLight;
            this.nudPriceTo.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.nudPriceTo.Location = new System.Drawing.Point(626, 53);
            this.nudPriceTo.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.nudPriceTo.Name = "nudPriceTo";
            this.nudPriceTo.Size = new System.Drawing.Size(64, 27);
            this.nudPriceTo.TabIndex = 4;
            this.nudPriceTo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // nudPriceFrom
            // 
            this.nudPriceFrom.BackColor = System.Drawing.SystemColors.ControlLight;
            this.nudPriceFrom.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.nudPriceFrom.Location = new System.Drawing.Point(533, 54);
            this.nudPriceFrom.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.nudPriceFrom.Name = "nudPriceFrom";
            this.nudPriceFrom.Size = new System.Drawing.Size(65, 27);
            this.nudPriceFrom.TabIndex = 3;
            this.nudPriceFrom.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label9.Location = new System.Drawing.Point(601, 56);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(20, 19);
            this.label9.TabIndex = 26;
            this.label9.Text = "~";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label10.Location = new System.Drawing.Point(468, 56);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(59, 19);
            this.label10.TabIndex = 25;
            this.label10.Text = "Price $:";
            // 
            // dtpEndTime
            // 
            this.dtpEndTime.CustomFormat = "HH:mm";
            this.dtpEndTime.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.dtpEndTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpEndTime.Location = new System.Drawing.Point(626, 92);
            this.dtpEndTime.Name = "dtpEndTime";
            this.dtpEndTime.Size = new System.Drawing.Size(65, 27);
            this.dtpEndTime.TabIndex = 8;
            this.dtpEndTime.Value = System.Convert.ToDateTime("23:59:59");
            // 
            // dtpStartTime
            // 
            this.dtpStartTime.CustomFormat = "HH:mm";
            this.dtpStartTime.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.dtpStartTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpStartTime.Location = new System.Drawing.Point(533, 92);
            this.dtpStartTime.Name = "dtpStartTime";
            this.dtpStartTime.Size = new System.Drawing.Size(65, 27);
            this.dtpStartTime.TabIndex = 7;
            this.dtpStartTime.Value = System.Convert.ToDateTime("0:00:00");
            this.dtpStartTime.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label8.Location = new System.Drawing.Point(601, 95);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(20, 19);
            this.label8.TabIndex = 22;
            this.label8.Text = "~";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(468, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 19);
            this.label4.TabIndex = 21;
            this.label4.Text = "Time:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(12, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 19);
            this.label2.TabIndex = 20;
            this.label2.Text = "CourseID:";
            // 
            // txtCourseID
            // 
            this.txtCourseID.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtCourseID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCourseID.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtCourseID.Location = new System.Drawing.Point(103, 24);
            this.txtCourseID.Name = "txtCourseID";
            this.txtCourseID.Size = new System.Drawing.Size(107, 20);
            this.txtCourseID.TabIndex = 0;
            // 
            // cbbCourseName
            // 
            this.cbbCourseName.BackColor = System.Drawing.SystemColors.ControlLight;
            this.cbbCourseName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbCourseName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbbCourseName.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cbbCourseName.FormattingEnabled = true;
            this.cbbCourseName.Location = new System.Drawing.Point(341, 52);
            this.cbbCourseName.Name = "cbbCourseName";
            this.cbbCourseName.Size = new System.Drawing.Size(110, 27);
            this.cbbCourseName.TabIndex = 2;
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.Coral;
            this.btnReset.FlatAppearance.BorderSize = 0;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnReset.ForeColor = System.Drawing.Color.White;
            this.btnReset.Location = new System.Drawing.Point(626, 131);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(65, 23);
            this.btnReset.TabIndex = 12;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // lblCourseName
            // 
            this.lblCourseName.AutoSize = true;
            this.lblCourseName.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblCourseName.Location = new System.Drawing.Point(228, 58);
            this.lblCourseName.Name = "lblCourseName";
            this.lblCourseName.Size = new System.Drawing.Size(107, 19);
            this.lblCourseName.TabIndex = 17;
            this.lblCourseName.Text = "Course Name:";
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Coral;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(553, 131);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(65, 23);
            this.btnSearch.TabIndex = 11;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label6.Location = new System.Drawing.Point(12, 131);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 19);
            this.label6.TabIndex = 19;
            this.label6.Text = "Available quota:";
            // 
            // cbbCategory
            // 
            this.cbbCategory.BackColor = System.Drawing.SystemColors.ControlLight;
            this.cbbCategory.DisplayMember = "categoryID";
            this.cbbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbbCategory.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cbbCategory.FormattingEnabled = true;
            this.cbbCategory.Location = new System.Drawing.Point(103, 53);
            this.cbbCategory.Name = "cbbCategory";
            this.cbbCategory.Size = new System.Drawing.Size(107, 27);
            this.cbbCategory.TabIndex = 1;
            this.cbbCategory.ValueMember = "categoryID";
            this.cbbCategory.SelectedIndexChanged += new System.EventHandler(this.cbbCategory_SelectedIndexChanged);
            // 
            // nudQuota
            // 
            this.nudQuota.BackColor = System.Drawing.SystemColors.ControlLight;
            this.nudQuota.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.nudQuota.Location = new System.Drawing.Point(145, 127);
            this.nudQuota.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudQuota.Name = "nudQuota";
            this.nudQuota.Size = new System.Drawing.Size(65, 27);
            this.nudQuota.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.Location = new System.Drawing.Point(12, 95);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 19);
            this.label5.TabIndex = 7;
            this.label5.Text = "Month:";
            // 
            // cbbMonth
            // 
            this.cbbMonth.BackColor = System.Drawing.SystemColors.ControlLight;
            this.cbbMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbMonth.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbbMonth.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cbbMonth.FormattingEnabled = true;
            this.cbbMonth.Items.AddRange(new object[] {
            "All",
            "January",
            "February",
            "March",
            "April",
            "May",
            "June",
            "July",
            "August",
            "September",
            "October",
            "November",
            "December "});
            this.cbbMonth.Location = new System.Drawing.Point(103, 92);
            this.cbbMonth.MaxDropDownItems = 5;
            this.cbbMonth.Name = "cbbMonth";
            this.cbbMonth.Size = new System.Drawing.Size(107, 27);
            this.cbbMonth.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label7.Location = new System.Drawing.Point(12, 58);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 19);
            this.label7.TabIndex = 15;
            this.label7.Text = "Category:";
            // 
            // masterDBDataSet
            // 
            this.masterDBDataSet.DataSetName = "masterDBDataSet";
            this.masterDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lstCourseDetail
            // 
            this.lstCourseDetail.AutoArrange = false;
            this.lstCourseDetail.BackColor = System.Drawing.SystemColors.Control;
            this.lstCourseDetail.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Category,
            this.CourseID,
            this.CourseName,
            this.Weekday,
            this.StartMonth,
            this.StartTime,
            this.Price,
            this.Room,
            this.Teacher});
            this.lstCourseDetail.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lstCourseDetail.FullRowSelect = true;
            this.lstCourseDetail.GridLines = true;
            this.lstCourseDetail.Location = new System.Drawing.Point(16, 184);
            this.lstCourseDetail.Name = "lstCourseDetail";
            this.lstCourseDetail.Size = new System.Drawing.Size(703, 118);
            this.lstCourseDetail.TabIndex = 6;
            this.lstCourseDetail.UseCompatibleStateImageBehavior = false;
            this.lstCourseDetail.View = System.Windows.Forms.View.Details;
            this.lstCourseDetail.DoubleClick += new System.EventHandler(this.lstCourseDetail_DoubleClick);
            // 
            // Category
            // 
            this.Category.Text = "Category";
            this.Category.Width = 76;
            // 
            // CourseID
            // 
            this.CourseID.Text = "CourseID";
            this.CourseID.Width = 82;
            // 
            // CourseName
            // 
            this.CourseName.Text = "Course Name";
            this.CourseName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.CourseName.Width = 98;
            // 
            // Weekday
            // 
            this.Weekday.Text = "Weekday";
            this.Weekday.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Weekday.Width = 76;
            // 
            // StartMonth
            // 
            this.StartMonth.Text = "Month";
            this.StartMonth.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.StartMonth.Width = 70;
            // 
            // StartTime
            // 
            this.StartTime.Text = "Time";
            this.StartTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.StartTime.Width = 94;
            // 
            // Price
            // 
            this.Price.Text = "Price";
            this.Price.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Room
            // 
            this.Room.Text = "Room";
            this.Room.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Teacher
            // 
            this.Teacher.Text = "Teacher";
            this.Teacher.Width = 79;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(12, 306);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(323, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "(Double Click to View More Course Detail)";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Coral;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(570, 312);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(64, 23);
            this.btnAdd.TabIndex = 13;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Coral;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(643, 312);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(64, 23);
            this.btnClose.TabIndex = 14;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // AddCoursesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(737, 347);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lstCourseDetail);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "AddCoursesForm";
            this.Text = "Search and Register Course";
            this.Load += new System.EventHandler(this.AddCoursesForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPriceTo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPriceFrom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuota)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.masterDBDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbbWeekday;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbbMonth;
        private System.Windows.Forms.Label label5;
        private XButton btnReset;
        private XButton btnSearch;
        private System.Windows.Forms.ListView lstCourseDetail;
        private System.Windows.Forms.ColumnHeader Category;
        private System.Windows.Forms.ColumnHeader CourseName;
        private System.Windows.Forms.ColumnHeader Weekday;
        private System.Windows.Forms.ColumnHeader StartMonth;
        private System.Windows.Forms.ColumnHeader StartTime;
        private System.Windows.Forms.ColumnHeader Room;
        private System.Windows.Forms.ColumnHeader Price;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbbCategory;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbbCourseName;
        private System.Windows.Forms.Label lblCourseName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown nudQuota;
        private System.Windows.Forms.DateTimePicker dtpEndTime;
        private System.Windows.Forms.DateTimePicker dtpStartTime;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCourseID;
        private XButton btnAdd;
        private res.db.masterDBDataSet masterDBDataSet;
        private System.Windows.Forms.ColumnHeader CourseID;
        private System.Windows.Forms.NumericUpDown nudPriceTo;
        private System.Windows.Forms.NumericUpDown nudPriceFrom;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private XButton btnClose;
        private System.Windows.Forms.ColumnHeader Teacher;
        private System.Windows.Forms.ComboBox cbbSortedBy;
        private System.Windows.Forms.Label label11;
    }
}

