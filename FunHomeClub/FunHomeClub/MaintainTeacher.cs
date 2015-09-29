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

namespace FunHomeClub
{
    public partial class MaintainTeacher : Form
    {
        OleDbConnection connection;
        String teacherID;
        OleDbDataAdapter dataAdapter;
        public MaintainTeacher()
        {
            InitializeComponent();
        }
        public MaintainTeacher(OleDbConnection connection,ListViewItem lstItem,Boolean isAdd = false)
        {
            InitializeComponent();
            this.connection = connection;
            if(!isAdd)
            {
                this.teacherID = lstItem.SubItems[0].Text;
                txtName.Text = lstItem.SubItems[1].Text;
                txtContact.Text = lstItem.SubItems[3].Text;
                if (lstItem.SubItems[2].Text.Equals("m"))
                    mRadio.Checked = true;
                else
                    fRadio.Checked = true;
            }
            btnAdd.Visible = isAdd;
            btnSave.Visible = !isAdd;
        }

        private void MaintainTeacher_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedToolWindow;
        }
        private String getNextValidTeacherID()
        {
            DataTable dt = new DataTable();
            string sql = "SELECT teacherID from teacher order by teacherID desc";
            dataAdapter = new OleDbDataAdapter(sql, connection);
            dataAdapter.Fill(dt);
            if (Int32.Parse(dt.Rows[0][0].ToString().Substring(2)) != dt.Rows.Count)
                for (int i = 0; i < dt.Rows.Count; i++)
                    if (i + 1 != Int32.Parse(dt.Rows[dt.Rows.Count - i - 1][0].ToString().Substring(2)))
                        return String.Format("te{0:D4}", i + 1).ToString();
            return String.Format("te{0:D4}", Int32.Parse(dt.Rows[0][0].ToString().Substring(2)) + 1).ToString();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            String gender = (mRadio.Checked ? "m" : "f");
            String sql = "insert into teacher values('" + getNextValidTeacherID() + "','" + txtName.Text + "','" + gender + "','" + txtContact.Text + "')";
            OleDbCommand cmd = new OleDbCommand(sql, connection);
            cmd.ExecuteNonQuery();
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            String gender = (mRadio.Checked ? "m" : "f");
            String sql = "update teacher set name='" + txtName.Text + "',contact='" + txtContact.Text + "',gender='"+gender + "' where teacherID = '" + teacherID + "'";
            OleDbCommand cmd = new OleDbCommand(sql, connection);
            cmd.ExecuteNonQuery();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
