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

namespace F3_Admin
{
    public partial class Admin : Form
    {
        OleDbConnection connection;
        OleDbDataAdapter dataAdapter;
        DataTable dt;
        string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=masterDB.accdb";
        public Admin()
        {
            InitializeComponent();
            connection = new OleDbConnection(connectionString);
            connection.Open();
            showCourse();
            showStaff();
        }
        private void showStaff()
        {
            lstStaff.Items.Clear();
            String sql = "select * from employee";
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
                lstStaff.Items.Add(item);
            }
        }
        private void showCourse()
        {
            lstCourse.Items.Clear();
            string sql = "SELECT c.courseID,c.name,c.quota,c.weekday,c.room,c.startTime,c.endTime,c.teacherRate,c.operatingCharges,cat.name,tea.name,c.startMonth,c.endMonth FROM course c,courseCategory cat, teacher tea where c.categoryID = cat.categoryID and c.teacherID = tea.teacherID order by c.courseID asc";
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
                lstCourse.Items.Add(item);
            }
        }
        private void Admin_Load(object sender, EventArgs e)
        {

        }

        private void lstCourse_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void aToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MaintainCourse mc = new MaintainCourse(connection, lstCourse.SelectedItems[0]);
            mc.ShowDialog();
            if(mc.DialogResult == DialogResult.OK)
            {
                MessageBox.Show("Save Successfully!");
                showCourse();
            }
        }

        private void lstCourseMenuStrip_Opening(object sender, CancelEventArgs e)
        {
            if(lstCourse.SelectedIndices.Count > 0)
            {
                addToolStripMenuItem.Visible = false;
                deleteToolStripMenuItem.Visible = true;
                aToolStripMenuItem.Visible = true;
            }
            else
            {
                deleteToolStripMenuItem.Visible = false;
                addToolStripMenuItem.Visible = true;
                aToolStripMenuItem.Visible = false;
            }


            addToolStripMenuItem.Visible = (lstCourse.SelectedIndices.Count > 0) ? false : true;
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String sql = "delete from course where courseID='" + lstCourse.SelectedItems[0].SubItems[0].Text + "'";
            OleDbCommand cmd = new OleDbCommand(sql, connection);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Course:" + lstCourse.SelectedItems[0].SubItems[1].Text + " Deleted!");
            showCourse();
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MaintainCourse mc = new MaintainCourse(connection, null,true);
            mc.ShowDialog();
            if (mc.DialogResult == DialogResult.OK)
            {
                MessageBox.Show("Add successfully!");
                showCourse();
            }
        }

        private void lstStaff_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void addStaffMenuItem_Click(object sender, EventArgs e)
        {
            MaintainStaff ms = new MaintainStaff(connection,null,true);
            ms.ShowDialog();
            if(ms.DialogResult == DialogResult.OK)
            {
                MessageBox.Show("Add staff record successfully!!");
                showStaff();
            }
        }

        private void lstStaffMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            Boolean isSelected = (lstStaff.SelectedIndices.Count > 0) ? true : false;
            addStaffMenuItem.Visible = !isSelected;
            maintainStaffMenuItem.Visible = isSelected;
            deleteStaffMenuItem.Visible = isSelected;
        }

        private void maintainStaffMenuItem_Click(object sender, EventArgs e)
        {
            MaintainStaff ms = new MaintainStaff(connection,lstStaff.SelectedItems[0]);
            ms.ShowDialog();
            if(ms.DialogResult == DialogResult.OK)
            {
                MessageBox.Show("Update successfully!!");
                showStaff();
            }
        }

        private void deleteStaffMenuItem_Click(object sender, EventArgs e)
        {
            String sql = "delete from employee where employeeID='" + lstStaff.SelectedItems[0].SubItems[0].Text + "'";
            OleDbCommand cmd = new OleDbCommand(sql, connection);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Staff:" + lstStaff.SelectedItems[0].SubItems[1].Text + " Deleted!");
            showStaff();
        }


    }
}
