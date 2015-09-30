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
    public partial class PromotionControl : UserControl
    {
        OleDbConnection connection;
        OleDbDataAdapter dataAdapter;
        DataTable dt;

        string promotionSQL = "select promotionID,name,description,additionalDiscount,Format(startTime,'dd/MM/yyyy'),Format(endTime,'dd/MM/yyyy') from promotion";
        public PromotionControl(OleDbConnection connection)
        {
            InitializeComponent();
            this.connection = connection;
            showDatainListView(promotionSQL, lstPromotion);
        }

        private void PromotionControl_Load(object sender, EventArgs e)
        {
            lstPromotion.MultiSelect = false;
            lstPromotion.GridLines = true;
            lstPromotion.FullRowSelect = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            addPromotion();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            maintainPromotion();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            deletePromotion();
        }
        private void addPromotion()
        {
            MaintainPromotion mp = new MaintainPromotion(connection, null, true);
            mp.ShowDialog();
            if (mp.DialogResult == DialogResult.OK)
            {
                MessageBox.Show("Add Promotion successfully!");
                showDatainListView(promotionSQL, lstPromotion);
            }
            btnMaintainStudent.Enabled = false;
            btnDeleteStudent.Enabled = false;
        }
        private void maintainPromotion()
        {
            MaintainPromotion mp = new MaintainPromotion(connection, lstPromotion.SelectedItems[0]);
            mp.ShowDialog();
            if (mp.DialogResult == DialogResult.OK)
            {
                MessageBox.Show("Update Promotion successfully!");
                showDatainListView(promotionSQL, lstPromotion);
            }
            btnMaintainStudent.Enabled = false;
            btnDeleteStudent.Enabled = false;
        }
        private void deletePromotion()
        {
            String sql = "delete from promotion where promotionID='" + lstPromotion.SelectedItems[0].SubItems[0].Text + "'";
            OleDbCommand cmd = new OleDbCommand(sql, connection);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Promotion: " + lstPromotion.SelectedItems[0].SubItems[1].Text + " Deleted!");
            showDatainListView(promotionSQL, lstPromotion);
            btnMaintainStudent.Enabled = false;
            btnDeleteStudent.Enabled = false;
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

        private void lstPromotion_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstPromotion.SelectedItems.Count > 0)
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
