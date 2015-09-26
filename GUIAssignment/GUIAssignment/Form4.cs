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
    public partial class Form4 : Form
    {
        DataSet ds;
        OleDbDataAdapter oledbAdapter;
        public Form4(DataSet ds, OleDbDataAdapter oledbAdapter)
        {
            InitializeComponent();
            this.ds = ds;
            this.oledbAdapter = oledbAdapter;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataRow row = ds.Tables["student"].NewRow();
            row.SetField("studentID", textBox1.Text);
            row.SetField("membershipID", textBox2.Text);
            row.SetField("phoneNumber", textBox3.Text);
            row.SetField("email", textBox4.Text);
            row.SetField("enrollMonth", dateTimePicker1.Text);
            row.SetField("name", textBox5.Text);
            ds.Tables["student"].Rows.Add(row);
            oledbAdapter.Update(ds.Tables["student"]);
            MessageBox.Show("You have inserted a new student, the detail of following:\n"
                + "\nStudent ID: " + textBox1.Text
                + "\nName: " + textBox5.Text
                + "\nMembership ID: " + textBox2.Text
                + "\nPhone Number: " + textBox3.Text
                + "\nEmail: " + textBox4.Text
                + "\nEnrollMonth: " + dateTimePicker1.Text);
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
