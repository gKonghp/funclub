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
    public partial class CourseDetailControl : UserControl
    {
        OleDbConnection connection;
        OleDbDataAdapter dataAdapter;
        DataTable dt;
        string courseID;
        double profitMargin;
        double[] basicMonthFee = new double[3];
        double currentBasicPrice;
        public CourseDetailControl(OleDbConnection connection, string courseID)
        {
            InitializeComponent();
            this.connection = connection;
            this.courseID = courseID;

            string sql = "SELECT percentage FROM profitMargin WHERE profitMarginID = 'pm0001'";
            dataAdapter = new OleDbDataAdapter(sql, connection);
            dt = new DataTable();
            dataAdapter.Fill(dt);
            this.profitMargin = Convert.ToDouble(dt.Rows[0]["percentage"].ToString());

            txtDescription.ReadOnly = true;
            lstPromotion.GridLines = true;
            lstPromotion.FullRowSelect = true;
            lstPromotion.MultiSelect = false;
            lstQuota.GridLines = true;
            lstQuota.FullRowSelect = true;
            lstQuota.MultiSelect = false;

            sql = "SELECT * FROM course c, courseCategory cc, teacher t WHERE c.categoryID = cc.categoryID AND"
                + " c.teacherID = t.teacherID AND courseID = '" + courseID + "'";
            dataAdapter.SelectCommand.CommandText = sql;
            dt.Clear();
            dataAdapter.Fill(dt);

            txtID.Text = dt.Rows[0]["courseID"].ToString();
            txtName.Text = dt.Rows[0]["c.name"].ToString();
            txtCategory.Text = dt.Rows[0]["cc.name"].ToString();
            txtDescription.Text = dt.Rows[0]["description"].ToString();
            basicMonthFee[0] = ((Convert.ToInt32(dt.Rows[0]["teacherRate"].ToString()) + Convert.ToInt32(dt.Rows[0]["operatingCharges"].ToString())) * profitMargin) / 10;
            txtStartTime.Text = Convert.ToDateTime(dt.Rows[0]["startTime"].ToString()).ToShortTimeString();
            txtEndTime.Text = Convert.ToDateTime(dt.Rows[0]["endTime"].ToString()).ToShortTimeString();
            txtRoom.Text = dt.Rows[0]["room"].ToString();
            txtStartMonth.Text = dt.Rows[0]["startMonth"].ToString();
            txtEndMonth.Text = dt.Rows[0]["endMonth"].ToString();
            txtTeacher.Text = dt.Rows[0]["t.name"].ToString();
            txtMaterial.Text = dt.Rows[0]["materialCost"].ToString();
            this.Text = this.Text + txtName.Text;

            dt.Clear();
            dataAdapter.SelectCommand.CommandText = "SELECT * FROM membership";
            dataAdapter.Fill(dt);

            basicMonthFee[1] = basicMonthFee[0] * Convert.ToDouble(dt.Rows[1]["discount"].ToString());
            basicMonthFee[2] = basicMonthFee[0] * Convert.ToDouble(dt.Rows[2]["discount"].ToString());
            txtFee.Text = basicMonthFee[0].ToString();
            currentBasicPrice = basicMonthFee[0];
            FilllstQuota();
            FilllstPromotion();
        }

        private void rdoNone_CheckedChanged(object sender, EventArgs e)
        {
            txtFee.Text = basicMonthFee[0].ToString();
            currentBasicPrice = basicMonthFee[0];
            FilllstPromotion();
        }

        private void rdoNormal_CheckedChanged(object sender, EventArgs e)
        {
            txtFee.Text = basicMonthFee[1].ToString();
            currentBasicPrice = basicMonthFee[1];
            FilllstPromotion();
        }

        private void rdoGold_CheckedChanged(object sender, EventArgs e)
        {
            txtFee.Text = basicMonthFee[2].ToString();
            currentBasicPrice = basicMonthFee[2];
            FilllstPromotion();
        }
        private void FilllstQuota()
        {
            string sql = "SELECT month, quota FROM courseMonth WHERE courseID = '" + courseID + "'";
            lstQuota.Items.Clear();
            dt.Clear();
            dataAdapter.SelectCommand.CommandText = sql;
            dataAdapter.Fill(dt);

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                lstQuota.Items.Add(dt.Rows[i]["month"].ToString());
                lstQuota.Items[i].SubItems.Add(dt.Rows[i]["quota"].ToString());
                if (dt.Rows[i]["quota"].ToString().Equals("0"))
                {
                    lstQuota.Items[i].BackColor = Color.Salmon;
                }
            }
        }
        private void FilllstPromotion()
        {
            string sql = "SELECT name, additionalDiscount, additionalDiscount * " + currentBasicPrice + " as totalPrice FROM promotion WHERE #"
                + DateTime.Today.ToString("yyyy-M-d") + "# BETWEEN startTime AND endTime";
            lstPromotion.Items.Clear();
            dt.Clear();
            dataAdapter.SelectCommand.CommandText = sql;
            dataAdapter.Fill(dt);


            for (int i = 0; i < dt.Rows.Count; i++)
            {
                lstPromotion.Items.Add(dt.Rows[i]["name"].ToString());
                lstPromotion.Items[i].SubItems.Add(dt.Rows[i]["additionalDiscount"].ToString());
            }
        }

        private void lstPromotion_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstPromotion.SelectedItems.Count > 0)
            {
                txtFee.Text = dt.Rows[lstPromotion.SelectedItems[0].Index]["totalPrice"].ToString();
            }
        }

        private void chbAddional_CheckedChanged(object sender, EventArgs e)
        {
            if (chbAddional.Checked)
            {
                lstPromotion.Enabled = true;
                label15.Visible = true;
            }
            else
            {
                lstPromotion.Enabled = false;
                txtFee.Text = currentBasicPrice.ToString();
                label15.Visible = false;
            }
        }
    }
}
