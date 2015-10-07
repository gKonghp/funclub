namespace FunHomeClub
{
    partial class CourseDetailControl
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lstQuota = new System.Windows.Forms.ListView();
            this.Month = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Quota = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMaterial = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTeacher = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEndMonth = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtStartMonth = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtRoom = new System.Windows.Forms.Label();
            this.txtEndTime = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtStartTime = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtCategory = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.tabPage = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label15 = new System.Windows.Forms.Label();
            this.chbAddional = new System.Windows.Forms.CheckBox();
            this.lstPromotion = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label14 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdoGold = new System.Windows.Forms.RadioButton();
            this.rdoNormal = new System.Windows.Forms.RadioButton();
            this.rdoNone = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.txtFee = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage);
            this.tabControl1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tabControl1.Location = new System.Drawing.Point(3, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(395, 482);
            this.tabControl1.TabIndex = 28;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lstQuota);
            this.tabPage1.Controls.Add(this.txtDescription);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.txtMaterial);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.txtTeacher);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.txtEndMonth);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.txtStartMonth);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.txtRoom);
            this.tabPage1.Controls.Add(this.txtEndTime);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.txtStartTime);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.txtCategory);
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Controls.Add(this.txtName);
            this.tabPage1.Controls.Add(this.label12);
            this.tabPage1.Controls.Add(this.txtID);
            this.tabPage1.Controls.Add(this.label13);
            this.tabPage1.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(387, 449);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Course Detail";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // lstQuota
            // 
            this.lstQuota.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Month,
            this.Quota});
            this.lstQuota.Location = new System.Drawing.Point(183, 244);
            this.lstQuota.Name = "lstQuota";
            this.lstQuota.Size = new System.Drawing.Size(161, 97);
            this.lstQuota.TabIndex = 27;
            this.lstQuota.UseCompatibleStateImageBehavior = false;
            this.lstQuota.View = System.Windows.Forms.View.Details;
            // 
            // Month
            // 
            this.Month.Text = "Month";
            this.Month.Width = 81;
            // 
            // Quota
            // 
            this.Quota.Text = "Quota";
            this.Quota.Width = 87;
            // 
            // txtDescription
            // 
            this.txtDescription.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtDescription.Location = new System.Drawing.Point(132, 93);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtDescription.Size = new System.Drawing.Size(212, 73);
            this.txtDescription.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(10, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Course ID:";
            // 
            // txtMaterial
            // 
            this.txtMaterial.AutoSize = true;
            this.txtMaterial.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtMaterial.Location = new System.Drawing.Point(128, 421);
            this.txtMaterial.Name = "txtMaterial";
            this.txtMaterial.Size = new System.Drawing.Size(15, 19);
            this.txtMaterial.TabIndex = 25;
            this.txtMaterial.Text = "-";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(10, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Course Name:";
            // 
            // txtTeacher
            // 
            this.txtTeacher.AutoSize = true;
            this.txtTeacher.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtTeacher.Location = new System.Drawing.Point(128, 386);
            this.txtTeacher.Name = "txtTeacher";
            this.txtTeacher.Size = new System.Drawing.Size(15, 19);
            this.txtTeacher.TabIndex = 24;
            this.txtTeacher.Text = "-";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(10, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Category:";
            // 
            // txtEndMonth
            // 
            this.txtEndMonth.AutoSize = true;
            this.txtEndMonth.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtEndMonth.Location = new System.Drawing.Point(290, 177);
            this.txtEndMonth.Name = "txtEndMonth";
            this.txtEndMonth.Size = new System.Drawing.Size(15, 19);
            this.txtEndMonth.TabIndex = 23;
            this.txtEndMonth.Text = "-";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(10, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "Description:";
            // 
            // txtStartMonth
            // 
            this.txtStartMonth.AutoSize = true;
            this.txtStartMonth.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtStartMonth.Location = new System.Drawing.Point(128, 177);
            this.txtStartMonth.Name = "txtStartMonth";
            this.txtStartMonth.Size = new System.Drawing.Size(15, 19);
            this.txtStartMonth.TabIndex = 22;
            this.txtStartMonth.Text = "-";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.Location = new System.Drawing.Point(10, 244);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(148, 19);
            this.label5.TabIndex = 4;
            this.label5.Text = "Remaining Amount:";
            // 
            // txtRoom
            // 
            this.txtRoom.AutoSize = true;
            this.txtRoom.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtRoom.Location = new System.Drawing.Point(128, 355);
            this.txtRoom.Name = "txtRoom";
            this.txtRoom.Size = new System.Drawing.Size(15, 19);
            this.txtRoom.TabIndex = 21;
            this.txtRoom.Text = "-";
            // 
            // txtEndTime
            // 
            this.txtEndTime.AutoSize = true;
            this.txtEndTime.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtEndTime.Location = new System.Drawing.Point(290, 205);
            this.txtEndTime.Name = "txtEndTime";
            this.txtEndTime.Size = new System.Drawing.Size(15, 19);
            this.txtEndTime.TabIndex = 20;
            this.txtEndTime.Text = "-";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label7.Location = new System.Drawing.Point(10, 205);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 19);
            this.label7.TabIndex = 6;
            this.label7.Text = "Start Time:";
            // 
            // txtStartTime
            // 
            this.txtStartTime.AutoSize = true;
            this.txtStartTime.Location = new System.Drawing.Point(128, 205);
            this.txtStartTime.Name = "txtStartTime";
            this.txtStartTime.Size = new System.Drawing.Size(15, 19);
            this.txtStartTime.TabIndex = 19;
            this.txtStartTime.Text = "-";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label8.Location = new System.Drawing.Point(179, 205);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 19);
            this.label8.TabIndex = 7;
            this.label8.Text = "End Time:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label9.Location = new System.Drawing.Point(10, 355);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 19);
            this.label9.TabIndex = 8;
            this.label9.Text = "Room:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label10.Location = new System.Drawing.Point(10, 177);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(95, 19);
            this.label10.TabIndex = 9;
            this.label10.Text = "Start Month:";
            // 
            // txtCategory
            // 
            this.txtCategory.AutoSize = true;
            this.txtCategory.Location = new System.Drawing.Point(128, 63);
            this.txtCategory.Name = "txtCategory";
            this.txtCategory.Size = new System.Drawing.Size(15, 19);
            this.txtCategory.TabIndex = 15;
            this.txtCategory.Text = "-";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label11.Location = new System.Drawing.Point(179, 177);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(89, 19);
            this.label11.TabIndex = 10;
            this.label11.Text = "End Month:";
            // 
            // txtName
            // 
            this.txtName.AutoSize = true;
            this.txtName.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtName.Location = new System.Drawing.Point(128, 37);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(15, 19);
            this.txtName.TabIndex = 14;
            this.txtName.Text = "-";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label12.Location = new System.Drawing.Point(10, 386);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(112, 19);
            this.label12.TabIndex = 11;
            this.label12.Text = "Teacher Name:";
            // 
            // txtID
            // 
            this.txtID.AutoSize = true;
            this.txtID.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtID.Location = new System.Drawing.Point(128, 11);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(15, 19);
            this.txtID.TabIndex = 13;
            this.txtID.Text = "-";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label13.Location = new System.Drawing.Point(10, 421);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(104, 19);
            this.label13.TabIndex = 12;
            this.label13.Text = "Material Cost:";
            // 
            // tabPage
            // 
            this.tabPage.Controls.Add(this.groupBox2);
            this.tabPage.Controls.Add(this.label14);
            this.tabPage.Controls.Add(this.groupBox1);
            this.tabPage.Controls.Add(this.txtFee);
            this.tabPage.Location = new System.Drawing.Point(4, 29);
            this.tabPage.Name = "tabPage";
            this.tabPage.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage.Size = new System.Drawing.Size(387, 449);
            this.tabPage.TabIndex = 1;
            this.tabPage.Text = "Fee";
            this.tabPage.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.chbAddional);
            this.groupBox2.Controls.Add(this.lstPromotion);
            this.groupBox2.Location = new System.Drawing.Point(22, 95);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(336, 328);
            this.groupBox2.TabIndex = 31;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Additional Discount";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("微軟正黑體", 9F);
            this.label15.Location = new System.Drawing.Point(221, 28);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(113, 16);
            this.label15.TabIndex = 32;
            this.label15.Text = "(Select Promotion)";
            this.label15.Visible = false;
            // 
            // chbAddional
            // 
            this.chbAddional.AutoSize = true;
            this.chbAddional.Location = new System.Drawing.Point(12, 21);
            this.chbAddional.Name = "chbAddional";
            this.chbAddional.Size = new System.Drawing.Size(195, 24);
            this.chbAddional.TabIndex = 31;
            this.chbAddional.Text = "Use addional discount";
            this.chbAddional.UseVisualStyleBackColor = true;
            this.chbAddional.CheckedChanged += new System.EventHandler(this.chbAddional_CheckedChanged);
            // 
            // lstPromotion
            // 
            this.lstPromotion.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.lstPromotion.Enabled = false;
            this.lstPromotion.Location = new System.Drawing.Point(11, 48);
            this.lstPromotion.Name = "lstPromotion";
            this.lstPromotion.Size = new System.Drawing.Size(318, 274);
            this.lstPromotion.TabIndex = 30;
            this.lstPromotion.UseCompatibleStateImageBehavior = false;
            this.lstPromotion.View = System.Windows.Forms.View.Details;
            this.lstPromotion.SelectedIndexChanged += new System.EventHandler(this.lstPromotion_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Promotion Name";
            this.columnHeader1.Width = 147;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Additional Discount";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 162;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(157, 426);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(136, 20);
            this.label14.TabIndex = 29;
            this.label14.Text = "Total Month Fee:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdoGold);
            this.groupBox1.Controls.Add(this.rdoNormal);
            this.groupBox1.Controls.Add(this.rdoNone);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Location = new System.Drawing.Point(22, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(336, 60);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Basic Month Fee";
            // 
            // rdoGold
            // 
            this.rdoGold.AutoSize = true;
            this.rdoGold.Location = new System.Drawing.Point(258, 25);
            this.rdoGold.Name = "rdoGold";
            this.rdoGold.Size = new System.Drawing.Size(63, 24);
            this.rdoGold.TabIndex = 30;
            this.rdoGold.Text = "Gold";
            this.rdoGold.UseVisualStyleBackColor = true;
            this.rdoGold.CheckedChanged += new System.EventHandler(this.rdoGold_CheckedChanged);
            // 
            // rdoNormal
            // 
            this.rdoNormal.AutoSize = true;
            this.rdoNormal.Location = new System.Drawing.Point(168, 25);
            this.rdoNormal.Name = "rdoNormal";
            this.rdoNormal.Size = new System.Drawing.Size(84, 24);
            this.rdoNormal.TabIndex = 29;
            this.rdoNormal.Text = "Normal";
            this.rdoNormal.UseVisualStyleBackColor = true;
            this.rdoNormal.CheckedChanged += new System.EventHandler(this.rdoNormal_CheckedChanged);
            // 
            // rdoNone
            // 
            this.rdoNone.AutoSize = true;
            this.rdoNone.Checked = true;
            this.rdoNone.Location = new System.Drawing.Point(93, 25);
            this.rdoNone.Name = "rdoNone";
            this.rdoNone.Size = new System.Drawing.Size(69, 24);
            this.rdoNone.TabIndex = 28;
            this.rdoNone.TabStop = true;
            this.rdoNone.Text = "None";
            this.rdoNone.UseVisualStyleBackColor = true;
            this.rdoNone.CheckedChanged += new System.EventHandler(this.rdoNone_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 20);
            this.label6.TabIndex = 27;
            this.label6.Text = "Member:";
            // 
            // txtFee
            // 
            this.txtFee.AutoSize = true;
            this.txtFee.Location = new System.Drawing.Point(299, 426);
            this.txtFee.Name = "txtFee";
            this.txtFee.Size = new System.Drawing.Size(18, 20);
            this.txtFee.TabIndex = 28;
            this.txtFee.Text = "0";
            // 
            // CourseDetailControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControl1);
            this.Name = "CourseDetailControl";
            this.Size = new System.Drawing.Size(399, 483);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage.ResumeLayout(false);
            this.tabPage.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ListView lstQuota;
        private System.Windows.Forms.ColumnHeader Month;
        private System.Windows.Forms.ColumnHeader Quota;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label txtMaterial;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label txtTeacher;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label txtEndMonth;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label txtStartMonth;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label txtRoom;
        private System.Windows.Forms.Label txtEndTime;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label txtStartTime;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label txtCategory;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label txtName;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label txtID;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TabPage tabPage;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.CheckBox chbAddional;
        private System.Windows.Forms.ListView lstPromotion;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdoGold;
        private System.Windows.Forms.RadioButton rdoNormal;
        private System.Windows.Forms.RadioButton rdoNone;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label txtFee;
    }
}
