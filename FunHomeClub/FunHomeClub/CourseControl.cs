using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace FunHomeClub
{
    public partial class CourseControl : UserControl
    {
        OleDbConnection connection;
        string courseSQL = "SELECT c.courseID,c.name,c.weekday,c.room,Format(c.startTime,'hh:MM'),Format(c.endTime,'hh:MM'),c.teacherRate,c.operatingCharges,cat.name,tea.name,c.startMonth,c.endMonth ,c.description FROM course c,courseCategory cat, teacher tea where c.categoryID = cat.categoryID and c.teacherID = tea.teacherID order by c.courseID asc";
        DataTable dt;
        OleDbDataAdapter dataAdapter;

        public CourseControl(OleDbConnection connection)
        {
            InitializeComponent();
            this.connection = connection;
            showDatainListView(courseSQL, lstCourse);
        }

        private void btnAddCourse_Click(object sender, EventArgs e)
        {
            addCourse();
        }

        private void btnMaintainCourse_Click(object sender, EventArgs e)
        {
            maintainCourse();
        }

        private void btnDeleteCourse_Click(object sender, EventArgs e)
        {
            deleteCourse();
        }

        private void addCourse()
        {
            MaintainCourse mc = new MaintainCourse(connection, null, true);
            mc.ShowDialog();
            if (mc.DialogResult == DialogResult.OK)
            {
                MessageBox.Show("Add successfully!");
                showDatainListView(courseSQL, lstCourse);
            }
            btnMaintainCourse.Enabled = false;
            btnDeleteCourse.Enabled = false;
        }
        private void maintainCourse()
        {
            MaintainCourse mc = new MaintainCourse(connection, lstCourse.SelectedItems[0]);
            mc.ShowDialog();
            if (mc.DialogResult == DialogResult.OK)
            {
                MessageBox.Show("Save Successfully!");
                showDatainListView(courseSQL, lstCourse);
            }
            btnMaintainCourse.Enabled = false;
            btnDeleteCourse.Enabled = false;
        }
        private void deleteCourse()
        {
            
            String sql = "delete from course where courseID='" + lstCourse.SelectedItems[0].SubItems[0].Text + "'";
            OleDbCommand cmd = new OleDbCommand(sql, connection);
            cmd.ExecuteNonQuery();
            cmd = new OleDbCommand("delete from courseMonth where courseID = '" + lstCourse.SelectedItems[0].SubItems[0].Text + "'",connection);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Course:" + lstCourse.SelectedItems[0].SubItems[1].Text + " Deleted!");
            showDatainListView(courseSQL, lstCourse);
            btnMaintainCourse.Enabled = false;
            btnDeleteCourse.Enabled = false;
        }
        private void showDatainListView(String sql, ListView lstView)
        {
            lstView.Items.Clear();
            dt = new DataTable();
            dataAdapter = new OleDbDataAdapter(sql, connection);
            dataAdapter.Fill(dt);
            foreach (DataRow row in dt.Rows)
            {
                ListViewItem item = new ListViewItem(row[0].ToString());
                for (int i = 1; i < dt.Columns.Count; i++)
                {
                    item.SubItems.Add(row[i].ToString());
                }
                lstView.Items.Add(item);
            }
        }

        private void CourseControl_Load(object sender, EventArgs e)
        {
            lstCourse.FullRowSelect = true;
            lstCourse.GridLines = true;
            lstCourse.MultiSelect = false;
        }

        private void lstCourse_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstCourse.SelectedItems.Count > 0)
            {
                btnMaintainCourse.Enabled = true;
                btnDeleteCourse.Enabled = true;
            }
            else
            {
                btnMaintainCourse.Enabled = false;
                btnDeleteCourse.Enabled = false;
            }
        }
    }
}
