using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FunHomeClub
{
    public partial class CoursePeriodForm : Form
    {
        private CourseRegForm frmCourseReg;
        private string[] mapMonth = { "Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec"};
        private string courseID;
        private string name;
        private string catName;
        private int weekday;
        private string room;
        private int quota;
        private string startTime;
        private string endTime;
        private int startMonth;
        private int endMonth;
        private double price;
        private int startPeriod;
        private int endPeriod;
        public CoursePeriodForm()
        {
            InitializeComponent();
        }

        public CoursePeriodForm(CourseRegForm frmCourseReg, string catName, string courseID, string name, int weekday, int startMonth, int endMonth, string startTime, string endTime, double price, int quota, string room)
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
            this.quota = quota;
            this.weekday = weekday;
            InitializeComponent();

        }

        private void CoursePeriodForm_Load(object sender, EventArgs e)
        {
            lblCourseID_d.Text = courseID;
            lblCourseName_d.Text = name;
            for (int i = 0; i <= endMonth - startMonth; i++)
            {
                cbbPeriodFrom.Items.Add(new ComboBoxItem((startMonth + i).ToString(), mapMonth[startMonth + i -1]));
            }

                
        }

        private void cbbPeriodFrom_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedValue = Convert.ToInt32(((ComboBoxItem)cbbPeriodFrom.SelectedItem).Value);
            cbbPeriodTo.Items.Clear();
            for (int i = 0; i <= endMonth - selectedValue; i++)
            {
                cbbPeriodTo.Items.Add(new ComboBoxItem((selectedValue + i).ToString(), mapMonth[selectedValue + i - 1]));
            }
            if(cbbPeriodTo.Items.Count > 0)
                cbbPeriodTo.SelectedIndex = cbbPeriodTo.Items.Count - 1;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            
            startPeriod = Convert.ToInt32(((ComboBoxItem)cbbPeriodFrom.SelectedItem).Value);
            endPeriod = Convert.ToInt32(((ComboBoxItem)cbbPeriodTo.SelectedItem).Value);
            if (frmCourseReg.IsQuotaRemain(lblCourseID_d.Text))
            {
                bool isClashed = frmCourseReg.IsCourseClashInTime(lblCourseID_d.Text, startPeriod, endPeriod);
                if (!isClashed)
                {
                    ListViewItem item = new ListViewItem(catName);
                    item.SubItems.Add(courseID);
                    item.SubItems.Add(name);
                    item.SubItems.Add(weekday.ToString());
                    item.SubItems.Add(startMonth.ToString());
                    item.SubItems.Add(endMonth.ToString());
                    item.SubItems.Add(startTime);
                    item.SubItems.Add(endTime);
                    item.SubItems.Add(price.ToString());
                    item.SubItems.Add(quota.ToString());
                    item.SubItems.Add(room);
                    item.SubItems.Add(startPeriod.ToString());
                    item.SubItems.Add(endPeriod.ToString());
                    frmCourseReg.ltvRegCourseList.Items.Add(item);

                    frmCourseReg.updateTotalPrice();

                    Dispose();
                }
            }
        }
    }
}
