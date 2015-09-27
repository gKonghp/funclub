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
    public partial class CourseRegForm : Form
    {
        string connStr = ConfigurationManager.ConnectionStrings["FunHomeClub.Properties.Settings.masterDBConnectionString"].ToString();
        private OleDbConnection conn;
        private OleDbDataAdapter studentAdapter;
        private Student student;
        private Employee emp;
        public CourseRegForm(Employee emp)
        {
            InitializeComponent();
            conn = new OleDbConnection(connStr);
            studentAdapter = new OleDbDataAdapter();
        }

        private void RegCourse_Load(object sender, EventArgs e)
        {
            // TODO: 這行程式碼會將資料載入 'masterDBDataSet.courseCategory' 資料表。您可以視需要進行移動或移除。
            this.courseCategoryTableAdapter.Fill(this.masterDBDataSet.courseCategory);

        }

        private void btnStudIDEnter_Click(object sender, EventArgs e)
        {
            string studentID = txtStudentID.Text;
            try
            {
                string sql = string.Format("SELECT * FROM Student WHERE studentID = '{0}'", studentID);
                OleDbCommand selectStudCommand = new OleDbCommand();
                selectStudCommand.Connection = conn;
                selectStudCommand.CommandText = sql;
                studentAdapter.SelectCommand = selectStudCommand;
                studentAdapter.Fill(masterDBDataSet, "Student");
                studentAdapter.Dispose();
            }
            catch (Exception err) {
                MessageBox.Show(err.Message);
            }
            // Student is Found
            if (masterDBDataSet.student.Count > 0)
            {

                // fetch details from membership table
                string sql = string.Format("SELECT * FROM Membership WHERE studentID = '{0}'", studentID);
                OleDbCommand selectStudCommand = new OleDbCommand(sql, conn);
                studentAdapter.SelectCommand = selectStudCommand;
                studentAdapter.Fill(masterDBDataSet, "Membership");
                studentAdapter.Dispose();
                // fetch details from course table
                sql = string.Format("SELECT * FROM Course WHERE studentID = '{0}'", studentID);
                selectStudCommand = new OleDbCommand(sql, conn);
                studentAdapter.SelectCommand = selectStudCommand;
                studentAdapter.Fill(masterDBDataSet, "Course");
                studentAdapter.Dispose();
                //student fields
                string membershipID = masterDBDataSet.student.Rows[0]["studentID"].ToString();
                string phoneNumber = masterDBDataSet.student.Rows[0]["phoneNumber"].ToString();
                string email = masterDBDataSet.student.Rows[0]["email"].ToString();
                string name = masterDBDataSet.student.Rows[0]["name"].ToString();
                // membership fields
                string status = masterDBDataSet.membership.Rows[0]["status"].ToString();
                double discount = Convert.ToDouble(masterDBDataSet.membership.Rows[0]["discount"].ToString());

                //course fields
                string 
                student = new Student(studentID, name, phoneNumber, email);
                Membership membership = new Membership(membershipID, status, discount);
                student.membership = membership; //link membership and student;
                membership.student = student;

                lblStudName_d.Text = name;
                lblMembership_d.Text = membershipID == null ? "Non-member" : membershipID;
            }
            else // Cannot find the student
            {   
                MessageBox.Show(string.Format("{0} is not found.",studentID));
            }
            
        }
    }
}
