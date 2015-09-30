using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Configuration;

namespace FunHomeClub
{
    public partial class MainForm : Form
    {
        public Employee employee { get; set; }
        private MenuForm frmMenu;
        private AdminMainForm frmAdminMain;
        private CourseRegForm frmCourseReg;
        private SearchForm frmSearch;
        private InvoiceHistoryForm frmInvoiceHistory;
        private OleDbConnection connection;

        public MainForm(OleDbConnection connection)
        {
            InitializeComponent();
            this.connection = connection;
        }

        public MainForm(Employee employee, OleDbConnection connection)
        {
            InitializeComponent();
            this.employee = employee;
            this.connection = connection;
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void mainMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMenu = new MenuForm(employee, connection);
            frmMenu.MdiParent = this;
            frmMenu.Dock = DockStyle.Fill;
            frmMenu.Show();
            int frmCount = this.MdiChildren.Count();
            for(int i=0; i< frmCount-1; i++)
                this.MdiChildren[i].Dispose();
        }

        private void maintainCourseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Course Tab
        }

        private void maintainStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Student Tab
        }

        private void maintainStaffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Staff Tab
        }

        private void maintainTeacherToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Teacher Tab
        }

        private void maintainMmembershipToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Membership Form
        }

        private void setProfitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Profit Tab
        }

        private void maintainPromotionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Promotion Tab
        }

        private void courseRegistrationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCourseReg = new CourseRegForm(employee);
            frmCourseReg.MdiParent = this;
            frmCourseReg.Dock = DockStyle.Fill;
            frmCourseReg.Show();
            int frmCount = this.MdiChildren.Count();
            for (int i = 0; i < frmCount - 1; i++)
                this.MdiChildren[i].Dispose();
        }

        private void viewCourseDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSearch = new SearchForm();
            frmSearch.MdiParent = this;
            frmSearch.Dock = DockStyle.Fill;
            frmSearch.Show();
            int frmCount = this.MdiChildren.Count();
            for (int i = 0; i < frmCount - 1; i++)
                this.MdiChildren[i].Dispose();
        }

        private void invoiceHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmInvoiceHistory = new InvoiceHistoryForm();
            frmInvoiceHistory.MdiParent = this;
            frmInvoiceHistory.Dock = DockStyle.Fill;
            frmInvoiceHistory.Show();
            int frmCount = this.MdiChildren.Count();
            for (int i = 0; i < frmCount - 1; i++)
                this.MdiChildren[i].Dispose();
        }

        private void MainForm_FormClosed_1(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
