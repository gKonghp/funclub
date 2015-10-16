using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FunHomeClub
{
    public partial class InvoiceHistoryForm : Form
    {
        private string connStr = ConfigurationManager.ConnectionStrings["FunHomeClub.Properties.Settings.masterDBConnectionString"].ToString();
        private OleDbConnection conn;
        private OleDbDataAdapter adapter;
        private DataTable invoiceList;
        public InvoiceHistoryForm()
        {
            InitializeComponent();
            invoiceList = new DataTable();
            conn = new OleDbConnection(connStr);
        }

        private void InvoiceHistoryForm_Load(object sender, EventArgs e)
        {
            FillAll(); //fill All records;
            FillListView(); //fill ListView;
            if(cbbSortedBy.Items.Count > 0)
                cbbSortedBy.SelectedIndex = 0;
        }

        public void FillAll()
        {
            invoiceList.Clear();
            string sql = string.Format("SELECT Distinct Invoice.invoiceID, s.studentID, s.name, Invoice.Date, Invoice.totalCost, ms.discount as discount, Invoice.employeeID FROM Invoice, Student s, StudentCourse sc, Membership ms WHERE Invoice.invoiceID = sc.invoiceID AND sc.studentID = s.studentID AND s.membershipID = ms.membershipID ORDER BY Invoice.invoiceID, s.StudentID");
            adapter = new OleDbDataAdapter(sql, conn);
            adapter.Fill(invoiceList);
            adapter.Dispose();
            foreach (DataRow row in invoiceList.Rows)
            {
                DataTable promotionMatch = new DataTable();
                sql = string.Format("SELECT additionalDiscount From Promotion, Invoice WHERE Promotion.promotionID = Invoice.promotionID AND invoiceID = '{0}'", row["invoiceID"].ToString());
                adapter = new OleDbDataAdapter(sql, conn);
                adapter.Fill(promotionMatch);
                adapter.Dispose();
                if (promotionMatch.Rows.Count > 0)
                {
                    row["discount"] = Convert.ToDouble(row["discount"].ToString()) * Convert.ToDouble(promotionMatch.Rows[0]["additionalDiscount"].ToString());
                }
            }
        }
        public void FillListView()
        {
            ltvInvoice.Items.Clear();
            foreach (DataRow row in invoiceList.Rows)
            {
                bool duplicate = false;
                foreach (ListViewItem listItem in ltvInvoice.Items)
                {
                    if (listItem.Text.Equals(row["invoiceID"].ToString()))
                    {
                        duplicate = true;
                        break;
                    }
                }
                
                if (duplicate)
                    continue;
                ListViewItem item = new ListViewItem(row["invoiceID"].ToString());
                item.SubItems.Add(row["studentID"].ToString());
                item.SubItems.Add(row["name"].ToString());
                item.SubItems.Add(Convert.ToDateTime(row["date"].ToString()).ToShortDateString());
                item.SubItems.Add(row["totalCost"].ToString());
                if(Convert.ToDouble(row["discount"].ToString())<1)     
                    item.SubItems.Add((1-Convert.ToDouble(row["discount"].ToString()))*100 + "% OFF");
                else
                    item.SubItems.Add("--");
                item.SubItems.Add(row["employeeID"].ToString());
                ltvInvoice.Items.Add(item);


            }
        }

        private void ltvInvoice_DoubleClick(object sender, EventArgs e)
        {
            if (ltvInvoice.SelectedItems.Count > 0)
            {
                int idx = ltvInvoice.SelectedItems[0].Index;
                InvoicePreviewForm frmInvoicePreview = new InvoicePreviewForm(invoiceList.Rows[idx]["invoiceID"].ToString());
                frmInvoicePreview.ShowDialog();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            //Check Format

            string sql = string.Format("SELECT Invoice.invoiceID, s.studentID, s.name, Invoice.Date, Invoice.totalCost, ms.discount, Invoice.employeeID FROM Invoice, Student s, StudentCourse sc, Membership ms WHERE Invoice.invoiceID = sc.invoiceID AND sc.studentID = s.studentID AND s.membershipID = ms.membershipID");
            //if (txtInvoiceID.Text.Trim().Length <= 0)
            //{
                if (txtCourseID.Text.Trim().Length > 0)
                    sql += string.Format(" AND sc.courseID = '{0}'", txtCourseID.Text.Trim());

                if (txtStudentID.Text.Trim().Length > 0)
                    sql += string.Format(" AND sc.studentID = '{0}'", txtStudentID.Text.Trim());

                sql += string.Format(" AND date BETWEEN #{0}# AND #{1}#", String.Format("{0:d/M/yyyy}", dtpDataFrom.Value), String.Format("{0:d/M/yyyy}", dtpDateTo.Value.ToShortDateString()));
              
                if (nudPriceFrom.Value > 0 || nudPriceTo.Value > 0)
                    sql += string.Format(" AND totalCost BETWEEN {0} AND {1}", nudPriceFrom.Value, nudPriceTo.Value);
            //}
            //else
            //{
            if(txtInvoiceID.Text.Trim().Length >0)
                sql += " AND  Invoice.invoiceID ='" + txtInvoiceID.Text.Trim() + "'";
            //}

            if (cbbSortedBy.SelectedItem.ToString().Equals("Invoice ID"))
                sql += " ORDER BY Invoice.invoiceID, s.studentID";
            else
            {
                if (cbbSortedBy.SelectedItem.ToString().Equals("Student ID"))
                    sql += "ORDER BY s.studentID";
                if (cbbSortedBy.SelectedItem.ToString().Equals("Date"))
                    sql += "ORDER BY Invoice.Date";
                if (cbbSortedBy.SelectedItem.ToString().Equals("Cost"))
                    sql += "ORDER BY Invoice.totalCost";
                sql += " , Invoice.invoiceID";
            }


            adapter = new OleDbDataAdapter(sql, conn);
            invoiceList.Clear();
            adapter.Fill(invoiceList);
            adapter.Dispose();

            foreach (DataRow row in invoiceList.Rows)
            {
                DataTable promotionMatch = new DataTable();
                sql = string.Format("SELECT additionalDiscount From Promotion, Invoice WHERE Promotion.promotionID = Invoice.promotionID AND invoiceID = '{0}'", row["invoiceID"].ToString());
                adapter = new OleDbDataAdapter(sql, conn);
                adapter.Fill(promotionMatch);
                adapter.Dispose();
                if (promotionMatch.Rows.Count > 0)
                {
                    row["discount"] = Convert.ToDouble(row["discount"].ToString()) * Convert.ToDouble(promotionMatch.Rows[0]["additionalDiscount"].ToString());
                }
            }

            FillListView();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtCourseID.ResetText();
            txtInvoiceID.ResetText();
            txtStudentID.ResetText();
            dtpDataFrom.Value = Convert.ToDateTime("1/1/1753");
            dtpDateTo.Value = Convert.ToDateTime(DateTime.Now.ToShortDateString());
            nudPriceFrom.Value = 0;
            nudPriceTo.Value = 0;
            ltvInvoice.Items.Clear();
            FillAll();
            FillListView();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
