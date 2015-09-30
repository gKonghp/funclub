﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Configuration;

namespace FunHomeClub
{
    public partial class SearchForm : Form
    {
        public OleDbConnection connection;
        public OleDbDataAdapter dataAdapter;
        public DataTable dt;
        public string showAllCourse;
        public double profitMargin;
        public string connectionString = ConfigurationManager.ConnectionStrings["FunHomeClub.Properties.Settings.masterDBConnectionString"].ToString();
        public SearchFilterForm sff;

        public SearchForm()
        {
            InitializeComponent();
            lstCourseDetail.FullRowSelect = true;
            lstCourseDetail.GridLines = true;
            lstCourseDetail.MultiSelect = false;

            connection = new OleDbConnection(connectionString);
            dt = new DataTable();
            string sql = "SELECT percentage FROM profitMargin";
            dataAdapter = new OleDbDataAdapter(sql, connection);
            dataAdapter.Fill(dt);
            profitMargin = Convert.ToDouble(dt.Rows[0]["percentage"].ToString());

            dt.Clear();
            showAllCourse = "SELECT cc.name, c.name, weekday, startMonth, endMonth, startTime, endTime, ((teacherRate + operatingCharges) * " +
              profitMargin + ") / 10 as Price, quota, room, courseID FROM course c, courseCategory cc WHERE c.categoryID = cc.categoryID";
            dataAdapter.SelectCommand.CommandText = showAllCourse;
            dataAdapter.Fill(dt);

            FillListView();
            sff = new SearchFilterForm(this);
        }
        public void FillListView()
        {
           lstCourseDetail.Items.Clear();
           for (int i = 0; i < dt.Rows.Count; i++)
            {
                lstCourseDetail.Items.Add(dt.Rows[i]["cc.name"].ToString());
                lstCourseDetail.Items[i].SubItems.Add(dt.Rows[i]["c.name"].ToString());
                lstCourseDetail.Items[i].SubItems.Add(dt.Rows[i]["weekday"].ToString());
                lstCourseDetail.Items[i].SubItems.Add(dt.Rows[i]["startMonth"].ToString());
                lstCourseDetail.Items[i].SubItems.Add(dt.Rows[i]["endMonth"].ToString());
                lstCourseDetail.Items[i].SubItems.Add(dt.Rows[i]["startTime"].ToString());
                lstCourseDetail.Items[i].SubItems.Add(dt.Rows[i]["endTime"].ToString());
                lstCourseDetail.Items[i].SubItems.Add(dt.Rows[i]["Price"].ToString());
                lstCourseDetail.Items[i].SubItems.Add(dt.Rows[i]["quota"].ToString());
                lstCourseDetail.Items[i].SubItems.Add(dt.Rows[i]["room"].ToString());
            }
        }

        /*private void btnSearch_Click(object sender, EventArgs e)
        {
            string selectString = "SELECT cc.name, c.name, weekday, startMonth, endMonth, startTime, endTime,  ((teacherRate + operatingCharges) * " +
              profitMargin + ") / 10 as Price, quota, room, courseID FROM course c, courseCategory cc WHERE c.categoryID = cc.categoryID"
                + " AND quota >= " + Convert.ToInt32(nudQuota.Value.ToString());

            if (cboMonth.SelectedIndex>0)
                selectString += " AND " + cboMonth.SelectedIndex + " BETWEEN startMonth AND endMonth";

            if (cboWeekday.SelectedIndex>0)
                selectString += " AND weekday =" + cboWeekday.SelectedIndex;

            if(!(txtPrice1.Text.Equals("") || txtPrice2.Text.Equals("")))
                selectString += " AND ((teacherRate + operatingCharges) * " + profitMargin + ") / 10 BETWEEN " + txtPrice1.Text + " AND " + txtPrice2.Text;

            if (cboCategory.SelectedIndex >= 0)
                selectString += " AND cc.categoryID = '" + category.Rows[cboCategory.SelectedIndex]["categoryID"].ToString() + "'";

            dataAdapter.SelectCommand.CommandText = selectString;
            dt.Clear();
            dataAdapter.Fill(dt);
            FillListView();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            cboMonth.SelectedIndex = 0;
            cboWeekday.SelectedIndex = 0;
            cboCategory.SelectedIndex = -1;
            txtPrice1.Text = "";
            txtPrice2.Text = "";
            nudQuota.Value = 0;

            dataAdapter.SelectCommand.CommandText = showAllCourse;
            dt.Clear();
            dataAdapter.Fill(dt);
            FillListView();
        }*/

        private void lstCourseDetail_DoubleClick(object sender, EventArgs e)
        {
            CourseDetail cd = new CourseDetail(connection, dt.Rows[lstCourseDetail.SelectedItems[0].Index]["courseID"].ToString(), profitMargin);
            cd.ShowDialog();
        }

        private void txtKeyword_TextChanged(object sender, EventArgs e)
        {
            string selectString = "";
            if (txtKeyword.Text.Length > 0)
            {
                selectString = "SELECT cc.name, c.name, weekday, startMonth, endMonth, startTime, endTime,  ((teacherRate + operatingCharges) * " +
                  profitMargin + ") / 10 as Price, quota, room, courseID FROM course c, courseCategory cc WHERE c.categoryID = cc.categoryID" +
                  " AND (cc.name like '%" + txtKeyword.Text + "%' OR c.name like '%" + txtKeyword.Text + "%' OR weekday like '%" + txtKeyword.Text +
                  "%' OR startMonth like '%" + txtKeyword.Text + "%' OR endMonth like '%" + txtKeyword.Text + "%' OR startTime like '%" + txtKeyword.Text +
                  "%' OR endTime like '%" + txtKeyword.Text + "%' OR ((teacherRate + operatingCharges) * " + profitMargin + ") / 10 like '%" + txtKeyword.Text +
                  "%' OR room like '%" + txtKeyword.Text + "%')";
            }
            else
            {
                selectString = showAllCourse;
            }

            dataAdapter.SelectCommand.CommandText = selectString;
            Console.WriteLine(txtKeyword.Text.Length);
            Console.WriteLine(dataAdapter.SelectCommand.CommandText);
            dt.Clear();
            dataAdapter.Fill(dt);
            Console.WriteLine(dt.Rows.Count.ToString());
            FillListView();
        }

        private void btnAdvanced_Click(object sender, EventArgs e)
        {
            sff.ShowDialog();
        }

        private void SearchForm_Load(object sender, EventArgs e)
        {

        }
    }
}