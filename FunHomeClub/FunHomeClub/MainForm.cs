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
    public partial class MainForm : Form
    {
        public Employee employee { get; set; }
        private MenuForm frmMenu;
        private AdminMainForm frmAdminMain;
        private CourseRegForm frmCourseReg;
        private SearchForm frmSearch;
        private InvoiceHistoryForm frmInvoiceHistory;
        public MainForm()
        {
            InitializeComponent();
        }

        public MainForm(Employee employee)
        {
            InitializeComponent();
            this.employee = employee;
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void mainMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMenu = new MenuForm(employee);
            frmMenu.MdiParent = this;
            frmMenu.Dock = DockStyle.Fill;
            frmMenu.Show();
            int frmCount = this.MdiChildren.Count();
            for(int i=0; i< frmCount-1; i++)
                this.MdiChildren[i].Dispose();
        }

        private void maintainCourseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tab2Be(0); // Course Tab
        }

        private void maintainStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tab2Be(3); // Staff Tab
        }

        private void maintainStaffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tab2Be(1); // Staff Tab
        }

        private void maintainTeacherToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tab2Be(2); // Teacher Tab

        }

        private void maintainMmembershipToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tab2Be(4); // Membership Tab
        }

        private void setProfitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tab2Be(5); // Profit Tab
        }

        private void maintainPromotionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tab2Be(6); // Promotion Tab
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

        private void tab2Be(int tabIdx)
        {
            int targetTabIdx = tabIdx; // Tab index
            int frmCount = this.MdiChildren.Count();
            for (int i = 0; i < frmCount; i++)
            {
                Form frm = this.MdiChildren[i];
                if (frm is AdminMainForm)
                {
                    frm.Show();
                    Control ctr = frm.Controls.Find("tabAdmin", true)[0];
                    ((TabControl)ctr).SelectedIndex = targetTabIdx;
                }
                else
                    frm.Dispose();
            }
            frmCount = this.MdiChildren.Count();
            if (frmCount < 1)
            {
                frmAdminMain = new AdminMainForm();
                frmAdminMain.MdiParent = this;
                frmAdminMain.Dock = DockStyle.Fill;
                frmAdminMain.Show();
                Control ctr = frmAdminMain.Controls.Find("tabAdmin", true)[0];
                ((TabControl)ctr).SelectedIndex = targetTabIdx;
            }
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
