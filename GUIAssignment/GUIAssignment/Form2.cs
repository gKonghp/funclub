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
    public partial class Form2 : Form
    {
        DataSet ds;
        OleDbDataAdapter oledbAdapter;
        public Form2(DataSet ds, OleDbDataAdapter oledbAdapter)
        {
            InitializeComponent();
            this.ds = ds;
            this.oledbAdapter = oledbAdapter;
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataRow row = ds.Tables["teacher"].NewRow();
            row.SetField("teacherID", textBox1.Text);
            row.SetField("name", textBox2.Text);
            String gender = "";
            if (radioButton1.Checked)
            {
                gender = radioButton1.Text.ToLower();
            }
            if (radioButton2.Checked)
            {
                gender = radioButton2.Text.ToLower();
            }
            row.SetField("gender", gender);
            ds.Tables["teacher"].Rows.Add(row);
            oledbAdapter.Update(ds.Tables["teacher"]);
            MessageBox.Show("You have inserted a new teacher, the detail of following:\n"
                + "\nteacherID: " + textBox1.Text
                + "\nname: " + textBox2.Text
                + "\ngender: " + gender);
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
