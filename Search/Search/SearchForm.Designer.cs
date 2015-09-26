namespace Search
{
    partial class SearchForm
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
            this.cboWeekday = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtPrice2 = new System.Windows.Forms.TextBox();
            this.txtPrice1 = new System.Windows.Forms.TextBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.nudQuota = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.cboMonth = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lstCourseDetail = new System.Windows.Forms.ListView();
            this.Category = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CourseName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Weekday = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.StartMonth = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.EndMonth = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.StartTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.EndTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Price = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Quota = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Room = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuota)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "Weekday:";
            // 
            // cboWeekday
            // 
            this.cboWeekday.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboWeekday.FormattingEnabled = true;
            this.cboWeekday.Items.AddRange(new object[] {
            "",
            "Monday",
            "Tuesday",
            "Wednesday",
            "Thursday",
            "Friday",
            "Saturday",
            "Sunday"});
            this.cboWeekday.Location = new System.Drawing.Point(67, 61);
            this.cboWeekday.Name = "cboWeekday";
            this.cboWeekday.Size = new System.Drawing.Size(157, 20);
            this.cboWeekday.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtPrice2);
            this.groupBox1.Controls.Add(this.txtPrice1);
            this.groupBox1.Controls.Add(this.btnReset);
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.nudQuota);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cboMonth);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cboWeekday);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(720, 99);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Course Filter";
            // 
            // txtPrice2
            // 
            this.txtPrice2.Location = new System.Drawing.Point(423, 27);
            this.txtPrice2.Name = "txtPrice2";
            this.txtPrice2.Size = new System.Drawing.Size(67, 22);
            this.txtPrice2.TabIndex = 14;
            // 
            // txtPrice1
            // 
            this.txtPrice1.Location = new System.Drawing.Point(333, 27);
            this.txtPrice1.Name = "txtPrice1";
            this.txtPrice1.Size = new System.Drawing.Size(67, 22);
            this.txtPrice1.TabIndex = 7;
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(540, 57);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 33);
            this.btnReset.TabIndex = 13;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(639, 57);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 35);
            this.btnSearch.TabIndex = 12;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(246, 61);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 12);
            this.label6.TabIndex = 10;
            this.label6.Text = "Available quota:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(406, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(11, 12);
            this.label4.TabIndex = 6;
            this.label4.Text = "~";
            // 
            // nudQuota
            // 
            this.nudQuota.Location = new System.Drawing.Point(333, 57);
            this.nudQuota.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudQuota.Name = "nudQuota";
            this.nudQuota.Size = new System.Drawing.Size(67, 22);
            this.nudQuota.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(290, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "Price $";
            // 
            // cboMonth
            // 
            this.cboMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMonth.FormattingEnabled = true;
            this.cboMonth.Items.AddRange(new object[] {
            "",
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
            this.cboMonth.Location = new System.Drawing.Point(67, 24);
            this.cboMonth.Name = "cboMonth";
            this.cboMonth.Size = new System.Drawing.Size(157, 20);
            this.cboMonth.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 12);
            this.label5.TabIndex = 7;
            this.label5.Text = "Month:";
            // 
            // lstCourseDetail
            // 
            this.lstCourseDetail.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Category,
            this.CourseName,
            this.Weekday,
            this.StartMonth,
            this.EndMonth,
            this.StartTime,
            this.EndTime,
            this.Price,
            this.Quota,
            this.Room});
            this.lstCourseDetail.Location = new System.Drawing.Point(14, 117);
            this.lstCourseDetail.Name = "lstCourseDetail";
            this.lstCourseDetail.Size = new System.Drawing.Size(720, 329);
            this.lstCourseDetail.TabIndex = 6;
            this.lstCourseDetail.UseCompatibleStateImageBehavior = false;
            this.lstCourseDetail.View = System.Windows.Forms.View.Details;
            this.lstCourseDetail.DoubleClick += new System.EventHandler(this.lstCourseDetail_DoubleClick);
            // 
            // Category
            // 
            this.Category.Text = "Category";
            this.Category.Width = 71;
            // 
            // CourseName
            // 
            this.CourseName.Text = "Course Name";
            this.CourseName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.CourseName.Width = 103;
            // 
            // Weekday
            // 
            this.Weekday.Text = "Weekday";
            this.Weekday.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Weekday.Width = 66;
            // 
            // StartMonth
            // 
            this.StartMonth.Text = "Start Month";
            this.StartMonth.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.StartMonth.Width = 74;
            // 
            // EndMonth
            // 
            this.EndMonth.Text = "End Month";
            this.EndMonth.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.EndMonth.Width = 67;
            // 
            // StartTime
            // 
            this.StartTime.Text = "Start Time";
            this.StartTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.StartTime.Width = 65;
            // 
            // EndTime
            // 
            this.EndTime.Text = "End Time";
            this.EndTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.EndTime.Width = 63;
            // 
            // Price
            // 
            this.Price.Text = "Price";
            this.Price.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Quota
            // 
            this.Quota.Text = "Quota";
            this.Quota.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Quota.Width = 53;
            // 
            // Room
            // 
            this.Room.Text = "Room";
            this.Room.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 459);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(208, 12);
            this.label3.TabIndex = 7;
            this.label3.Text = "(Double Click to View More Course Detail)";
            // 
            // SearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(746, 483);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lstCourseDetail);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SearchForm";
            this.Text = "Search Course";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuota)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboWeekday;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cboMonth;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown nudQuota;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ListView lstCourseDetail;
        private System.Windows.Forms.ColumnHeader Category;
        private System.Windows.Forms.ColumnHeader CourseName;
        private System.Windows.Forms.ColumnHeader Weekday;
        private System.Windows.Forms.ColumnHeader StartMonth;
        private System.Windows.Forms.ColumnHeader EndMonth;
        private System.Windows.Forms.ColumnHeader StartTime;
        private System.Windows.Forms.ColumnHeader EndTime;
        private System.Windows.Forms.ColumnHeader Quota;
        private System.Windows.Forms.ColumnHeader Room;
        private System.Windows.Forms.TextBox txtPrice2;
        private System.Windows.Forms.TextBox txtPrice1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ColumnHeader Price;
        private System.Windows.Forms.Label label3;
    }
}

