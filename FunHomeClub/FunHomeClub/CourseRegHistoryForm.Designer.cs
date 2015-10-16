namespace FunHomeClub
{
    partial class CourseRegHistoryForm
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
            this.lblRegCourseDetail = new System.Windows.Forms.Label();
            this.ltvRegCourseDetail = new System.Windows.Forms.ListView();
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CourseID_r = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Weekday_r = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.StartMonth_r = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.startPeriod_r = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnClose = new FunHomeClub.XButton();
            this.masterDBDataSet1 = new FunHomeClub.res.db.masterDBDataSet();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.masterDBDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblRegCourseDetail
            // 
            this.lblRegCourseDetail.AutoSize = true;
            this.lblRegCourseDetail.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblRegCourseDetail.Location = new System.Drawing.Point(12, 9);
            this.lblRegCourseDetail.Name = "lblRegCourseDetail";
            this.lblRegCourseDetail.Size = new System.Drawing.Size(220, 19);
            this.lblRegCourseDetail.TabIndex = 9;
            this.lblRegCourseDetail.Text = "The registered courses details:";
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
            this.columnHeader10,
            this.columnHeader1});
            this.ltvRegCourseDetail.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ltvRegCourseDetail.FullRowSelect = true;
            this.ltvRegCourseDetail.GridLines = true;
            this.ltvRegCourseDetail.Location = new System.Drawing.Point(14, 33);
            this.ltvRegCourseDetail.MultiSelect = false;
            this.ltvRegCourseDetail.Name = "ltvRegCourseDetail";
            this.ltvRegCourseDetail.Size = new System.Drawing.Size(751, 81);
            this.ltvRegCourseDetail.TabIndex = 8;
            this.ltvRegCourseDetail.UseCompatibleStateImageBehavior = false;
            this.ltvRegCourseDetail.View = System.Windows.Forms.View.Details;
            this.ltvRegCourseDetail.DoubleClick += new System.EventHandler(this.ltvRegCourseDetail_DoubleClick);
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "Category";
            this.columnHeader11.Width = 74;
            // 
            // CourseID_r
            // 
            this.CourseID_r.Text = "CourseID";
            this.CourseID_r.Width = 76;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Name";
            // 
            // Weekday_r
            // 
            this.Weekday_r.Text = "Weekday";
            this.Weekday_r.Width = 73;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Room";
            this.columnHeader4.Width = 57;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Time";
            this.columnHeader6.Width = 100;
            // 
            // StartMonth_r
            // 
            this.StartMonth_r.Text = "Month";
            this.StartMonth_r.Width = 87;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Teacher";
            this.columnHeader10.Width = 74;
            // 
            // startPeriod_r
            // 
            this.startPeriod_r.Text = "Enrolled Period";
            this.startPeriod_r.Width = 109;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Coral;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(351, 120);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 10;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // masterDBDataSet1
            // 
            this.masterDBDataSet1.DataSetName = "masterDBDataSet";
            this.masterDBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Cost";
            // 
            // CourseRegHistoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(779, 152);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblRegCourseDetail);
            this.Controls.Add(this.ltvRegCourseDetail);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "CourseRegHistoryForm";
            this.Text = "Course Registration History";
            this.Load += new System.EventHandler(this.CourseRegHistoryForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.masterDBDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRegCourseDetail;
        public System.Windows.Forms.ListView ltvRegCourseDetail;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ColumnHeader CourseID_r;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader Weekday_r;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader StartMonth_r;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader startPeriod_r;
        private XButton btnClose;
        private res.db.masterDBDataSet masterDBDataSet1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
    }
}