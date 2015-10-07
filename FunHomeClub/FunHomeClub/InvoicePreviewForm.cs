using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FunHomeClub
{
    public partial class InvoicePreviewForm : Form
    {
        string connStr = ConfigurationManager.ConnectionStrings["FunHomeClub.Properties.Settings.masterDBConnectionString"].ToString();
        private OleDbConnection conn;
        private string invoiceID;
        public InvoicePreviewForm(string invoiceID)
        {
            InitializeComponent();
            conn = new OleDbConnection(connStr);
            this.invoiceID = invoiceID;
        }

        public void Form1_Load(object sender, EventArgs e)
        {

            Initialize();
            if (this.Parent == null)
                btnClose.Text = "Close";
            else
            {
                btnClose.Text = "Home";
            }
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }

        public void Initialize()
        {
            // TODO: 這行程式碼會將資料載入 'masterDBDataSet.course' 資料表。您可以視需要進行移動或移除。
            this.courseTableAdapter.Fill(this.masterDBDataSet.course);

            string sql;
            OleDbDataAdapter adapter;
            // Get invoice Table
            sql = string.Format("SELECT * FROM Invoice WHERE invoiceID = '{0}'", invoiceID);
            adapter = new OleDbDataAdapter(sql, conn);
            adapter.Fill(this.masterDBDataSet.invoice);
            adapter.Dispose();

            // Get studentCourse Table
            sql = string.Format("SELECT * FROM studentCourse WHERE invoiceID = '{0}'", invoiceID);
            adapter = new OleDbDataAdapter(sql, conn);
            adapter.Fill(this.masterDBDataSet.studentCourse);
            adapter.Dispose();

            //get the student who owned the inovice 
            string studentID = this.masterDBDataSet.studentCourse.Rows[0]["studentID"].ToString();

            // Get student Table
            sql = string.Format("SELECT * FROM student WHERE studentID = '{0}'", studentID);
            adapter = new OleDbDataAdapter(sql, conn);
            adapter.Fill(this.masterDBDataSet.student);
            adapter.Dispose();

            //get the student who owned the inovice 
            string membershipID = this.masterDBDataSet.student.Rows[0]["membershipID"].ToString();

            // Get membership Table
            sql = string.Format("SELECT * FROM membership WHERE membershipID = '{0}'", membershipID);
            adapter = new OleDbDataAdapter(sql, conn);
            adapter.Fill(this.masterDBDataSet.membership);
            adapter.Dispose();

            //Get promotion
            string promotionID = this.masterDBDataSet.invoice.Rows[0]["promotionID"].ToString();
            sql = string.Format("SELECT * FROM promotion WHERE promotionID = '{0}'", promotionID);
            adapter = new OleDbDataAdapter(sql, conn);
            adapter.Fill(this.masterDBDataSet.promotion);
            adapter.Dispose();

            //ReportParameter p1 = new ReportParameter("invoiceID", "in0001");
            //this.reportViewer1.LocalReport.SetParameters(new ReportParameter[] { p1 });
            this.reportViewer1.RefreshReport();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (this.Parent == null)
                Dispose();
            else
            {
                MainForm frmMain = ((MainForm)this.MdiParent);
                frmMain.frmMenu = new MenuForm(frmMain.employee, frmMain.connection);
                frmMain.frmMenu.MdiParent = this.MdiParent;
                frmMain.frmMenu.Dock = DockStyle.Fill;
                Utility.repaintFrameSize(this, frmMain.frmMenu);
                frmMain.frmMenu.Show();
                int frmCount = this.MdiChildren.Count();
                for (int i = 0; i < frmCount - 1; i++)
                    this.MdiChildren[i].Dispose();
            }
        }
    }
}
