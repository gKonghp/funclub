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
    public partial class Form8 : Form
    {

        DataSet ds;
        OleDbDataAdapter oledbAdapter;
        DataGridView dataGridView3;

        string employeeID = "";
        string username = "";
        string password = "";
        string position = "";

        public Form8(DataSet ds, OleDbDataAdapter oledbAdapter, DataGridView dataGridView3)
        {
            InitializeComponent();
            this.dataGridView3 = dataGridView3;
            this.ds = ds;
            this.oledbAdapter = oledbAdapter;
            this.employeeID = dataGridView3.CurrentRow.Cells[0].Value.ToString();
            this.username = dataGridView3.CurrentRow.Cells[1].Value.ToString();
            this.password = dataGridView3.CurrentRow.Cells[2].Value.ToString();
            this.position = dataGridView3.CurrentRow.Cells[3].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form8_Load(object sender, EventArgs e)
        {
            textBox1.Text = employeeID;
            textBox2.Text = username;
            textBox3.Text = password;
            if (position.Equals("s"))
            {
                radioButton1.Checked = true;
            }
            else
            {
                radioButton2.Checked = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView3.CurrentRow.Cells[0].Value = textBox1.Text;
            dataGridView3.CurrentRow.Cells[1].Value = textBox2.Text;
            dataGridView3.CurrentRow.Cells[2].Value = textBox3.Text;
            if (radioButton1.Checked)
            {
                dataGridView3.CurrentRow.Cells[3].Value = "s";
            }
            if (radioButton2.Checked)
            {
                dataGridView3.CurrentRow.Cells[3].Value = "m";
            }
            oledbAdapter.Update(ds.Tables["employee"]);
            this.Close();
        }
    }
}
