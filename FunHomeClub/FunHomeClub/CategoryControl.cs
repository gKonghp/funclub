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
    public partial class CategoryControl : UserControl
    {
        OleDbConnection connection;
        string categorySQL = "select * from courseCategory order by categoryID asc";
        DataTable dt;
        OleDbDataAdapter dataAdapter;
        public CategoryControl()
        {
            InitializeComponent();
        }
        public CategoryControl(OleDbConnection connection)
        {
            InitializeComponent();
            this.connection = connection;
            showDatainListView(categorySQL, lstCategory);
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
        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            MaintainCategory mc = new MaintainCategory(connection, null);
            mc.StartPosition = FormStartPosition.CenterParent;
            mc.ShowDialog();
            if(mc.DialogResult == DialogResult.OK)
            {
                MessageBox.Show("Add category successfully!", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
                showDatainListView(categorySQL, lstCategory);
            }
            btnDeleteCategory.Enabled = false;
            btnMaintainCategory.Enabled = false;
            
        }

        private void CategoryControl_Load(object sender, EventArgs e)
        {
            lstCategory.FullRowSelect = true;
            lstCategory.GridLines = true;
            lstCategory.MultiSelect = false;
        }
        
        private void lstCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnDeleteCategory.Enabled = btnMaintainCategory.Enabled = (lstCategory.SelectedItems.Count > 0 ? true : false);
            
        }

        private void btnMaintainCategory_Click(object sender, EventArgs e)
        {
            MaintainCategory mc = new MaintainCategory(connection, lstCategory.SelectedItems[0]);
            mc.StartPosition = FormStartPosition.CenterParent;
            mc.ShowDialog();
            if(mc.DialogResult == DialogResult.OK)
            {
                MessageBox.Show("Update category successfully!", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
                showDatainListView(categorySQL, lstCategory);
            }

        }

        private void btnDeleteCategory_Click(object sender, EventArgs e)
        {
            String deleteSQL = "delete from courseCategory where categoryID='" + lstCategory.SelectedItems[0].SubItems[0].Text + "'";
            OleDbCommand cmd = new OleDbCommand(deleteSQL, connection);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Category - " + lstCategory.SelectedItems[0].SubItems[1].Text + " deleted!", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
            showDatainListView(categorySQL, lstCategory);

        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.Control | Keys.A))
                btnAddCategory.PerformClick();

            if (keyData == (Keys.Control | Keys.M))
            {
                if(btnMaintainCategory.Enabled == true)
                    btnMaintainCategory.PerformClick();
                else
                    MessageBox.Show("Please select a item first!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (keyData == (Keys.Control | Keys.D))
            {
                if(btnDeleteCategory.Enabled == true)
                    btnDeleteCategory.PerformClick();
                else
                    MessageBox.Show("Please select a item first!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
    }
}
