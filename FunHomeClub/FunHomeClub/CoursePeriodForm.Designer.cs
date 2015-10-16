namespace FunHomeClub
{
    partial class CoursePeriodForm
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
            this.cbbPeriodFrom = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblPeriodFrom = new System.Windows.Forms.Label();
            this.cbbPeriodTo = new System.Windows.Forms.ComboBox();
            this.btnOK = new FunHomeClub.XButton();
            this.btnCancel = new FunHomeClub.XButton();
            this.lblPeriodTo = new System.Windows.Forms.Label();
            this.lblCourseID = new System.Windows.Forms.Label();
            this.lblCourseName = new System.Windows.Forms.Label();
            this.lblCourseID_d = new System.Windows.Forms.Label();
            this.lblCourseName_d = new System.Windows.Forms.Label();
            this.lblMonthStatus = new System.Windows.Forms.Label();
            this.masterDBDataSet1 = new FunHomeClub.res.db.masterDBDataSet();
            this.lblWeekday_d = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.masterDBDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // cbbPeriodFrom
            // 
            this.cbbPeriodFrom.BackColor = System.Drawing.SystemColors.ControlLight;
            this.cbbPeriodFrom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbPeriodFrom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbbPeriodFrom.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cbbPeriodFrom.FormattingEnabled = true;
            this.cbbPeriodFrom.Location = new System.Drawing.Point(80, 97);
            this.cbbPeriodFrom.Name = "cbbPeriodFrom";
            this.cbbPeriodFrom.Size = new System.Drawing.Size(121, 28);
            this.cbbPeriodFrom.TabIndex = 0;
            this.cbbPeriodFrom.SelectedIndexChanged += new System.EventHandler(this.cbbPeriodFrom_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(12, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(228, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select a period for the course";
            // 
            // lblPeriodFrom
            // 
            this.lblPeriodFrom.AutoSize = true;
            this.lblPeriodFrom.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblPeriodFrom.Location = new System.Drawing.Point(12, 101);
            this.lblPeriodFrom.Name = "lblPeriodFrom";
            this.lblPeriodFrom.Size = new System.Drawing.Size(52, 20);
            this.lblPeriodFrom.TabIndex = 2;
            this.lblPeriodFrom.Text = "From:";
            // 
            // cbbPeriodTo
            // 
            this.cbbPeriodTo.BackColor = System.Drawing.SystemColors.ControlLight;
            this.cbbPeriodTo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbPeriodTo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbbPeriodTo.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cbbPeriodTo.FormattingEnabled = true;
            this.cbbPeriodTo.Location = new System.Drawing.Point(289, 98);
            this.cbbPeriodTo.Name = "cbbPeriodTo";
            this.cbbPeriodTo.Size = new System.Drawing.Size(121, 28);
            this.cbbPeriodTo.TabIndex = 4;
            // 
            // btnOK
            // 
            this.btnOK.BackColor = System.Drawing.Color.Coral;
            this.btnOK.FlatAppearance.BorderSize = 0;
            this.btnOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOK.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnOK.ForeColor = System.Drawing.Color.White;
            this.btnOK.Location = new System.Drawing.Point(488, 40);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 24);
            this.btnOK.TabIndex = 5;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = false;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Coral;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(488, 80);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 24);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblPeriodTo
            // 
            this.lblPeriodTo.AutoSize = true;
            this.lblPeriodTo.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblPeriodTo.Location = new System.Drawing.Point(230, 101);
            this.lblPeriodTo.Name = "lblPeriodTo";
            this.lblPeriodTo.Size = new System.Drawing.Size(32, 20);
            this.lblPeriodTo.TabIndex = 7;
            this.lblPeriodTo.Text = "To:";
            // 
            // lblCourseID
            // 
            this.lblCourseID.AutoSize = true;
            this.lblCourseID.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblCourseID.Location = new System.Drawing.Point(12, 9);
            this.lblCourseID.Name = "lblCourseID";
            this.lblCourseID.Size = new System.Drawing.Size(87, 20);
            this.lblCourseID.TabIndex = 8;
            this.lblCourseID.Text = "Course ID:";
            // 
            // lblCourseName
            // 
            this.lblCourseName.AutoSize = true;
            this.lblCourseName.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblCourseName.Location = new System.Drawing.Point(230, 9);
            this.lblCourseName.Name = "lblCourseName";
            this.lblCourseName.Size = new System.Drawing.Size(116, 20);
            this.lblCourseName.TabIndex = 9;
            this.lblCourseName.Text = "Course Name:";
            // 
            // lblCourseID_d
            // 
            this.lblCourseID_d.AutoSize = true;
            this.lblCourseID_d.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblCourseID_d.Location = new System.Drawing.Point(105, 9);
            this.lblCourseID_d.Name = "lblCourseID_d";
            this.lblCourseID_d.Size = new System.Drawing.Size(23, 20);
            this.lblCourseID_d.TabIndex = 10;
            this.lblCourseID_d.Text = "--";
            // 
            // lblCourseName_d
            // 
            this.lblCourseName_d.AutoSize = true;
            this.lblCourseName_d.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblCourseName_d.Location = new System.Drawing.Point(352, 9);
            this.lblCourseName_d.Name = "lblCourseName_d";
            this.lblCourseName_d.Size = new System.Drawing.Size(23, 20);
            this.lblCourseName_d.TabIndex = 11;
            this.lblCourseName_d.Text = "--";
            // 
            // lblMonthStatus
            // 
            this.lblMonthStatus.AutoSize = true;
            this.lblMonthStatus.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblMonthStatus.ForeColor = System.Drawing.Color.IndianRed;
            this.lblMonthStatus.Location = new System.Drawing.Point(13, 132);
            this.lblMonthStatus.Name = "lblMonthStatus";
            this.lblMonthStatus.Size = new System.Drawing.Size(20, 17);
            this.lblMonthStatus.TabIndex = 12;
            this.lblMonthStatus.Text = "--";
            this.lblMonthStatus.Visible = false;
            // 
            // masterDBDataSet1
            // 
            this.masterDBDataSet1.DataSetName = "masterDBDataSet";
            this.masterDBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lblWeekday_d
            // 
            this.lblWeekday_d.AutoSize = true;
            this.lblWeekday_d.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblWeekday_d.Location = new System.Drawing.Point(105, 38);
            this.lblWeekday_d.Name = "lblWeekday_d";
            this.lblWeekday_d.Size = new System.Drawing.Size(23, 20);
            this.lblWeekday_d.TabIndex = 14;
            this.lblWeekday_d.Text = "--";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(12, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "Weekday:";
            // 
            // CoursePeriodForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(575, 161);
            this.Controls.Add(this.lblWeekday_d);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblMonthStatus);
            this.Controls.Add(this.lblCourseName_d);
            this.Controls.Add(this.lblCourseID_d);
            this.Controls.Add(this.lblCourseName);
            this.Controls.Add(this.lblCourseID);
            this.Controls.Add(this.lblPeriodTo);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.cbbPeriodTo);
            this.Controls.Add(this.lblPeriodFrom);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbbPeriodFrom);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "CoursePeriodForm";
            this.Text = "Select Course Period";
            this.Load += new System.EventHandler(this.CoursePeriodForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.masterDBDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbbPeriodFrom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPeriodFrom;
        private System.Windows.Forms.ComboBox cbbPeriodTo;
        private XButton btnOK;
        private XButton btnCancel;
        private System.Windows.Forms.Label lblPeriodTo;
        private System.Windows.Forms.Label lblCourseID;
        private System.Windows.Forms.Label lblCourseName;
        private System.Windows.Forms.Label lblCourseID_d;
        private System.Windows.Forms.Label lblCourseName_d;
        private System.Windows.Forms.Label lblMonthStatus;
        private res.db.masterDBDataSet masterDBDataSet1;
        private System.Windows.Forms.Label lblWeekday_d;
        private System.Windows.Forms.Label label3;
    }
}