using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FunHomeClub
{
    public partial class MenuForm : Form
    {
        private CourseRegForm frmCourseReg;
        private InvoiceHistoryForm frmInvoiceHistory;
        private AdminMainForm frmAdminMain;
        private SearchForm frmSearch;
        private Employee employee;
        public MenuForm(Employee employee)
        {
            InitializeComponent();
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
            lblPosition.Text += employee.position.Equals("m") ? "\tManager" : "\tStaff";
            lblEmployeeID.Text += " " +employee.employeeID;
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
            frmAdminMain = new AdminMainForm();
            frmAdminMain.MdiParent = this.MdiParent;
            frmAdminMain.Dock = DockStyle.Fill;
            Utility.repaintFrameSize(this.MdiParent, frmAdminMain);
            frmAdminMain.Show();
            this.Dispose();
        }

    }
}
