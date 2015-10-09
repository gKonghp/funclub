using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FunHomeClub
{
    public partial class StudentSuccessForm : Form
    {
        public string studentID { get; set; }
        private OleDbConnection connection;
        public StudentSuccessForm(OleDbConnection connection, string studentID, bool success)
        {
            if (!success)
                Dispose();
            InitializeComponent();
            this.studentID = studentID;
            this.connection = connection;
        }

        private void StudentSuccessForm_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            string sql = string.Format("SELECT * FROM Student s, Membership m WHERE m.membershipID = s.membershipID AND studentID = '{0}'",studentID);
            OleDbDataAdapter adpater = new OleDbDataAdapter(sql,connection);
            adpater.Fill(dt);
            adpater.Dispose();

            DataRow row;
            if (dt.Rows.Count > 0)
            {
                row = dt.Rows[0];
                lblStudentID_d.Text = row["studentID"].ToString();
                lblName_d.Text = row["name"].ToString();
                lblContact_d.Text = row["phoneNumber"].ToString();
                lblEmail_d.Text = row["email"].ToString();
                lblEnrollDay_d.Text = row["enrollMonth"].ToString();
                lblMembership_d.Text = Utility.firstChar2UpperCase(row["status"].ToString());
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void StudentSuccessForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }
    }
}
