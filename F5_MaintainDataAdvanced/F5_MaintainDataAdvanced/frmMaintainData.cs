using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace F5_MaintainDataAdvanced
{
    public partial class frmMaintainData : Form
    {
        string password = "";
        string position = "";

        OleDbConnection cnn;
        OleDbDataAdapter oledbAdapterForTeacher, oledbAdapterForStudent,
            oledbAdapterForEmployee, oledbAdapterForCourse,
            oledbAdapterForMembership, oledbAdapterForProfitMargin
            ,oledbAdapterForCategory;

        string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;"
                          + "Data Source=masterDB.accdb";

        DataSet ds = new DataSet();

        OleDbCommandBuilder oledbCmdBuilderForTeacher, oledbCmdBuilderForStudent,
            oledbCmdBuilderForEmployee, oledbCmdBuilderForCourse,
            oledbCmdBuilderForMembership, oledbCmdBuilderForProfitMargin,
            oledbCmdBuilderForCategory;

        public frmMaintainData()
        {
            InitializeComponent();
        }

        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            DataRow row = ds.Tables["employee"].NewRow();
            row.SetField("employeeID", tbEmployeeID.Text);
            row.SetField("username", tbUserName.Text);
            row.SetField("password", tbPassword.Text);
            row.SetField("position", position);
            ds.Tables["employee"].Rows.Add(row);
            oledbAdapterForEmployee.Update(ds.Tables["employee"]);
            MessageBox.Show("Add record successful");
            loadEmployee();
        }

        private void rbStaff_CheckedChanged(object sender, EventArgs e)
        {
            position = "s";
        }

        private void rbManager_CheckedChanged(object sender, EventArgs e)
        {
            position = "m";
        }

        private void btnDeleteEmployee_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to delete the record?", "Confirmation", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                int index = Convert.ToInt32(lvEmployee.SelectedItems[0].Index.ToString());
                ds.Tables["employee"].Rows[index].Delete();
                oledbAdapterForEmployee.Update(ds.Tables["employee"]);
                loadEmployee ();
            }
        }

        private void btnDeleteTeacher_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to delete the record?", "Confirmation", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                int index = Convert.ToInt32(lvTeacher.SelectedItems[0].Index.ToString());
                ds.Tables["teacher"].Rows[index].Delete();
                oledbAdapterForTeacher.Update(ds.Tables["teacher"]);
                loadTeacher();
            }
        }

        private void btnAddTeacher_Click(object sender, EventArgs e)
        {
            DataRow row = ds.Tables["teacher"].NewRow();
            row.SetField("teacherID", tbTeacherID.Text);
            row.SetField("name", tbTeacherName.Text);
            if (rbMale.Checked) {
                row.SetField("gender", "m");
            } else {
                row.SetField("gender", "f");
            }
            ds.Tables["teacher"].Rows.Add(row);
            oledbAdapterForTeacher.Update(ds.Tables["teacher"]);
            MessageBox.Show("Add record successful");
            loadTeacher();
        }

        private void lvTeacher_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvTeacher.SelectedItems.Count == 0)
            {
                tbTeacherID.Text = "";
                tbTeacherName.Text = "";
                rbMale.Checked = false;
                rbFemale.Checked = false;
                return;
            }

            tbTeacherID.Text = lvTeacher.SelectedItems[0].SubItems[0].Text;
            tbTeacherName.Text = lvTeacher.SelectedItems[0].SubItems[1].Text;
            if (lvTeacher.SelectedItems[0].SubItems[2].Text.Equals("m"))
            {
                rbMale.Checked = true;
            }
            if (lvTeacher.SelectedItems[0].SubItems[2].Text.Equals("f"))
            {
                rbFemale.Checked = true;
            }
        }

        private void btnUpdateTeacher_Click(object sender, EventArgs e)
        {
            int index = Convert.ToInt32(lvTeacher.SelectedItems[0].Index.ToString());
            ds.Tables["teacher"].Rows[index].SetField("teacherID", tbEmployeeID.Text);
            ds.Tables["teacher"].Rows[index].SetField("name", tbUserName.Text);
            if (rbMale.Checked)
            {
                ds.Tables["teacher"].Rows[index].SetField("gender", "m");
            }
            else
            {
                ds.Tables["teacher"].Rows[index].SetField("gender", "f");
            }
            oledbAdapterForTeacher.Update(ds.Tables["teacher"]);
            MessageBox.Show("Update record successful");
            loadTeacher();
        }

        private void lvStudent_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvStudent.SelectedItems.Count == 0)
            {

                tbStudentID.Text = "";
                tbPhoneNumber.Text = "";
                cbMembershipID.Text = "";
                tbEmail.Text = "";
                dtpEnrollMonth.Text = "";
                tbStudentName.Text = "";
                return;
            }

            tbStudentID.Text = lvStudent.SelectedItems[0].SubItems[0].Text;
            cbMembershipID.Text = lvStudent.SelectedItems[0].SubItems[1].Text;
            tbPhoneNumber.Text = lvStudent.SelectedItems[0].SubItems[2].Text;
            tbEmail.Text = lvStudent.SelectedItems[0].SubItems[3].Text;
            dtpEnrollMonth.Text = lvStudent.SelectedItems[0].SubItems[4].Text;
            tbStudentName.Text = lvStudent.SelectedItems[0].SubItems[5].Text; 
        }

        private void btnUpdateEmployee_Click(object sender, EventArgs e)
        {
            int index = Convert.ToInt32(lvEmployee.SelectedItems[0].Index.ToString());
            ds.Tables["employee"].Rows[index].SetField("employeeID", tbEmployeeID.Text);
            ds.Tables["employee"].Rows[index].SetField("username", tbUserName.Text);
            ds.Tables["employee"].Rows[index].SetField("password", tbPassword.Text);
            ds.Tables["employee"].Rows[index].SetField("position", position);
            oledbAdapterForEmployee.Update(ds.Tables["employee"]);
            MessageBox.Show("Update record successful");
            loadEmployee();
        }

        private void btnDeleteStudent_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to delete the record?", "Confirmation", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                int index = Convert.ToInt32(lvStudent.SelectedItems[0].Index.ToString());
                ds.Tables["student"].Rows[index].Delete();
                oledbAdapterForStudent.Update(ds.Tables["student"]);
                loadStudent();
            }
        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            DataRow row = ds.Tables["student"].NewRow();
            row.SetField("studentID", tbStudentID.Text);
            row.SetField("membershipID", cbMembershipID.Text);
            row.SetField("phoneNumber", Convert.ToInt32(tbPhoneNumber.Text));
            row.SetField("email", tbEmail.Text);
            row.SetField("enrollMonth", dtpEnrollMonth.Text);
            row.SetField("name", tbStudentName.Text);
            ds.Tables["student"].Rows.Add(row);
            oledbAdapterForStudent.Update(ds.Tables["student"]);
            MessageBox.Show("Add record successful");
            loadStudent();
        }

        private void btnUpdateStudent_Click(object sender, EventArgs e)
        {
            int index = Convert.ToInt32(lvStudent.SelectedItems[0].Index.ToString());
            ds.Tables["student"].Rows[index].SetField("studentID", tbStudentID.Text);
            ds.Tables["student"].Rows[index].SetField("membershipID", cbMembershipID.Text);
            ds.Tables["student"].Rows[index].SetField("phoneNumber", Convert.ToInt32(tbPhoneNumber.Text));
            ds.Tables["student"].Rows[index].SetField("email", tbEmail.Text);
            ds.Tables["student"].Rows[index].SetField("enrollMonth", dtpEnrollMonth.Text);
            ds.Tables["student"].Rows[index].SetField("name", tbStudentName.Text);
            oledbAdapterForStudent.Update(ds.Tables["student"]);
            MessageBox.Show("Update record successful");
            loadStudent();
        }

        private void lvEmployee_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvEmployee.SelectedItems.Count == 0)
            {
                tbEmployeeID.Text = "";
                tbUserName.Text = "";
                tbPassword.Text = "";
                rbManager.Checked = false;
                rbStaff.Checked = false;
                return;
            }

            tbEmployeeID.Text = lvEmployee.SelectedItems[0].SubItems[0].Text;
            tbUserName.Text = lvEmployee.SelectedItems[0].SubItems[1].Text;
            tbPassword.Text = lvEmployee.SelectedItems[0].SubItems[2].Text;
            if (lvEmployee.SelectedItems[0].SubItems[3].Text.Equals("s")) {
                rbStaff.Checked = true;
            }
            if (lvEmployee.SelectedItems[0].SubItems[3].Text.Equals("m"))
            {
                rbManager.Checked = true;
            }

        }

        private void lvMembershipDiscount_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvMembershipDiscount.SelectedItems.Count == 0)
            {
                tbMembershipID.Text = "";
                tbStatus.Text = "";
                tbDiscount.Text = "";
                return;
            }
            tbMembershipID.Text = lvMembershipDiscount.SelectedItems[0].SubItems[0].Text;
            tbStatus.Text = lvMembershipDiscount.SelectedItems[0].SubItems[1].Text;
            tbDiscount.Text = lvMembershipDiscount.SelectedItems[0].SubItems[2].Text;
        }

        private void btnAddMembershipDiscount_Click(object sender, EventArgs e)
        {
            DataRow row = ds.Tables["membership"].NewRow();
            row.SetField("membershipID", tbMembershipID.Text);
            row.SetField("status", tbStatus.Text);
            row.SetField("discount", Convert.ToDouble(tbDiscount.Text));
            ds.Tables["membership"].Rows.Add(row);
            oledbAdapterForMembership.Update(ds.Tables["membership"]);
            MessageBox.Show("Add record successful");
            loadMembership();
        }

        private void btnUpdateMembershipDiscount_Click(object sender, EventArgs e)
        {
            int index = Convert.ToInt32(lvMembershipDiscount.SelectedItems[0].Index.ToString());
            ds.Tables["membership"].Rows[index].SetField("membershipID", tbMembershipID.Text);
            ds.Tables["membership"].Rows[index].SetField("status", tbStatus.Text);
            ds.Tables["membership"].Rows[index].SetField("discount", Convert.ToDouble(tbDiscount.Text));
            oledbAdapterForMembership.Update(ds.Tables["membership"]);
            MessageBox.Show("Update record successful");
            loadMembership();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to delete the record?", "Confirmation", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                int index = Convert.ToInt32(lvMembershipDiscount.SelectedItems[0].Index.ToString());
                ds.Tables["membership"].Rows[index].Delete();
                oledbAdapterForMembership.Update(ds.Tables["membership"]);
                loadMembership();
            }
        }

        private void btnUpdateProfitMargin_Click(object sender, EventArgs e)
        {
            
            ds.Tables["profitMargin"].Rows[0].SetField("percentage", Convert.ToDouble(tbProfitMargin.Text));
            oledbAdapterForProfitMargin.Update(ds.Tables["profitMargin"]);
            MessageBox.Show("Update record successful");
            this.Refresh();
        }

        private void lvCourse_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvCourse.SelectedItems.Count == 0) {

                tbCourseID.Text = "";
                tbName.Text = "";
                tbQuota.Text = "";
                tbWeekday.Text = "";
                tbRoom.Text = "";
                dtpStartTime.Text = "";
                dtpEndTime.Text = "";
                tbTeacherRate.Text = "";
                tbOperatingCharges.Text = "";
                cbCategoryID.Text = "";
                cbTeacherID.Text = "";
                tbStartMonth.Text = "";
                tbEndMonth.Text = "";
                tbDescription.Text = "";
                return;
            }

            tbCourseID.Text = lvCourse.SelectedItems[0].SubItems[0].Text;
            tbName.Text = lvCourse.SelectedItems[0].SubItems[1].Text;
            tbQuota.Text = lvCourse.SelectedItems[0].SubItems[2].Text;
            tbWeekday.Text = lvCourse.SelectedItems[0].SubItems[3].Text;
            tbRoom.Text = lvCourse.SelectedItems[0].SubItems[4].Text;
            dtpStartTime.Text = lvCourse.SelectedItems[0].SubItems[5].Text;
            dtpEndTime.Text = lvCourse.SelectedItems[0].SubItems[6].Text;
            tbTeacherRate.Text = lvCourse.SelectedItems[0].SubItems[7].Text;
            tbOperatingCharges.Text = lvCourse.SelectedItems[0].SubItems[8].Text;
            cbCategoryID.Text = lvCourse.SelectedItems[0].SubItems[9].Text;
            cbTeacherID.Text = lvCourse.SelectedItems[0].SubItems[10].Text;
            tbStartMonth.Text = lvCourse.SelectedItems[0].SubItems[11].Text;
            tbEndMonth.Text = lvCourse.SelectedItems[0].SubItems[12].Text;
            tbDescription.Text = lvCourse.SelectedItems[0].SubItems[13].Text;
        }

        private void btnUpdatedCourse_Click(object sender, EventArgs e)
        {

            int index = Convert.ToInt32(lvCourse.SelectedItems[0].Index.ToString());
            ds.Tables["course"].Rows[index].SetField("courseID", tbCourseID.Text);
            ds.Tables["course"].Rows[index].SetField("name", tbName.Text);
            ds.Tables["course"].Rows[index].SetField("quota", Convert.ToInt32(tbQuota.Text));
            ds.Tables["course"].Rows[index].SetField("weekday", Convert.ToInt32(tbWeekday.Text));
            ds.Tables["course"].Rows[index].SetField("room", tbRoom.Text);
            ds.Tables["course"].Rows[index].SetField("startTime", dtpStartTime.Text);
            ds.Tables["course"].Rows[index].SetField("endTime", dtpEndTime.Text);
            ds.Tables["course"].Rows[index].SetField("teacherRate", Convert.ToInt32(tbTeacherRate.Text));
            ds.Tables["course"].Rows[index].SetField("operatingCharges", Convert.ToInt32(tbOperatingCharges.Text));
            ds.Tables["course"].Rows[index].SetField("categoryID", cbCategoryID.Text);
            ds.Tables["course"].Rows[index].SetField("teacherID", cbTeacherID.Text);
            ds.Tables["course"].Rows[index].SetField("startMonth", Convert.ToInt32(tbStartMonth.Text));
            ds.Tables["course"].Rows[index].SetField("endMonth", Convert.ToInt32(tbEndMonth.Text));
            ds.Tables["course"].Rows[index].SetField("description", tbDescription.Text);
            oledbAdapterForCourse.Update(ds.Tables["course"]);
            MessageBox.Show("Update record successful");
            loadCourse();

        }


        private void btnAddCourse_Click(object sender, EventArgs e)
        {
            //add record to database
            DataRow row = ds.Tables["course"].NewRow();
            row.SetField("courseID", tbCourseID.Text);
            row.SetField("name", tbName.Text);
            row.SetField("quota", tbQuota.Text);
            row.SetField("weekday", tbWeekday.Text);
            row.SetField("room", tbRoom.Text);
            row.SetField("startTime", dtpStartTime.Text);
            row.SetField("endTime", dtpEndTime.Text);
            row.SetField("teacherRate", tbTeacherRate.Text);
            row.SetField("operatingCharges", tbOperatingCharges.Text);
            row.SetField("categoryID", cbCategoryID.Text);
            row.SetField("teacherID", cbTeacherID.Text);
            row.SetField("startMonth", tbStartMonth.Text);
            row.SetField("endMonth", tbEndMonth.Text);
            row.SetField("description", tbDescription.Text);
            ds.Tables["course"].Rows.Add(row);
            oledbAdapterForCourse.Update(ds.Tables["course"]);
            MessageBox.Show("Add record successful");
            loadCourse();

        }

        private void btnDeleteCourse_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to delete the record?", "Confirmation", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                int index = Convert.ToInt32(lvCourse.SelectedItems[0].Index.ToString());
                ds.Tables["course"].Rows[index].Delete();
                oledbAdapterForCourse.Update(ds.Tables["course"]);
                loadCourse();
            }
        }


        private void loadCourse() {
            lvCourse.Items.Clear();
            for (int i = 0; i < ds.Tables["course"].Rows.Count; i++)
            {
                //display items in lvCourse
                ListViewItem lvi = new ListViewItem(ds.Tables["course"].Rows[i].ItemArray[0].ToString());
                lvi.SubItems.Add(ds.Tables["course"].Rows[i].ItemArray[1].ToString());
                lvi.SubItems.Add(ds.Tables["course"].Rows[i].ItemArray[2].ToString());
                lvi.SubItems.Add(ds.Tables["course"].Rows[i].ItemArray[3].ToString());
                lvi.SubItems.Add(ds.Tables["course"].Rows[i].ItemArray[4].ToString());
                lvi.SubItems.Add(ds.Tables["course"].Rows[i].ItemArray[5].ToString());
                lvi.SubItems.Add(ds.Tables["course"].Rows[i].ItemArray[6].ToString());
                lvi.SubItems.Add(ds.Tables["course"].Rows[i].ItemArray[7].ToString());
                lvi.SubItems.Add(ds.Tables["course"].Rows[i].ItemArray[8].ToString());
                lvi.SubItems.Add(ds.Tables["course"].Rows[i].ItemArray[9].ToString());
                lvi.SubItems.Add(ds.Tables["course"].Rows[i].ItemArray[10].ToString());
                lvi.SubItems.Add(ds.Tables["course"].Rows[i].ItemArray[11].ToString());
                lvi.SubItems.Add(ds.Tables["course"].Rows[i].ItemArray[12].ToString());
                lvi.SubItems.Add(ds.Tables["course"].Rows[i].ItemArray[13].ToString());
                lvCourse.Items.Add(lvi);
                //cbCategoryID.Items.Add(ds.Tables["course"].Rows[i].ItemArray[9].ToString()); 
            }
            //display items in category  and the teacherid of course

            for (int i = 0; i < ds.Tables["teacher"].Rows.Count; i++) {
                cbTeacherID.Items.Add(ds.Tables["teacher"].Rows[i].ItemArray[0].ToString());
            }

            for (int i = 0; i < ds.Tables["courseCategory"].Rows.Count; i++)
            {
                cbCategoryID.Items.Add(ds.Tables["courseCategory"].Rows[i].ItemArray[0].ToString());
            }

        }

        private void loadEmployee()
        {
            lvEmployee.Items.Clear();
            for (int i = 0; i < ds.Tables["employee"].Rows.Count; i++)
            {
                //display items in lvCourse
                ListViewItem lvi = new ListViewItem(ds.Tables["employee"].Rows[i].ItemArray[0].ToString());
                lvi.SubItems.Add(ds.Tables["employee"].Rows[i].ItemArray[1].ToString());
                lvi.SubItems.Add(ds.Tables["employee"].Rows[i].ItemArray[2].ToString());
                lvi.SubItems.Add(ds.Tables["employee"].Rows[i].ItemArray[3].ToString());
                lvEmployee.Items.Add(lvi);
            }
        }

        private void loadTeacher()
        {
            lvTeacher.Items.Clear();
            for (int i = 0; i < ds.Tables["teacher"].Rows.Count; i++)
            {
                //display items in lvCourse
                ListViewItem lvi = new ListViewItem(ds.Tables["teacher"].Rows[i].ItemArray[0].ToString());
                lvi.SubItems.Add(ds.Tables["teacher"].Rows[i].ItemArray[1].ToString());
                lvi.SubItems.Add(ds.Tables["teacher"].Rows[i].ItemArray[2].ToString());
                lvTeacher.Items.Add(lvi);
            }
        }

        private void loadStudent()
        {
            lvStudent.Items.Clear();
            for (int i = 0; i < ds.Tables["student"].Rows.Count; i++)
            {
                //display items in lvCourse
                ListViewItem lvi = new ListViewItem(ds.Tables["student"].Rows[i].ItemArray[0].ToString());
                lvi.SubItems.Add(ds.Tables["student"].Rows[i].ItemArray[1].ToString());
                lvi.SubItems.Add(ds.Tables["student"].Rows[i].ItemArray[2].ToString());
                lvi.SubItems.Add(ds.Tables["student"].Rows[i].ItemArray[3].ToString());
                lvi.SubItems.Add(ds.Tables["student"].Rows[i].ItemArray[4].ToString());
                lvi.SubItems.Add(ds.Tables["student"].Rows[i].ItemArray[5].ToString());
                lvStudent.Items.Add(lvi);
            }
            for (int i = 0; i < ds.Tables["membership"].Rows.Count; i++) {
                cbMembershipID.Items.Add(ds.Tables["membership"].Rows[i].ItemArray[0].ToString());
            }
        }

        private void loadMembership()
        {
            lvMembershipDiscount.Items.Clear();
            for (int i = 0; i < ds.Tables["membership"].Rows.Count; i++)
            {
                //display items in lvCourse
                ListViewItem lvi = new ListViewItem(ds.Tables["membership"].Rows[i].ItemArray[0].ToString());
                lvi.SubItems.Add(ds.Tables["membership"].Rows[i].ItemArray[1].ToString());
                lvi.SubItems.Add(ds.Tables["membership"].Rows[i].ItemArray[2].ToString());
                lvMembershipDiscount.Items.Add(lvi);
            } 
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cnn = new OleDbConnection(connectionString);
            try
            {
                cnn.Open();

                oledbAdapterForTeacher = new OleDbDataAdapter("Select * from teacher", cnn);
                oledbCmdBuilderForTeacher = new OleDbCommandBuilder(oledbAdapterForTeacher);
                oledbAdapterForTeacher.Fill(ds, "teacher");

                oledbAdapterForStudent = new OleDbDataAdapter("Select * from Student", cnn);
                oledbCmdBuilderForStudent = new OleDbCommandBuilder(oledbAdapterForStudent);
                oledbAdapterForStudent.Fill(ds, "student");
                
                oledbAdapterForMembership = new OleDbDataAdapter("Select * from membership", cnn);
                oledbCmdBuilderForMembership = new OleDbCommandBuilder(oledbAdapterForMembership);
                oledbAdapterForMembership.Fill(ds, "membership");

                oledbAdapterForProfitMargin = new OleDbDataAdapter("Select * from profitMargin", cnn);
                oledbCmdBuilderForProfitMargin = new OleDbCommandBuilder(oledbAdapterForProfitMargin);
                oledbAdapterForProfitMargin.Fill(ds, "profitMargin");

                oledbAdapterForCourse = new OleDbDataAdapter("Select * from course", cnn);
                oledbCmdBuilderForCourse = new OleDbCommandBuilder(oledbAdapterForCourse);
                oledbAdapterForCourse.Fill(ds, "course");

                oledbAdapterForEmployee = new OleDbDataAdapter("Select * from employee", cnn);
                oledbCmdBuilderForEmployee = new OleDbCommandBuilder(oledbAdapterForEmployee);
                oledbAdapterForEmployee.Fill(ds, "employee");

                oledbAdapterForCategory = new OleDbDataAdapter("Select * from courseCategory", cnn);
                oledbCmdBuilderForCategory = new OleDbCommandBuilder(oledbAdapterForCategory);
                oledbAdapterForCategory.Fill(ds, "courseCategory");

                MessageBox.Show("Connection Open ! ");

                loadCourse();
                loadEmployee();
                loadTeacher();
                loadStudent();
                loadMembership();

                tbProfitMargin.Text = ds.Tables["profitMargin"].Rows[0].ItemArray[1].ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Cannot open connection ! ");
            }
        }

    }
}
