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
    public partial class CourseConfirmForm : Form
    {
        private CourseRegForm courseReg;
        string connStr = ConfigurationManager.ConnectionStrings["FunHomeClub.Properties.Settings.masterDBConnectionString"].ToString();
        private OleDbConnection conn;
        private string invoiceID;
        public CourseConfirmForm(CourseRegForm courseReg)
        {
            InitializeComponent();
            conn = new OleDbConnection(connStr);
            this.courseReg = courseReg;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void CourseConfirmForm_Load(object sender, EventArgs e)
        {
            this.lblContactNum_d.Text = courseReg.lblContactNum_d.Text;
            this.lblDiscount_d.Text = courseReg.lblDiscount_d.Text;
            this.lblEmailAddress_d.Text = courseReg.lblEmailAddress_d.Text;
            this.lblMembership_d.Text = courseReg.lblMembership_d.Text;
            this.lblOriginalTotal_d.Text = courseReg.lblOriginalTotal_d.Text;
            this.lblStudentID_d.Text = courseReg.studentID;
            this.lblStudName_d.Text = courseReg.lblStudName_d.Text;
            this.ltvRegCourseList.Items.Clear();
            foreach (ListViewItem item in courseReg.ltvRegCourseList.Items)
                this.ltvRegCourseList.Items.Add((ListViewItem)item.Clone());
            this.ltvRegCourseDetail.Items.Clear();
            foreach (ListViewItem item in courseReg.ltvRegCourseDetail.Items)
                this.ltvRegCourseDetail.Items.Add((ListViewItem)item.Clone()); ;
            this.lblTotal_d.Text = courseReg.lblTotal_d.Text;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (registerCourse())
            {
                MessageBox.Show("Successful Registration");

                this.Dispose();
                courseReg.Dispose();
                InvoicePreviewForm frm1 = new InvoicePreviewForm(invoiceID);
                frm1.ShowDialog();
            }
            else
                MessageBox.Show("Fail Registration");
        }

        private bool registerCourse()
        {
            string sql;
            OleDbDataAdapter invoiceAdapter, studentCourseAdapter, courseAdapter;
            //Fetch Invoice Table
            sql = string.Format("SELECT * FROM Invoice");
            invoiceAdapter = new OleDbDataAdapter(sql, conn);
            DataTable invoiceTable = masterDBDataSet1.invoice;
            invoiceAdapter.Fill(invoiceTable);

            //Fetch studentCourse Table
            sql = string.Format("SELECT * FROM studentCourse");
            studentCourseAdapter = new OleDbDataAdapter(sql, conn);
            DataTable studentCourseTable = masterDBDataSet1.studentCourse;
            studentCourseAdapter.Fill(studentCourseTable);

            // Get the current Time
            DateTime now = DateTime.Now;
            string nowStr = String.Format("{0:d/M/yyyy}", now);

            //Fetch Course Table
            sql = string.Format("SELECT * FROM Course");
            courseAdapter = new OleDbDataAdapter(sql, conn);
            DataTable courseTable = masterDBDataSet1.course;
            courseAdapter.Fill(courseTable);

            //Add Record of Invoice
            invoiceID = Utility.findAvailableID(invoiceTable, "invoiceID", "in", "000");
            DataRow invoiceRow = invoiceTable.NewRow();
            invoiceRow["invoiceID"] = invoiceID;
            string employeeID = ((MainForm)this.MdiParent.FindForm()).employee.employeeID;
            invoiceRow["employeeID"] = employeeID;
            invoiceRow["date"] = nowStr;

            string totalCostStr = lblTotal_d.Text.Substring(2, lblTotal_d.Text.Length - 2);
            invoiceRow["totalCost"] = Convert.ToInt32(totalCostStr);
            // ?????? Promotional ID?????
            invoiceRow["promotionID"] = "123";
            sql = string.Format("INSERT INTO Invoice VALUES('{0}', '{1}', '{2}', {3}, '{4}')", invoiceID, employeeID, nowStr, Convert.ToInt32(totalCostStr), "123");
            OleDbCommand invoiceCmd = new OleDbCommand(sql, conn);
            invoiceAdapter.InsertCommand = invoiceCmd;
            invoiceTable.Rows.Add(invoiceRow);
            try
            {
                foreach (ListViewItem item in ltvRegCourseList.Items)
                    {

                    string courseID = item.SubItems[CourseID.Index].Text;
                    //Update course quota
                    DataRow[] row = courseTable.Select(string.Format("courseID = '{0}'", courseID));
                    int quota = Convert.ToInt32(row[0]["quota"].ToString());
                    row[0]["quota"] = quota - 1;
                    sql = string.Format("UPDATE Course SET quota = quota-1 WHERE courseID = '{0}'", courseID);
                    OleDbCommand courseCmd = new OleDbCommand(sql, conn);
                    courseAdapter.UpdateCommand = courseCmd;

                    //Add Record of studentCourse
                    DataRow studentCourseRow = studentCourseTable.NewRow();
                    studentCourseRow["studentID"] = lblStudentID_d.Text;
                    studentCourseRow["courseID"] = courseID;
                    studentCourseRow["enrollDate"] = nowStr;
                   
                    int cost = Convert.ToInt32(Math.Ceiling(Convert.ToDouble(item.SubItems[Price.Index].Text)));
                    studentCourseRow["cost"] = cost;
                    studentCourseRow["invoiceID"] = invoiceID;
                    sql = string.Format("INSERT INTO studentCourse VALUES('{0}', '{1}', '{2}', {3}, '{4}')", lblStudentID_d.Text, courseID, nowStr, cost, invoiceID);
                    OleDbCommand studentCourseRowCmd = new OleDbCommand(sql, conn);
                    studentCourseAdapter.InsertCommand = studentCourseRowCmd;
                    studentCourseTable.Rows.Add(studentCourseRow);
                    studentCourseAdapter.Update(studentCourseTable);

                    courseAdapter.Update(courseTable);
                }
                invoiceAdapter.Update(invoiceTable);
                return true;
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
                return false;
            }
        }
    }
}
