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
    public partial class StaffControl : UserControl
    {
        OleDbConnection connection;
        DataTable dt;
        OleDbDataAdapter dataAdapter;
        string employeeSQL = "select * from employee";

        public StaffControl(OleDbConnection connection)
        {
            InitializeComponent();
            this.connection = connection;
            showDatainListView(employeeSQL, lstStaff);
        }

        private void btnAddStaff_Click(object sender, EventArgs e)
        {
            addStaff();
        }

        private void btnMaintainStaff_Click(object sender, EventArgs e)
        {
            maintainStaff();
        }

        private void btnDeleteStaff_Click(object sender, EventArgs e)
        {
            DialogResult dResult = MessageBox.Show("Do you conform to delete this record?", "Warnning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dResult == DialogResult.Yes)
            {
                deleteStaff();
            }
        }
        private void addStaff()
        {
            MaintainStaff ms = new MaintainStaff(connection, null, true);
            ms.ShowDialog();
            if (ms.DialogResult == DialogResult.OK)
            {
                MessageBox.Show("Add staff record successfully!!");
                showDatainListView(employeeSQL, lstStaff);
            }
            btnMaintainStaff.Enabled = false;
            btnDeleteStaff.Enabled = false;
        }
        private void maintainStaff()
        {
            MaintainStaff ms = new MaintainStaff(connection, lstStaff.SelectedItems[0]);
            ms.ShowDialog();
            if (ms.DialogResult == DialogResult.OK)
            {
                MessageBox.Show("Update successfully!!");
                showDatainListView(employeeSQL, lstStaff);
            }
            btnMaintainStaff.Enabled = false;
            btnDeleteStaff.Enabled = false;
        }
        private void deleteStaff()
        {
            String sql = "delete from employee where employeeID='" + lstStaff.SelectedItems[0].SubItems[0].Text + "'";
            OleDbCommand cmd = new OleDbCommand(sql, connection);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Staff:" + lstStaff.SelectedItems[0].SubItems[1].Text + " Deleted!");
            showDatainListView(employeeSQL, lstStaff);
            btnMaintainStaff.Enabled = false;
            btnDeleteStaff.Enabled = false;
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

        private void StaffControl_Load(object sender, EventArgs e)
        {
            lstStaff.MultiSelect = false;
            lstStaff.GridLines = true;
            lstStaff.FullRowSelect = true;
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.Control | Keys.A))
                btnAddStaff.PerformClick();

            if (keyData == (Keys.Control | Keys.M))
            {
                if (btnMaintainStaff.Enabled == true)
                    btnMaintainStaff.PerformClick();
                else
                    MessageBox.Show("Please select a item first!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (keyData == (Keys.Control | Keys.D))
            {
                if(btnDeleteStaff.Enabled == true)
                    btnDeleteStaff.PerformClick();
                else
                    MessageBox.Show("Please select a item first!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }
        private void lstStaff_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstStaff.SelectedItems.Count > 0)
            {
                btnMaintainStaff.Enabled = true;
                btnDeleteStaff.Enabled = true;
            }
            else
            {
                btnMaintainStaff.Enabled = false;
                btnDeleteStaff.Enabled = false;
            }
        }
    }
}
