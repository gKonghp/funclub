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
using System.Collections.ObjectModel;

namespace FunHomeClub
{
    public partial class CourseRegForm : Form
    {
        string connStr = ConfigurationManager.ConnectionStrings["FunHomeClub.Properties.Settings.masterDBConnectionString"].ToString();
        private OleDbConnection conn;
        private OleDbDataAdapter adapter;
        private string membershipID;
        private double discount;
        private DataTable courseTables;
        private double precentage;
        public string studentID { get; set; }

        public CourseRegForm(Employee emp)
        {
            InitializeComponent();
            conn = new OleDbConnection(connStr);
            adapter = new OleDbDataAdapter();
            courseTables = new DataTable();
        }

        private void RegCourse_Load(object sender, EventArgs e)
        {
            // find the profitMargin
            string sql = string.Format("SELECT * FROM profitMargin WHERE profitMarginID = '{0}'", "pm0001");
            adapter = new OleDbDataAdapter(sql, conn);
            adapter.Fill(masterDBDataSet, "profitMargin");
            adapter.Dispose();

            precentage = Convert.ToDouble(masterDBDataSet.profitMargin.Rows[0]["percentage"].ToString());

        }

        private void btnStudIDEnter_Click(object sender, EventArgs e)
        {
            string sql;
            OleDbCommand selectCmd;
            studentID = txtStudentID.Text;
            masterDBDataSet.studentCourse.Clear();
            try
            {
                sql = string.Format("SELECT * FROM Student WHERE studentID = '{0}'", studentID);
                selectCmd = new OleDbCommand();
                selectCmd.Connection = conn;
                selectCmd.CommandText = sql;
                adapter.SelectCommand = selectCmd;
                adapter.Fill(masterDBDataSet, "Student");
                adapter.Dispose();
            }
            catch (Exception err) {
                MessageBox.Show(err.Message);
            }
            // Student is Found
            if (masterDBDataSet.student.Count > 0)
            {
                //student fields
                membershipID = masterDBDataSet.student.Rows[0]["membershipID"].ToString();
                string phoneNumber = masterDBDataSet.student.Rows[0]["phoneNumber"].ToString();
                string email = masterDBDataSet.student.Rows[0]["email"].ToString();
                string name = masterDBDataSet.student.Rows[0]["name"].ToString();

                // fetch details from membership table
                sql = string.Format("SELECT * FROM Membership WHERE membershipID = '{0}'", membershipID);
                selectCmd = new OleDbCommand(sql, conn);
                adapter.SelectCommand = selectCmd;
                adapter.Fill(masterDBDataSet, "membership");
                adapter.Dispose();
                // membership fields
                string status = masterDBDataSet.membership.Rows[0]["status"].ToString();
                discount = Convert.ToDouble(masterDBDataSet.membership.Rows[0]["discount"].ToString());

                //fetch details from registration table
                sql = string.Format("SELECT * FROM studentCourse WHERE studentID = '{0}'", studentID);
                adapter = new OleDbDataAdapter(sql, conn);
                adapter.Fill(masterDBDataSet, "studentCourse");
                adapter.Dispose();
                courseTables = masterDBDataSet.course.Clone();
                courseTables.Clear();

                foreach (DataRow row in masterDBDataSet.studentCourse.Rows)
                {
                    string courseID = row["courseID"].ToString();
                    DateTime enrollDate = Convert.ToDateTime(row["enrollDate"].ToString());
                    // fetch details from course table
                    sql = string.Format("SELECT * FROM Course WHERE courseID = '{0}'", courseID);
                    adapter = new OleDbDataAdapter(sql, conn);
                    masterDBDataSet.course.Clear();
                    adapter.Fill(masterDBDataSet, "Course");
                    adapter.Dispose();
                    foreach (DataRow subRow in masterDBDataSet.course)
                    {
                        DataRow newRow = courseTables.NewRow();
                        newRow.ItemArray = (object[])subRow.ItemArray.Clone();
                        courseTables.Rows.Add(newRow);

                    }
                    adapter.Dispose();
                }
                //course fields
                
                //student = new Student(studentID, name, phoneNumber, email);
                //Membership membership = new Membership(membershipID, status, discount);
                //student.membership = membership; //link membership and student;
               // membership.student = student;

                lblStudName_d.Text = name;
                lblMembership_d.Text = Utility.firstChar2UpperCase(status);
                lblContactNum_d.Text = phoneNumber;
                lblEmailAddress_d.Text = email;
                ltvRegCourseDetail.Items.Clear();
                foreach (DataRow row in courseTables.Rows)
                {

                        ListViewItem item = new ListViewItem(row["courseID"].ToString());
                        string categoryID = row["categoryID"].ToString();
                        sql = string.Format("SELECT * FROM courseCategory WHERE categoryID = '{0}'", categoryID);
                        adapter = new OleDbDataAdapter(sql, conn);
                        adapter.Fill(masterDBDataSet.courseCategory);
                        //adapter.Dispose();
                        //adapter = new OleDbDataAdapter(sql, conn);
                        //item.SubItems.Add(row["categoryID"].ToString());
                        //foreach (DataRow subRow in masterDBDataSet.courseCategory.Rows)
                        //{
                        item.SubItems.Add(masterDBDataSet.courseCategory.Rows[0]["name"].ToString());
                       //}
                        item.SubItems.Add(row["name"].ToString());
                        item.SubItems.Add(row["weekday"].ToString());
                        item.SubItems.Add(row["room"].ToString());
                        item.SubItems.Add(row["startTime"].ToString());
                        item.SubItems.Add(row["endTime"].ToString());
                        item.SubItems.Add(row["startMonth"].ToString());
                        item.SubItems.Add(row["endMonth"].ToString());
                        string teacherID = row["teacherID"].ToString();
                        sql = string.Format("SELECT * FROM Teacher WHERE teacherID = '{0}'", teacherID);
                        adapter = new OleDbDataAdapter(sql, conn);
                        adapter.Fill(masterDBDataSet, "Teacher");
                        adapter.Dispose();
                        //foreach (DataRow subRow in masterDBDataSet.teacher.Rows)
                        //{ 
                            item.SubItems.Add(masterDBDataSet.teacher.Rows[0]["name"].ToString());
                        //}
                        ltvRegCourseDetail.Items.Add(item);

                }
                btnAdd.Enabled = true;
                btnRegister.Enabled = true;
                btnView.Enabled = true;
                btnDel.Enabled = true;
                btnClear.Enabled = true;
            }
            else // Cannot find the student
            {
                btnAdd.Enabled = false;
                btnRegister.Enabled = false;
                btnView.Enabled = false;
                btnDel.Enabled = false;
                btnClear.Enabled = false;
                MessageBox.Show(string.Format("{0} is not found.",studentID));
            }
            
        }

        private void ltvRegCourseDetail_DoubleClick(object sender, EventArgs e)
        {
            if (ltvRegCourseDetail.SelectedItems.Count > 0) {
                int idx = ltvRegCourseDetail.SelectedItems[0].Index;
                CourseDetail cd = new CourseDetail(conn, masterDBDataSet.course.Rows[idx]["courseID"].ToString(), precentage);
                cd.ShowDialog();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddCoursesForm addCourse = new AddCoursesForm(this, precentage);
            addCourse.ShowDialog();
        }

        public bool IsCourseClash(string courseID)
        {
            string sql = string.Format("SELECT courseId, weekday, startMonth, endMonth FROM Course WHERE courseID = '{0}'", courseID);
            adapter = new OleDbDataAdapter(sql,conn);
            DataTable courseTimeTable = new DataTable();
            adapter.Fill(courseTimeTable);
            adapter.Dispose();

            DataRow courseTimeRow = courseTimeTable.Rows[0];
            int weekday = Convert.ToInt32(courseTimeRow["weekday"].ToString());
            int startMonth = Convert.ToInt32(courseTimeRow["startMonth"].ToString());
            int endMonth = Convert.ToInt32(courseTimeRow["endMonth"].ToString());
            //Check whether registered before
            foreach (ListViewItem item in ltvRegCourseDetail.Items)
            {
                if (courseID.Equals(item.SubItems[CourseID_r.Index].Text))
                {
                    MessageBox.Show(courseID + " have been reistered already");
                    return true;
                }
                MessageBox.Show(item.SubItems[StartMonth_r.Index].Text);
                int previousStartMonth = Convert.ToInt32(item.SubItems[StartMonth_r.Index].Text.ToString());
                int previousEndMonth = Convert.ToInt32(item.SubItems[EndMonth_r.Index].Text);
                int previousWeekday = Convert.ToInt32(item.SubItems[Weekday_r.Index].Text);
                string previousCourseID = item.SubItems[CourseID_r.Index].Text;
                // [preStart] start [preEnd]  || [preStart] end [preEnd] || start [preStart]  end || start [preEnd]  end
                if ((startMonth >= previousStartMonth && startMonth <= previousEndMonth) || (endMonth >= previousStartMonth && endMonth <= previousEndMonth) || (startMonth >= previousStartMonth && previousStartMonth <= endMonth) || (startMonth >= previousEndMonth && previousEndMonth <= endMonth))
                {
                    if (weekday == previousWeekday)
                    {
                        MessageBox.Show(courseID + " and " + previousCourseID + " have been clashed on Day"+ weekday);
                        return true;
                    }
                }
            }
            foreach (ListViewItem item in ltvRegCourseList.Items)
            {
                if (courseID.Equals(item.SubItems[CourseID.Index].Text))
                {
                    MessageBox.Show(courseID + " have been added into list already");
                    return true;
                }
                int previousStartMonth = Convert.ToInt32(item.SubItems[StartMonth.Index].Text);
                int previousEndMonth = Convert.ToInt32(item.SubItems[EndMonth.Index].Text);
                int previousWeekday = Convert.ToInt32(item.SubItems[Weekday.Index].Text);
                string previousCourseID = item.SubItems[CourseID.Index].Text;
                // [preStart] start [preEnd]  || [preStart] end [preEnd] || start [preStart]  end || start [preEnd]  end
                if ((startMonth >= previousStartMonth && startMonth <= previousEndMonth) || (endMonth >= previousStartMonth && endMonth <= previousEndMonth) || (startMonth >= previousStartMonth && previousStartMonth <= endMonth) || (startMonth >= previousEndMonth && previousEndMonth <= endMonth))
                {
                    if (weekday == previousWeekday)
                    {
                        MessageBox.Show(courseID + " and " + previousCourseID + " have been clashed on Day" + weekday);
                        return true;
                    }
                }
            }


            return false;
        }
        private double calcOriginalTotal()
        {
            double totalPrice = 0;
            foreach (ListViewItem item in ltvRegCourseList.Items)
            {
                totalPrice += Convert.ToDouble(item.SubItems[Price.Index].Text);
            }
            return totalPrice;
        }
        public void updateTotalPrice()
        {

            double originalTotal = calcOriginalTotal();
            double finalDiscount = discount; // not calcalate all;
            //Update Original Price;
            if (originalTotal <= 0)
            {
                lblOriginalTotal_d.Text = "--";
                lblTotal_d.Text = "--";
            }
            else
            {
                lblOriginalTotal_d.Text = "$ " + Convert.ToString(originalTotal);
                //Update Discount
                if (discount >= 1)
                    lblDiscount_d.Text = "--";
                else if (discount > 0)
                {
                    lblDiscount_d.Text = Convert.ToString((1 - discount) * 100) + " OFF";
                }
                else if (discount == 0)
                    lblDiscount_d.Text = "Free";

                //Update TotalPrice
                lblTotal_d.Text = "$ " + Convert.ToString(originalTotal * discount);
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            CourseConfirmForm courseConfirm = new CourseConfirmForm(this);
            courseConfirm.MdiParent = this.MdiParent;
            courseConfirm.Dock = DockStyle.Fill;
            courseConfirm.Show();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem selectedItem in ltvRegCourseList.SelectedItems)
            {
                ltvRegCourseList.Items.RemoveAt(selectedItem.Index);
                updateTotalPrice();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ltvRegCourseList.Items.Clear();
            updateTotalPrice();
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            if (ltvRegCourseList.SelectedItems.Count > 1)
                MessageBox.Show("Cannot view multi-courses in the same time.");
            else if(ltvRegCourseList.SelectedItems.Count == 1)
            {
                int idx = ltvRegCourseList.SelectedItems[0].Index;
                CourseDetail cd = new CourseDetail(conn, ltvRegCourseList.Items[idx].SubItems[CourseID.Index].Text, precentage);
                cd.ShowDialog();
            }
        }

        private void ltvRegCourseList_DoubleClick(object sender, EventArgs e)
        {
            if (ltvRegCourseList.SelectedItems.Count > 1)
                MessageBox.Show("Cannot view multi-courses in the same time.");
            else if (ltvRegCourseList.SelectedItems.Count == 1)
            {
                int idx = ltvRegCourseList.SelectedItems[0].Index;
                CourseDetail cd = new CourseDetail(conn,ltvRegCourseList.Items[idx].SubItems[CourseID.Index].Text, precentage);
                cd.ShowDialog();
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtStudentID.Clear();
            ltvRegCourseDetail.Items.Clear();
            ltvRegCourseList.Items.Clear();
            lblContactNum_d.Text = "--";
            lblDiscount_d.Text = "--";
            lblStudName_d.Text = "--";
            lblEmailAddress_d.Text = "--";
            lblMembership_d.Text = "--";
            lblOriginalTotal_d.Text = "--";
            lblTotal_d.Text = "--";
            btnAdd.Enabled = false;
            btnClear.Enabled = false;
            btnDel.Enabled = false;
            btnView.Enabled = false;
            btnRegister.Enabled = false;
        }

        private void llbRegStudent_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
    }
}
