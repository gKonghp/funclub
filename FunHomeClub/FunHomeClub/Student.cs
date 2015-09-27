using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Configuration;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;

namespace FunHomeClub
{
    class Student
    {
        private res.db.masterDBDataSet masterDBDataSet;
        public string studentID { get; set; }
        public string phoneNumber { get; set; }
        public string email { get; set; }

        public DateTime enrollMonth { get; set; }

        public string name { get; set; }

        public Collection<Registration> registrations { get; set; }

        public Membership membership { get; set; }
        public Student(string studentID, string name, string phoneNumber, string email)
        {
            this.studentID = studentID;
            this.name = name;
            this.phoneNumber = phoneNumber;
            this.email = email;
            registrations = new Collection<Registration>();
        }

        public Student(string studentID)
        {
            this.studentID = studentID;
        }

        public void addRegistraton(Registration registration) {
            registrations.Add(registration);
        }

        public void removeCourse(Registration registration) {
            registrations.Remove(registration);
        }

        public bool fetchStudent()
        {
            string connStr = ConfigurationManager.ConnectionStrings["FunHomeClub.Properties.Settings.masterDBConnectionString"].ToString();
            OleDbConnection conn = new OleDbConnection(connStr);
            string sql = string.Format("SELECT * FROM Student WHERE studentID = '{0}'", studentID);
            OleDbCommand selectStudCommand = new OleDbCommand();
            OleDbDataAdapter adapter = new OleDbDataAdapter();
            selectStudCommand.Connection = conn;
            selectStudCommand.CommandText = sql;
            adapter.SelectCommand = selectStudCommand;
            adapter.Fill(masterDBDataSet, "Student");
            adapter.Dispose();

            if (masterDBDataSet.student.Count > 0)
            {
                name = masterDBDataSet.student.Rows[0]["name"].ToString();
                string membershipID = masterDBDataSet.student.Rows[0]["membershipID"].ToString(); 
                phoneNumber = masterDBDataSet.student.Rows[0]["phoneNumber"].ToString();
                string email = masterDBDataSet.student.Rows[0]["email"].ToString();
                enrollMonth = Convert.ToDateTime(masterDBDataSet.student.Rows[0]["enrollMonth"].ToString());
                //find out studentCourse
                sql = string.Format("SELECT * FROM studentCourse WHERE studentID = '{0}'", studentID);
                adapter = new OleDbDataAdapter(sql, conn);
                adapter.Fill(masterDBDataSet, "studentCourse");
                adapter.Dispose();
                
                foreach (DataRow row in masterDBDataSet.studentCourse.Rows)
                {
                    string courseID = masterDBDataSet.studentCourse.Rows[0]["courseID"].ToString();
                    DateTime enrollDate = Convert.ToDateTime(masterDBDataSet.studentCourse.Rows[0]["enrollDate"].ToString());
                    Course course = new Course(courseID);
                    registrations.Add(new Registration(this, course, enrollDate));
                }
                return true;
            }
            else
                return false;
        }

    }
}
