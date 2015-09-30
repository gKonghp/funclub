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
    public partial class AdminMainForm : Form
    {
        OleDbConnection connection;
        public AdminMainForm(OleDbConnection connection)
        {
            InitializeComponent();
            this.connection = connection;
            tvControlForm.ExpandAll();
        }

        private void tvControlForm_AfterSelect(object sender, TreeViewEventArgs e)
        {
            adminPanel.Controls.Clear();
            switch (tvControlForm.SelectedNode.ToString())
            {
                case "TreeNode: Administrative":
                case "TreeNode: Course":
                    Course();
                    break;
                case "TreeNode: Staff":
                    Staff();
                    break;
                case "TreeNode: Teacher":
                    Teacher();
                    break;
                case "TreeNode: Student":
                    Student();
                    break;
                case "TreeNode: Membership":
                    Membership();
                    break;
                case "TreeNode: Promotions":
                    Promotions();
                    break;
                case "TreeNode: Profit Margin":
                    ProfitMargin();
                    break;
            }
        }
        public void Course()
        {
            CourseControl courseUC = new CourseControl(connection);
            adminPanel.Controls.Add(courseUC);
            courseUC.Dock = DockStyle.Fill;
        }
        public void Staff()
        {
            StaffControl staffUC = new StaffControl(connection);
            adminPanel.Controls.Add(staffUC);
            staffUC.Dock = DockStyle.Fill;
        }
        public void Teacher()
        {
            TeacherControl teacherUC = new TeacherControl(connection);
            adminPanel.Controls.Add(teacherUC);
            teacherUC.Dock = DockStyle.Fill;
        }
        public void Student()
        {
            StudentControl studentUC = new StudentControl(connection);
            adminPanel.Controls.Add(studentUC);
            studentUC.Dock = DockStyle.Fill;
        }
        public void Membership()
        {
            MembershipControl msUC = new MembershipControl(connection);
            adminPanel.Controls.Add(msUC);
            msUC.Dock = DockStyle.Fill;
        }
        public void Promotions()
        {
            PromotionControl promotionUC = new PromotionControl(connection);
            adminPanel.Controls.Add(promotionUC);
            promotionUC.Dock = DockStyle.Fill;
        }
        public void ProfitMargin()
        {
            ProfitMarginControl pmUC = new ProfitMarginControl(connection);
            adminPanel.Controls.Add(pmUC);
            pmUC.Dock = DockStyle.Fill;
        }

        private void AdminMainForm_Load(object sender, EventArgs e)
        {
            InitializeRights();
        }

        private void InitializeRights()
        {
            if (!((MainForm)this.MdiParent).enableAdvanceRight)
            {
                tvControlForm.Nodes["Administration"].Nodes["ProfitMargin"].Remove();
                tvControlForm.Nodes["Membership"].Remove();
                tvControlForm.Nodes["Promotions"].Remove();
            }
        }
    }
}
