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
using System.Text.RegularExpressions;
using System.Diagnostics;

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
            
            
            txtRoom.Tag = "ns";
            numQuota.Value = 10;
            numericOperating.Value = 2000;
            this.connection = connection;
            if (!isAdd)
            {
                txtCourseName.Text = lstItem.SubItems[1].Text;
                cboWeekday.SelectedIndex = Int32.Parse(lstItem.SubItems[2].Text) - 1;
                txtRoom.Text = lstItem.SubItems[3].Text;
                txtDescription.Text = lstItem.SubItems[12].Text;
                fillTeacherName(lstItem.SubItems[9].Text);
                numericRate.Value = Int32.Parse(lstItem.SubItems[6].Text);
                fillCategory(lstItem.SubItems[8].Text);
                numericOperating.Value = Int32.Parse(lstItem.SubItems[7].Text);
                String[] StartTime = lstItem.SubItems[4].Text.Split(':');
                String[] EndTime = lstItem.SubItems[5].Text.Split(':');
                dtpStartTime.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, Int32.Parse(StartTime[0].ToString()), Int32.Parse(StartTime[1].ToString()), 0);
                dtpEndTime.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, Int32.Parse(EndTime[0].ToString()), Int32.Parse(EndTime[1].ToString()), 0);

                cboStartMonth.SelectedIndex = cboStartMonth.Items.IndexOf(lstItem.SubItems[10].Text);
                cboEndMonth.SelectedIndex = cboStartMonth.Items.IndexOf(lstItem.SubItems[11].Text);
                this.courseID = lstItem.SubItems[0].Text;
                DataTable dt = new DataTable();
                dataAdapter = new OleDbDataAdapter("select quota from courseMonth where courseID = '" + this.courseID + "'", connection);
                dataAdapter.Fill(dt);
                numQuota.Value = Int32.Parse(dt.Rows[0][0].ToString());
            }
            else
            {

                fillTeacherName();
                fillCategory();
                cboStartMonth.SelectedIndex = 0;
                cboEndMonth.SelectedIndex = 0;
                cboWeekday.SelectedIndex = 0;
                cboTeacherName.SelectedIndex = 0;
                cboCategory.SelectedIndex = 0;
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
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            Button btn = (btnAdd.Visible == true) ? btnAdd : btnSave;
            switch (keyData)
            {
                case Keys.Enter:
                    btn.PerformClick();
                    break;
                case Keys.Escape:
                    button2.PerformClick();
                    break;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (checkStringValid(txtCourseName, txtRoom, numericOperating, txtDescription, numQuota, cboCategory, cboEndMonth, cboStartMonth, cboTeacherName, cboWeekday))
            {
                String categoryID = String.Format("ca{0:D4}", cboCategory.SelectedIndex + 1);
                String teacherID = String.Format("te{0:D4}", cboTeacherName.SelectedIndex + 1);
                String sql = "update course set name='" + txtCourseName.Text + "',weekday='" + (cboWeekday.SelectedIndex + 1) + "',room='" + txtRoom.Text + "',startTime='" + dtpStartTime.Value + "',endTime='" + dtpEndTime.Value + "',teacherRate='" + numericRate.Value + "',operatingCharges='" + numericOperating.Value + "',categoryID='" + categoryID + "',teacherID='" + teacherID + "',startMonth='" + cboStartMonth.Text + "',endMonth='" + cboEndMonth.Text + "',description='" + txtDescription.Text + "',startYear='" + dtpStartTime.Value.Year + "',endYear='" + dtpEndTime.Value.Year + "' where courseID = '" + this.courseID + "'";
                OleDbCommand cmd = new OleDbCommand(sql, connection);
                cmd.ExecuteNonQuery();
                //--update quota
                cmd = new OleDbCommand("delete from courseMonth where courseID = '" + this.courseID + "'", connection);
                cmd.ExecuteNonQuery();
                for (int i = Int32.Parse(cboStartMonth.Text); i <= Int32.Parse(cboEndMonth.Text); i++)
                {
                    String sqlInsertMonth = "insert into courseMonth values('" + this.courseID + "','" + i.ToString() + "','" + numQuota.Value + "')";
                    OleDbCommand cmd2 = new OleDbCommand(sqlInsertMonth, connection);
                    cmd2.ExecuteNonQuery();
                }
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
        private Boolean checkStringValid(params object[] para)
        {
            for (int i = 0; i < para.Length; i++)
            {
                switch (para[i].GetType().Name)
                {
                    case "TextBox":
                        TextBox tb = (TextBox)para[i];
                        tb.Text = tb.Text.Trim();
                        if (tb.Text == "")
                        {
                            courseErrProvider.SetError(tb, "Please fill in all Textbox first!");
                            //MessageBox.Show("Please fill in all Textbox first!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            switch ((tb.Tag == null ? null : tb.Tag.ToString()))
                            {
                                case null:
                                    if (!Regex.IsMatch(tb.Text, @"^[\sa-zA-Z0-9]+$") && tb.Multiline == false)
                                    {
                                        courseErrProvider.SetError(tb, tb.Name.Replace("txt", "") + " do not allow any special characters!");
                                        //MessageBox.Show(tb.Name.Replace("txt","") + " do not allow any special characters!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                    else
                                        courseErrProvider.SetError(tb, "");
                                    break;
                                case "ns":
                                    if (!Regex.IsMatch(tb.Text, @"^[a-zA-Z0-9]+$"))
                                    {
                                        courseErrProvider.SetError(tb, tb.Name.Replace("txt", "") + " do not allow space characters!");

                                        //MessageBox.Show(tb.Name.Replace("txt", "") + " do not allow space characters!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                    else
                                        courseErrProvider.SetError(tb, "");
                                    break;
                                case "email":
                                    if (!Regex.IsMatch(tb.Text, @"^\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$"))
                                    {
                                        courseErrProvider.SetError(tb, "Not a valid email format!");

                                        //MessageBox.Show("Not a valid email format!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                    else
                                        courseErrProvider.SetError(tb, "");
                                    break;
                            }
                        }
                        break;
                    case "ComboBox":
                        ComboBox cb = (ComboBox)para[i];
                        if (cb.SelectedItem == null)
                        {
                            courseErrProvider.SetError(cb, "Please choose all combobox first!");
                            //MessageBox.Show("Please choose all combobox first!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        break;
                    case "NumericUpDown":
                        NumericUpDown numeric = (NumericUpDown)para[i];
                        if (numeric.Value == 0)
                        {
                            courseErrProvider.SetError(numeric, "The number cannot be zero!");
                           // MessageBox.Show("The number cannot be zero!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        break;
                }
            }
            if (cboStartMonth.SelectedIndex > cboEndMonth.SelectedIndex)
            {
                courseErrProvider.SetError(cboEndMonth, "Start month must smaller than end month!!");
                //MessageBox.Show("Start month must smaller than end month!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                courseErrProvider.SetError(cboEndMonth, "");

            if (dtpStartTime.Value >= dtpEndTime.Value)
            {
                courseErrProvider.SetError(dtpEndTime, "Start time must smaller than end time!!");
                //MessageBox.Show("Start time must smaller than end time!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                courseErrProvider.SetError(dtpEndTime, "");


            Boolean v = isValid();
            btnAdd.Enabled = btnSave.Enabled = v;
            return v;
        }
        private bool isValid()
        {
            foreach (Control c in courseErrProvider.ContainerControl.Controls)
            {
                foreach (Control subC in c.Controls)
                {
                    if (!(courseErrProvider.GetError(subC).Trim() == ""))
                    {
                        return false;
                    }
                }
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
                String nextValidCourseID = getNextValidCourseID();
                String sql = "insert into course values('" + nextValidCourseID + "','" + txtCourseName.Text + "','" + (cboWeekday.SelectedIndex + 1) + "','" + txtRoom.Text + "','" + dtpStartTime.Value + "','" + dtpEndTime.Value + "','" + numericRate.Value + "','" + numericOperating.Value + "','" + categoryID + "','" + teacherID + "','" + cboStartMonth.Text + "','" + cboEndMonth.Text + "','" + txtDescription.Text + "','" + dtpStartTime.Value.Year + "','" + dtpEndTime.Value.Year + "')";
                OleDbCommand cmd = new OleDbCommand(sql, connection);
                cmd.ExecuteNonQuery();
                for (int i = Int32.Parse(cboStartMonth.Text); i <= Int32.Parse(cboEndMonth.Text); i++)
                {
                    String sqlInsertMonth = "insert into courseMonth values('" + nextValidCourseID + "','" + i.ToString() + "','" + numQuota.Value + "')";
                    OleDbCommand cmd2 = new OleDbCommand(sqlInsertMonth, connection);
                    cmd2.ExecuteNonQuery();
                }
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void txtCourseName_TextChanged(object sender, EventArgs e)
        {
            checkStringValid(txtCourseName);
        }

        private void txtRoom_TextChanged(object sender, EventArgs e)
        {
            checkStringValid(txtRoom);
        }

        private void MaintainCourse_TextChanged(object sender, EventArgs e)
        {
           // checkStringValid(txtCourseName, txtRoom, numericOperating, txtDescription, numQuota, cboCategory, cboEndMonth, cboStartMonth, cboTeacherName, cboWeekday);

        }

        private void numQuota_ValueChanged(object sender, EventArgs e)
        {
            checkStringValid(numQuota);
        }

        private void numericOperating_ValueChanged(object sender, EventArgs e)
        {
            checkStringValid(numericOperating);
        }

        private void dtpStartTime_ValueChanged(object sender, EventArgs e)
        {
            checkStringValid();
        }

        private void dtpEndTime_ValueChanged(object sender, EventArgs e)
        {
            checkStringValid();
        }

        private void cboStartMonth_SelectedIndexChanged(object sender, EventArgs e)
        {
            checkStringValid(cboStartMonth);
        }

        private void cboEndMonth_SelectedIndexChanged(object sender, EventArgs e)
        {
            //MessageBox.Show("12w"+cboEndMonth.SelectedIndex.ToString());
            checkStringValid(cboEndMonth);

        }

        private void cboWeekday_SelectedIndexChanged(object sender, EventArgs e)
        {
            checkStringValid(cboWeekday);

        }

        private void txtDescription_TextChanged(object sender, EventArgs e)
        {
            checkStringValid(txtDescription);

        }

        private void cboTeacherName_SelectedIndexChanged(object sender, EventArgs e)
        {
            checkStringValid(cboTeacherName);

        }

        private void numericRate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void cboCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            checkStringValid(cboCategory);

        }
    }
}
