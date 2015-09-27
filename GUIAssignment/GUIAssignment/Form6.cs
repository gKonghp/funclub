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
    public partial class Form6 : Form
    {
        DataSet ds;
        OleDbDataAdapter oledbAdapter;
        public Form6(DataSet ds, OleDbDataAdapter oledbAdapter)
        {
            InitializeComponent();
            this.ds = ds;
            this.oledbAdapter = oledbAdapter;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataRow row = ds.Tables["course"].NewRow();
            row.SetField("courseID", textBox1.Text);
            row.SetField("name", textBox2.Text);
            row.SetField("quota", Convert.ToInt32(textBox3.Text));
            row.SetField("weekday", Convert.ToInt32(textBox4.Text));
            row.SetField("room", textBox5.Text);
            //row.SetField("startTime", textBox6.Text);
            //row.SetField("endTime", textBox7.Text);
            row.SetField("startTime", dateTimePicker1.Text);
            row.SetField("endTime", dateTimePicker2.Text);
            row.SetField("teacherRate", Convert.ToInt32(textBox8.Text));
            row.SetField("operatingCharges", Convert.ToInt32(textBox9.Text));
            row.SetField("categoryID", textBox10.Text);
            row.SetField("teacherID", textBox11.Text);
            row.SetField("startMonth", Convert.ToInt32(textBox6.Text));
            row.SetField("endMonth", Convert.ToInt32(textBox7.Text));
            row.SetField("description", textBox14.Text);
            ds.Tables["course"].Rows.Add(row);
            oledbAdapter.Update(ds.Tables["course"]);

            MessageBox.Show("You have inserted a new course, the detail of following:\n"
                + "\nCourseID: " + textBox1.Text
                + "\nName: " + textBox2.Text
                + "\nQuota: " + Convert.ToInt32(textBox3.Text)
                + "\nWeekday: " + Convert.ToInt32(textBox4.Text)
                + "\nRoom: " + textBox5.Text
                + "\nStart Time: " + dateTimePicker1.Text
                + "\nEnd Time: " + dateTimePicker2.Text
                + "\nTeacher Rate: " + Convert.ToInt32(textBox8.Text)
                + "\nOperating Charges: " + Convert.ToInt32(textBox9.Text)
                + "\nCategory ID: " + textBox10.Text
                + "\nTeacherID: " + textBox11.Text
                + "\nStart Month: " + Convert.ToInt32(textBox6.Text)
                + "\nEnd Month: " + Convert.ToInt32(textBox7.Text)
                + "\nDescription: " + textBox14.Text);
            this.Close();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            dateTimePicker1.Format = DateTimePickerFormat.Time;
            dateTimePicker2.Format = DateTimePickerFormat.Time;
        }
    }
}
