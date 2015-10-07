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
    public partial class MaintainPromotion : Form
    {
        OleDbConnection connection;
        OleDbDataAdapter dataAdapter;
        String promotionID;
        public MaintainPromotion()
        {
            InitializeComponent();
        }
        public MaintainPromotion(OleDbConnection connection,ListViewItem lstItem,Boolean isAdd = false)
        {
            InitializeComponent();
            this.connection = connection;
            if(!isAdd)
            {
                txtName.Text = lstItem.SubItems[1].Text;
                this.promotionID = lstItem.SubItems[0].Text;
                numDiscount.Value = decimal.Parse(lstItem.SubItems[3].Text);
                String[] startTime = lstItem.SubItems[4].Text.Split('/');
                String[] endTime = lstItem.SubItems[5].Text.Split('/');
                txtDescription.Text = lstItem.SubItems[2].Text;
                dtpStartTime.Value = new DateTime(Int32.Parse(startTime[2]), Int32.Parse(startTime[1]), Int32.Parse(startTime[0]));
                dtpEndTime.Value = new DateTime(Int32.Parse(endTime[2]), Int32.Parse(endTime[1]), Int32.Parse(endTime[0]));
            }
            btnAdd.Visible = isAdd;
            btnSave.Visible = !isAdd;
        }

        private void MaintainPromotion_Load(object sender, EventArgs e)
        {

        }
        private String getNextValidPromotionID()
        {
            DataTable dt = new DataTable();
            string sql = "SELECT promotionID from promotion order by promotionID desc";
            dataAdapter = new OleDbDataAdapter(sql, connection);
            dataAdapter.Fill(dt);
            if (Int32.Parse(dt.Rows[0][0].ToString().Substring(2)) != dt.Rows.Count)
                for (int i = 0; i < dt.Rows.Count; i++)
                    if (i + 1 != Int32.Parse(dt.Rows[dt.Rows.Count - i - 1][0].ToString().Substring(2)))
                        return String.Format("pr{0:D4}", i + 1).ToString();
            return String.Format("pr{0:D4}", Int32.Parse(dt.Rows[0][0].ToString().Substring(2)) + 1).ToString();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (checkStringValid(txtName, numDiscount, txtDescription))
            {
                String sql = "insert into promotion values('" + getNextValidPromotionID() + "','" + txtName.Text + "','" + txtDescription.Text + "','" + numDiscount.Value.ToString() + "','" + dtpStartTime.Value.ToString("dd/MM/yyyy") + "','" + dtpEndTime.Value.ToString("dd/MM/yyyy") + "')";
                OleDbCommand cmd = new OleDbCommand(sql, connection);
                cmd.ExecuteNonQuery();
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (checkStringValid(txtName, numDiscount, txtDescription))
            {
                String sql = "update promotion set name='" + txtName.Text + "',description='" + txtDescription.Text + "',additionalDiscount='" + numDiscount.Value.ToString() + "',startTime='" + dtpStartTime.Value.ToString("dd/MM/yyyy") + "',endTime='" + dtpEndTime.Value.ToString("dd/MM/yyyy") + "' where promotionID = '" + this.promotionID + "'";
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
            if (dtpStartTime.Value.CompareTo(dtpEndTime.Value)> 0)
            {
                MessageBox.Show("Start time must smaller than end time!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void txtDescription_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
