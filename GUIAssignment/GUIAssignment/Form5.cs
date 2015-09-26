using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUIAssignment
{
    public partial class Form5 : Form
    {
        DataSet ds;
        OleDbDataAdapter oledbAdapter;
        public Form5(DataSet ds, OleDbDataAdapter oledbAdapter)
        {
            InitializeComponent();
            this.ds = ds;
            this.oledbAdapter = oledbAdapter;
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataRow row = ds.Tables["employee"].NewRow();
            row.SetField("employeeID", textBox1.Text);
            row.SetField("username", textBox2.Text);
            row.SetField("password", textBox3.Text);
            string position = "";
            if (radioButton1.Checked)
            {
                position = "s";
            }
            if (radioButton2.Checked)
            {
                position = "m";
            }
            row.SetField("position", position);
            ds.Tables["employee"].Rows.Add(row);
            oledbAdapter.Update(ds.Tables["employee"]);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
