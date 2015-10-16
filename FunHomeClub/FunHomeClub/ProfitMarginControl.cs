using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Text.RegularExpressions;

namespace FunHomeClub
{
    public partial class ProfitMarginControl : UserControl
    {
        OleDbConnection connection;
        OleDbDataAdapter dataAdapter;
        DataTable dt;

        public ProfitMarginControl(OleDbConnection connection)
        {
            InitializeComponent();
            this.connection = connection;
            ShowProfitMargin();
        }

        private void btnMargin_Click(object sender, EventArgs e)
        {
            if (btnMargin.Text.Equals("Modify"))
            {
                txtMargin.Enabled = true;
                btnMargin.Text = "Save";
            }
            else
            {
                if (Regex.IsMatch(txtMargin.Text, @"^([0-9]|[.][0-9])*$"))
                {
                    txtMargin.Enabled = false;
                    btnMargin.Text = "Modify";
                    new OleDbCommand("Update profitMargin SET percentage = " + txtMargin.Text, connection).ExecuteNonQuery();
                }
                else
                {
                    errorProvider1.SetError(txtMargin, "Margin only allow number input!");
                }
            }
        }
        private void ShowProfitMargin()
        {
            String sql = "SELECT * FROM profitMargin Where profitMarginID = 'pm0001'";
            dt = new DataTable();
            dataAdapter = new OleDbDataAdapter(sql, connection);
            dataAdapter.Fill(dt);
            txtMargin.Text = dt.Rows[0]["percentage"].ToString();
        }

        private void ProfitMarginControl_Load(object sender, EventArgs e)
        {
            
        }

        private void txtMargin_TextChanged(object sender, EventArgs e)
        {
            if (Regex.IsMatch(txtMargin.Text, @"^([0-9]|[.][0-9])*$"))
                errorProvider1.SetError(txtMargin, "");
            else
                errorProvider1.SetError(txtMargin, "Margin only allow number input!");
        }

        private void txtMargin_EnabledChanged(object sender, EventArgs e)
        {
            if (txtMargin.Enabled == false)
            {
                txtMargin.BackColor = System.Drawing.Color.Silver;
            }
            else
            {
                txtMargin.BackColor = System.Drawing.SystemColors.ControlLight;
            }
        }
    }
}
