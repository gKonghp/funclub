using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace FunHomeClub
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtUsername.Text = "";
            txtPassword.Text = "";
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=masterDB.accdb";
            string sql = "SELECT * FROM employee WHERE username = '" + txtUsername.Text + "'";
            OleDbConnection connection = new OleDbConnection(connectionString);
            OleDbDataAdapter dataAdapter = new OleDbDataAdapter(sql, connectionString);
            DataTable dt = new DataTable();

            connection.Open();
            dataAdapter.Fill(dt);
            connection.Close();

            if (dt.Rows.Count != 1)
                MessageBox.Show("Username Incorrect!");
            else if (dt.Rows[0].ItemArray[2].Equals(txtPassword.Text))
            {
                MessageBox.Show("Login Successful!");
                MainForm loginForm = new MainForm(this, dt.Rows[0].ItemArray[2].ToString(), dt.Rows[0].ItemArray[3].ToString());
                loginForm.Show();
                this.Hide();
            }
            else
                MessageBox.Show("Password Incorrect!");

            dataAdapter.Dispose();
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
            if (txtUsername.TextLength > 0 && txtPassword.TextLength > 0)
                btnLogin.Enabled = true;
            else
                btnLogin.Enabled = false;
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            if (txtUsername.TextLength > 0 && txtPassword.TextLength > 0)
                btnLogin.Enabled = true;
            else
                btnLogin.Enabled = false;
        }
    }
}
