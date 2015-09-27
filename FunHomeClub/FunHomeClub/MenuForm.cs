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
        private Employee emp;
        public MenuForm(Employee emp)
        {
            InitializeComponent();
        }

        private void btnCourseReg_Click(object sender, EventArgs e)
        {
            frmCourseReg = new CourseRegForm(emp);
            frmCourseReg.MdiParent = this.MdiParent;
            frmCourseReg.Dock = DockStyle.Fill;
            frmCourseReg.Show();
            this.Dispose();
        }
    }
}
