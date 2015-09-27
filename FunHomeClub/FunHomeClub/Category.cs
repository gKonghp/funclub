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
    class Category
    {
        private res.db.masterDBDataSet masterDBDataSet;
        public string categoryID { get; set; }
        public string name { get; set; }

        public double materialCost { get; set; }

        public Collection<Course> courses { get; set; }
        public Category(string categoryID, string name, double materialCost)
        {
            this.categoryID = categoryID;
            this.name = name;
            this.materialCost = materialCost;
        }

        public Category(string categoryID)
        {
            this.categoryID = categoryID;
            fetchCategory();
        }

        public bool fetchCategory()
        {
            string connStr = ConfigurationManager.ConnectionStrings["FunHomeClub.Properties.Settings.masterDBConnectionString"].ToString();
            OleDbConnection conn = new OleDbConnection(connStr);
            string sql = string.Format("SELECT * FROM Category WHERE categoryID = '{0}'", categoryID);
            OleDbCommand selectStudCommand = new OleDbCommand();
            OleDbDataAdapter adapter = new OleDbDataAdapter();
            selectStudCommand.Connection = conn;
            selectStudCommand.CommandText = sql;
            adapter.SelectCommand = selectStudCommand;
            adapter.Fill(masterDBDataSet, "Category");
            adapter.Dispose();

            if (masterDBDataSet.courseCategory.Count > 0)
            {
                name = masterDBDataSet.courseCategory.Rows[0]["name"].ToString();
                materialCost = Convert.ToDouble(masterDBDataSet.courseCategory.Rows[0]["materialCost"].ToString());
                sql = string.Format("SELECT * FROM Course WHERE categoryID = '{0}'", categoryID);
                adapter = new OleDbDataAdapter(sql, conn);
                adapter.Fill(masterDBDataSet, "Course");
                adapter.Dispose();

                foreach (DataRow row in masterDBDataSet.course.Rows)
                {
                    string courseID = masterDBDataSet.course.Rows[0]["courseID"].ToString();
                    courses.Add(new Course(courseID));
                }
                return true;
            }
            else
                return false;
        }
    }
}
