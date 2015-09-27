using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.OleDb;
using System.Linq;
using System.Text;

namespace FunHomeClub
{
    class Teacher
    {
        private res.db.masterDBDataSet masterDBDataSet;
        public string teacherID { get; set; }
        public string name { get; set; }
        public string gender { get; set; }
        public Course course { get; set; }

        public Teacher(string teacherID, string name, string gender)
        {
            this.teacherID = teacherID;
            this.name = name;
            this.gender = gender;
        }

        public Teacher(string teacherID)
        {
            this.teacherID = teacherID;
            fetchTeacher();
        }

        public bool fetchTeacher()
        {
            string connStr = ConfigurationManager.ConnectionStrings["FunHomeClub.Properties.Settings.masterDBConnectionString"].ToString();
            OleDbConnection conn = new OleDbConnection(connStr);                 
            string sql = string.Format("SELECT * FROM Teacher WHERE teacherID = '{0}'", teacherID);
            OleDbCommand selectStudCommand = new OleDbCommand();
            OleDbDataAdapter adapter = new OleDbDataAdapter();
            selectStudCommand.Connection = conn;
            selectStudCommand.CommandText = sql;
            adapter.SelectCommand = selectStudCommand;
            adapter.Fill(masterDBDataSet, "Teacher");
            adapter.Dispose();

            if (masterDBDataSet.teacher.Count > 0)
            {
                name = masterDBDataSet.teacher.Rows[0]["name"].ToString();
                gender = masterDBDataSet.teacher.Rows[0]["gender"].ToString();
                course = new Course(masterDBDataSet.teacher.Rows[0]["course"].ToString());
                return true;
            }
            else
                return false;
        }
    }
}
