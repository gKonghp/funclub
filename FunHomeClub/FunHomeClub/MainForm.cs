using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FunHomeClub
{
    public partial class MainForm : Form
    {
        LoginForm loginForm = null;
        string employeePosition = null;
        string username = null;
        public MainForm(LoginForm loginForm, string username, string employeePosition)
        {
            InitializeComponent();
            IsMdiContainer = true;
            this.loginForm = loginForm;
            this.username = username;
            this.employeePosition = employeePosition;
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            loginForm.Close();
        }
    }
}
