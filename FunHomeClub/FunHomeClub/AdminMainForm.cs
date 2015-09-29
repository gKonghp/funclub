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
using System.Configuration;

namespace FunHomeClub
{
    public partial class AdminMainForm : Form
    {
        OleDbConnection connection;
        OleDbDataAdapter dataAdapter;
        DataTable dt;
        string connectionString = ConfigurationManager.ConnectionStrings["FunHomeClub.Properties.Settings.masterDBConnectionString"].ToString();
        string teacherSQL = "select * from teacher";
        string employeeSQL = "select * from employee";
        string studentSQL = "select * from student";
        string courseSQL = "SELECT c.courseID,c.name,c.quota,c.weekday,c.room,c.startTime,c.endTime,c.teacherRate,c.operatingCharges,cat.name,tea.name,c.startMonth,c.endMonth ,c.description FROM course c,courseCategory cat, teacher tea where c.categoryID = cat.categoryID and c.teacherID = tea.teacherID order by c.courseID asc";
        string memberSQL = "SELECT * FROM membership";
        string promotionSQL = "select promotionID,name,description,additionalDiscount,Format(startTime,'dd/MM/yyyy'),Format(endTime,'dd/MM/yyyy') from promotion";
        public AdminMainForm()
        {
            InitializeComponent();
            lstMembership.FullRowSelect = true;
            lstMembership.GridLines = true;
            lstMembership.MultiSelect = false;
            connection = new OleDbConnection(connectionString);
            connection.Open();
            ShowProfitMargin();
            showDatainListView(employeeSQL, lstStaff);
            showDatainListView(teacherSQL, lstTeacher);
            showDatainListView(courseSQL, lstCourse);
            showDatainListView(studentSQL, lstStudent);
            showDatainListView(memberSQL, lstMembership);
            showDatainListView(promotionSQL, lstPromotion);
        }
        private void showDatainListView(String sql,ListView lstView)
        {
            lstView.Items.Clear();
            dt = new DataTable();
            dataAdapter = new OleDbDataAdapter(sql, connection);
            dataAdapter.Fill(dt);
            foreach (DataRow row in dt.Rows)
            {
                ListViewItem item = new ListViewItem(row[0].ToString());
                for (int i = 1; i < dt.Columns.Count; i++)
                {
                    item.SubItems.Add(row[i].ToString());
                }
                lstView.Items.Add(item);
            }
        }
        private void Admin_Load(object sender, EventArgs e)
        {
            lstCourse.FullRowSelect = true;
            lstCourse.GridLines = true;
            lstCourse.MultiSelect = false;

            lstTeacher.FullRowSelect = true;
            lstTeacher.GridLines = true;
            lstTeacher.MultiSelect = false;

            lstStudent.FullRowSelect = true;
            lstStudent.GridLines = true;
            lstStudent.MultiSelect = false;

            lstStaff.MultiSelect = false;
            lstStaff.GridLines = true;
            lstStaff.FullRowSelect = true;

            lstPromotion.MultiSelect = false;
            lstPromotion.GridLines = true;
            lstPromotion.FullRowSelect = true;
        }

        private void lstCourse_SelectedIndexChanged(object sender, EventArgs e)
        {
            Boolean isSelected = (lstCourse.SelectedIndices.Count > 0?true:false);
            btnDeleteCourse.Enabled = isSelected;
            btnMaintainCourse.Enabled = isSelected;
        }

        private void aToolStripMenuItem_Click(object sender, EventArgs e)
        {
            maintainCourse();
        }
        private void maintainCourse()
        {
            MaintainCourse mc = new MaintainCourse(connection, lstCourse.SelectedItems[0]);
            mc.ShowDialog();
            if (mc.DialogResult == DialogResult.OK)
            {
                MessageBox.Show("Save Successfully!");
                showDatainListView(courseSQL, lstCourse);
            }
            btnMaintainCourse.Enabled = false;
            btnDeleteCourse.Enabled = false;
        }

        private void lstCourseMenuStrip_Opening(object sender, CancelEventArgs e)
        {
            if(lstCourse.SelectedIndices.Count > 0)
            {
                addToolStripMenuItem.Visible = false;
                deleteToolStripMenuItem.Visible = true;
                aToolStripMenuItem.Visible = true;
            }
            else
            {
                deleteToolStripMenuItem.Visible = false;
                addToolStripMenuItem.Visible = true;
                aToolStripMenuItem.Visible = false;
            }


            addToolStripMenuItem.Visible = (lstCourse.SelectedIndices.Count > 0) ? false : true;
        }
        private void deleteCourse()
        {
            String sql = "delete from course where courseID='" + lstCourse.SelectedItems[0].SubItems[0].Text + "'";
            OleDbCommand cmd = new OleDbCommand(sql, connection);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Course:" + lstCourse.SelectedItems[0].SubItems[1].Text + " Deleted!");
            showDatainListView(courseSQL, lstCourse);
            btnMaintainCourse.Enabled = false;
            btnDeleteCourse.Enabled = false;
        }
        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            deleteCourse();
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addCourse();
        }
        private void addCourse(){
            MaintainCourse mc = new MaintainCourse(connection, null, true);
            mc.ShowDialog();
            if (mc.DialogResult == DialogResult.OK){
                MessageBox.Show("Add successfully!");
                showDatainListView(courseSQL, lstCourse);
            }
            btnMaintainCourse.Enabled = false;
            btnDeleteCourse.Enabled = false;
        }

        private void lstStaff_SelectedIndexChanged(object sender, EventArgs e){
            Boolean isSelected = (lstStaff.SelectedIndices.Count > 0 ? true : false);
            btnDeleteStaff.Enabled = isSelected;
            btnMaintainStaff.Enabled = isSelected;
        }
        private void addStaff(){
            MaintainStaff ms = new MaintainStaff(connection, null, true);
            ms.ShowDialog();
            if (ms.DialogResult == DialogResult.OK){
                MessageBox.Show("Add staff record successfully!!");
                showDatainListView(employeeSQL, lstStaff);
            }
            btnMaintainStaff.Enabled = false;
            btnDeleteStaff.Enabled = false;
        }
        private void addStaffMenuItem_Click(object sender, EventArgs e)
        {
            addStaff();
        }

        private void lstStaffMenuStrip1_Opening(object sender, CancelEventArgs e) {
            Boolean isSelected = (lstStaff.SelectedIndices.Count > 0) ? true : false;
            addStaffMenuItem.Visible = !isSelected;
            maintainStaffMenuItem.Visible = isSelected;
            deleteStaffMenuItem.Visible = isSelected;
        }
        private void maintainStaff(){
            MaintainStaff ms = new MaintainStaff(connection, lstStaff.SelectedItems[0]);
            ms.ShowDialog();
            if (ms.DialogResult == DialogResult.OK){
                MessageBox.Show("Update successfully!!");
                showDatainListView(employeeSQL, lstStaff);
            }
            btnMaintainStaff.Enabled = false;
            btnDeleteStaff.Enabled = false;
        }

        private void maintainStaffMenuItem_Click(object sender, EventArgs e){
            maintainStaff();
        }
        private void deleteStaff(){
            String sql = "delete from employee where employeeID='" + lstStaff.SelectedItems[0].SubItems[0].Text + "'";
            OleDbCommand cmd = new OleDbCommand(sql, connection);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Staff:" + lstStaff.SelectedItems[0].SubItems[1].Text + " Deleted!");
            showDatainListView(employeeSQL, lstStaff);
            btnMaintainStaff.Enabled = false;
            btnDeleteStaff.Enabled = false;
        }
        private void deleteStaffMenuItem_Click(object sender, EventArgs e){
            deleteStaff();
        }
        private void addTeacher(){
            MaintainTeacher mt = new MaintainTeacher(connection, null, true);
            mt.ShowDialog();
            if (mt.DialogResult == DialogResult.OK)
            {
                MessageBox.Show("Add successfully");
                showDatainListView(teacherSQL, lstTeacher);
            }
            btnMaintainTeacher.Enabled = false;
            btnDeleteTeacher.Enabled = false;
        }
        private void addTeacherMenuItem_Click(object sender, EventArgs e){
            addTeacher();
        }
        private void deleteTeacher(){
            String sql = "delete from teacher where teacherID='" + lstTeacher.SelectedItems[0].SubItems[0].Text + "'";
            OleDbCommand cmd = new OleDbCommand(sql, connection);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Teacher:" + lstTeacher.SelectedItems[0].SubItems[1].Text + " Deleted!");
            showDatainListView(teacherSQL, lstTeacher);
            btnMaintainTeacher.Enabled = false;
            btnDeleteTeacher.Enabled = false;
        }
        private void deleteTeacherMenuItem_Click(object sender, EventArgs e){
            deleteTeacher();
        }
        private void maintainTeacher(){
            MaintainTeacher mt = new MaintainTeacher(connection, lstTeacher.SelectedItems[0]);
            mt.ShowDialog();
            if (mt.DialogResult == DialogResult.OK){
                MessageBox.Show("Update successfully!");
                showDatainListView(teacherSQL, lstTeacher);
            }
            btnMaintainTeacher.Enabled = false;
            btnDeleteTeacher.Enabled = false;
        }
        private void maintainTeacherMenuItem_Click(object sender, EventArgs e){
            maintainTeacher();
        }

        private void lstTeacherMenuStrip_Opening(object sender, CancelEventArgs e){
            Boolean isSelected = (lstTeacher.SelectedIndices.Count > 0) ? true : false;
            addTeacherMenuItem.Visible = !isSelected;
            maintainTeacherMenuItem.Visible = isSelected;
            deleteTeacherMenuItem.Visible = isSelected;
        }
        private void deleteStudent(){
            String sql = "delete from student where studentID='" + lstStudent.SelectedItems[0].SubItems[0].Text + "'";
            OleDbCommand cmd = new OleDbCommand(sql, connection);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Teacher:" + lstStudent.SelectedItems[0].SubItems[1].Text + " Deleted!");
            showDatainListView(studentSQL, lstStudent);
            btnMaintainStudent.Enabled = false;
            btnDeleteStudent.Enabled = false;
        }
        private void deleteStudentMenuItem_Click(object sender, EventArgs e){
            deleteStudent();
        }
        private void addStudent(){
            MaintainStudent ms = new MaintainStudent(connection, null, true);
            ms.ShowDialog();
            if (ms.DialogResult == DialogResult.OK){
                MessageBox.Show("Added successfully!");
                showDatainListView(studentSQL, lstStudent);
            }
            btnMaintainStudent.Enabled = false;
            btnDeleteStudent.Enabled = false;
        }
        private void addStudentMenuItem_Click(object sender, EventArgs e){
            addStudent();
        }

        private void StudentMenuStrip_Opening(object sender, CancelEventArgs e){
            Boolean isSelected = (lstStudent.SelectedIndices.Count > 0) ? true : false;
            addStudentMenuItem.Visible = !isSelected;
            maintainStudentMenuItem.Visible = isSelected;
            deleteStudentMenuItem.Visible = isSelected;
        }
        private void maintainStudent()
        {
            MaintainStudent ms = new MaintainStudent(connection, lstStudent.SelectedItems[0]);
            ms.ShowDialog();
            if (ms.DialogResult == DialogResult.OK)
            {
                MessageBox.Show("Update successfully!");
                showDatainListView(studentSQL, lstStudent);
            }
            btnMaintainStudent.Enabled = false;
            btnDeleteStudent.Enabled = false;
        }
        private void maintainStudentMenuItem_Click(object sender, EventArgs e)
        {
            maintainStudent();
        }

        private void studentPage_Click(object sender, EventArgs e)
        {

        }
        //--
        private void ShowMembership(){
            lstMembership.Items.Clear();
            String sql = "SELECT * FROM membership";
            dt = new DataTable();
            dataAdapter = new OleDbDataAdapter(sql, connection);
            dataAdapter.Fill(dt);
            foreach (DataRow row in dt.Rows){
                ListViewItem item = new ListViewItem(row[0].ToString());
                for (int i = 1; i < dt.Columns.Count; i++){
                    item.SubItems.Add(row[i].ToString());
                }
                lstMembership.Items.Add(item);
            }
        }
        private void ShowProfitMargin()
        {
            String sql = "SELECT * FROM profitMargin Where profitMarginID = 'pm0001'";
            dt = new DataTable();
            dataAdapter = new OleDbDataAdapter(sql, connection);
            dataAdapter.Fill(dt);
            txtMargin.Text = dt.Rows[0]["percentage"].ToString();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            MaintainMembership mms = new MaintainMembership("Add", connection);
            if (mms.ShowDialog().Equals(DialogResult.OK))
            {
                ShowMembership();
            }
            AfterListMemberchange();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            new OleDbCommand("DELETE FROM memberShip WHERE membershipID = '" + lstMembership.Items[lstMembership.SelectedItems[0].Index].Text + "'", connection).ExecuteNonQuery();
            MessageBox.Show("Delete Successful!");
            ShowMembership();
            AfterListMemberchange();
        }

        private void lstMembership_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstMembership.SelectedItems.Count <= 0)
            {
                btnChange.Enabled = false;
                btnDelete.Enabled = false;
            }
            else
            {
                btnChange.Enabled = true;
                btnDelete.Enabled = true;
            }
        }

        public void AfterListMemberchange()
        {
            btnChange.Enabled = false;
            btnDelete.Enabled = false;


        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            MaintainMembership mms = new MaintainMembership("Change", lstMembership.Items[lstMembership.SelectedItems[0].Index].Text, connection);
            if (mms.ShowDialog().Equals(DialogResult.OK))
            {
                ShowMembership();
            }
            AfterListMemberchange();
        }

        private void profitPage_Click(object sender, EventArgs e)
        {

        }

        private void btnMargin_Click(object sender, EventArgs e)
        {
            if (btnMargin.Text.Equals("Modify"))
            {
                txtMargin.Enabled = true;
                btnMargin.Text = "Save";
            }
            else
            {
                txtMargin.Enabled = false;
                btnMargin.Text = "Modify";
                new OleDbCommand("Update profitMargin SET percentage = " + txtMargin.Text, connection).ExecuteNonQuery();
            }
        }

        private void lstStudent_SelectedIndexChanged(object sender, EventArgs e)
        {
            Boolean isSelected = (lstStudent.SelectedIndices.Count > 0 ? true : false);
            btnDeleteStudent.Enabled = isSelected;
            btnMaintainStudent.Enabled = isSelected;
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void btnAddCourse_Click(object sender, EventArgs e)
        {
            addCourse();
        }

        private void btnChangeCourse_Click(object sender, EventArgs e)
        {
            maintainCourse();
        }

        private void btnDeleteCourse_Click(object sender, EventArgs e)
        {
            deleteCourse();
        }

        private void btnAddStaff_Click(object sender, EventArgs e)
        {
            addStaff();
        }

        private void btnMaintainStaff_Click(object sender, EventArgs e)
        {
            maintainStaff();
        }

        private void btnDeleteStaff_Click(object sender, EventArgs e)
        {
            deleteStaff();
        }

        private void btnAddTeacher_Click(object sender, EventArgs e)
        {
            addTeacher();
        }

        private void btnMaintainTeacher_Click(object sender, EventArgs e)
        {
            maintainTeacher();
        }

        private void btnDeleteTeacher_Click(object sender, EventArgs e)
        {
            deleteTeacher();
        }

        private void lstTeacher_SelectedIndexChanged(object sender, EventArgs e)
        {
            Boolean isSelected = (lstTeacher.SelectedIndices.Count > 0 ? true : false);
            btnDeleteTeacher.Enabled = isSelected;
            btnMaintainTeacher.Enabled = isSelected;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            addStudent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            maintainStudent();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            deleteStudent();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            addPromotion();
        }
        private void deletePromotion()
        {
            String sql = "delete from promotion where promotionID='" + lstPromotion.SelectedItems[0].SubItems[0].Text + "'";
            OleDbCommand cmd = new OleDbCommand(sql, connection);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Promotion: " + lstPromotion.SelectedItems[0].SubItems[1].Text + " Deleted!");
            showDatainListView(promotionSQL, lstPromotion);
            btnMaintainStudent.Enabled = false;
            btnDeleteStudent.Enabled = false;
            button2.Enabled = false;
            button1.Enabled = false;
        }
        private void deletePromotionMenuItem_Click(object sender, EventArgs e)
        {
            deletePromotion();
        }
        private void addPromotion()
        {
            MaintainPromotion mp = new MaintainPromotion(connection, null, true);
            mp.ShowDialog();
            if(mp.DialogResult == DialogResult.OK)
            {
                MessageBox.Show("Add Promotion successfully!");
                showDatainListView(promotionSQL, lstPromotion);
            }
            button2.Enabled = false;
            button1.Enabled = false;
        }
        private void addPromotionMenuItem_Click(object sender, EventArgs e)
        {
            addPromotion();
        }
        private void maintainPromotion()
        {
            MaintainPromotion mp = new MaintainPromotion(connection, lstPromotion.SelectedItems[0]);
            mp.ShowDialog();
            if (mp.DialogResult == DialogResult.OK)
            {
                MessageBox.Show("Update Promotion successfully!");
                showDatainListView(promotionSQL, lstPromotion);
            }
            button2.Enabled = false;
            button1.Enabled = false;
        }
        private void maintainPromotionMenuItem_Click(object sender, EventArgs e)
        {
            maintainPromotion();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            maintainPromotion();
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            deletePromotion();
        }

        private void PromotionMenuStrip_Opening(object sender, CancelEventArgs e)
        {
            Boolean isSelected = (lstPromotion.SelectedIndices.Count > 0) ? true : false;
            addPromotionMenuItem.Visible = !isSelected;
            maintainPromotionMenuItem.Visible = isSelected;
            deletePromotionMenuItem.Visible = isSelected;
        }

        private void lstPromotion_SelectedIndexChanged(object sender, EventArgs e)
        {
            Boolean isSelected = (lstPromotion.SelectedIndices.Count > 0 ? true : false);
            button2.Enabled = isSelected;
            button1.Enabled = isSelected;
        }

        private void coursePage_Click(object sender, EventArgs e)
        {

        }


    }
}
