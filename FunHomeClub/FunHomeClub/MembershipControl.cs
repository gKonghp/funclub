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
    public partial class MembershipControl : UserControl
    {
        private OleDbConnection connection;
        private DataTable dt;
        private OleDbDataAdapter dataAdapter;
        public MembershipControl(OleDbConnection connection)
        {
            InitializeComponent();
            this.connection = connection;
            lstMembership.FullRowSelect = true;
            lstMembership.GridLines = true;
            lstMembership.MultiSelect = false;
            ShowMembership();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            MaintainMembership mms = new MaintainMembership("Add", connection);
            if (mms.ShowDialog().Equals(DialogResult.OK))
            {
                ShowMembership();
            }
            AfterListMemberchange();
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            MaintainMembership mms = new MaintainMembership("Change", lstMembership.Items[lstMembership.SelectedItems[0].Index].Text, connection);
            if (mms.ShowDialog().Equals(DialogResult.OK))
            {
                ShowMembership();
            }
            AfterListMemberchange();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dResult = MessageBox.Show("Do you conform to delete this record?", "Warnning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dResult == DialogResult.Yes)
            {
                new OleDbCommand("DELETE FROM memberShip WHERE membershipID = '" + lstMembership.Items[lstMembership.SelectedItems[0].Index].Text + "'", connection).ExecuteNonQuery();
                MessageBox.Show("Delete Successful!");
                ShowMembership();
                AfterListMemberchange();
            }
        }

        private void lstMembership_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstMembership.SelectedItems.Count <= 0)
            {
                btnChange.Enabled = false;
                btnDelete.Enabled = false;
            }
            else
            {
                btnChange.Enabled = true;
                btnDelete.Enabled = true;
            }
        }
        public void AfterListMemberchange()
        {
            btnChange.Enabled = false;
            btnDelete.Enabled = false;
        }
        private void ShowMembership()
        {
            lstMembership.Items.Clear();
            String sql = "SELECT * FROM membership";
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
                lstMembership.Items.Add(item);
            }
        }

        private void MembershipControl_Load(object sender, EventArgs e)
        {
            lstMembership.FullRowSelect = true;
            lstMembership.GridLines = true;
            lstMembership.MultiSelect = false;
        }

        private void lstMembership_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (lstMembership.SelectedItems.Count > 0)
            {
                btnChange.Enabled = true;
                btnDelete.Enabled = true;
            }
            else
            {
                btnChange.Enabled = false;
                btnDelete.Enabled = false;
            }
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.Control | Keys.A))
                btnAdd.PerformClick();

            if (keyData == (Keys.Control | Keys.M))
            {
                if (btnChange.Enabled == true)
                    btnChange.PerformClick();
                else
                    MessageBox.Show("Please select a item first!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (keyData == (Keys.Control | Keys.D))
            {
                if(btnDelete.Enabled == true)
                    btnDelete.PerformClick();
                else
                    MessageBox.Show("Please select a item first!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            return base.ProcessCmdKey(ref msg, keyData);
        }
    }
}
