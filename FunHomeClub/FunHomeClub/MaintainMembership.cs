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
    public partial class MaintainMembership : Form
    {
        OleDbConnection connection;
        OleDbDataAdapter dataAdapter;
        DataTable dt;
        string msID;
        string sql;
        public MaintainMembership(String buttonText,OleDbConnection connection)
        {
            InitializeComponent();
            btnSave.Text = buttonText;
            this.connection = connection;
            sql = "SELECT * FROM membership";
            txtDiscount.Tag = "dot";
            initProgram();
        }
        public MaintainMembership(String buttonText, string msID, OleDbConnection connection)
        {
            InitializeComponent();
            btnSave.Text = buttonText;
            this.connection = connection;
            this.msID = msID;
            sql = "SELECT * FROM membership WHERE membershipID = '" + msID + "'";
            initProgram();
            txtDiscount.Tag = "dot";
            txtStatus.Text = dt.Rows[0]["status"].ToString();
            txtDiscount.Text = dt.Rows[0]["discount"].ToString();
        }
        public void initProgram()
        {
            dataAdapter = new OleDbDataAdapter(sql, connection);
            dt = new DataTable();
            dataAdapter.Fill(dt);
        }
        private String getNextValidMembershipID()
        {
            DataTable dt = new DataTable();
            string sql = "SELECT membershipID from membership order by membershipID desc";
            dataAdapter = new OleDbDataAdapter(sql, connection);
            dataAdapter.Fill(dt);
            if (Int32.Parse(dt.Rows[0][0].ToString().Substring(2)) != dt.Rows.Count)
                for (int i = 0; i < dt.Rows.Count; i++)
                    if (i + 1 != Int32.Parse(dt.Rows[dt.Rows.Count - i - 1][0].ToString().Substring(2)))
                        return String.Format("ms{0:D4}", i + 1).ToString();
            return String.Format("ms{0:D4}", Int32.Parse(dt.Rows[0][0].ToString().Substring(2)) + 1).ToString();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (checkStringValid(txtStatus, txtDiscount))
            {
                if (btnSave.Text.Equals("Add"))
                {
                    String id = getNextValidMembershipID();
                    if (id.Equals("ERROR"))
                    {
                        MessageBox.Show("Do not have any Available ID!");
                    }
                    else
                    {
                        new OleDbCommand("Insert into membership values('" + id + "', '" + txtStatus.Text + "','" + txtDiscount.Text + "')", connection).ExecuteNonQuery();
                        MessageBox.Show("Adding membership successul!");
                        this.DialogResult = DialogResult.OK;
                    }
                }
                else
                {
                    new OleDbCommand("Update membership set status = '" + txtStatus.Text + "', discount = " + txtDiscount.Text + " WHERE membershipID = '" + msID + "'", connection).ExecuteNonQuery();
                    MessageBox.Show("Changing successul!");
                    this.DialogResult = DialogResult.OK;
                }
                this.Close();
            }
        }

        private void MaintainMembership_Load(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
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
                                case "dot":
                                    if(!Regex.IsMatch(tb.Text, @"^[0-9]*[.]?[0-9]*$"))
                                    {
                                        MessageBox.Show("Not a valid float number!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
