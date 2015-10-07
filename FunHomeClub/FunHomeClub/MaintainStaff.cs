﻿using System;
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
        String currentUsername;
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
            txtUsername.Tag = "ns";
            txtPassword.Tag = "ns";
            if (!isAdd)
            {
                this.employeeID = lstItem.SubItems[0].Text;
                txtUsername.Text = lstItem.SubItems[1].Text;
                txtPassword.Text = lstItem.SubItems[2].Text;
                cboPosition.SelectedIndex = (lstItem.SubItems[3].Text.Equals("m") ? 0 : 1);
                currentUsername = txtUsername.Text;
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
                if(txtUsername.Text != currentUsername)
                {
                    if(!checkUsernameRepeat(txtUsername.Text))
                    {
                        MessageBox.Show("Username are exist already!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
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
                if(!checkUsernameRepeat(txtUsername.Text))
                {
                    MessageBox.Show("Username are exist already!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                String position = cboPosition.Text.Substring(0, 1).ToLower();
                String sql = "insert into employee values('" + getNextValidEmployeeID() + "','" + txtUsername.Text + "','" + txtPassword.Text + "','" + position + "')";
                OleDbCommand cmd = new OleDbCommand(sql, connection);
                cmd.ExecuteNonQuery();
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
        private Boolean checkUsernameRepeat(String username)
        {
            DataTable dt = new DataTable();
            string sql = "SELECT username from employee where username = '" + username + "'";
            dataAdapter = new OleDbDataAdapter(sql, connection);
            dataAdapter.Fill(dt);
            if (dt.Rows.Count != 0){
                return false;
            }
            else
            {
                return true;
            };
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

        private void btnCancel_Click(object sender, EventArgs e)
        {

        }
    }
}
