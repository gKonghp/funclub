using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FunHomeClub
{
    public partial class PromotionViewForm : Form
    {
        private OleDbConnection conn;
        private string promotionID;
        public PromotionViewForm(OleDbConnection conn, string promotionID)
        {
            InitializeComponent();
            this.conn = conn;
            this.promotionID = promotionID;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void PromotionViewForm_Load(object sender, EventArgs e)
        {
            string sql = string.Format("SELECT * FROM promotion WHERE promotionID = '{0}'",promotionID);
            OleDbDataAdapter adapter = new OleDbDataAdapter(sql, conn);
            adapter.Fill(masterDBDataSet1.promotion);
            adapter.Dispose();

            DataRow row = masterDBDataSet1.promotion.Rows[0];

            lblName_d.Text = row["name"].ToString();
            lblTo_d.Text = string.Format("{0:d/M/yyyy}",Convert.ToDateTime(row["endTime"].ToString()));
            lblTime_d.Text = string.Format("{0:d/M/yyyy}", Convert.ToDateTime(row["startTime"].ToString()));
            lblPromotionID_d.Text = row["promotionID"].ToString();
            lblDiscount_d.Text = row["additionalDiscount"].ToString();
            lblDescription_d.Text = row["description"].ToString();
        }
    }
}
