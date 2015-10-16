using System;

namespace FunHomeClub
{
    partial class InvoiceHistoryForm
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
            this.txtInvoiceID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSearch = new FunHomeClub.XButton();
            this.label2 = new System.Windows.Forms.Label();
            this.txtStudentID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCourseID = new System.Windows.Forms.TextBox();
            this.dtpDataFrom = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpDateTo = new System.Windows.Forms.DateTimePicker();
            this.ltvInvoice = new System.Windows.Forms.ListView();
            this.invoiceID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.studentID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.studentName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.enrollDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cost = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.discount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.employeeID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnReset = new FunHomeClub.XButton();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.nudPriceTo = new System.Windows.Forms.NumericUpDown();
            this.nudPriceFrom = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.masterDBDataSet1 = new FunHomeClub.res.db.masterDBDataSet();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cbbSortedBy = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudPriceTo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPriceFrom)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.masterDBDataSet1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtInvoiceID
            // 
            this.txtInvoiceID.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtInvoiceID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtInvoiceID.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtInvoiceID.Location = new System.Drawing.Point(103, 29);
            this.txtInvoiceID.Name = "txtInvoiceID";
            this.txtInvoiceID.Size = new System.Drawing.Size(105, 20);
            this.txtInvoiceID.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(10, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Invoice ID:";
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Coral;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(474, 100);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(67, 26);
            this.btnSearch.TabIndex = 8;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(214, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "Student ID:";
            // 
            // txtStudentID
            // 
            this.txtStudentID.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtStudentID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtStudentID.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtStudentID.Location = new System.Drawing.Point(306, 28);
            this.txtStudentID.Name = "txtStudentID";
            this.txtStudentID.Size = new System.Drawing.Size(105, 20);
            this.txtStudentID.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(417, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 19);
            this.label3.TabIndex = 6;
            this.label3.Text = "Course ID:";
            // 
            // txtCourseID
            // 
            this.txtCourseID.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtCourseID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCourseID.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtCourseID.Location = new System.Drawing.Point(500, 27);
            this.txtCourseID.Name = "txtCourseID";
            this.txtCourseID.Size = new System.Drawing.Size(114, 20);
            this.txtCourseID.TabIndex = 2;
            // 
            // dtpDataFrom
            // 
            this.dtpDataFrom.CustomFormat = "d/M/yyyy";
            this.dtpDataFrom.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.dtpDataFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDataFrom.Location = new System.Drawing.Point(103, 62);
            this.dtpDataFrom.Name = "dtpDataFrom";
            this.dtpDataFrom.Size = new System.Drawing.Size(105, 27);
            this.dtpDataFrom.TabIndex = 3;
            this.dtpDataFrom.Value = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(10, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 19);
            this.label4.TabIndex = 9;
            this.label4.Text = "Date: (From) ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.Location = new System.Drawing.Point(214, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 19);
            this.label5.TabIndex = 10;
            this.label5.Text = "(To) ";
            // 
            // dtpDateTo
            // 
            this.dtpDateTo.CustomFormat = "d/M/yyyy";
            this.dtpDateTo.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.dtpDateTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDateTo.Location = new System.Drawing.Point(306, 64);
            this.dtpDateTo.Name = "dtpDateTo";
            this.dtpDateTo.Size = new System.Drawing.Size(105, 27);
            this.dtpDateTo.TabIndex = 4;
            this.dtpDateTo.Value = DateTime.Now;
            // 
            // ltvInvoice
            // 
            this.ltvInvoice.AutoArrange = false;
            this.ltvInvoice.BackColor = System.Drawing.SystemColors.Control;
            this.ltvInvoice.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.invoiceID,
            this.studentID,
            this.studentName,
            this.enrollDate,
            this.cost,
            this.discount,
            this.employeeID});
            this.ltvInvoice.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ltvInvoice.FullRowSelect = true;
            this.ltvInvoice.GridLines = true;
            this.ltvInvoice.Location = new System.Drawing.Point(12, 225);
            this.ltvInvoice.Name = "ltvInvoice";
            this.ltvInvoice.Size = new System.Drawing.Size(623, 150);
            this.ltvInvoice.TabIndex = 12;
            this.ltvInvoice.UseCompatibleStateImageBehavior = false;
            this.ltvInvoice.View = System.Windows.Forms.View.Details;
            this.ltvInvoice.DoubleClick += new System.EventHandler(this.ltvInvoice_DoubleClick);
            // 
            // invoiceID
            // 
            this.invoiceID.Text = "Invoice ID";
            this.invoiceID.Width = 84;
            // 
            // studentID
            // 
            this.studentID.Text = "Student ID";
            this.studentID.Width = 80;
            // 
            // studentName
            // 
            this.studentName.Text = "Student Name";
            this.studentName.Width = 110;
            // 
            // enrollDate
            // 
            this.enrollDate.Text = "Enroll Date";
            this.enrollDate.Width = 95;
            // 
            // cost
            // 
            this.cost.Text = "Cost";
            this.cost.Width = 68;
            // 
            // discount
            // 
            this.discount.Text = "Discount";
            this.discount.Width = 86;
            // 
            // employeeID
            // 
            this.employeeID.Text = "employeeID";
            this.employeeID.Width = 92;
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.Coral;
            this.btnReset.FlatAppearance.BorderSize = 0;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnReset.ForeColor = System.Drawing.Color.White;
            this.btnReset.Location = new System.Drawing.Point(547, 100);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(67, 26);
            this.btnReset.TabIndex = 9;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label6.Location = new System.Drawing.Point(7, 378);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(300, 19);
            this.label6.TabIndex = 16;
            this.label6.Text = "(Double Click to View More Course Detail)";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label8.Location = new System.Drawing.Point(417, 67);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 19);
            this.label8.TabIndex = 17;
            this.label8.Text = "Cost $";
            // 
            // nudPriceTo
            // 
            this.nudPriceTo.BackColor = System.Drawing.SystemColors.ControlLight;
            this.nudPriceTo.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.nudPriceTo.Location = new System.Drawing.Point(500, 62);
            this.nudPriceTo.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.nudPriceTo.Name = "nudPriceTo";
            this.nudPriceTo.Size = new System.Drawing.Size(51, 27);
            this.nudPriceTo.TabIndex = 5;
            // 
            // nudPriceFrom
            // 
            this.nudPriceFrom.BackColor = System.Drawing.SystemColors.ControlLight;
            this.nudPriceFrom.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.nudPriceFrom.Location = new System.Drawing.Point(563, 62);
            this.nudPriceFrom.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.nudPriceFrom.Name = "nudPriceFrom";
            this.nudPriceFrom.Size = new System.Drawing.Size(51, 27);
            this.nudPriceFrom.TabIndex = 6;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label9.Location = new System.Drawing.Point(548, 68);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(20, 19);
            this.label9.TabIndex = 31;
            this.label9.Text = "~";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbbSortedBy);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.nudPriceTo);
            this.groupBox1.Controls.Add(this.txtInvoiceID);
            this.groupBox1.Controls.Add(this.btnReset);
            this.groupBox1.Controls.Add(this.nudPriceFrom);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtStudentID);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtCourseID);
            this.groupBox1.Controls.Add(this.dtpDataFrom);
            this.groupBox1.Controls.Add(this.dtpDateTo);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox1.Location = new System.Drawing.Point(12, 82);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(623, 137);
            this.groupBox1.TabIndex = 34;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Invoice Filter";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // masterDBDataSet1
            // 
            this.masterDBDataSet1.DataSetName = "masterDBDataSet";
            this.masterDBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DimGray;
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(646, 71);
            this.panel1.TabIndex = 35;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("微軟正黑體", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(103, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(352, 44);
            this.label7.TabIndex = 1;
            this.label7.Text = "View Invoice History";
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
            // cbbSortedBy
            // 
            this.cbbSortedBy.BackColor = System.Drawing.SystemColors.ControlLight;
            this.cbbSortedBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbSortedBy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbbSortedBy.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cbbSortedBy.FormattingEnabled = true;
            this.cbbSortedBy.ItemHeight = 19;
            this.cbbSortedBy.Items.AddRange(new object[] {
            "Invoice ID",
            "Student ID",
            "Date",
            "Cost"});
            this.cbbSortedBy.Location = new System.Drawing.Point(103, 99);
            this.cbbSortedBy.Name = "cbbSortedBy";
            this.cbbSortedBy.Size = new System.Drawing.Size(110, 27);
            this.cbbSortedBy.TabIndex = 34;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label11.Location = new System.Drawing.Point(10, 102);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(80, 19);
            this.label11.TabIndex = 35;
            this.label11.Text = "Sorted By:";
            // 
            // InvoiceHistoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(646, 402);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ltvInvoice);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "InvoiceHistoryForm";
            this.Text = "InvoiceHistoryForm";
            this.Load += new System.EventHandler(this.InvoiceHistoryForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudPriceTo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPriceFrom)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.masterDBDataSet1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtInvoiceID;
        private System.Windows.Forms.Label label1;
        private XButton btnSearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtStudentID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCourseID;
        private System.Windows.Forms.DateTimePicker dtpDataFrom;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpDateTo;
        private System.Windows.Forms.ListView ltvInvoice;
        private XButton btnReset;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ColumnHeader invoiceID;
        private System.Windows.Forms.ColumnHeader studentID;
        private System.Windows.Forms.ColumnHeader studentName;
        private System.Windows.Forms.ColumnHeader enrollDate;
        private System.Windows.Forms.ColumnHeader cost;
        private System.Windows.Forms.ColumnHeader discount;
        private System.Windows.Forms.ColumnHeader employeeID;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown nudPriceTo;
        private System.Windows.Forms.NumericUpDown nudPriceFrom;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox1;
        private res.db.masterDBDataSet masterDBDataSet1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox cbbSortedBy;
        private System.Windows.Forms.Label label11;
    }
}