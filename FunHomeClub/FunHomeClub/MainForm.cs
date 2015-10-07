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
        public MenuForm frmMenu;
        private AdminMainForm frmAdminMain;
        private CourseRegForm frmCourseReg;
        private SearchForm frmSearch;
        private ViewCourseForm frmViewCourse;
        private InvoiceHistoryForm frmInvoiceHistory;
        public OleDbConnection connection;
	public bool enableAdvanceRight{get; set;}
        public MainForm(OleDbConnection connection)
        {
            InitializeComponent();
            this.enableAdvanceRight = IsEnableAdvanceRight();
            this.connection = connection;
        }

        public MainForm(Employee employee, OleDbConnection connection)
        {
            InitializeComponent();
            this.employee = employee;
            this.enableAdvanceRight = IsEnableAdvanceRight();
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
            Utility.repaintFrameSize(this, frmMenu);
            frmMenu.Show();
            int frmCount = this.MdiChildren.Count();
            for(int i=0; i< frmCount-1; i++)
                this.MdiChildren[i].Dispose();
        }

        private void maintainCourseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Course Tab
            node2Be("Course");
        }

        private void maintainStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Student Tab
            node2Be("Student");
        }

        private void maintainStaffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Staff Tab
            node2Be("Staff");
        }

        private void maintainTeacherToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Teacher Tab
            node2Be("Teacher");
        }

        private void maintainMmembershipToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Membership Form
            node2Be("Membership");
        }

        private void setProfitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Profit Tab
            node2Be("ProfitMargin");
        }

        private void maintainPromotionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Promotion Tab
            node2Be("Promotions");
        }

        private void courseRegistrationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCourseReg = new CourseRegForm(employee);
            frmCourseReg.MdiParent = this;
            frmCourseReg.Dock = DockStyle.Fill;
            Utility.repaintFrameSize(this, frmCourseReg);
            frmCourseReg.Show();
            int frmCount = this.MdiChildren.Count();
            for (int i = 0; i < frmCount - 1; i++)
                this.MdiChildren[i].Dispose();
        }

        private void node2Be(string nodeName)
        {
            //int targetNodeIdx = nodeIdx; // Tab index
            string targetNodeName = nodeName;
            int frmCount = this.MdiChildren.Count();
            for (int i = 0; i < frmCount; i++)
            {
                Form frm = this.MdiChildren[i];
                if (frm is AdminMainForm)
                {
                    Utility.repaintFrameSize(this, frm);
                    frm.Show();
                    Control ctr = frmAdminMain.Controls.Find("tvControlForm", true)[0];
                    TreeView tv = ((TreeView)ctr);
                    tv.SelectedNode = tv.Nodes.Find(targetNodeName, true)[0];
                }
                else
                    frm.Dispose();
            }
            frmCount = this.MdiChildren.Count();
            if (frmCount < 1)
            {
                frmAdminMain = new AdminMainForm(connection);
                frmAdminMain.MdiParent = this;
                frmAdminMain.Dock = DockStyle.Fill;
                Utility.repaintFrameSize(this, frmAdminMain);
                frmAdminMain.Show();
                Control ctr = frmAdminMain.Controls.Find("tvControlForm", true)[0];
                TreeView tv = ((TreeView)ctr);
                tv.SelectedNode = tv.Nodes.Find(targetNodeName, true)[0];
            }
        }

        private void viewCourseDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmViewCourse = new ViewCourseForm(connection);
            frmViewCourse.MdiParent = this;
            frmViewCourse.Dock = DockStyle.Fill;
            Utility.repaintFrameSize(this, frmViewCourse);
            frmViewCourse.Show();
            int frmCount = this.MdiChildren.Count();
            for (int i = 0; i < frmCount - 1; i++)
                this.MdiChildren[i].Dispose();
        }

        private void invoiceHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmInvoiceHistory = new InvoiceHistoryForm();
            frmInvoiceHistory.MdiParent = this;
            frmInvoiceHistory.Dock = DockStyle.Fill;
            Utility.repaintFrameSize(this, frmInvoiceHistory);
            frmInvoiceHistory.Show();
            int frmCount = this.MdiChildren.Count();
            for (int i = 0; i < frmCount - 1; i++)
                this.MdiChildren[i].Dispose();
        }

        private void MainForm_FormClosed_1(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            new LoginForm().Show();
            this.Dispose();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

            InitializeRights();
        }


        private bool IsEnableAdvanceRight()
        {
            if (employee.position.Equals("m"))
                return true;
            else
                return false;
        }

        private void InitializeRights()
        {
            if (enableAdvanceRight)
            {
                maintainMmembershipToolStripMenuItem.Visible = true;
                maintainPromotionToolStripMenuItem.Visible = true;
                setProfitToolStripMenuItem.Visible = true;
            }
            else
            {
                maintainMmembershipToolStripMenuItem.Visible = false;
                maintainPromotionToolStripMenuItem.Visible = false;
                setProfitToolStripMenuItem.Visible = false;
            }
        }

        private void searchCourseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSearch = new SearchForm();
            frmSearch.MdiParent = this;
            frmSearch.Dock = DockStyle.Fill;
            Utility.repaintFrameSize(this, frmSearch);
            frmSearch.Show();
            int frmCount = this.MdiChildren.Count();
            for (int i = 0; i < frmCount - 1; i++)
                this.MdiChildren[i].Dispose();
        }
    }
}
