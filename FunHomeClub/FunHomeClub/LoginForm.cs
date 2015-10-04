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
using System.Text.RegularExpressions;

namespace FunHomeClub
{
    public partial class LoginForm : Form
    {
        private MainForm frmMain;
        private Employee emp;
        private MenuForm frmMenu;
        private OleDbConnection connection;

        public LoginForm()
        {
            InitializeComponent();
            connection = connection = new OleDbConnection(ConfigurationManager.ConnectionStrings["FunHomeClub.Properties.Settings.masterDBConnectionString"].ToString());
            connection.Open();
        }


        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
            Utility.checkFieldPresense(errLogin, txtUsername, "Username cannot be null");
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
        }


        private void btnLogin_Click(object sender, EventArgs e)
        {
            string usernamePasswordPattern = "^([A-Z][a-z][0-9])*$";
            Regex regex = new Regex(usernamePasswordPattern);
            string errUsernameIncorrect = "Incorrect Username";
            string errPasswordIncorrect = "Incorrect Password";
            if (errLogin.GetError(txtUsername).Trim().Length > 0)
            {
                return;
            }
            if (errLogin.GetError(txtPassword).Trim().Length > 0)
            {
                return;
            }
            if(txtUsername.Text.Length <= 0 || txtPassword.Text.Length <= 0)
            {
                MessageBox.Show("Username or Password cannot missing!");
                return;
            }
            if (regex.IsMatch(txtUsername.Text))
            {
                MessageBox.Show("Username cannot contain special character!");
                return;
            }
            if (regex.IsMatch(txtPassword.Text))
            {
                MessageBox.Show("Password cannot contain special character!");
                return;
            }

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
                    frmMain = new MainForm(emp, connection);
                    frmMenu = new MenuForm(emp, connection);
                    Utility.repaintFrameSize(frmMain, frmMenu);
                    frmMenu.MdiParent = frmMain;
                    frmMenu.Dock = DockStyle.Fill;
                    frmMenu.Show();
                    frmMain.Show();

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
            Utility.checkFieldPresense(errLogin, txtPassword, "Password cannot be null");
        }

        private void Reset_Click(object sender, EventArgs e)
        {
            txtPassword.Clear();
            txtUsername.Clear();
            errLogin.SetError(txtUsername, "");
            errLogin.SetError(txtPassword, "");
        }
    }
}
