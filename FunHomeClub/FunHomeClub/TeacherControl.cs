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
    public partial class TeacherControl : UserControl
    {
        OleDbConnection connection;
        OleDbDataAdapter dataAdapter;
        DataTable dt;
        string teacherSQL = "select * from teacher";
        public TeacherControl(OleDbConnection connection)
        {
            InitializeComponent();
            this.connection = connection;
            
            showDatainListView(teacherSQL, lstTeacher);
        }

        private void btnAddTeacher_Click(object sender, EventArgs e)
        {
            addTeacher();
        }

        private void btnMaintainTeacher_Click(object sender, EventArgs e)
        {
            maintainTeacher();
        }

        private void btnDeleteTeacher_Click(object sender, EventArgs e)
        {
            DialogResult dResult = MessageBox.Show("Do you conform to delete this record?", "Warnning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dResult == DialogResult.Yes)
            {
                deleteTeacher();
            }
        }
        private void addTeacher()
        {
            MaintainTeacher mt = new MaintainTeacher(connection, null, true);
            mt.ShowDialog();
            if (mt.DialogResult == DialogResult.OK)
            {
                MessageBox.Show("Add successfully");
                showDatainListView(teacherSQL, lstTeacher);
            }
            btnMaintainTeacher.Enabled = false;
            btnDeleteTeacher.Enabled = false;
        }
        private void maintainTeacher()
        {
            MaintainTeacher mt = new MaintainTeacher(connection, lstTeacher.SelectedItems[0]);
            mt.ShowDialog();
            if (mt.DialogResult == DialogResult.OK)
            {
                MessageBox.Show("Update successfully!");
                showDatainListView(teacherSQL, lstTeacher);
            }
            btnMaintainTeacher.Enabled = false;
            btnDeleteTeacher.Enabled = false;
        }
        private void deleteTeacher()
        {
            String sql = "delete from teacher where teacherID='" + lstTeacher.SelectedItems[0].SubItems[0].Text + "'";
            OleDbCommand cmd = new OleDbCommand(sql, connection);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Teacher:" + lstTeacher.SelectedItems[0].SubItems[1].Text + " Deleted!");
            showDatainListView(teacherSQL, lstTeacher);
            btnMaintainTeacher.Enabled = false;
            btnDeleteTeacher.Enabled = false;
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
        private void TeacherControl_Load(object sender, EventArgs e)
        {
            lstTeacher.FullRowSelect = true;
            lstTeacher.GridLines = true;
            lstTeacher.MultiSelect = false;
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.Control | Keys.A))
                btnAddTeacher.PerformClick();

            if (keyData == (Keys.Control | Keys.M))
            {
                if (btnMaintainTeacher.Enabled == true)
                    btnMaintainTeacher.PerformClick();
                else
                    MessageBox.Show("Please select a item first!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (keyData == (Keys.Control | Keys.D))
            {
                if(btnDeleteTeacher.Enabled == true)
                    btnDeleteTeacher.PerformClick();
                else
                    MessageBox.Show("Please select a item first!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
        private void lstTeacher_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstTeacher.SelectedItems.Count > 0)
            {
                btnMaintainTeacher.Enabled = true;
                btnDeleteTeacher.Enabled = true;
            }
            else
            {
                btnMaintainTeacher.Enabled = false;
                btnDeleteTeacher.Enabled = false;
            }
        }
    }
}
