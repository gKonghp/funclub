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
    public partial class Form3 : Form
    {
        DataSet ds;
        OleDbDataAdapter oledbAdapter;
        String teacherID = "";
        String name = "";
        String gender = "";
        DataGridView dataGridView1;

        public Form3(DataSet ds, OleDbDataAdapter oledbAdapter, DataGridView dataGridView1)
        {
            InitializeComponent();
            this.dataGridView1 = dataGridView1;
            this.ds = ds;
            this.oledbAdapter = oledbAdapter;
            this.teacherID = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            this.name = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            this.gender = dataGridView1.CurrentRow.Cells[2].Value.ToString();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            
            textBox1.Text = teacherID;
            textBox2.Text = name;
            if (gender.Equals("m"))
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
            dataGridView1.CurrentRow.Cells[0].Value = textBox1.Text;
            dataGridView1.CurrentRow.Cells[1].Value = textBox2.Text;
            if (radioButton1.Checked)
            {
                dataGridView1.CurrentRow.Cells[2].Value = radioButton1.Text.ToLower();
            }
            if (radioButton2.Checked)
            {
                dataGridView1.CurrentRow.Cells[2].Value = radioButton2.Text.ToLower();
            }
            oledbAdapter.Update(ds.Tables["teacher"]);
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
