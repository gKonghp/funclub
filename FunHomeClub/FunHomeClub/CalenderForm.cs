using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FunHomeClub
{
    public partial class CalenderForm : Form
    {
        public CalenderForm(OleDbConnection connection)
        {
            InitializeComponent();
            panel1.Controls.Clear();
            CalendarControl cc = new CalendarControl(connection);
            panel1.Controls.Add(cc);
            cc.Dock = DockStyle.Fill;
        }
    }
}
