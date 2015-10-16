using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace FunHomeClub
{
    public partial class MembershipForm : Form
    {
        string connStr = ConfigurationManager.ConnectionStrings["FunHomeClub.Properties.Settings.masterDBConnectionString"].ToString();
        private OleDbConnection conn;
        private MembershipControl mc;
        private DataTable dTStudent;
        private int currentStdRowIdx = 0;
        private int StdRowCount = 0;
        private ChangeMembershipStatusForm frmChMS;
        private CourseRegHistoryForm frmCourseRegHistory;
        public MembershipForm()
        {
            InitializeComponent();
            conn = new OleDbConnection(connStr);
        }

        private void membershipConfig_Click(object sender, EventArgs e)
        {

        }

        private void MembershipFrom_Load(object sender, EventArgs e)
        {
            mc = new MembershipControl(conn);
            membershipConfig.Controls.Add(mc);
            //panel2.Controls.Add(mc);
            //mc.Dock = DockStyle.Fill;
            //mc.Show();



            dTStudent = new DataTable();
            string sql = string.Format("SELECT studentID FROM Student");
            OleDbDataAdapter adapter = new OleDbDataAdapter(sql, conn);
            adapter.Fill(dTStudent);
            adapter.Dispose();
            currentStdRowIdx = 0;
            StdRowCount = dTStudent.Rows.Count;
            lblRowCount.Text = "1/" + StdRowCount;

            lblCumSpend_d.Text = "--";
            lblEmailAddress_d.Text = "--";
            lblEnrollDate_d.Text = "--";
            lblMemberStatus_d.Text = "--";
            lblName_d.Text = "--";
            lblPhone_d.Text = "--";

            FetchMember(dTStudent.Rows[0]["studentID"].ToString()); //default get the first Student
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(txtStudentID.Text, @"^[a-zA-Z0-9]+$"))
            {
                //txtStudentID.BackColor = Color.IndianRed;
                MessageBox.Show("StudentID is Alphanumeric.");
                txtStudentID.Focus();
                txtStudentID.SelectAll();
                return;
            }
            FetchMember(txtStudentID.Text);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtStudentID.Clear();
            /*
            lblCumSpend_d.Text = "--";
            lblEmailAddress_d.Text = "--";
            lblEnrollDate_d.Text = "--";
            lblMemberStatus_d.Text = "--";
            lblName_d.Text = "--";
            lblPhone_d.Text = "--";
            */
        }

        public void FetchMember(string studentID)
        {

            DataTable dTMember = new DataTable();
            string sql = string.Format("SELECT * FROM Student s, Membership m WHERE s.membershipID = m.membershipID AND studentID = '{0}'", studentID.Trim());
            OleDbDataAdapter adapter = new OleDbDataAdapter(sql, conn);
            adapter.Fill(dTMember);
            adapter.Dispose();
            if (studentID.Trim().Length <= 0)
            {
                MessageBox.Show("Student ID cannot be empty.");
                return;
            }
            if (dTMember.Rows.Count > 0)
            {
                DataRow mRow = dTMember.Rows[0];
                lblStudentID_d.Text = mRow["studentID"].ToString();
                lblName_d.Text = mRow["name"].ToString();
                lblMemberStatus_d.Text = Utility.firstChar2UpperCase(mRow["status"].ToString());
                lblPhone_d.Text = mRow["phoneNumber"].ToString();
                lblEnrollDate_d.Text = string.Format("{0:d/M/yyyy}", Convert.ToDateTime(mRow["enrollMonth"].ToString()));
                lblEmailAddress_d.Text = mRow["email"].ToString();
                DataTable dTCourseReg = new DataTable();
                sql = string.Format("SELECT * FROM StudentCourse sc, Invoice i WHERE sc.invoiceID = i.invoiceID AND studentID = '{0}'", studentID.Trim());
                adapter = new OleDbDataAdapter(sql, conn);
                adapter.Fill(dTCourseReg);
                adapter.Dispose();

                double cummulativeSpend = 0;
                foreach (DataRow cRow in dTCourseReg.Rows)
                {
                    cummulativeSpend += Convert.ToDouble(cRow["totalCost"].ToString());
                }
                lblCumSpend_d.Text = "$ " + cummulativeSpend.ToString();

                currentStdRowIdx = FoundStudentInIndex(studentID);//set the current row idx
                lblRowCount.Text = string.Format("{0}/{1}", currentStdRowIdx+1, StdRowCount);
            }
            else
            {
                MessageBox.Show("The member is not found");
            }

            if (currentStdRowIdx < StdRowCount - 1)
            {
                btnNext.Enabled = true;
            }
            else
            {
                btnNext.Enabled = false;
            }

            if (currentStdRowIdx > 0)
            {
                btnPrev.Enabled = true;
            }
            else
            {
                btnPrev.Enabled = false;
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            string stdID;
            if (currentStdRowIdx < StdRowCount - 1)
            {
                stdID = dTStudent.Rows[++currentStdRowIdx]["studentID"].ToString();
                FetchMember(stdID);
              
            }

        }

        private int FoundStudentInIndex(string studentID)
        {
            int stdIdx = 0;
            int count = dTStudent.Rows.Count;
            for (int i = 0; i < count; i++)
            {
                if (studentID.Equals(dTStudent.Rows[i]["studentID"].ToString()))
                {
                    stdIdx = i;
                    break;
                }
            }
            return stdIdx; 
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            string stdID;
            if (currentStdRowIdx > 0)
            {
                stdID = dTStudent.Rows[--currentStdRowIdx]["studentID"].ToString();
                FetchMember(stdID);
            }
          
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmChMS = new ChangeMembershipStatusForm(this,lblStudentID_d.Text, lblMemberStatus_d.Text);
            frmChMS.ShowDialog();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmCourseRegHistory = new CourseRegHistoryForm(lblStudentID_d.Text);
            frmCourseRegHistory.ShowDialog();
        }

        private void txtStudentID_TextChanged(object sender, EventArgs e)
        {
            if (txtStudentID.Text.Trim().Length <= 0)
                btnEnter.Enabled = false;
            else
                btnEnter.Enabled = true;
        }
    }
}
