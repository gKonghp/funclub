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

namespace FunHomeClub
{
    public partial class MaintainStudent : Form
    {
        OleDbConnection connection;
        OleDbDataAdapter dataAdapter;
        public String studentID{get; set;}
        public MaintainStudent()
        {
            InitializeComponent();
        }

        public MaintainStudent(OleDbConnection connection,ListViewItem lstItem,Boolean isAdd=false)
        {
            InitializeComponent();
            this.connection = connection;
            txtContact.Tag = "ns";
            txtEmail.Tag = "email";
            txtContact.Tag = "contact";
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
            if (checkStringValid(txtContact, txtEmail, txtName, cboMembership))
            {
                String sql = "update student set name='" + txtName.Text + "',phoneNumber='" + txtContact.Text + "',email='" + txtEmail.Text + "',membershipID='" + getMembershipIDByName(cboMembership.Text) + "' where studentID='" + this.studentID + "'";
                OleDbCommand cmd = new OleDbCommand(sql, connection);
                cmd.ExecuteNonQuery();
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
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
            if (checkStringValid(txtContact, txtEmail, txtName, cboMembership))
            {
                String sql = "insert into student values('" + getNextValidStudentID() + "','" + getMembershipIDByName(cboMembership.Text) + "','" + txtContact.Text + "','" + txtEmail.Text + "','" + lblEnrollDay.Text.Split(' ')[0] + "','" + txtName.Text + "')";
                OleDbCommand cmd = new OleDbCommand(sql, connection);
                cmd.ExecuteNonQuery();
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
                            MessageBox.Show("Please fill in all Textbox first!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return false;
                        }
                        else
                        {
                            switch((tb.Tag == null?null:tb.Tag.ToString()))
                            {
                                case null:
                                    if (!Regex.IsMatch(tb.Text, @"^[\sa-zA-Z0-9]+$") && tb.Multiline == false)
                                    {
                                        MessageBox.Show(tb.Name.Replace("txt","") + " do not allow any special characters!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        return false;
                                    }
                                    break;
                                case "ns":
                                    if (!Regex.IsMatch(tb.Text, @"^[a-zA-Z0-9]+$"))
                                    {
                                        MessageBox.Show(tb.Name.Replace("txt","") + " do not allow space characters!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        return false;
                                    }
                                    break;
                                case "email":
                                    if (!Regex.IsMatch(tb.Text, @"^\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$"))
                                    {
                                        MessageBox.Show("Not a valid email format!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        return false;
                                    }
                                    break;
                                case "contact":
                                    if (!Regex.IsMatch(tb.Text, @"^([2-3]|[5-6]|[9])[0-9]{7}$"))
                                    {
                                        MessageBox.Show("Not a valid phone format!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        return false;
                                    }
                                    break;
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
            return true;
        }
    }
}
