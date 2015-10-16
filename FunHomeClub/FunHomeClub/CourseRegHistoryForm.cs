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
    public partial class CourseRegHistoryForm : Form
    {
        string connStr = ConfigurationManager.ConnectionStrings["FunHomeClub.Properties.Settings.masterDBConnectionString"].ToString();
        private OleDbConnection conn;
        private DataTable courseTables;
        private string studentID;
        private OleDbDataAdapter adapter;
        public CourseRegHistoryForm(string studentID)
        {
            InitializeComponent();
            this.studentID = studentID;
            conn = new OleDbConnection(connStr);
        }

        private void CourseRegHistoryForm_Load(object sender, EventArgs e)
        {
            string sql;
            //fetch details from registration table
            sql = string.Format("SELECT * FROM studentCourse WHERE studentID = '{0}'", studentID);
            adapter = new OleDbDataAdapter(sql, conn);
            adapter.Fill(masterDBDataSet1, "studentCourse");
            adapter.Dispose();
            courseTables = masterDBDataSet1.course.Clone();
            courseTables.Columns.Add("startPeriod");
            courseTables.Columns.Add("endPeriod");
            courseTables.Columns.Add("cost");
            DataColumn[] keys = new DataColumn[3];
            keys[0] = courseTables.Columns["courseID"];
            keys[1] = courseTables.Columns["startPeriod"];
            keys[2] = courseTables.Columns["endPeriod"];
            courseTables.PrimaryKey = keys;
            courseTables.Clear();

            ltvRegCourseDetail.Items.Clear();

            foreach (DataRow row in masterDBDataSet1.studentCourse.Rows)
            {
                string courseID = row["courseID"].ToString();
                int startPeriod = Convert.ToInt32(row["startPeriod"].ToString());
                int endPeriod = Convert.ToInt32(row["endPeriod"].ToString());

                DateTime enrollDate = Convert.ToDateTime(row["enrollDate"].ToString());
                // fetch details from course table
                sql = string.Format("SELECT * FROM Course WHERE courseID = '{0}'", courseID);
                adapter = new OleDbDataAdapter(sql, conn);
                masterDBDataSet1.course.Clear();
                adapter.Fill(masterDBDataSet1, "Course");
                adapter.Dispose();

                foreach (DataRow subRow in masterDBDataSet1.course)
                {
                    DataRow newRow = courseTables.NewRow();
                    newRow.SetField("startPeriod", startPeriod);
                    newRow.SetField("endPeriod", endPeriod);
                    newRow.SetField("cost", row["cost"].ToString());
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
                adapter.Fill(masterDBDataSet1.courseCategory);
                ListViewItem item = new ListViewItem(masterDBDataSet1.courseCategory.Rows[0]["name"].ToString());
                //adapter.Dispose();
                //adapter = new OleDbDataAdapter(sql, conn);
                //item.SubItems.Add(row["categoryID"].ToString());
                //foreach (DataRow subRow in masterDBDataSet.courseCategory.Rows)
                //{
                item.SubItems.Add(row["courseID"].ToString());
                //}
                item.SubItems.Add(row["name"].ToString());
                item.SubItems.Add(row["weekday"].ToString());
                item.SubItems.Add(row["startMonth"].ToString() + "-" + row["endMonth"].ToString());
                item.SubItems.Add(string.Format("{0:H:mm}", Convert.ToDateTime(row["startTime"].ToString())) + "-" + string.Format("{0:H:mm}", Convert.ToDateTime(row["endTime"].ToString())));
                //item.SubItems.Add(string.Format("{0:H:mm}", Convert.ToDateTime(row["endTime"].ToString())))
                //item.SubItems.Add(row["endMonth"].ToString());
                item.SubItems.Add(row["room"].ToString());
                item.SubItems.Add(row["startPeriod"].ToString() + "-" + row["endPeriod"].ToString());
                //item.SubItems.Add(row["endPeriod"].ToString());


                string teacherID = row["teacherID"].ToString();
                sql = string.Format("SELECT * FROM Teacher WHERE teacherID = '{0}'", teacherID);
                adapter = new OleDbDataAdapter(sql, conn);
                adapter.Fill(masterDBDataSet1, "Teacher");
                adapter.Dispose();
                //foreach (DataRow subRow in masterDBDataSet.teacher.Rows)
                //{ 
                item.SubItems.Add(masterDBDataSet1.teacher.Rows[0]["name"].ToString());
                //}
                item.SubItems.Add(row["cost"].ToString());
                ltvRegCourseDetail.Items.Add(item);

            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void ltvRegCourseDetail_DoubleClick(object sender, EventArgs e)
        {
            if (ltvRegCourseDetail.SelectedItems.Count > 0)
            {
                int idx = ltvRegCourseDetail.SelectedItems[0].Index;
                CourseDetail cd = new CourseDetail(conn, masterDBDataSet1.course.Rows[idx]["courseID"].ToString());
                cd.ShowDialog();
            }
        }
    }
}
