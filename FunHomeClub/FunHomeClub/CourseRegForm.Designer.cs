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
            this.components = new System.ComponentModel.Container();
            this.btnRegister = new System.Windows.Forms.Button();
            this.cbbCourseCourseID = new System.Windows.Forms.ComboBox();
            this.courseCategoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.masterDBDataSet = new FunHomeClub.res.db.masterDBDataSet();
            this.txtStudentID = new System.Windows.Forms.TextBox();
            this.courseCategoryTableAdapter = new FunHomeClub.res.db.masterDBDataSetTableAdapters.courseCategoryTableAdapter();
            this.cbbCourseName = new System.Windows.Forms.ComboBox();
            this.cbbCoursePeriod = new System.Windows.Forms.ComboBox();
            this.lblStudentID = new System.Windows.Forms.Label();
            this.ltvRegCourseDetail = new System.Windows.Forms.ListView();
            this.lblRegCourseDetail = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.gpbStudentInfo = new System.Windows.Forms.GroupBox();
            this.lblEmailAddress = new System.Windows.Forms.Label();
            this.lblContactNum = new System.Windows.Forms.Label();
            this.lblMembership = new System.Windows.Forms.Label();
            this.lblStudentName = new System.Windows.Forms.Label();
            this.gpbCourseReg = new System.Windows.Forms.GroupBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnView = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.listView2 = new System.Windows.Forms.ListView();
            this.btnCancel = new System.Windows.Forms.Button();
            this.llbRegStudent = new System.Windows.Forms.LinkLabel();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnStudIDEnter = new System.Windows.Forms.Button();
            this.lblStudName_d = new System.Windows.Forms.Label();
            this.lblMembership_d = new System.Windows.Forms.Label();
            this.lblContactNum_d = new System.Windows.Forms.Label();
            this.lblEmailAddress_d = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.courseCategoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.masterDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.gpbStudentInfo.SuspendLayout();
            this.gpbCourseReg.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(574, 277);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(75, 24);
            this.btnRegister.TabIndex = 0;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = true;
            // 
            // cbbCourseCourseID
            // 
            this.cbbCourseCourseID.DataSource = this.courseCategoryBindingSource;
            this.cbbCourseCourseID.FormattingEnabled = true;
            this.cbbCourseCourseID.Location = new System.Drawing.Point(688, 48);
            this.cbbCourseCourseID.Name = "cbbCourseCourseID";
            this.cbbCourseCourseID.Size = new System.Drawing.Size(121, 20);
            this.cbbCourseCourseID.TabIndex = 1;
            // 
            // courseCategoryBindingSource
            // 
            this.courseCategoryBindingSource.DataMember = "courseCategory";
            this.courseCategoryBindingSource.DataSource = this.masterDBDataSet;
            // 
            // masterDBDataSet
            // 
            this.masterDBDataSet.DataSetName = "masterDBDataSet";
            this.masterDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtStudentID
            // 
            this.txtStudentID.Location = new System.Drawing.Point(86, 10);
            this.txtStudentID.Name = "txtStudentID";
            this.txtStudentID.Size = new System.Drawing.Size(100, 22);
            this.txtStudentID.TabIndex = 2;
            // 
            // courseCategoryTableAdapter
            // 
            this.courseCategoryTableAdapter.ClearBeforeFill = true;
            // 
            // cbbCourseName
            // 
            this.cbbCourseName.FormattingEnabled = true;
            this.cbbCourseName.Location = new System.Drawing.Point(688, 74);
            this.cbbCourseName.Name = "cbbCourseName";
            this.cbbCourseName.Size = new System.Drawing.Size(121, 20);
            this.cbbCourseName.TabIndex = 3;
            // 
            // cbbCoursePeriod
            // 
            this.cbbCoursePeriod.FormattingEnabled = true;
            this.cbbCoursePeriod.Location = new System.Drawing.Point(688, 100);
            this.cbbCoursePeriod.Name = "cbbCoursePeriod";
            this.cbbCoursePeriod.Size = new System.Drawing.Size(121, 20);
            this.cbbCoursePeriod.TabIndex = 4;
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
            this.ltvRegCourseDetail.Location = new System.Drawing.Point(10, 94);
            this.ltvRegCourseDetail.Name = "ltvRegCourseDetail";
            this.ltvRegCourseDetail.Size = new System.Drawing.Size(325, 99);
            this.ltvRegCourseDetail.TabIndex = 6;
            this.ltvRegCourseDetail.UseCompatibleStateImageBehavior = false;
            // 
            // lblRegCourseDetail
            // 
            this.lblRegCourseDetail.AutoSize = true;
            this.lblRegCourseDetail.Location = new System.Drawing.Point(8, 79);
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
            this.splitContainer1.Size = new System.Drawing.Size(719, 212);
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
            this.gpbStudentInfo.Size = new System.Drawing.Size(348, 199);
            this.gpbStudentInfo.TabIndex = 8;
            this.gpbStudentInfo.TabStop = false;
            this.gpbStudentInfo.Text = "Student Information";
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
            this.gpbCourseReg.Controls.Add(this.lblTotal);
            this.gpbCourseReg.Controls.Add(this.btnClear);
            this.gpbCourseReg.Controls.Add(this.btnView);
            this.gpbCourseReg.Controls.Add(this.btnDel);
            this.gpbCourseReg.Controls.Add(this.btnAdd);
            this.gpbCourseReg.Controls.Add(this.listView2);
            this.gpbCourseReg.Location = new System.Drawing.Point(3, 3);
            this.gpbCourseReg.Name = "gpbCourseReg";
            this.gpbCourseReg.Size = new System.Drawing.Size(342, 205);
            this.gpbCourseReg.TabIndex = 11;
            this.gpbCourseReg.TabStop = false;
            this.gpbCourseReg.Text = "Course Registration";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(14, 185);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(41, 12);
            this.lblTotal.TabIndex = 14;
            this.lblTotal.Text = "lblTotal";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(255, 23);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 13;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // btnView
            // 
            this.btnView.Location = new System.Drawing.Point(87, 24);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(75, 23);
            this.btnView.TabIndex = 12;
            this.btnView.Text = "View";
            this.btnView.UseVisualStyleBackColor = true;
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(168, 24);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(75, 23);
            this.btnDel.TabIndex = 11;
            this.btnDel.Text = "Del";
            this.btnDel.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(6, 24);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 10;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // listView2
            // 
            this.listView2.Location = new System.Drawing.Point(6, 66);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(324, 112);
            this.listView2.TabIndex = 9;
            this.listView2.UseCompatibleStateImageBehavior = false;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(400, 277);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 24);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // llbRegStudent
            // 
            this.llbRegStudent.AutoSize = true;
            this.llbRegStudent.Location = new System.Drawing.Point(273, 15);
            this.llbRegStudent.Name = "llbRegStudent";
            this.llbRegStudent.Size = new System.Drawing.Size(101, 12);
            this.llbRegStudent.TabIndex = 9;
            this.llbRegStudent.TabStop = true;
            this.llbRegStudent.Text = "Register new student";
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(493, 277);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 24);
            this.btnReset.TabIndex = 10;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
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
            // lblStudName_d
            // 
            this.lblStudName_d.AutoSize = true;
            this.lblStudName_d.Location = new System.Drawing.Point(97, 22);
            this.lblStudName_d.Name = "lblStudName_d";
            this.lblStudName_d.Size = new System.Drawing.Size(13, 12);
            this.lblStudName_d.TabIndex = 12;
            this.lblStudName_d.Text = "--";
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
            // lblContactNum_d
            // 
            this.lblContactNum_d.AutoSize = true;
            this.lblContactNum_d.Location = new System.Drawing.Point(271, 21);
            this.lblContactNum_d.Name = "lblContactNum_d";
            this.lblContactNum_d.Size = new System.Drawing.Size(13, 12);
            this.lblContactNum_d.TabIndex = 14;
            this.lblContactNum_d.Text = "--";
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
            // CourseRegForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 373);
            this.Controls.Add(this.btnStudIDEnter);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.llbRegStudent);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.cbbCoursePeriod);
            this.Controls.Add(this.cbbCourseName);
            this.Controls.Add(this.cbbCourseCourseID);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.lblStudentID);
            this.Controls.Add(this.txtStudentID);
            this.Controls.Add(this.btnRegister);
            this.Name = "CourseRegForm";
            this.Text = "RegCourse";
            this.Load += new System.EventHandler(this.RegCourse_Load);
            ((System.ComponentModel.ISupportInitialize)(this.courseCategoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.masterDBDataSet)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.gpbStudentInfo.ResumeLayout(false);
            this.gpbStudentInfo.PerformLayout();
            this.gpbCourseReg.ResumeLayout(false);
            this.gpbCourseReg.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.ComboBox cbbCourseCourseID;
        private System.Windows.Forms.TextBox txtStudentID;
        private res.db.masterDBDataSet masterDBDataSet;
        private System.Windows.Forms.BindingSource courseCategoryBindingSource;
        private res.db.masterDBDataSetTableAdapters.courseCategoryTableAdapter courseCategoryTableAdapter;
        private System.Windows.Forms.ComboBox cbbCourseName;
        private System.Windows.Forms.ComboBox cbbCoursePeriod;
        private System.Windows.Forms.Label lblStudentID;
        private System.Windows.Forms.ListView ltvRegCourseDetail;
        private System.Windows.Forms.Label lblRegCourseDetail;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox gpbStudentInfo;
        private System.Windows.Forms.Label lblMembership;
        private System.Windows.Forms.Label lblStudentName;
        private System.Windows.Forms.GroupBox gpbCourseReg;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.LinkLabel llbRegStudent;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label lblEmailAddress;
        private System.Windows.Forms.Label lblContactNum;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnStudIDEnter;
        private System.Windows.Forms.Label lblStudName_d;
        private System.Windows.Forms.Label lblEmailAddress_d;
        private System.Windows.Forms.Label lblContactNum_d;
        private System.Windows.Forms.Label lblMembership_d;
    }
}