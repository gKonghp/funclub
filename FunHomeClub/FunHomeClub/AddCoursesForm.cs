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
    public partial class AddCoursesForm : Form
    {
        private string connStr = ConfigurationManager.ConnectionStrings["FunHomeClub.Properties.Settings.masterDBConnectionString"].ToString();
        private OleDbConnection conn;
        private OleDbDataAdapter adapter;
        private double profitMargin;
        private DataTable coursesList;
        private CourseRegForm courseReg;
        private double precentage;
        public AddCoursesForm(CourseRegForm courseReg, double profitMargin)
        {
            InitializeComponent();
            conn = new OleDbConnection(connStr);
            this.profitMargin = profitMargin;
            this.courseReg = courseReg;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void AddCoursesForm_Load(object sender, EventArgs e)
        {
            //fetch category into combobox
            cbbCategory.Items.Clear();
            string sql = string.Format("SELECT * FROM courseCategory");
            adapter = new OleDbDataAdapter(sql, conn);
            adapter.Fill(masterDBDataSet, "courseCategory");
            adapter.Dispose();
            cbbCategory.Items.Add(new ComboBoxItem("&", "All"));
            cbbCategory.SelectedIndex = 0;
            foreach (DataRow row in masterDBDataSet.courseCategory)
            {
                cbbCategory.Items.Add(new ComboBoxItem(row["categoryID"].ToString(), row["name"].ToString()));
            }
            FillAll(); //fill All records;
            FillListView(); //fill ListView;

            // find the profitMargin
            sql = string.Format("SELECT * FROM profitMargin WHERE profitMarginID = '{0}'", "pm0001");
            adapter = new OleDbDataAdapter(sql, conn);
            adapter.Fill(masterDBDataSet, "profitMargin");
            adapter.Dispose();

            precentage = Convert.ToDouble(masterDBDataSet.profitMargin.Rows[0]["percentage"].ToString());
        }

        private void cbbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Fetch CourseName
            cbbCourseName.Items.Clear();
            string categoryID = ((ComboBoxItem)cbbCategory.Items[cbbCategory.SelectedIndex]).Value;
            string sql = string.Format("SELECT * FROM Course WHERE categoryID = '{0}'", categoryID);
            adapter = new OleDbDataAdapter(sql, conn);
            adapter.Fill(masterDBDataSet, "Course");
            cbbCourseName.Items.Add(new ComboBoxItem("&", "All"));
            cbbCourseName.SelectedIndex = 0;
            foreach (DataRow row in masterDBDataSet.course.Rows)
            {
                cbbCourseName.Items.Add(new ComboBoxItem(row["courseID"].ToString(), row["name"].ToString()));
            }
        }
        public void FillAll()
        {
            string sql = string.Format("SELECT cc.name, c.name, weekday, startMonth, endMonth, startTime, endTime, ((teacherRate + operatingCharges) * " +
   profitMargin + ") / 10 as Price, room, courseID FROM course c, courseCategory cc WHERE c.categoryID = cc.categoryID");
            adapter = new OleDbDataAdapter(sql, conn);
            coursesList = new DataTable();
            adapter.Fill(coursesList);
            adapter.Dispose();
        }
        public void FillListView()
        {
            lstCourseDetail.Items.Clear();
            for (int i = 0; i < coursesList.Rows.Count; i++)
                lstCourseDetail.Items.Clear();
            foreach(DataRow row in coursesList.Rows)
            {
                ListViewItem item = new ListViewItem(row["cc.name"].ToString());
                item.SubItems.Add(row["courseID"].ToString());
                item.SubItems.Add(row["c.name"].ToString());
                item.SubItems.Add(row["weekday"].ToString());
                item.SubItems.Add(row["startMonth"].ToString());
                item.SubItems.Add(row["endMonth"].ToString());
                item.SubItems.Add(row["startTime"].ToString());
                item.SubItems.Add(row["endTime"].ToString());
                item.SubItems.Add(row["Price"].ToString());
                //item.SubItems.Add(row["quota"].ToString());
                item.SubItems.Add(row["room"].ToString());
                lstCourseDetail.Items.Add(item);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
         {
            string selectString = "SELECT DISTINCT cc.name, c.name, weekday, startMonth, endMonth, startTime, endTime,  ((teacherRate + operatingCharges) * " +
               profitMargin + ") / 10 as Price, room, c.courseID FROM course c, courseCategory cc, courseMonth cm WHERE c.categoryID = cc.categoryID" + " AND cm.courseID = c.courseID"
                 + " AND quota >= " + Convert.ToInt32(nudQuota.Value.ToString());

            if (txtCourseID.Text.Trim().Length <= 0)
            {
                if (cbbMonth.SelectedIndex > 0)
                    selectString += " AND " + cbbMonth.SelectedIndex + " BETWEEN startMonth AND endMonth";

                if (cbbCourseName.SelectedIndex > 0 && !((ComboBoxItem)cbbCourseName.Items[cbbCourseName.SelectedIndex]).Value.ToString().Equals("&"))
                    selectString += " AND  c.courseID ='" + ((ComboBoxItem)cbbCourseName.Items[cbbCourseName.SelectedIndex]).Value.ToString() + "'";

                if (cbbWeekday.SelectedIndex > 0)
                    selectString += " AND weekday =" + cbbWeekday.SelectedIndex;

                if (nudPriceFrom.Value > 0 || nudPriceTo.Value > 0)
                    selectString += " AND ((teacherRate + operatingCharges) * " + profitMargin + ") / 10 BETWEEN " + nudPriceFrom.Text + " AND " + nudPriceTo.Text;

                if (cbbCategory.SelectedIndex >= 0 && !((ComboBoxItem)cbbCategory.Items[cbbCategory.SelectedIndex]).Value.ToString().Equals("&"))
                    selectString += " AND cc.categoryID = '" + ((ComboBoxItem)cbbCategory.Items[cbbCategory.SelectedIndex]).Value.ToString() + "'";

                 selectString += string.Format(" AND startTime >= #{0}# AND endTime <= #{1}#", String.Format("{0:H:mm}", dtpStartTime.Value), String.Format("{0:H:mm}", dtpEndTime.Value));
            }
            else
            {
                selectString += " AND  c.courseID ='" + txtCourseID.Text.Trim()+"'";
            }

            adapter = new OleDbDataAdapter(selectString, conn);
            coursesList.Clear();
            adapter.Fill(coursesList);
            FillListView();
         }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem selectedItem in lstCourseDetail.SelectedItems)
            {
                DataRow row = coursesList.Rows[selectedItem.Index];
                //the comment below moved to coursePeriodForm
                //bool isClashed = courseReg.IsCourseClashInList(row["courseID"].ToString()); 
                //if (!isClashed)
                //{
                    string courseID = row["courseID"].ToString();
                    string courseName = row["c.name"].ToString();
                    int startMonth = Convert.ToInt32(row["startMonth"].ToString());
                    int endMonth = Convert.ToInt32(row["endMonth"].ToString());
                    string catName = row["cc.name"].ToString();
                    int weekday = Convert.ToInt32(row["weekday"].ToString());
                    string startTime = row["startTime"].ToString();
                    string endTime = row["endTime"].ToString();
                    double price = Convert.ToDouble(row["price"].ToString());
                    string room = row["room"].ToString();
                    //int quota = Convert.ToInt32(row["quota"].ToString()); 

                    CoursePeriodForm frmCoursePeriod = new CoursePeriodForm(courseReg, catName, courseID, courseName, weekday,  startMonth, endMonth, startTime, endTime, price, room);
                    frmCoursePeriod.ShowDialog();
                    /*
                    ListViewItem item = new ListViewItem(row["cc.name"].ToString());
                    item.SubItems.Add(row["courseID"].ToString());
                    item.SubItems.Add(row["c.name"].ToString());
                    item.SubItems.Add(row["weekday"].ToString());
                    item.SubItems.Add(row["startMonth"].ToString());
                    item.SubItems.Add(row["endMonth"].ToString());
                    item.SubItems.Add(row["startTime"].ToString());
                    item.SubItems.Add(row["endTime"].ToString());
                    item.SubItems.Add(row["Price"].ToString());
                    item.SubItems.Add(row["quota"].ToString());
                    item.SubItems.Add(row["room"].ToString());
                    courseReg.ltvRegCourseList.Items.Add(item);

                    courseReg.updateTotalPrice();
                    */
                //}
            }
            //this.Dispose();

        }

        private void lstCourseDetail_DoubleClick(object sender, EventArgs e)
        {
            if (lstCourseDetail.SelectedItems.Count > 1)
                MessageBox.Show("Cannot view multi-courses in the same time.");
            else if (lstCourseDetail.SelectedItems.Count == 1)
            {
                int idx = lstCourseDetail.SelectedItems[0].Index;
                CourseDetail cd = new CourseDetail(conn, lstCourseDetail.Items[idx].SubItems[CourseID.Index].Text);
                cd.ShowDialog();
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtCourseID.Clear();
            cbbCategory.SelectedIndex = 0;
            cbbCourseName.SelectedIndex = 0;
            nudQuota.Value = 0;
            nudPriceFrom.Value = 0;
            nudPriceTo.Value = 0;
            cbbMonth.SelectedIndex = 0;
            cbbWeekday.SelectedIndex = 0;
            dtpStartTime.Value = Convert.ToDateTime("0:00:00");
            dtpEndTime.Value = Convert.ToDateTime("23:59:59");
            lstCourseDetail.Items.Clear();
            FillAll();
            FillListView();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
