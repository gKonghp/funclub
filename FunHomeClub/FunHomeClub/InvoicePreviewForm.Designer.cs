namespace FunHomeClub
{
    partial class InvoicePreviewForm
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource4 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource5 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource6 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource7 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.studentCourseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.masterDBDataSet = new FunHomeClub.res.db.masterDBDataSet();
            this.studentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.invoiceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.membershipBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.promotionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.teacherBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.studentCourseTableAdapter = new FunHomeClub.res.db.masterDBDataSetTableAdapters.studentCourseTableAdapter();
            this.invoiceTableAdapter = new FunHomeClub.res.db.masterDBDataSetTableAdapters.invoiceTableAdapter();
            this.studentTableAdapter = new FunHomeClub.res.db.masterDBDataSetTableAdapters.studentTableAdapter();
            this.teacherTableAdapter = new FunHomeClub.res.db.masterDBDataSetTableAdapters.teacherTableAdapter();
            this.membershipTableAdapter = new FunHomeClub.res.db.masterDBDataSetTableAdapters.membershipTableAdapter();
            this.promotionTableAdapter = new FunHomeClub.res.db.masterDBDataSetTableAdapters.promotionTableAdapter();
            this.btnClose = new XButton();
            this.employeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employeeTableAdapter = new FunHomeClub.res.db.masterDBDataSetTableAdapters.employeeTableAdapter();
            this.reportDataSet = new FunHomeClub.res.db.ReportDataSet();
            this.courseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.studentCourseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.masterDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.membershipBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.promotionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teacherBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // studentCourseBindingSource
            // 
            this.studentCourseBindingSource.DataMember = "studentCourse";
            this.studentCourseBindingSource.DataSource = this.masterDBDataSet;
            // 
            // masterDBDataSet
            // 
            this.masterDBDataSet.DataSetName = "masterDBDataSet";
            this.masterDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // studentBindingSource
            // 
            this.studentBindingSource.DataMember = "student";
            this.studentBindingSource.DataSource = this.masterDBDataSet;
            // 
            // invoiceBindingSource
            // 
            this.invoiceBindingSource.DataMember = "invoice";
            this.invoiceBindingSource.DataSource = this.masterDBDataSet;
            // 
            // membershipBindingSource
            // 
            this.membershipBindingSource.DataMember = "membership";
            this.membershipBindingSource.DataSource = this.masterDBDataSet;
            // 
            // promotionBindingSource
            // 
            this.promotionBindingSource.DataMember = "promotion";
            this.promotionBindingSource.DataSource = this.masterDBDataSet;
            // 
            // teacherBindingSource
            // 
            this.teacherBindingSource.DataMember = "teacher";
            this.teacherBindingSource.DataSource = this.masterDBDataSet;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            reportDataSource1.Name = "Course";
            reportDataSource1.Value = this.courseBindingSource;
            reportDataSource2.Name = "Employee";
            reportDataSource2.Value = this.employeeBindingSource;
            reportDataSource3.Name = "StudentCourse";
            reportDataSource3.Value = this.studentCourseBindingSource;
            reportDataSource4.Name = "Membership";
            reportDataSource4.Value = this.membershipBindingSource;
            reportDataSource5.Name = "Invoice";
            reportDataSource5.Value = this.invoiceBindingSource;
            reportDataSource6.Name = "Promotion";
            reportDataSource6.Value = this.promotionBindingSource;
            reportDataSource7.Name = "Student";
            reportDataSource7.Value = this.studentBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource4);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource5);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource6);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource7);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "FunHomeClub.InvoiceReport.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(733, 341);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // studentCourseTableAdapter
            // 
            this.studentCourseTableAdapter.ClearBeforeFill = true;
            // 
            // invoiceTableAdapter
            // 
            this.invoiceTableAdapter.ClearBeforeFill = true;
            // 
            // studentTableAdapter
            // 
            this.studentTableAdapter.ClearBeforeFill = true;
            // 
            // teacherTableAdapter
            // 
            this.teacherTableAdapter.ClearBeforeFill = true;
            // 
            // membershipTableAdapter
            // 
            this.membershipTableAdapter.ClearBeforeFill = true;
            // 
            // promotionTableAdapter
            // 
            this.promotionTableAdapter.ClearBeforeFill = true;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnClose.BackColor = System.Drawing.Color.Coral;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(333, 347);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // employeeBindingSource
            // 
            this.employeeBindingSource.DataMember = "employee";
            this.employeeBindingSource.DataSource = this.masterDBDataSet;
            // 
            // employeeTableAdapter
            // 
            this.employeeTableAdapter.ClearBeforeFill = true;
            // 
            // reportDataSet
            // 
            this.reportDataSet.DataSetName = "ReportDataSet";
            this.reportDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // courseBindingSource
            // 
            this.courseBindingSource.DataMember = "Course";
            this.courseBindingSource.DataSource = this.reportDataSet;
            // 
            // InvoicePreviewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(733, 378);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.reportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "InvoicePreviewForm";
            this.Text = "Invoice Preview";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.studentCourseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.masterDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.membershipBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.promotionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teacherBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private res.db.masterDBDataSet masterDBDataSet;
        private System.Windows.Forms.BindingSource studentCourseBindingSource;
        private res.db.masterDBDataSetTableAdapters.studentCourseTableAdapter studentCourseTableAdapter;
        private System.Windows.Forms.BindingSource invoiceBindingSource;
        private res.db.masterDBDataSetTableAdapters.invoiceTableAdapter invoiceTableAdapter;
        private System.Windows.Forms.BindingSource studentBindingSource;
        private res.db.masterDBDataSetTableAdapters.studentTableAdapter studentTableAdapter;
        private System.Windows.Forms.BindingSource teacherBindingSource;
        private res.db.masterDBDataSetTableAdapters.teacherTableAdapter teacherTableAdapter;
        private System.Windows.Forms.BindingSource membershipBindingSource;
        private res.db.masterDBDataSetTableAdapters.membershipTableAdapter membershipTableAdapter;
        private System.Windows.Forms.BindingSource promotionBindingSource;
        private res.db.masterDBDataSetTableAdapters.promotionTableAdapter promotionTableAdapter;
        public Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private XButton btnClose;
        private System.Windows.Forms.BindingSource employeeBindingSource;
        private res.db.masterDBDataSetTableAdapters.employeeTableAdapter employeeTableAdapter;
        private res.db.ReportDataSet reportDataSet;
        private System.Windows.Forms.BindingSource courseBindingSource;
    }
}