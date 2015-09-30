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
    public partial class MaintainStaff : Form
    {
        OleDbConnection connection;
        OleDbDataAdapter dataAdapter;
        String employeeID;
        public MaintainStaff()
        {
            InitializeComponent();
        }
        public MaintainStaff(OleDbConnection connection,ListViewItem lstItem,Boolean isAdd=false)
        {
            InitializeComponent();
            btnAdd.Visible = isAdd;
            btnSave.Visible = !isAdd;
            this.connection = connection;
            if (!isAdd)
            {
                this.employeeID = lstItem.SubItems[0].Text;
                txtUsername.Text = lstItem.SubItems[1].Text;
                txtPassword.Text = lstItem.SubItems[2].Text;
                cboPosition.SelectedIndex = (lstItem.SubItems[3].Text.Equals("m") ? 0 : 1);
            }
        }

        private void MaintainStaff_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedToolWindow;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (checkStringValid(txtPassword, txtUsername, cboPosition))
            {
                String position = cboPosition.Text.Substring(0, 1).ToLower();
                String sql = "update employee set username='" + txtUsername.Text + "',[password]='" + txtPassword.Text + "',[position]='" + position + "' where employeeID='" + employeeID + "'";
                OleDbCommand cmd = new OleDbCommand(sql, connection);
                cmd.ExecuteNonQuery();
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
        private String getNextValidEmployeeID()
        {
            DataTable dt = new DataTable();
            string sql = "SELECT employeeID from employee order by employeeID desc";
            dataAdapter = new OleDbDataAdapter(sql, connection);
            dataAdapter.Fill(dt);
            if (Int32.Parse(dt.Rows[0][0].ToString().Substring(2)) != dt.Rows.Count)
                for (int i = 0; i < dt.Rows.Count; i++)
                    if (i + 1 != Int32.Parse(dt.Rows[dt.Rows.Count - i - 1][0].ToString().Substring(2)))
                        return String.Format("em{0:D4}", i + 1).ToString();
            return String.Format("em{0:D4}", Int32.Parse(dt.Rows[0][0].ToString().Substring(2)) + 1).ToString();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (checkStringValid(txtPassword, txtUsername, cboPosition))
            {
                String position = cboPosition.Text.Substring(0, 1).ToLower();
                String sql = "insert into employee values('" + getNextValidEmployeeID() + "','" + txtUsername.Text + "','" + txtPassword.Text + "','" + position + "')";
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
                        if (tb.Text == "")
                        {
                            MessageBox.Show("Please fill in all Textbox first!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return false;
                        }
                        else
                        {
                            if (!Regex.IsMatch(tb.Text, @"^[a-zA-Z0-9]+$") && tb.Multiline == false)
                            {
                                MessageBox.Show("TextBox do not allow any special characters!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return false;
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
