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
    class Course
    {
        private res.db.masterDBDataSet masterDBDataSet;

        public string courseID { get; set; }
        public string name { get; set; }
        public int quota { get; set; }

        public int weekday { get; set; }

        public string room { get; set; }

        public DateTime startTime { get; set; }
        public DateTime endTime { get; set; }

        public double teacherRate { get; set; }

        public double operatingCharges { get; set; }

        public Category category { get; set; }
        public Teacher teacher { get; set; }
        public DateTime startMonth { get; set; }
        public DateTime endMonth { get; set; }

        public string description { get; set; }
        public Collection<Registration> registrations { get; set; }
        public Course(string courseID, string name, int quota, int weekday, string room, DateTime startTime, DateTime endTime, double teacherRate, double operatingCharges, DateTime startMonth, DateTime endMonth, string description) {
            this.courseID = courseID;
            this.name = name;
            this.weekday = weekday;
            this.room = room;
            this.startTime = startTime;
            this.endTime = endTime;
            this.teacherRate = teacherRate;
            this.operatingCharges = operatingCharges;
            this.startMonth = startMonth;
            this.endMonth = endMonth;
            this.description = description;
        }

        public Course(string categoryID)
        {
            this.courseID = courseID;
            fetchCourse();
        }

        public bool fetchCourse()
        {
            string connStr = ConfigurationManager.ConnectionStrings["FunHomeClub.Properties.Settings.masterDBConnectionString"].ToString();
            OleDbConnection conn = new OleDbConnection(connStr);
            string sql = string.Format("SELECT * FROM Course WHERE courseID = '{0}'", courseID);
            OleDbCommand selectStudCommand = new OleDbCommand();
            OleDbDataAdapter adapter = new OleDbDataAdapter();
            selectStudCommand.Connection = conn;
            selectStudCommand.CommandText = sql;
            adapter.SelectCommand = selectStudCommand;
            adapter.Fill(masterDBDataSet, "Course");
            adapter.Dispose();

            if (masterDBDataSet.course.Count > 0)
            {
                name = masterDBDataSet.course.Rows[0]["name"].ToString();
                quota = Convert.ToInt32(masterDBDataSet.course.Rows[0]["quota"].ToString());
                weekday = Convert.ToInt32(masterDBDataSet.course.Rows[0]["weekday"].ToString());
                room = masterDBDataSet.course.Rows[0]["room"].ToString();
                startTime = Convert.ToDateTime(masterDBDataSet.course.Rows[0]["startTime"].ToString());
                endTime = Convert.ToDateTime(masterDBDataSet.course.Rows[0]["endTime"].ToString());
                teacherRate = Convert.ToDouble(masterDBDataSet.course.Rows[0]["teacherRate"].ToString());
                operatingCharges = Convert.ToDouble(masterDBDataSet.course.Rows[0]["operatingCharges"].ToString());
                string teacherID = masterDBDataSet.course.Rows[0]["teacherID"].ToString();
                string categoryID = masterDBDataSet.course.Rows[0]["categoryID"].ToString();
                startMonth = Convert.ToDateTime(masterDBDataSet.course.Rows[0]["startMonth"].ToString());
                endMonth = Convert.ToDateTime(masterDBDataSet.course.Rows[0]["endMonth"].ToString());
                description = masterDBDataSet.course.Rows[0]["description"].ToString();
                
                //find out studentCourse
                sql = string.Format("SELECT * FROM studentCourse WHERE courseID = '{0}'", courseID);
                adapter = new OleDbDataAdapter(sql,conn);
                adapter.Fill(masterDBDataSet, "studentCourse");
                adapter.Dispose();
                teacher = new Teacher(teacherID);
                category = new Category(categoryID);
                foreach (DataRow row in masterDBDataSet.studentCourse.Rows)
                {
                    string studentID = masterDBDataSet.studentCourse.Rows[0]["studentID"].ToString();
                    DateTime enrollDate = Convert.ToDateTime(masterDBDataSet.studentCourse.Rows[0]["enrollDate"].ToString());
                    Student student = new Student(studentID);
                    registrations.Add(new Registration(student, this, enrollDate));
                } 
                return true;
            }
            else
                return false;
        }
    }
}
