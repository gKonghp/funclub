using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

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
                txtMargin.Enabled = false;
                btnMargin.Text = "Modify";
                new OleDbCommand("Update profitMargin SET percentage = " + txtMargin.Text, connection).ExecuteNonQuery();
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
    }
}
