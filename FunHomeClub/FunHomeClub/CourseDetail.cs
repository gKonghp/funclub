using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace FunHomeClub
{
    public partial class CourseDetail : Form
    {
        public CourseDetail(OleDbConnection connection, string courseID)
        {
            InitializeComponent();
            CourseDetailControl cdc = new CourseDetailControl(connection, courseID);
            containCourseDetail.Controls.Add(cdc);
            cdc.Dock = DockStyle.Fill;
        }
    }
}
