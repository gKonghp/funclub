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
            this.masterDBDataSet = new FunHomeClub.res.db.masterDBDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.studentCourseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentCourseTableAdapter = new FunHomeClub.res.db.masterDBDataSetTableAdapters.studentCourseTableAdapter();
            this.invoiceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.invoiceTableAdapter = new FunHomeClub.res.db.masterDBDataSetTableAdapters.invoiceTableAdapter();
            this.studentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentTableAdapter = new FunHomeClub.res.db.masterDBDataSetTableAdapters.studentTableAdapter();
            this.courseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.courseTableAdapter = new FunHomeClub.res.db.masterDBDataSetTableAdapters.courseTableAdapter();
            this.teacherBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.teacherTableAdapter = new FunHomeClub.res.db.masterDBDataSetTableAdapters.teacherTableAdapter();
            this.membershipBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.membershipTableAdapter = new FunHomeClub.res.db.masterDBDataSetTableAdapters.membershipTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.masterDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentCourseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teacherBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.membershipBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // masterDBDataSet
            // 
            this.masterDBDataSet.DataSetName = "masterDBDataSet";
            this.masterDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "StudentCourse";
            reportDataSource1.Value = this.studentCourseBindingSource;
            reportDataSource2.Name = "Student";
            reportDataSource2.Value = this.studentBindingSource;
            reportDataSource3.Name = "Invoice";
            reportDataSource3.Value = this.invoiceBindingSource;
            reportDataSource4.Name = "Course";
            reportDataSource4.Value = this.courseBindingSource;
            reportDataSource5.Name = "Teacher";
            reportDataSource5.Value = this.teacherBindingSource;
            reportDataSource6.Name = "Membership";
            reportDataSource6.Value = this.membershipBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource4);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource5);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource6);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "FunHomeClub.InvoiceReport.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(733, 378);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // studentCourseBindingSource
            // 
            this.studentCourseBindingSource.DataMember = "studentCourse";
            this.studentCourseBindingSource.DataSource = this.masterDBDataSet;
            // 
            // studentCourseTableAdapter
            // 
            this.studentCourseTableAdapter.ClearBeforeFill = true;
            // 
            // invoiceBindingSource
            // 
            this.invoiceBindingSource.DataMember = "invoice";
            this.invoiceBindingSource.DataSource = this.masterDBDataSet;
            // 
            // invoiceTableAdapter
            // 
            this.invoiceTableAdapter.ClearBeforeFill = true;
            // 
            // studentBindingSource
            // 
            this.studentBindingSource.DataMember = "student";
            this.studentBindingSource.DataSource = this.masterDBDataSet;
            // 
            // studentTableAdapter
            // 
            this.studentTableAdapter.ClearBeforeFill = true;
            // 
            // courseBindingSource
            // 
            this.courseBindingSource.DataMember = "course";
            this.courseBindingSource.DataSource = this.masterDBDataSet;
            // 
            // courseTableAdapter
            // 
            this.courseTableAdapter.ClearBeforeFill = true;
            // 
            // teacherBindingSource
            // 
            this.teacherBindingSource.DataMember = "teacher";
            this.teacherBindingSource.DataSource = this.masterDBDataSet;
            // 
            // teacherTableAdapter
            // 
            this.teacherTableAdapter.ClearBeforeFill = true;
            // 
            // membershipBindingSource
            // 
            this.membershipBindingSource.DataMember = "membership";
            this.membershipBindingSource.DataSource = this.masterDBDataSet;
            // 
            // membershipTableAdapter
            // 
            this.membershipTableAdapter.ClearBeforeFill = true;
            // 
            // InvoicePreviewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(733, 378);
            this.Controls.Add(this.reportViewer1);
            this.Name = "InvoicePreviewForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.masterDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentCourseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teacherBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.membershipBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private res.db.masterDBDataSet masterDBDataSet;
        private System.Windows.Forms.BindingSource studentCourseBindingSource;
        private res.db.masterDBDataSetTableAdapters.studentCourseTableAdapter studentCourseTableAdapter;
        private System.Windows.Forms.BindingSource invoiceBindingSource;
        private res.db.masterDBDataSetTableAdapters.invoiceTableAdapter invoiceTableAdapter;
        private System.Windows.Forms.BindingSource studentBindingSource;
        private res.db.masterDBDataSetTableAdapters.studentTableAdapter studentTableAdapter;
        private System.Windows.Forms.BindingSource courseBindingSource;
        private res.db.masterDBDataSetTableAdapters.courseTableAdapter courseTableAdapter;
        private System.Windows.Forms.BindingSource teacherBindingSource;
        private res.db.masterDBDataSetTableAdapters.teacherTableAdapter teacherTableAdapter;
        private System.Windows.Forms.BindingSource membershipBindingSource;
        private res.db.masterDBDataSetTableAdapters.membershipTableAdapter membershipTableAdapter;
    }
}