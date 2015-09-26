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
    public partial class Form9 : Form
    {

        DataSet ds;
        OleDbDataAdapter oledbAdapter;
        DataGridView dataGridView4;

        string courseID = "";
        string name = "";
        string quota = "";
        string weekday = "";
        string room = "";
        string startTime = "";
        string endTime = "";
        string teacherRate = "";
        string operatingCharges = "";
        string categoryID = "";
        string teacherID = "";
        string startMonth = "";
        string endMonth = "";

        public Form9(DataSet ds, OleDbDataAdapter oledbAdapter, DataGridView dataGridView4)
        {
            InitializeComponent();
            this.dataGridView4 = dataGridView4;
            this.ds = ds;
            this.oledbAdapter = oledbAdapter;
            this.courseID = dataGridView4.CurrentRow.Cells[0].Value.ToString();
            this.name = dataGridView4.CurrentRow.Cells[1].Value.ToString();
            this.quota = dataGridView4.CurrentRow.Cells[2].Value.ToString();
            this.weekday = dataGridView4.CurrentRow.Cells[3].Value.ToString();
            this.room = dataGridView4.CurrentRow.Cells[4].Value.ToString();
            this.startTime = dataGridView4.CurrentRow.Cells[5].Value.ToString();
            this.endTime = dataGridView4.CurrentRow.Cells[6].Value.ToString();
            this.teacherRate = dataGridView4.CurrentRow.Cells[7].Value.ToString();
            this.operatingCharges = dataGridView4.CurrentRow.Cells[8].Value.ToString();
            this.categoryID = dataGridView4.CurrentRow.Cells[9].Value.ToString();
            this.teacherID = dataGridView4.CurrentRow.Cells[10].Value.ToString();
            this.startMonth = dataGridView4.CurrentRow.Cells[11].Value.ToString();
            this.endMonth = dataGridView4.CurrentRow.Cells[12].Value.ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form9_Load(object sender, EventArgs e)
        {
            textBox1.Text = courseID;
            textBox2.Text = name;
            textBox3.Text = quota;
            textBox4.Text = weekday;
            textBox5.Text = room;
            textBox6.Text = startTime;
            textBox7.Text = endTime;
            textBox8.Text = teacherRate;
            textBox9.Text = operatingCharges;
            textBox10.Text = categoryID;
            textBox11.Text = teacherID;
            textBox12.Text = startMonth;
            textBox13.Text = endMonth;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView4.CurrentRow.Cells[0].Value = textBox1.Text;
            dataGridView4.CurrentRow.Cells[1].Value = textBox2.Text;
            dataGridView4.CurrentRow.Cells[2].Value = textBox3.Text;
            dataGridView4.CurrentRow.Cells[3].Value = textBox4.Text;
            dataGridView4.CurrentRow.Cells[4].Value = textBox5.Text;
            dataGridView4.CurrentRow.Cells[5].Value = textBox6.Text;
            dataGridView4.CurrentRow.Cells[6].Value = textBox7.Text;
            dataGridView4.CurrentRow.Cells[7].Value = textBox8.Text;
            dataGridView4.CurrentRow.Cells[8].Value = textBox9.Text;
            dataGridView4.CurrentRow.Cells[9].Value = textBox10.Text;
            dataGridView4.CurrentRow.Cells[10].Value = textBox11.Text;
            dataGridView4.CurrentRow.Cells[11].Value = textBox12.Text;
            dataGridView4.CurrentRow.Cells[12].Value = textBox13.Text;
            oledbAdapter.Update(ds.Tables["course"]);
            this.Close();
        }
    }
}
