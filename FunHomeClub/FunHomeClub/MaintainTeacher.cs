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
            txtContact.Tag = "contact";
            
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
            if (checkStringValid(txtContact, txtName))
            {
                String gender = (mRadio.Checked ? "m" : "f");
                String sql = "insert into teacher values('" + getNextValidTeacherID() + "','" + txtName.Text + "','" + gender + "','" + txtContact.Text + "')";
                OleDbCommand cmd = new OleDbCommand(sql, connection);
                cmd.ExecuteNonQuery();
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (checkStringValid(txtContact, txtName))
            {
                String gender = (mRadio.Checked ? "m" : "f");
                String sql = "update teacher set name='" + txtName.Text + "',contact='" + txtContact.Text + "',gender='" + gender + "' where teacherID = '" + teacherID + "'";
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
                            switch ((tb.Tag == null ? null : tb.Tag.ToString()))
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
