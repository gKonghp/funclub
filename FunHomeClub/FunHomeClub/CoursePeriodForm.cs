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
    public partial class CoursePeriodForm : Form
    {
        private CourseRegForm frmCourseReg;
        string connStr = ConfigurationManager.ConnectionStrings["FunHomeClub.Properties.Settings.masterDBConnectionString"].ToString();
        private OleDbDataAdapter adapter;
        private OleDbConnection conn;
        private string[] mapMonth = { "Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec" };
        private string courseID;
        private string name;
        private string catName;
        private int weekday;
        private string room;
        private string startTime;
        private string endTime;
        private int startMonth;
        private int endMonth;
        private double price;
        private int startPeriod;
        private int endPeriod;
        private List<int> monthIgnoreList;
        public CoursePeriodForm()
        {
            InitializeComponent();
        }

        public CoursePeriodForm(CourseRegForm frmCourseReg, string catName, string courseID, string name, int weekday, int startMonth, int endMonth, string startTime, string endTime, double price, string room)
        {
            this.frmCourseReg = frmCourseReg;
            this.courseID = courseID;
            this.name = name;
            this.catName = catName;
            this.room = room;
            this.startTime = startTime;
            this.endTime = endTime;
            this.startMonth = startMonth;
            this.endMonth = endMonth;
            this.price = price;
            this.weekday = weekday;
            conn = new OleDbConnection(connStr);
            InitializeComponent();

        }

        private void CoursePeriodForm_Load(object sender, EventArgs e)
        {
            lblCourseID_d.Text = courseID;
            lblCourseName_d.Text = name;
            lblWeekday_d.Text = weekday.ToString();
            string sql = string.Format("SELECT * FROM courseMonth WHERE courseID = '{0}'", courseID);
            masterDBDataSet1.Clear();
            adapter = new OleDbDataAdapter(sql, conn);
            adapter.Fill(masterDBDataSet1.courseMonth);
            adapter.Dispose();
            monthIgnoreList = new List<int>();
            foreach (DataRow row in masterDBDataSet1.courseMonth)
            {
                int quota = Convert.ToInt32(row["quota"].ToString());
                int month = Convert.ToInt32(row["month"].ToString());
                if (quota <= 0)
                {
                    monthIgnoreList.Add(month);
                    lblMonthStatus.Visible = true;
                    lblMonthStatus.Text = "";
                }
            }

            //ADD
            for (int i = 0; i <= endMonth - startMonth; i++)
            {
                int indexMonth = monthIgnoreList.IndexOf(startMonth + i);
                if (indexMonth >= 0) // Ignore the empty quota month.
                {
                    if (indexMonth == 0)
                        lblMonthStatus.Text += "In month ";
                    if (monthIgnoreList.Count > 1 && indexMonth == monthIgnoreList.Count - 1)
                        lblMonthStatus.Text += " and ";
                    if (indexMonth == monthIgnoreList.Count - 1)
                        lblMonthStatus.Text += "[" + mapMonth[monthIgnoreList[indexMonth]-1] + "]" + " ";
                    else
                        lblMonthStatus.Text += "[" + mapMonth[monthIgnoreList[indexMonth] -1] + "]" + ", ";
                    continue;
                }
                cbbPeriodFrom.Items.Add(new ComboBoxItem((startMonth + i).ToString(), mapMonth[startMonth + i - 1]));
            }

            if (monthIgnoreList.Count > 1)
                lblMonthStatus.Text += ", the courses do not have enough quota.";
            else if (monthIgnoreList.Count == 1)
                lblMonthStatus.Text += ", the course does not have enough quota.";
            else
            {
                lblMonthStatus.Text = "";
                lblMonthStatus.Visible = false;
            }
            if (cbbPeriodFrom.Items.Count > 0)
                cbbPeriodFrom.SelectedIndex = 0;
            else
            {
                MessageBox.Show(this, "Quota of this course in all period is empty, please attemp another courses.", "Warning",MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Dispose();
            }
        }

        private void cbbPeriodFrom_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedValue = Convert.ToInt32(((ComboBoxItem)cbbPeriodFrom.SelectedItem).Value);
            cbbPeriodTo.Items.Clear();
            for (int i = 0; i <= endMonth - selectedValue; i++)
            {
                int indexMonth = monthIgnoreList.IndexOf(selectedValue + i);
                if (indexMonth >= 0) // Ignore the empty quota month.
                {
                    continue;
                }
                cbbPeriodTo.Items.Add(new ComboBoxItem((selectedValue + i).ToString(), mapMonth[selectedValue + i - 1]));
            }
            if (cbbPeriodTo.Items.Count > 0)
                cbbPeriodTo.SelectedIndex = cbbPeriodTo.Items.Count - 1;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (cbbPeriodFrom.SelectedItem == null)
            {
                MessageBox.Show(null, "You have not selected the period yet", "Warning",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            startPeriod = Convert.ToInt32(((ComboBoxItem)cbbPeriodFrom.SelectedItem).Value);
            endPeriod = Convert.ToInt32(((ComboBoxItem)cbbPeriodTo.SelectedItem).Value);
            //if (frmCourseReg.IsQuotaRemain(lblCourseID_d.Text))
            //{
            bool isClashed = frmCourseReg.IsCourseClashInList(lblCourseID_d.Text, startPeriod, endPeriod);
            if(!isClashed)
               isClashed = frmCourseReg.IsCourseClashInTime(lblCourseID_d.Text, startPeriod, endPeriod);
            if (!isClashed)
            {
                ListViewItem item = new ListViewItem(catName);
                item.SubItems.Add(courseID);
                item.SubItems.Add(name);
                item.SubItems.Add(weekday.ToString());
                item.SubItems.Add(startMonth.ToString() + "-" + endMonth.ToString());
                //item.SubItems.Add(endMonth.ToString());
                item.SubItems.Add(string.Format("{0:H:mm}", Convert.ToDateTime(startTime)) + "-" + string.Format("{0:H:mm}", Convert.ToDateTime(endTime)));
                //item.SubItems.Add(endTime);
                item.SubItems.Add(startPeriod.ToString() + "-" + endPeriod.ToString());
                //item.SubItems.Add(endPeriod.ToString());

                item.SubItems.Add(price.ToString());
                //item.SubItems.Add(quota.ToString());
                item.SubItems.Add(room);
                frmCourseReg.ltvRegCourseList.Items.Add(item);

                frmCourseReg.updateTotalPrice();

                Dispose();
            }
            //}
        }
    }
}
