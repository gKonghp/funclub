using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FunHomeClub
{
    public partial class ChangeMembershipStatusForm : Form
    {
        private string studentID;
        private string status;
        private MembershipForm frmMS;
        string connStr = ConfigurationManager.ConnectionStrings["FunHomeClub.Properties.Settings.masterDBConnectionString"].ToString();
        private OleDbConnection conn;
        public ChangeMembershipStatusForm(MembershipForm frmMS, string studentID, string status)
        {
            InitializeComponent();
            this.studentID = studentID;
            this.status = status;
            conn = new OleDbConnection(connStr);
            this.frmMS = frmMS;
        }

        private void ChangeMembershipStatusForm_Load(object sender, EventArgs e)
        {
            DataTable dtMembership = new DataTable();
            string sql = string.Format("SELECT * FROM Membership");
            OleDbDataAdapter adapter = new OleDbDataAdapter(sql,conn);
            adapter.Fill(dtMembership);
            adapter.Dispose();

            lblCurrentMemberStatus_d.Text = status;

            foreach (DataRow row in dtMembership.Rows)
            {
                ComboBoxItem item = new ComboBoxItem(row["membershipID"].ToString(),Utility.firstChar2UpperCase(row["status"].ToString()));
                cbbNewMemberStatus.Items.Add(item);
                if (Utility.firstChar2UpperCase(row["status"].ToString()).Equals(status))
                {
                    cbbNewMemberStatus.SelectedItem = item;
                }
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            
            if (((ComboBoxItem)cbbNewMemberStatus.SelectedItem).Text.Equals(status))
            {
                string newMemberStatusText = ((ComboBoxItem)cbbNewMemberStatus.SelectedItem).Text;
                MessageBox.Show("The current member status is already " + newMemberStatusText);
            }
            else
            {
                string newMemberStatusValue = ((ComboBoxItem)cbbNewMemberStatus.SelectedItem).Value;
                string sql;
                sql = string.Format("SELECT * From Student WHERE studentID = '{0}'", studentID);
                DataTable dtStudent = new DataTable();
                OleDbDataAdapter adapter = new OleDbDataAdapter(sql, conn);
                adapter.Fill(dtStudent);
                sql = string.Format("UPDATE Student SET membershipID = '{0}' WHERE studentID = '{1}'", newMemberStatusValue, studentID);
                adapter.UpdateCommand = new OleDbCommand(sql, conn);
                dtStudent.Rows[0]["membershipID"] = newMemberStatusValue;
                adapter.Update(dtStudent);
                adapter.Dispose();

                frmMS.FetchMember(studentID);
                this.Dispose();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
