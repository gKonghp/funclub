using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Text.RegularExpressions;

namespace FunHomeClub
{
    public partial class MaintainCategory : Form
    {
        OleDbConnection connection;
        OleDbDataAdapter dataAdapter;
        String categoryID;
        String currentName;
        public MaintainCategory()
        {
            InitializeComponent();
        }
        public MaintainCategory(OleDbConnection connection, ListViewItem lstItem, Boolean isAdd = false)
        {
            InitializeComponent();
            this.connection = connection;
            btnAdd.Visible = lstItem == null ? true : false;
            btnSave.Visible = !btnAdd.Visible;
            this.categoryID = lstItem == null ? "" : lstItem.SubItems[0].Text;
            txtCategoryName.Text = lstItem == null ? "" : lstItem.SubItems[1].Text;
            numericMetrrialCost.Value = lstItem == null ? 100 : Int32.Parse(lstItem.SubItems[2].Text);
            currentName = txtCategoryName.Text;
        }
        private Boolean checkNameRepeat(String name)
        {
            DataTable dt = new DataTable();
            string sql = "SELECT name from courseCategory where name = '" + name + "'";
            dataAdapter = new OleDbDataAdapter(sql, connection);
            dataAdapter.Fill(dt);
            if (dt.Rows.Count != 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        private void MaintainCategory_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedToolWindow;
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
                            errorProvider1.SetError(tb, "Please fill in all Textbox first!");
                            //MessageBox.Show("Please fill in all Textbox first!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            switch ((tb.Tag == null ? null : tb.Tag.ToString()))
                            {
                                case null:
                                    if (!Regex.IsMatch(tb.Text, @"^[\sa-zA-Z0-9]+$") && tb.Multiline == false)
                                    {
                                        errorProvider1.SetError(tb, tb.Name.Replace("txt", "") + " do not allow any special characters!");
                                        //MessageBox.Show(tb.Name.Replace("txt","") + " do not allow any special characters!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                    else
                                        errorProvider1.SetError(tb, "");
                                    break;
                                case "ns":
                                    if (!Regex.IsMatch(tb.Text, @"^[a-zA-Z0-9]+$"))
                                    {
                                        errorProvider1.SetError(tb, tb.Name.Replace("txt", "") + " do not allow space characters!");

                                        //MessageBox.Show(tb.Name.Replace("txt", "") + " do not allow space characters!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                    else
                                        errorProvider1.SetError(tb, "");
                                    break;
                                case "email":
                                    if (!Regex.IsMatch(tb.Text, @"^\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$"))
                                    {
                                        errorProvider1.SetError(tb, "Not a valid email format!");

                                        //MessageBox.Show("Not a valid email format!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                    else
                                        errorProvider1.SetError(tb, "");
                                    break;
                                case "dot":
                                    if (!Regex.IsMatch(tb.Text, @"^([0-9]|[.][0-9])*$"))
                                    {
                                        errorProvider1.SetError(tb, "Not a valid number");
                                    }
                                    else
                                    {
                                        errorProvider1.SetError(tb, "");
                                    }
                                    break;
                                case "contact":
                                    if (!Regex.IsMatch(tb.Text, @"^([2-3]|[5-6]|[9])[0-9]{7}$"))
                                    {
                                        errorProvider1.SetError(tb, "Not a valid phone format!");
                                    }
                                    else
                                    {
                                        errorProvider1.SetError(tb, "");
                                    }
                                    break;
                            }
                        }
                        break;
                    case "ComboBox":
                        ComboBox cb = (ComboBox)para[i];
                        if (cb.SelectedItem == null)
                        {
                            errorProvider1.SetError(cb, "Please choose all combobox first!");
                            //MessageBox.Show("Please choose all combobox first!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        break;
                    case "NumericUpDown":
                        NumericUpDown numeric = (NumericUpDown)para[i];
                        if (numeric.Value == 0)
                        {
                            errorProvider1.SetError(numeric, "The number cannot be zero!");
                            // MessageBox.Show("The number cannot be zero!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        break;
                }
            }
            Boolean v = isValid();
            btnAdd.Enabled = btnSave.Enabled = v;
            return v;
        }
        private bool isValid()
        {
            foreach (Control c in this.Controls)
            {
                if (!(errorProvider1.GetError(c).Trim() == ""))
                {
                    return false;
                }
            }
            return true;
        }
        private String getNextValidCategoryID()
        {
            DataTable dt = new DataTable();
            string sql = "SELECT categoryID from courseCategory order by categoryID desc";
            dataAdapter = new OleDbDataAdapter(sql, connection);
            dataAdapter.Fill(dt);
            if (Int32.Parse(dt.Rows[0][0].ToString().Substring(2)) != dt.Rows.Count)
                for (int i = 0; i < dt.Rows.Count; i++)
                    if (i + 1 != Int32.Parse(dt.Rows[dt.Rows.Count - i - 1][0].ToString().Substring(2)))
                        return String.Format("ca{0:D4}", i + 1).ToString();
            return String.Format("ca{0:D4}", Int32.Parse(dt.Rows[0][0].ToString().Substring(2)) + 1).ToString();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (checkStringValid(txtCategoryName, numericMetrrialCost))
            {
                if (txtCategoryName.Text != currentName)
                {
                    if (!checkNameRepeat(txtCategoryName.Text))
                    {
                        MessageBox.Show("Category name are exist already!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                String saveSQL = "update courseCategory set name='" + txtCategoryName.Text + "',materialCost='" + numericMetrrialCost.Value.ToString() + "' where categoryID='" + this.categoryID + "'";
                OleDbCommand cmd = new OleDbCommand(saveSQL, connection);
                cmd.ExecuteNonQuery();
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            Button btn = (btnAdd.Visible == true) ? btnAdd : btnSave;
            switch (keyData)
            {
                case Keys.Enter:
                    btn.PerformClick();
                    break;
                case Keys.Escape:
                    button2.PerformClick();
                    break;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (checkStringValid(txtCategoryName, numericMetrrialCost))
            {
                if(!checkNameRepeat(txtCategoryName.Text))
                {
                    MessageBox.Show("Category Name are exist already!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                String addSQL = "insert into courseCategory values('" + getNextValidCategoryID() + "','" + txtCategoryName.Text + "','" + numericMetrrialCost.Value.ToString() + "')";
                OleDbCommand cmd = new OleDbCommand(addSQL, connection);
                cmd.ExecuteNonQuery();
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void txtCategoryName_TextChanged(object sender, EventArgs e)
        {
            checkStringValid(txtCategoryName);
        }

        private void numericMetrrialCost_ValueChanged(object sender, EventArgs e)
        {
            checkStringValid(numericMetrrialCost);
        }
    }
}
