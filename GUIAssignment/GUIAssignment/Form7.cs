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
    public partial class Form7 : Form
    {
        DataSet ds;
        OleDbDataAdapter oledbAdapter;
        DataGridView dataGridView2;
        string studentID = "";
        string membershipID = "";
        string phoneNumber = "";
        string email = "";
        string enrollMonth = "";
        string name = "";
        public Form7(DataSet ds, OleDbDataAdapter oledbAdapter, DataGridView dataGridView2)
        {
            InitializeComponent();
            this.dataGridView2 = dataGridView2;
            this.ds = ds;
            this.oledbAdapter = oledbAdapter;
            this.studentID = dataGridView2.CurrentRow.Cells[0].Value.ToString();
            this.membershipID = dataGridView2.CurrentRow.Cells[1].Value.ToString();
            this.phoneNumber = dataGridView2.CurrentRow.Cells[2].Value.ToString();
            this.email = dataGridView2.CurrentRow.Cells[3].Value.ToString();
            this.enrollMonth = dataGridView2.CurrentRow.Cells[4].Value.ToString();
            this.name = dataGridView2.CurrentRow.Cells[5].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            textBox1.Text = studentID;
            textBox2.Text = name;
            textBox3.Text = membershipID;
            textBox4.Text = phoneNumber;
            textBox5.Text = email;
            dateTimePicker1.Text = enrollMonth;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView2.CurrentRow.Cells[0].Value = textBox1.Text;
            dataGridView2.CurrentRow.Cells[1].Value = textBox3.Text;
            dataGridView2.CurrentRow.Cells[2].Value = textBox4.Text;
            dataGridView2.CurrentRow.Cells[3].Value = textBox5.Text;
            dataGridView2.CurrentRow.Cells[4].Value = dateTimePicker1.Text;
            dataGridView2.CurrentRow.Cells[5].Value = textBox2.Text;
            oledbAdapter.Update(ds.Tables["student"]);
            this.Close();
        }
    }
}
