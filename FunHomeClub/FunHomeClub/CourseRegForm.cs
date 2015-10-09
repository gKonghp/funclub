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
using System.Text.RegularExpressions;

namespace FunHomeClub
{
    public partial class CourseRegForm : Form
    {
        string connStr = ConfigurationManager.ConnectionStrings["FunHomeClub.Properties.Settings.masterDBConnectionString"].ToString();
        private OleDbConnection conn;
        private OleDbDataAdapter adapter;
        private AddPromotionForm frmAddPromotion;
        private double discount;
        private DataTable courseTables;
        private double precentage;
        private MenuForm frmMenu;
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
            if (Utility.checkFieldPresense(txtStudentID))
            {
                txtStudentID.BackColor = Color.IndianRed;
                MessageBox.Show("StudentID cannot be empty.");
                txtStudentID.Focus();
                return;
            }
            if (!Regex.IsMatch(txtStudentID.Text, @"^[a-zA-Z0-9]+$"))
            {
                txtStudentID.BackColor = Color.IndianRed;
                MessageBox.Show("StudentID is Alphanumeric.");
                txtStudentID.Focus();
                return;
            }
            // Reset
            ltvRegCourseDetail.Items.Clear();
            ltvRegCourseList.Items.Clear();
            lblContactNum_d.Text = "--";
            lblDiscount_d.Text = "--";
            lblStudName_d.Text = "--";
            lblEmailAddress_d.Text = "--";
            lblMembership_d.Text = "--";
            lblOriginalTotal_d.Text = "--";
            lblTotal_d.Text = "--";
            lblPromotionDiscount_d.Text = "";
            lblPromotionID_d.Text = "";
            lblPromotionName_d.Text = "";
            btnAdd.Enabled = false;
            btnClear.Enabled = false;
            btnDel.Enabled = false;
            btnView.Enabled = false;
            btnRegister.Enabled = false;
            btnDiscountView.Enabled = false;
            btnDiscountClear.Enabled = false;
            btnDiscountAdd.Enabled = false;


            // End reset
            string sql;
            OleDbCommand selectCmd;
            studentID = txtStudentID.Text;
            masterDBDataSet.studentCourse.Clear();
            masterDBDataSet.student.Clear();
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
                string membershipID = masterDBDataSet.student.Rows[0]["membershipID"].ToString();
                string phoneNumber = masterDBDataSet.student.Rows[0]["phoneNumber"].ToString();
                string email = masterDBDataSet.student.Rows[0]["email"].ToString();
                string name = masterDBDataSet.student.Rows[0]["name"].ToString();

                // fetch details from membership table
                masterDBDataSet.membership.Clear();
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
                courseTables.Columns.Add("startPeriod");
                courseTables.Columns.Add("endPeriod");
                courseTables.Clear();


                lblStudName_d.Text = name;
                lblMembership_d.Text = Utility.firstChar2UpperCase(status);
                lblContactNum_d.Text = phoneNumber;
                lblEmailAddress_d.Text = email;
                ltvRegCourseDetail.Items.Clear();

                foreach (DataRow row in masterDBDataSet.studentCourse.Rows)
                {
                    string courseID = row["courseID"].ToString();
                    int startPeriod = Convert.ToInt32(row["startPeriod"].ToString());
                    int endPeriod = Convert.ToInt32(row["endPeriod"].ToString());

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
                        newRow.SetField("startPeriod", startPeriod);
                        newRow.SetField("endPeriod", endPeriod);
                        newRow.ItemArray = (object[])subRow.ItemArray.Clone();

                        courseTables.Rows.Add(newRow);

                    }
                }
                //course fields
                
                //student = new Student(studentID, name, phoneNumber, email);
                //Membership membership = new Membership(membershipID, status, discount);
                //student.membership = membership; //link membership and student;
               // membership.student = student;

                
                foreach (DataRow row in courseTables.Rows)
                {

                    string categoryID = row["categoryID"].ToString();
                    sql = string.Format("SELECT * FROM courseCategory WHERE categoryID = '{0}'", categoryID);
                    adapter = new OleDbDataAdapter(sql, conn);
                    adapter.Fill(masterDBDataSet.courseCategory);
                    ListViewItem item = new ListViewItem(masterDBDataSet.courseCategory.Rows[0]["name"].ToString());
                        //adapter.Dispose();
                        //adapter = new OleDbDataAdapter(sql, conn);
                        //item.SubItems.Add(row["categoryID"].ToString());
                        //foreach (DataRow subRow in masterDBDataSet.courseCategory.Rows)
                        //{
                    item.SubItems.Add(row["courseID"].ToString());
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
                    item.SubItems.Add(row["startPeriod"].ToString());
                    item.SubItems.Add(row["endPeriod"].ToString());
                    ltvRegCourseDetail.Items.Add(item);

                }
                btnAdd.Enabled = true;
                //btnRegister.Enabled = true;
                btnView.Enabled = true;
                btnDel.Enabled = true;
                btnClear.Enabled = true;
                btnDiscountAdd.Enabled = true;
                btnDiscountClear.Enabled = true;
                btnDiscountView.Enabled = true;
            }
            else // Cannot find the student
            {
                btnAdd.Enabled = false;
                btnRegister.Enabled = false;
                btnView.Enabled = false;
                btnDel.Enabled = false;
                btnClear.Enabled = false;
                txtStudentID.BackColor = Color.IndianRed;
                MessageBox.Show(string.Format("{0} is not found.",studentID));
                txtStudentID.Focus();
            }
            
        }

        private void ltvRegCourseDetail_DoubleClick(object sender, EventArgs e)
        {
            if (ltvRegCourseDetail.SelectedItems.Count > 0) {
                int idx = ltvRegCourseDetail.SelectedItems[0].Index;
                CourseDetail cd = new CourseDetail(conn, masterDBDataSet.course.Rows[idx]["courseID"].ToString());
                cd.ShowDialog();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddCoursesForm addCourse = new AddCoursesForm(this, precentage);
            addCourse.ShowDialog();
            if (ltvRegCourseList.Items.Count > 0)
                btnRegister.Enabled = true;
            else
                btnRegister.Enabled = false;
        }

       /* public bool IsQuotaRemain(string courseID)
        {
            string sql = string.Format("SELECT courseId, quota FROM Course WHERE courseID = '{0}'", courseID);
            adapter = new OleDbDataAdapter(sql, conn);
            DataTable courseTimeTable = new DataTable();
            adapter.Fill(courseTimeTable);
            adapter.Dispose();

            DataRow courseTimeRow = courseTimeTable.Rows[0];
            int quota = Convert.ToInt32(courseTimeRow["quota"].ToString());
            if (quota - 1 >= 0)
            {
                return true;
            }
            else
            {
                MessageBox.Show(courseID + "'s quota has been 0 already. \nCannot assign this course.");
                return false;
            }
        }*/

        public bool IsCourseClashInTime(string courseID, int startPeriod, int endPeriod)
        {
            string sql = string.Format("SELECT courseId, weekday, startMonth, endMonth FROM Course WHERE courseID = '{0}'", courseID);
            adapter = new OleDbDataAdapter(sql, conn);
            DataTable courseTimeTable = new DataTable();
            adapter.Fill(courseTimeTable);
            adapter.Dispose();

            DataRow courseTimeRow = courseTimeTable.Rows[0];
            int weekday = Convert.ToInt32(courseTimeRow["weekday"].ToString());
            //int startMonth = Convert.ToInt32(courseTimeRow["startMonth"].ToString());
            //int endMonth = Convert.ToInt32(courseTimeRow["endMonth"].ToString());
            //Check whether registered before
            foreach (ListViewItem item in ltvRegCourseDetail.Items)
            {
                //if (courseID.Equals(item.SubItems[CourseID_r.Index].Text))
                //{
                //    MessageBox.Show(courseID + " have been reistered already");
                //    return true;
                //}
                //int previousStartMonth = Convert.ToInt32(item.SubItems[StartMonth.Index].Text);
                //int previousEndMonth = Convert.ToInt32(item.SubItems[EndMonth.Index].Text);
                //int previousWeekday = Convert.ToInt32(item.SubItems[Weekday.Index].Text);
                //string previousCourseID = item.SubItems[CourseID.Index].Text;
                int previousStartPeriod = Convert.ToInt32(item.SubItems[startPeriod_r.Index].Text);
                int previousEndPeriod = Convert.ToInt32(item.SubItems[endPeriod_r.Index].Text);
                int previousWeekday = Convert.ToInt32(item.SubItems[Weekday_r.Index].Text);
                string previousCourseID = item.SubItems[CourseID_r.Index].Text;
                // [preStart] start [preEnd]  || [preStart] end [preEnd] || start [preStart]  end || start [preEnd]  end
                if ((startPeriod >= previousStartPeriod && startPeriod <= previousEndPeriod) || (endPeriod >= previousStartPeriod && endPeriod <= previousEndPeriod) || (startPeriod <= previousStartPeriod && previousStartPeriod <= endPeriod) || (startPeriod <= previousEndPeriod && previousEndPeriod <= endPeriod))
                {

                    if (weekday == previousWeekday)
                    {
                        MessageBox.Show(courseID + "[" + startPeriod + "-" + endPeriod + "month]" + " and " + previousCourseID + "[" + previousStartPeriod + "-" + previousEndPeriod + "month]" + " have been clashed on Day" + weekday);
                        return true;
                    }
                }
            }
            foreach (ListViewItem item in ltvRegCourseList.Items)
            {
                //if (courseID.Equals(item.SubItems[CourseID.Index].Text))
                //{
                //    MessageBox.Show(courseID + " have been added into list already");
                //    return true;
                //}
                //int previousStartMonth = Convert.ToInt32(item.SubItems[StartMonth.Index].Text);
                //int previousEndMonth = Convert.ToInt32(item.SubItems[EndMonth.Index].Text);
                //int previousWeekday = Convert.ToInt32(item.SubItems[Weekday.Index].Text);
                //string previousCourseID = item.SubItems[CourseID.Index].Text;
                int previousStartPeriod = Convert.ToInt32(item.SubItems[StartPeriod.Index].Text);
                int previousEndPeriod = Convert.ToInt32(item.SubItems[EndPeriod.Index].Text);
                int previousWeekday = Convert.ToInt32(item.SubItems[Weekday.Index].Text);
                string previousCourseID = item.SubItems[CourseID.Index].Text;
                // [preStart] start [preEnd]  || [preStart] end [preEnd] || start [preStart]  end || start [preEnd]  end
                //if ((startMonth >= previousStartMonth && startMonth <= previousEndMonth) || (endMonth >= previousStartMonth && endMonth <= previousEndMonth) || (startMonth >= previousStartMonth && previousStartMonth <= endMonth) || (startMonth >= previousEndMonth && previousEndMonth <= endMonth))
                // [preStart] start [preEnd]  || [preStart] end [preEnd] || start [preStart]  end || start [preEnd]  end
                if ((startPeriod >= previousStartPeriod && startPeriod <= previousEndPeriod) || (endPeriod >= previousStartPeriod && endPeriod <= previousEndPeriod) || (startPeriod <= previousStartPeriod && previousStartPeriod <= endPeriod) || (startPeriod <= previousEndPeriod && previousEndPeriod <= endPeriod))
                {

                    if (weekday == previousWeekday)
                    {
                        MessageBox.Show(courseID + "[" + startPeriod + "-" + endPeriod + "month]" + " and " + previousCourseID + "[" + previousStartPeriod + "-" + previousEndPeriod + "month]" + " have been clashed on Day" + weekday);
                        return true;
                    }
                }
            }


            return false;
        }
        public bool IsCourseClashInList(string courseID, int startPeriod, int endPeriod)
        {
            string sql = string.Format("SELECT courseId, weekday, startMonth, endMonth FROM Course WHERE courseID = '{0}'", courseID);
            adapter = new OleDbDataAdapter(sql,conn);
            DataTable courseTimeTable = new DataTable();
            adapter.Fill(courseTimeTable);
            adapter.Dispose();

            DataRow courseTimeRow = courseTimeTable.Rows[0];
            int weekday = Convert.ToInt32(courseTimeRow["weekday"].ToString());
            //int startMonth = Convert.ToInt32(courseTimeRow["startMonth"].ToString());
            //int endMonth = Convert.ToInt32(courseTimeRow["endMonth"].ToString());
            //Check whether registered before
            foreach (ListViewItem item in ltvRegCourseDetail.Items)
            {
                //if (courseID.Equals(item.SubItems[CourseID_r.Index].Text))
                //{
                //    MessageBox.Show(courseID + " have been reistered already");
                //    return true;
                //}
                //int previousStartMonth = Convert.ToInt32(item.SubItems[StartMonth.Index].Text);
                //int previousEndMonth = Convert.ToInt32(item.SubItems[EndMonth.Index].Text);
                //int previousWeekday = Convert.ToInt32(item.SubItems[Weekday.Index].Text);
                //string previousCourseID = item.SubItems[CourseID.Index].Text;
                int previousStartPeriod = Convert.ToInt32(item.SubItems[startPeriod_r.Index].Text);
                int previousEndPeriod = Convert.ToInt32(item.SubItems[endPeriod_r.Index].Text);
                int previousWeekday = Convert.ToInt32(item.SubItems[Weekday_r.Index].Text);
                 string previousCourseID = item.SubItems[CourseID_r.Index].Text;
                // [preStart] start [preEnd]  || [preStart] end [preEnd] || start [preStart]  end || start [preEnd]  end

                if ((startPeriod >= previousStartPeriod && startPeriod <= previousEndPeriod) || (endPeriod >= previousStartPeriod && endPeriod <= previousEndPeriod) || (startPeriod <= previousStartPeriod && previousStartPeriod <= endPeriod) || (startPeriod <= previousEndPeriod && previousEndPeriod <= endPeriod))
                {
                    if (courseID.Equals(item.SubItems[CourseID_r.Index].Text))
                    {
                        MessageBox.Show(courseID + "[" + previousStartPeriod + "-" + previousEndPeriod + "month]" + " have been reistered already");
                        return true;
                    }
                }
                
            }
            foreach (ListViewItem item in ltvRegCourseList.Items)
            {
                //if (courseID.Equals(item.SubItems[CourseID.Index].Text))
                //{
                //    MessageBox.Show(courseID + " have been added into list already");
                //    return true;
                //}
                //int previousStartMonth = Convert.ToInt32(item.SubItems[StartMonth.Index].Text);
                //int previousEndMonth = Convert.ToInt32(item.SubItems[EndMonth.Index].Text);
                //int previousWeekday = Convert.ToInt32(item.SubItems[Weekday.Index].Text);
                //string previousCourseID = item.SubItems[CourseID.Index].Text;
                int previousStartPeriod = Convert.ToInt32(item.SubItems[StartPeriod.Index].Text);
                int previousEndPeriod = Convert.ToInt32(item.SubItems[EndPeriod.Index].Text);
                int previousWeekday = Convert.ToInt32(item.SubItems[Weekday.Index].Text);
                string previousCourseID = item.SubItems[CourseID.Index].Text;
                // [preStart] start [preEnd]  || [preStart] end [preEnd] || start [preStart]  end || start [preEnd]  end
                //if ((startMonth >= previousStartMonth && startMonth <= previousEndMonth) || (endMonth >= previousStartMonth && endMonth <= previousEndMonth) || (startMonth >= previousStartMonth && previousStartMonth <= endMonth) || (startMonth >= previousEndMonth && previousEndMonth <= endMonth))
                // [preStart] start [preEnd]  || [preStart] end [preEnd] || start [preStart]  end || start [preEnd]  end
                
                if ((startPeriod >= previousStartPeriod && startPeriod <= previousEndPeriod) || (endPeriod >= previousStartPeriod && endPeriod <= previousEndPeriod) || (startPeriod <= previousStartPeriod && previousStartPeriod <= endPeriod) || (startPeriod <= previousEndPeriod && previousEndPeriod <= endPeriod))
                {
                    if (courseID.Equals(item.SubItems[CourseID.Index].Text))
                    {
                        MessageBox.Show(courseID + "[" + previousStartPeriod + "-" + previousEndPeriod + "month]"+" have been added in list already");
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
                totalPrice += Convert.ToDouble(item.SubItems[Price.Index].Text) * ((Convert.ToInt32(item.SubItems[EndPeriod.Index].Text) - Convert.ToInt32(item.SubItems[StartPeriod.Index].Text)) + 1);
            }
            return totalPrice;
        }
        public void updateTotalPrice()
        {

            double originalTotal = calcOriginalTotal();
            discount = Math.Round(discount,2);
            double finalDiscount = (1 - discount); // not calcalate all;
            finalDiscount = Math.Round(finalDiscount,2);
            /*
            foreach (ListViewItem item in ltvPromotion.Items)
            {
                double itemDiscount = Convert.ToDouble(item.SubItems[pro_discount.Index].Text);
                if (finalDiscount == 0)
                {
                    finalDiscount = 1;
                }
                    //finalDiscount *= (1 - itemDiscount);
            }
            */
            double promotionDiscount = 1;
            if(Utility.IsNumeric(lblPromotionDiscount_d.Text))
                promotionDiscount = Math.Round(Convert.ToDouble(lblPromotionDiscount_d.Text),2);
            finalDiscount += (1 - promotionDiscount);
            finalDiscount = Math.Round(finalDiscount, 2);
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
                if (finalDiscount >= 1 || finalDiscount == 0)
                {
                    lblDiscount_d.Text = "--";
                    finalDiscount = 0;
                }
                else if (finalDiscount > 0)
                {
                    lblDiscount_d.Text = Convert.ToString(finalDiscount * 100) + " OFF";
                }

                //Update TotalPrice
                lblTotal_d.Text = "$ " + Convert.ToString(originalTotal * (1 - finalDiscount));
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            CourseConfirmForm courseConfirm = new CourseConfirmForm(this);
            courseConfirm.MdiParent = this.MdiParent;
            courseConfirm.Dock = DockStyle.Fill;
            Utility.repaintFrameSize(this.MdiParent, courseConfirm);
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
            if (ltvRegCourseList.Items.Count > 0)
                btnRegister.Enabled = true;
            else
                btnRegister.Enabled = false;
            updateTotalPrice();
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            if (ltvRegCourseList.SelectedItems.Count > 1)
                MessageBox.Show("Cannot view multi-courses in the same time.");
            else if(ltvRegCourseList.SelectedItems.Count == 1)
            {
                int idx = ltvRegCourseList.SelectedItems[0].Index;
                CourseDetail cd = new CourseDetail(conn, ltvRegCourseList.Items[idx].SubItems[CourseID.Index].Text);
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
                CourseDetail cd = new CourseDetail(conn,ltvRegCourseList.Items[idx].SubItems[CourseID.Index].Text);
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
            lblPromotionDiscount_d.Text = "";
            lblPromotionID_d.Text = "";
            lblPromotionName_d.Text = "";
            btnAdd.Enabled = false;
            btnClear.Enabled = false;
            btnDel.Enabled = false;
            btnView.Enabled = false;
            btnRegister.Enabled = false;
            btnDiscountView.Enabled = false;
            btnDiscountClear.Enabled = false;
            btnDiscountAdd.Enabled = false;
        }

        private void llbRegStudent_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            StudentSuccessForm frmStudentSuccess;
            string regStudentID = "";
            if(conn.State == ConnectionState.Closed)
                conn.Open();
            MaintainStudent mStudent = new MaintainStudent(conn, null, true);
            mStudent.ShowDialog();
            if (mStudent.DialogResult == DialogResult.OK)
            {
                frmStudentSuccess = new StudentSuccessForm(conn,mStudent.studentID, true);
                regStudentID = frmStudentSuccess.studentID;
                frmStudentSuccess.ShowDialog();
                txtStudentID.Text = regStudentID;
                //MessageBox.Show("Added successfully!");
            }
        }

        private void lblRegCourseDetail_Click(object sender, EventArgs e)
        {

        }

        private void btnDiscountAdd_Click(object sender, EventArgs e)
        {
            frmAddPromotion = new AddPromotionForm(conn, this);
            frmAddPromotion.ShowDialog();
        }

        private void btnDiscountClear_Click(object sender, EventArgs e)
        {
            lblPromotionName_d.Text = "";
            lblPromotionID_d.Text = "";
            lblPromotionDiscount_d.Text = "";
            updateTotalPrice();
        }

        private void btnDiscountView_Click(object sender, EventArgs e)
        {
            PromotionViewForm frmPromotionView;
            string promotionID = lblPromotionID_d.Text;
            if (!promotionID.Equals("--"))
            {
                frmPromotionView = new PromotionViewForm(conn, promotionID);
                frmPromotionView.ShowDialog();
            }
            else
            {
                MessageBox.Show("No promotion can be viewed.");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            frmMenu = new MenuForm(((MainForm)this.MdiParent).employee, conn);
            frmMenu.MdiParent = this.MdiParent;
            frmMenu.Dock = DockStyle.Fill;
            Utility.repaintFrameSize(this.MdiParent, frmMenu);
            frmMenu.Show();
            this.Dispose();
        }

        private void txtStudentID_TextChanged(object sender, EventArgs e)
        {
            txtStudentID.BackColor = System.Drawing.SystemColors.Control;
        }
    }
}
