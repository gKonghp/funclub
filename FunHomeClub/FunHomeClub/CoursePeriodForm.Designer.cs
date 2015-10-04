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
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblPeriodTo = new System.Windows.Forms.Label();
            this.lblCourseID = new System.Windows.Forms.Label();
            this.lblCourseName = new System.Windows.Forms.Label();
            this.lblCourseID_d = new System.Windows.Forms.Label();
            this.lblCourseName_d = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbbPeriodFrom
            // 
            this.cbbPeriodFrom.BackColor = System.Drawing.SystemColors.Control;
            this.cbbPeriodFrom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbPeriodFrom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbbPeriodFrom.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cbbPeriodFrom.FormattingEnabled = true;
            this.cbbPeriodFrom.Location = new System.Drawing.Point(80, 76);
            this.cbbPeriodFrom.Name = "cbbPeriodFrom";
            this.cbbPeriodFrom.Size = new System.Drawing.Size(121, 28);
            this.cbbPeriodFrom.TabIndex = 0;
            this.cbbPeriodFrom.SelectedIndexChanged += new System.EventHandler(this.cbbPeriodFrom_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(12, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(228, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select a period for the course";
            // 
            // lblPeriodFrom
            // 
            this.lblPeriodFrom.AutoSize = true;
            this.lblPeriodFrom.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblPeriodFrom.Location = new System.Drawing.Point(12, 80);
            this.lblPeriodFrom.Name = "lblPeriodFrom";
            this.lblPeriodFrom.Size = new System.Drawing.Size(52, 20);
            this.lblPeriodFrom.TabIndex = 2;
            this.lblPeriodFrom.Text = "From:";
            // 
            // cbbPeriodTo
            // 
            this.cbbPeriodTo.BackColor = System.Drawing.SystemColors.Control;
            this.cbbPeriodTo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbPeriodTo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbbPeriodTo.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cbbPeriodTo.FormattingEnabled = true;
            this.cbbPeriodTo.Location = new System.Drawing.Point(289, 77);
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
            this.lblPeriodTo.Location = new System.Drawing.Point(230, 80);
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
            // CoursePeriodForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(575, 141);
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
            this.Text = "CoursePeriodForm";
            this.Load += new System.EventHandler(this.CoursePeriodForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbbPeriodFrom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPeriodFrom;
        private System.Windows.Forms.ComboBox cbbPeriodTo;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblPeriodTo;
        private System.Windows.Forms.Label lblCourseID;
        private System.Windows.Forms.Label lblCourseName;
        private System.Windows.Forms.Label lblCourseID_d;
        private System.Windows.Forms.Label lblCourseName_d;
    }
}