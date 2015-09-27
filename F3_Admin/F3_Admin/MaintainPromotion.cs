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
    public partial class MaintainPromotion : Form
    {
        OleDbConnection connection;
        OleDbDataAdapter dataAdapter;
        String promotionID;
        public MaintainPromotion()
        {
            InitializeComponent();
        }
        public MaintainPromotion(OleDbConnection connection,ListViewItem lstItem,Boolean isAdd = false)
        {
            InitializeComponent();
            this.connection = connection;
            if(!isAdd)
            {
                txtName.Text = lstItem.SubItems[1].Text;
                this.promotionID = lstItem.SubItems[0].Text;
                numDiscount.Value = decimal.Parse(lstItem.SubItems[3].Text);
                String[] startTime = lstItem.SubItems[4].Text.Split('/');
                String[] endTime = lstItem.SubItems[5].Text.Split('/');
                txtDescription.Text = lstItem.SubItems[2].Text;
                dtpStartTime.Value = new DateTime(Int32.Parse(startTime[2]), Int32.Parse(startTime[1]), Int32.Parse(startTime[0]));
                dtpEndTime.Value = new DateTime(Int32.Parse(endTime[2]), Int32.Parse(endTime[1]), Int32.Parse(endTime[0]));
            }
            btnAdd.Visible = isAdd;
            btnSave.Visible = !isAdd;
        }

        private void MaintainPromotion_Load(object sender, EventArgs e)
        {

        }
        private String getNextValidPromotionID()
        {
            DataTable dt = new DataTable();
            string sql = "SELECT promotionID from promotion order by promotionID desc";
            dataAdapter = new OleDbDataAdapter(sql, connection);
            dataAdapter.Fill(dt);
            if (Int32.Parse(dt.Rows[0][0].ToString().Substring(2)) != dt.Rows.Count)
                for (int i = 0; i < dt.Rows.Count; i++)
                    if (i + 1 != Int32.Parse(dt.Rows[dt.Rows.Count - i - 1][0].ToString().Substring(2)))
                        return String.Format("pr{0:D4}", i + 1).ToString();
            return String.Format("pr{0:D4}", Int32.Parse(dt.Rows[0][0].ToString().Substring(2)) + 1).ToString();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            String sql = "insert into promotion values('" + getNextValidPromotionID() + "','" + txtName.Text + "','" + txtDescription.Text + "','" + numDiscount.Value.ToString() + "','" + dtpStartTime.Value.ToString("dd/MM/yyyy") + "','" + dtpEndTime.Value.ToString("dd/MM/yyyy") + "')";
            OleDbCommand cmd = new OleDbCommand(sql, connection);
            cmd.ExecuteNonQuery();
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            String sql = "update promotion set name='" + txtName.Text + "',description='" + txtDescription.Text + "',additionalDiscount='" + numDiscount.Value.ToString() + "',startTime='" + dtpStartTime.Value.ToString("dd/MM/yyyy") + "',endTime='" + dtpEndTime.Value.ToString("dd/MM/yyyy") + "' where promotionID = '" + this.promotionID + "'";
            OleDbCommand cmd = new OleDbCommand(sql, connection);
            cmd.ExecuteNonQuery();
            this.Close();
        }
    }
}
