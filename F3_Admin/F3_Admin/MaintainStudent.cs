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

namespace F3_Admin
{
    public partial class MaintainStudent : Form
    {
        OleDbConnection connection;
        OleDbDataAdapter dataAdapter;
        String studentID;
        public MaintainStudent()
        {
            InitializeComponent();
        }

        public MaintainStudent(OleDbConnection connection,ListViewItem lstItem,Boolean isAdd=false)
        {
            InitializeComponent();
            this.connection = connection;
            if(!isAdd)
            {
                this.studentID = lstItem.SubItems[0].Text;
                txtName.Text = lstItem.SubItems[5].Text;
                txtEmail.Text = lstItem.SubItems[3].Text;
                txtContact.Text = lstItem.SubItems[2].Text;
                lblEnrollDay.Text = lstItem.SubItems[4].Text;
            }
            lblEnrollDay.Text = (isAdd ? DateTime.Today.ToString("dd/MM/yyyy") : lstItem.SubItems[4].Text.Split(' ')[0]);
            fillMembership((isAdd?"none":lstItem.SubItems[1].Text.Split(' ')[0]));
            btnAdd.Visible = isAdd;
            btnSave.Visible = !isAdd;
        }
        private String getMembershipByID(String MemberShipID)
        {
            DataTable dt = new DataTable();
            string sql = "SELECT status from membership where membershipID = '" + MemberShipID + "'";
            dataAdapter = new OleDbDataAdapter(sql, connection);
            dataAdapter.Fill(dt);
            return dt.Rows[0][0].ToString();
        }
        private String getMembershipIDByName(String MembershipName)
        {
            DataTable dt = new DataTable();
            string sql = "SELECT membershipID from membership where status = '" + MembershipName + "'";
            dataAdapter = new OleDbDataAdapter(sql, connection);
            dataAdapter.Fill(dt);
            return dt.Rows[0][0].ToString();
        }
        private void fillMembership(String mShipID="none")
        {
            DataTable dt = new DataTable();
            string sql = "SELECT * from membership";
            dataAdapter = new OleDbDataAdapter(sql, connection);
            dataAdapter.Fill(dt);
            for (int i = 0; i < dt.Rows.Count;i++ )
            {
                cboMembership.Items.Add(dt.Rows[i][1].ToString());
            }
            if(!mShipID.Equals("none"))
            {
                cboMembership.SelectedIndex = cboMembership.Items.IndexOf(getMembershipByID(mShipID));
            }
        }
        private void MaintainStudent_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedToolWindow;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String sql = "update student set name='" + txtName.Text + "',phoneNumber='" + txtContact.Text + "',email='" + txtEmail.Text + "',membershipID='" + getMembershipIDByName(cboMembership.Text) + "' where studentID='" + this.studentID + "'";
            OleDbCommand cmd = new OleDbCommand(sql, connection);
            cmd.ExecuteNonQuery();
            this.Close();
        }
        private String getNextValidStudentID()
        {
            DataTable dt = new DataTable();
            string sql = "SELECT studentID from student order by studentID desc";
            dataAdapter = new OleDbDataAdapter(sql, connection);
            dataAdapter.Fill(dt);
            if (Int32.Parse(dt.Rows[0][0].ToString().Substring(2)) != dt.Rows.Count)
                for (int i = 0; i < dt.Rows.Count; i++)
                    if (i + 1 != Int32.Parse(dt.Rows[dt.Rows.Count - i - 1][0].ToString().Substring(2)))
                        return String.Format("st{0:D4}", i + 1).ToString();
            return String.Format("st{0:D4}", Int32.Parse(dt.Rows[0][0].ToString().Substring(2)) + 1).ToString();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            String sql = "insert into student values('" + getNextValidStudentID() + "','" + getMembershipIDByName(cboMembership.Text) + "','" + txtContact.Text + "','" + txtEmail.Text + "','" + lblEnrollDay.Text.Split(' ')[0] + "','" + txtName.Text + "')";
            OleDbCommand cmd = new OleDbCommand(sql, connection);
            cmd.ExecuteNonQuery();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
        }
    }
}
