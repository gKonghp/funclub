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
    public partial class StudentControl : UserControl
    {
        OleDbConnection connection;
        DataTable dt;
        OleDbDataAdapter dataAdapter;
        string studentSQL = "select * from student";

        public StudentControl(OleDbConnection connection)
        {
            InitializeComponent();
            this.connection = connection;
            showDatainListView(studentSQL, lstStudent); 
        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            addStudent();
        }

        private void btnMaintainStudent_Click(object sender, EventArgs e)
        {
            maintainStudent();
        }

        private void btnDeleteStudent_Click(object sender, EventArgs e)
        {
            DialogResult dResult = MessageBox.Show("Do you conform to delete this record?", "Warnning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dResult == DialogResult.Yes)
            {
                deleteStudent();
            }
        }
        private void addStudent()
        {
            MaintainStudent ms = new MaintainStudent(connection, null, true);
            ms.ShowDialog();
            if (ms.DialogResult == DialogResult.OK)
            {
                MessageBox.Show("Added successfully!");
                showDatainListView(studentSQL, lstStudent);
            }
            btnMaintainStudent.Enabled = false;
            btnDeleteStudent.Enabled = false;
        }
        private void maintainStudent()
        {
            MaintainStudent ms = new MaintainStudent(connection, lstStudent.SelectedItems[0]);
            ms.ShowDialog();
            if (ms.DialogResult == DialogResult.OK)
            {
                MessageBox.Show("Update successfully!");
                showDatainListView(studentSQL, lstStudent);
            }
            btnMaintainStudent.Enabled = false;
            btnDeleteStudent.Enabled = false;
        }
        private void deleteStudent()
        {
            String sql = "delete from student where studentID='" + lstStudent.SelectedItems[0].SubItems[0].Text + "'";
            OleDbCommand cmd = new OleDbCommand(sql, connection);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Teacher:" + lstStudent.SelectedItems[0].SubItems[1].Text + " Deleted!");
            showDatainListView(studentSQL, lstStudent);
            btnMaintainStudent.Enabled = false;
            btnDeleteStudent.Enabled = false;
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

        private void StudentControl_Load(object sender, EventArgs e)
        {
            lstStudent.FullRowSelect = true;
            lstStudent.GridLines = true;
            lstStudent.MultiSelect = false;
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.Control | Keys.A))
                btnAddStudent.PerformClick();

            if (keyData == (Keys.Control | Keys.M))
            {
                if (btnMaintainStudent.Enabled == true)
                    btnMaintainStudent.PerformClick();
                else
                    MessageBox.Show("Please select a item first!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (keyData == (Keys.Control | Keys.D))
            {
                if(btnDeleteStudent.Enabled == true)
                    btnDeleteStudent.PerformClick();
                else
                    MessageBox.Show("Please select a item first!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
        private void lstStudent_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstStudent.SelectedItems.Count > 0)
            {
                btnMaintainStudent.Enabled = true;
                btnDeleteStudent.Enabled = true;
            }
            else
            {
                btnMaintainStudent.Enabled = false;
                btnDeleteStudent.Enabled = false;
            }
        }
    }
}
