using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Globalization;
using System.Data.OleDb;
using System.Threading;

namespace FunHomeClub
{
    public partial class CalendarControl : UserControl
    {
        private int currentMonth;
        private int currentYear;
        private int lastDay;
        private int firstDayInMonth;
        OleDbConnection connection;
        OleDbDataAdapter dataAdapter;
        DataTable dt;
        string[][] course;
        Color[] colorList = {
            ColorTranslator.FromHtml("#7A67EE"),
            ColorTranslator.FromHtml("#7FC400"),
            ColorTranslator.FromHtml("#FFB90F"),
            ColorTranslator.FromHtml("#00BFFF"),
            ColorTranslator.FromHtml("#00FFFF"),
            ColorTranslator.FromHtml("#FF4040"),
            ColorTranslator.FromHtml("#FF82AB"),
            ColorTranslator.FromHtml("#FFFF00"),
            ColorTranslator.FromHtml("#D2691E"),
            };
        public CalendarControl(OleDbConnection connection)
        {
            InitializeComponent();
            this.connection = connection;
            dt = new DataTable();
            course = new string[7][];

            currentYear = Convert.ToInt32(DateTime.Now.ToString("yyyy"));
            currentMonth = Convert.ToInt32(DateTime.Now.ToString("MM"));

            InitialCourse();
            InitialHeading();
            InitialTable();
            dayTable.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
        }

        private void InitialCourse()
        {
            for (int i = 0; i < 7; i++)
            {
                string sql = "SELECT courseID, name, startTime, endTime FROM course WHERE " + currentMonth + " between startMonth AND endMonth AND weekday = " + i + " AND " + currentYear + " BETWEEN startYear AND endYear ORDER BY startTime";
                dataAdapter = new OleDbDataAdapter(sql, connection);
                dt.Clear();
                dataAdapter.Fill(dt);

                course[i] = new string[dt.Rows.Count];

                for (int q = 0; q < dt.Rows.Count; q++)
                {
                    //course[i][q] = dt.Rows[q]["courseID"] + " - " + dt.Rows[q]["name"] + "\n" + Convert.ToDateTime(dt.Rows[q]["startTime"].ToString()).ToShortTimeString() + "-" + Convert.ToDateTime(dt.Rows[q]["endTime"].ToString()).ToShortTimeString();
                    course[i][q] = dt.Rows[q]["courseID"] + " - " + dt.Rows[q]["name"];
                }
            }
        }

        private void InitialHeading()
        {
            CultureInfo culture = new CultureInfo("en-GB");
            lblMonth.Text = new DateTime(currentYear, currentMonth, 1).ToString("MMMM - yyyy", culture);
        }

        public void InitialTable()
        {
            dayTable.CellBorderStyle = TableLayoutPanelCellBorderStyle.None;

            lastDay = DateTime.DaysInMonth(currentYear, currentMonth);
            firstDayInMonth = (int)(new DateTime(currentYear, currentMonth, 1).DayOfWeek);
            dayTable.Controls.Clear();

            int countDay = 1;
            bool isFirst = true;
            // Suspend Layout
            this.SuspendLayout();
            // End SuspendLayout
            Console.WriteLine("currentMonth: " + currentMonth + " currentYear: " + currentYear + " lastDay: " + lastDay + " firstDayInMonth: " + firstDayInMonth);
            for (int i = 0; i <= Math.Ceiling(lastDay / 7.0); i++) //row
            {
                int n;
                if (isFirst)
                {
                    n = firstDayInMonth;
                    isFirst = false;
                }
                else
                    n = 0;

                for (; n < 7; n++) //column
                {
                    if (countDay > lastDay)
                        break;

                    TableLayoutPanel tmp = new TableLayoutPanel();
                    dayTable.Controls.Add(tmp, n, i);

                    tmp.RowStyles.Add(new RowStyle(SizeType.AutoSize));
                    tmp.Controls.Add(new Label() { Text = Convert.ToString(countDay), AutoSize = true });

                    for (int q = 0; q < course[n].Length; q++)
                    {
                        Label label = new Label() { Text = course[n][q].ToString(), AutoSize = true, BackColor = colorList[q], ForeColor = Color.White };
                        label.Margin = new Padding(3);
                        label.Click += new EventHandler(allLabel_Click);
                        label.MouseHover += new EventHandler(allLabel_MoverHover);
                        tmp.Controls.Add(label);
                    }
                    countDay++;
                }
            }
            this.ResumeLayout();
        }
        private void preMonth_Click(object sender, EventArgs e)
        {
            if (currentMonth - 1 == 0)
            {
                currentMonth = 12;
                currentYear -= 1;
            }
            else
                currentMonth -= 1;

            //this.SuspendLayout();
            InitialHeading();
            InitialCourse();
            InitialTable();

            dayTable.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            //this.ResumeLayout();
        }

        private void nextMonth_Click(object sender, EventArgs e)
        {
            if (currentMonth + 1 == 13)
            {
                currentMonth = 1;
                currentYear += 1;
            }
            else
                currentMonth += 1;

            InitialHeading();
            InitialCourse();
            InitialTable();
            
            dayTable.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
        }
        private void allLabel_Click(object sender, EventArgs e)
        {
            Label label = (Label)sender;
            CourseDetail cd = new CourseDetail(connection, label.Text.Split('-')[0].Trim());
            cd.ShowDialog();
        }
        private void allLabel_MoverHover(object sender, EventArgs e)
        {
            Label label = (Label)sender;
            label.Cursor = Cursors.Hand;
        }
    }
}
