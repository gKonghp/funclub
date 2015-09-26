using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Search
{
    public partial class SearchForm : Form
    {
        OleDbConnection connection;
        OleDbDataAdapter dataAdapter;
        DataTable dt;
        string showAllCourse;
        double profitMargin;
        string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=masterDB.accdb";

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
            showAllCourse = "SELECT cc.name, c.name, weekday, startMonth, endMonth, startTime, endTime, ((teacherRate + operatingCharges) * "+
              profitMargin + ") / 10 as Price, quota, room, courseID FROM course c, courseCategory cc WHERE c.categoryID = cc.categoryID";
            dataAdapter.SelectCommand.CommandText = showAllCourse;
            dataAdapter.Fill(dt);
            FillListView();
        }
        private void FillListView()
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
        private void btnSearch_Click(object sender, EventArgs e)
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

            dataAdapter.SelectCommand.CommandText = selectString;
            dt.Clear();
            dataAdapter.Fill(dt);
            FillListView();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            cboMonth.SelectedIndex = 0;
            cboWeekday.SelectedIndex = 0;
            txtPrice1.Text = "";
            txtPrice2.Text = "";
            nudQuota.Value = 0;

            dataAdapter.SelectCommand.CommandText = showAllCourse;
            dt.Clear();
            dataAdapter.Fill(dt);
            FillListView();
        }

        private void lstCourseDetail_DoubleClick(object sender, EventArgs e)
        {
            CourseDetail cd = new CourseDetail(connection, dt.Rows[lstCourseDetail.SelectedItems[0].Index]["courseID"].ToString(), profitMargin);
            cd.ShowDialog();
        }
    }
}
