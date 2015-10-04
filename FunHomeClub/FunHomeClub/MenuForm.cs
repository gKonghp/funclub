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
        private OleDbConnection connection;
        public MenuForm(Employee employee, OleDbConnection connection)
        {
            InitializeComponent();
            this.connection = connection;
            this.employee = employee;
        }

        private void btnCourseReg_Click(object sender, EventArgs e)
        {
            frmCourseReg = new CourseRegForm(employee);
            frmCourseReg.MdiParent = this.MdiParent;
            frmCourseReg.Dock = DockStyle.Fill;
            Utility.repaintFrameSize(this.MdiParent, frmCourseReg);
            frmCourseReg.Show();
            this.Dispose();
        }

        private void btnInvoiceHistory_Click(object sender, EventArgs e)
        {
            frmInvoiceHistory = new InvoiceHistoryForm();
            frmInvoiceHistory.MdiParent = this.MdiParent;
            frmInvoiceHistory.Dock = DockStyle.Fill;
            Utility.repaintFrameSize(this.MdiParent, frmInvoiceHistory);
            frmInvoiceHistory.Show();
            this.Dispose();
        }

        private void MenuForm_Load(object sender, EventArgs e)
        {
            // load employee info in menu
            lblWelcome.Text += " " + employee.name;
            lblPosition_d.Text = employee.position.Equals("m") ? "\tManager" : "\tStaff";
            lblEmployeeID_d.Text = " " +employee.employeeID;
        }

        private void btnViewCourseInfo_Link_Click(object sender, EventArgs e)
        {
            frmSearch = new SearchForm();
            frmSearch.MdiParent = this.MdiParent;
            frmSearch.Dock = DockStyle.Fill;
            Utility.repaintFrameSize(this.MdiParent, frmSearch);
            frmSearch.Show();
            this.Dispose();
        }

        private void btnAdministration_Link_Click(object sender, EventArgs e)
        {
            frmAdminMain = new AdminMainForm(connection);
            frmAdminMain.MdiParent = this.MdiParent;
            frmAdminMain.Dock = DockStyle.Fill;
            Utility.repaintFrameSize(this.MdiParent, frmAdminMain);
            frmAdminMain.Show();
            this.Dispose();
        }

    }
}
