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
    public partial class AddPromotionForm : Form
    {
        private OleDbConnection conn;
        private CourseRegForm frmCourseReg;
        private PromotionViewForm frmPromotionView;
        public AddPromotionForm(OleDbConnection conn, CourseRegForm frmCourseReg)
        {
            this.frmCourseReg = frmCourseReg;
            this.conn = conn;
            InitializeComponent();
        }

        private void AddPromotionForm_Load(object sender, EventArgs e)
        {
            FetchAll();
            FillList();
        }

        public void FetchAll()
        {
            DateTime now = DateTime.Now;
            masterDBDataSet1.promotion.Clear();
            string sql = string.Format("SELECT * FROM Promotion WHERE promotion.startTime <= #{0}# AND promotion.endTime >= #{0}#", String.Format("{0:M/d/yyyy}", now));
            OleDbDataAdapter adapter = new OleDbDataAdapter(sql, conn);
            adapter.Fill(masterDBDataSet1.promotion);
            adapter.Dispose();
        }

        public void FillList()
        {
            ltvPromotion.Items.Clear();
            foreach (DataRow row in masterDBDataSet1.promotion.Rows)
            {
                ListViewItem item = new ListViewItem(row["promotionID"].ToString());
                item.SubItems.Add(row["name"].ToString());
                item.SubItems.Add(row["description"].ToString());
                item.SubItems.Add(row["startTime"].ToString());
                item.SubItems.Add(row["endTime"].ToString());
                item.SubItems.Add(row["additionalDiscount"].ToString());
                ltvPromotion.Items.Add(item);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            masterDBDataSet1.promotion.Clear();
            string sql = string.Format("SELECT * FROM Promotion WHERE startTime <= #{0}# AND endTime >= #{0}# AND promotionID = '{1}'", String.Format("{0:M/d/yyyy}", now), txtPromotionID.Text.Trim());
            OleDbDataAdapter adapter = new OleDbDataAdapter(sql, conn);
            adapter.Fill(masterDBDataSet1.promotion);
            adapter.Dispose();
            FillList();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            /*
            foreach (ListViewItem selectedItem in ltvPromotion.SelectedItems)
            {
                ListViewItem item = new ListViewItem(selectedItem.Text);
                item.SubItems.Add(selectedItem.SubItems[name.Index].Text);
                item.SubItems.Add(selectedItem.SubItems[description.Index].Text);
                item.SubItems.Add(selectedItem.SubItems[discount.Index].Text);
                frmCourseReg.ltvPromotion.Items.Add(item);

                frmCourseReg.updateTotalPrice();    
            }
            */
            if (ltvPromotion.SelectedItems.Count == 1)
            {
                ListViewItem selectedItem = ltvPromotion.SelectedItems[0];
                frmCourseReg.lblPromotionID_d.Text = selectedItem.Text;
                frmCourseReg.lblPromotionName_d.Text = selectedItem.SubItems[name.Index].Text;
                frmCourseReg.lblPromotionDiscount_d.Text = selectedItem.SubItems[discount.Index].Text;
                frmCourseReg.updateTotalPrice();
                Dispose();
            }
            else if (ltvPromotion.SelectedItems.Count > 1)
            {
                MessageBox.Show("You is just able to select one promotion only.");
            }
            else
            {
                MessageBox.Show("No promotion is selected.");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtPromotionID.Clear();
            FetchAll();
            FillList();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void ltvPromotion_DoubleClick(object sender, EventArgs e)
        {
            if (ltvPromotion.SelectedItems.Count == 1)
            {
                string promotionID_d = ltvPromotion.SelectedItems[0].Text;
                frmPromotionView = new PromotionViewForm(conn, promotionID_d);
                frmPromotionView.ShowDialog();
            }
        }
    }
}
