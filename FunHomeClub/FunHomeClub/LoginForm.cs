using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Configuration;
using System.Data.OleDb;

namespace FunHomeClub
{
    public partial class LoginForm : Form
    {
        private MainForm frm_main;
        private Employee emp;
        public LoginForm()
        {
            InitializeComponent();
        }


        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
            if (Utility.checkFieldPresense(errLogin, txtUsername, "Username cannot be null"))
            {
                btnLogin.Enabled = false;
            }
            else
            {
                btnLogin.Enabled = true;
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
        }


        private void btnLogin_Click(object sender, EventArgs e)
        {
            string errUsernameIncorrect = "Incorrect Username";
            string errPasswordIncorrect = "Incorrect Password";
            employeeTableAdapter1.Fill(masterDBDataSet1.employee);
            string selectUsernameSql = string.Format("username = \'{0}\'", txtUsername.Text);
            DataRow[] passwordRows = masterDBDataSet1.employee.Select(selectUsernameSql);
            if (passwordRows.Count() <= 0)
            {
                // Username is not found.
                MessageBox.Show(errUsernameIncorrect);
                txtUsername.Focus();
                txtUsername.SelectAll();
            }

            foreach (DataRow row in passwordRows)
            {
                string tmpPassword = row["password"].ToString();
                if (tmpPassword.Equals(txtPassword.Text))
                {
                    string tmpUsername, tmpPosition, tmpEmployeeID;
                    tmpEmployeeID = row["employeeID"].ToString(); 
                    tmpUsername = row["username"].ToString();
                    tmpPosition = row["position"].ToString();
                    emp = new Employee(tmpEmployeeID, tmpUsername, tmpPassword, tmpPosition);
                    errLogin.Clear();
                    this.Hide();
                    frm_main = new MainForm(emp);
                    frm_main.Show();
                }
                else
                {
                    //Password is not matched;
                    MessageBox.Show(errPasswordIncorrect);
                    txtPassword.Focus();
                    txtPassword.SelectAll();
                }
            }
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            if (Utility.checkFieldPresense(errLogin, txtPassword, "Password cannot be null"))
            {
                btnLogin.Enabled = false;
            }
            else
            {
                btnLogin.Enabled = true;
            }
        }
    }
}
