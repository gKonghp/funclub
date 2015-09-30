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
using System.Text.RegularExpressions;

namespace FunHomeClub
{
    public partial class MaintainCourse : Form
    {
        String courseID;
        OleDbDataAdapter dataAdapter;
        OleDbConnection connection;
       
        public MaintainCourse()
        {
            InitializeComponent();
        }
        public MaintainCourse(OleDbConnection connection, ListViewItem lstItem, Boolean isAdd = false)
        {
            InitializeComponent();

            btnAdd.Visible = isAdd;
            btnSave.Visible = !isAdd;

            this.connection = connection;
            if (!isAdd)
            {
                txtCourseName.Text = lstItem.SubItems[1].Text;
                numQuota.Value = Int32.Parse(lstItem.SubItems[2].Text);
                cboWeekday.SelectedIndex = Int32.Parse(lstItem.SubItems[3].Text) - 1;
                txtRoom.Text = lstItem.SubItems[4].Text;
                txtDescription.Text = lstItem.SubItems[13].Text;
                fillTeacherName(lstItem.SubItems[10].Text);
                numericRate.Value = Int32.Parse(lstItem.SubItems[7].Text);
                fillCategory(lstItem.SubItems[9].Text);
                numericOperating.Value = Int32.Parse(lstItem.SubItems[8].Text);
                String[] StartTime = lstItem.SubItems[5].Text.Split(':');
                String[] EndTime = lstItem.SubItems[6].Text.Split(':');
                dtpStartTime.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, Int32.Parse(StartTime[0].ToString()), Int32.Parse(StartTime[1].ToString()), 0);
                dtpEndTime.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, Int32.Parse(EndTime[0].ToString()), Int32.Parse(EndTime[1].ToString()), 0);

                cboStartMonth.SelectedIndex = cboStartMonth.Items.IndexOf(lstItem.SubItems[11].Text);
                cboEndMonth.SelectedIndex = cboStartMonth.Items.IndexOf(lstItem.SubItems[12].Text);

                this.courseID = lstItem.SubItems[0].Text;
            }
            else
            {
                fillTeacherName();
                fillCategory();
            }
        }
        private void fillCategory(String categoryName = "none")
        {
            DataTable dt = new DataTable();
            string sql = "SELECT * from courseCategory order by categoryID asc";
            dataAdapter = new OleDbDataAdapter(sql, connection);
            dataAdapter.Fill(dt);
            for(int i = 0;i < dt.Rows.Count;i++)
            {
                cboCategory.Items.Add(dt.Rows[i]["name"].ToString());
            }
            if (!categoryName.Equals("none"))
                cboCategory.SelectedIndex = cboCategory.Items.IndexOf(categoryName);
        }
        private void fillTeacherName(String teacherName = "none")
        {
            DataTable dt = new DataTable();
            string sql = "SELECT * from teacher order by teacherID asc";
            dataAdapter = new OleDbDataAdapter(sql, connection);
            dataAdapter.Fill(dt);
            for(int i = 0;i < dt.Rows.Count;i++)
            {
                cboTeacherName.Items.Add(dt.Rows[i]["name"].ToString());
            }
            if(!teacherName.Equals("none"))
                cboTeacherName.SelectedIndex = cboTeacherName.Items.IndexOf(teacherName);
        }
        private void MaintainCourse_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedToolWindow;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String categoryID = String.Format("ca{0:D4}",cboCategory.SelectedIndex+1);
            String teacherID = String.Format("te{0:D4}", cboTeacherName.SelectedIndex + 1);
            String sql = "update course set name='" + txtCourseName.Text + "',quota='" + numQuota.Value + "',weekday='" + (cboWeekday.SelectedIndex + 1) + "',room='" + txtRoom.Text + "',startTime='" + dtpStartTime.Value.ToString("hh:mm") + "',endTime='" + dtpEndTime.Value.ToString("hh:mm") + "',teacherRate='" + numericRate.Value + "',operatingCharges='" + numericOperating.Value + "',categoryID='" + categoryID + "',teacherID='" + teacherID + "',startMonth='" + cboStartMonth.Text + "',endMonth='" + cboEndMonth.Text + "',description='" + txtDescription.Text + "' where courseID = '" + this.courseID + "'";
            OleDbCommand cmd = new OleDbCommand(sql,connection);
            cmd.ExecuteNonQuery();
            this.Close();
        }
        private Boolean checkStringValid(params object[] para)
        {
            for (int i = 0; i < para.Length; i++)
            {
                switch (para[i].GetType().Name)
                {
                    case "TextBox":
                        TextBox tb = (TextBox)para[i];
                        if (tb.Text == "")
                        {
                            MessageBox.Show("Please fill in all Textbox first!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return false;
                        }
                        else
                        {
                            if (!Regex.IsMatch(tb.Text, @"^[a-zA-Z0-9]+$") && tb.Multiline == false)
                            {
                                MessageBox.Show("TextBox do not allow any special characters!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return false;
                            }
                        }
                        break;
                    case "ComboBox":
                        ComboBox cb = (ComboBox)para[i];
                        if (cb.SelectedIndex < 0)
                        {
                            MessageBox.Show("Please choose all combobox first!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return false;
                        }
                        break;
                    case "NumericUpDown":
                        NumericUpDown numeric = (NumericUpDown)para[i];
                        if (numeric.Value == 0)
                        {
                            MessageBox.Show("The number cannot be zero!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return false;
                        }
                        break;
                }
            }
            if (cboStartMonth.SelectedIndex > cboEndMonth.SelectedIndex)
            {
                MessageBox.Show("Start month must smaller than end month!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (dtpStartTime.Value > dtpEndTime.Value)
            {
                MessageBox.Show("Start time must smaller than end time!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
        private String getNextValidCourseID()
        {
            DataTable dt = new DataTable();
            string sql = "SELECT courseID from course order by courseID desc";
            dataAdapter = new OleDbDataAdapter(sql, connection);
            dataAdapter.Fill(dt);
            if (Int32.Parse(dt.Rows[0][0].ToString().Substring(2)) != dt.Rows.Count)
                for (int i = 0; i < dt.Rows.Count; i++)
                    if (i + 1 != Int32.Parse(dt.Rows[dt.Rows.Count - i - 1][0].ToString().Substring(2)))
                        return String.Format("co{0:D4}", i + 1).ToString();
            return String.Format("co{0:D4}", Int32.Parse(dt.Rows[0][0].ToString().Substring(2)) + 1).ToString();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (checkStringValid(txtCourseName, txtRoom, numericOperating, txtDescription, numQuota, cboCategory, cboEndMonth, cboStartMonth, cboTeacherName, cboWeekday))
            {
                String categoryID = String.Format("ca{0:D4}", cboCategory.SelectedIndex + 1);
                String teacherID = String.Format("te{0:D4}", cboTeacherName.SelectedIndex + 1);
                String sql = "insert into course values('" + getNextValidCourseID() + "','" + txtCourseName.Text + "','" + numQuota.Value + "','" + (cboWeekday.SelectedIndex + 1) + "','" + txtRoom.Text + "','" + dtpStartTime.Value.ToString("hh:mm") + "','" + dtpEndTime.Value.ToString("hh:mm") + "','" + numericRate.Value + "','" + numericOperating.Value + "','" + categoryID + "','" + teacherID + "','" + cboStartMonth.Text + "','" + cboEndMonth.Text + "','" + txtDescription.Text + "')";
                OleDbCommand cmd = new OleDbCommand(sql, connection);
                cmd.ExecuteNonQuery();
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}