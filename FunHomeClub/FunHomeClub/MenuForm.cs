using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace FunHomeClub
{
    public partial class MenuForm : Form
    {
        private CourseRegForm frmCourseReg;
        private InvoiceHistoryForm frmInvoiceHistory;
        private AdminMainForm frmAdminMain;
        private SearchForm frmSearch;
        private Employee employee;
        private bool enableAdvanceRights = false;
        private OleDbConnection connection;
        public MenuForm(Employee emp, OleDbConnection connection)
        {
            InitializeComponent();
            this.connection = connection;
        }

        private void btnCourseReg_Click(object sender, EventArgs e)
        {
            frmCourseReg = new CourseRegForm(employee);
            frmCourseReg.MdiParent = this.MdiParent;
            frmCourseReg.Dock = DockStyle.Fill;
            frmCourseReg.Show();
            this.Dispose();
        }

        private void btnInvoiceHistory_Click(object sender, EventArgs e)
        {
            frmInvoiceHistory = new InvoiceHistoryForm();
            frmInvoiceHistory.MdiParent = this.MdiParent;
            frmInvoiceHistory.Dock = DockStyle.Fill;
            frmInvoiceHistory.Show();
            this.Dispose();
        }

        private void btnViewCourseInfo_Link_Click(object sender, EventArgs e)
        {
            frmSearch = new SearchForm();
            frmSearch.MdiParent = this.MdiParent;
            frmSearch.Dock = DockStyle.Fill;
            frmSearch.Show();
            this.Dispose();
        }

        private bool IsEnableAdvanceRight()
        {
            if (employee.position.Equals("m"))
                return true;
            else
                return false;
        }

        private void OpenRight()
        {

        }

        private void btnAdministration_Link_Click(object sender, EventArgs e)
        {
            frmAdminMain = new AdminMainForm(connection);
            frmAdminMain.MdiParent = this.MdiParent;
            frmAdminMain.Dock = DockStyle.Fill;
            frmAdminMain.Show();
            this.Dispose();
        }
    }
}
