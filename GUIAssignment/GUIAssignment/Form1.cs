using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace GUIAssignment
{
    public partial class Form1 : Form
    {
        OleDbConnection cnn;
        OleDbDataAdapter oledbAdapterForTeacher, oledbAdapterForStudent, 
            oledbAdapterForEmployee, oledbAdapterForCourse,
            oledbAdapterForMembership, oledbAdapterForProfitMargin;
        string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;"
                          + "Data Source=masterDB.accdb";
        DataSet ds = new DataSet();
        OleDbCommandBuilder oledbCmdBuilderForTeacher, oledbCmdBuilderForStudent,
            oledbCmdBuilderForEmployee, oledbCmdBuilderForCourse,
            oledbCmdBuilderForMembership, oledbCmdBuilderForProfitMargin;

        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {  
            cnn = new OleDbConnection(connectionString);
            try
            {
                cnn.Open();

                oledbAdapterForTeacher = new OleDbDataAdapter("Select * from teacher", cnn);
                oledbCmdBuilderForTeacher = new OleDbCommandBuilder(oledbAdapterForTeacher);
                oledbAdapterForTeacher.Fill(ds, "teacher");

                oledbAdapterForStudent = new OleDbDataAdapter("Select * from Student", cnn);
                oledbCmdBuilderForStudent = new OleDbCommandBuilder(oledbAdapterForStudent);
                oledbAdapterForStudent.Fill(ds, "student");

                oledbAdapterForEmployee = new OleDbDataAdapter("Select * from employee", cnn);
                oledbCmdBuilderForEmployee = new OleDbCommandBuilder(oledbAdapterForEmployee);
                oledbAdapterForEmployee.Fill(ds, "employee");

                oledbAdapterForCourse = new OleDbDataAdapter("Select * from course", cnn);
                oledbCmdBuilderForCourse = new OleDbCommandBuilder(oledbAdapterForCourse);
                oledbAdapterForCourse.Fill(ds, "course");

                oledbAdapterForMembership = new OleDbDataAdapter("Select * from membership", cnn);
                oledbCmdBuilderForMembership = new OleDbCommandBuilder(oledbAdapterForMembership);
                oledbAdapterForMembership.Fill(ds, "membership");

                oledbAdapterForProfitMargin = new OleDbDataAdapter("Select * from profitMargin", cnn);
                oledbCmdBuilderForProfitMargin = new OleDbCommandBuilder(oledbAdapterForProfitMargin);
                oledbAdapterForProfitMargin.Fill(ds, "profitMargin");

                MessageBox.Show("Connection Open ! ");

                dataGridView1.DataSource = ds;
                dataGridView1.DataMember = "teacher";

                dataGridView2.DataSource = ds;
                dataGridView2.DataMember = "student";

                dataGridView3.DataSource = ds;
                dataGridView3.DataMember = "employee";

                dataGridView4.DataSource = ds;
                dataGridView4.DataMember = "course";

                dataGridView5.DataSource = ds;
                dataGridView5.DataMember = "membership";

                textBox1.Text = ds.Tables["profitMargin"].Rows[0].ItemArray[1].ToString();



            }
            catch (Exception ex)
            {
                MessageBox.Show("Cannot open connection ! ");
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form5 frm5 = new Form5(ds, oledbAdapterForEmployee);
            frm5.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to delete the record?", "Confirmation", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                foreach (DataGridViewRow row in dataGridView3.SelectedRows)
                {
                    if (!row.IsNewRow)
                    {
                        dataGridView3.Rows.Remove(row);
                    }
                }
                oledbAdapterForEmployee.Update(ds.Tables["employee"]);
            }
            else if (result == DialogResult.No)
            {

            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to delete the record?", "Confirmation", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                foreach (DataGridViewRow row in dataGridView4.SelectedRows)
                {
                    if (!row.IsNewRow)
                    {
                        dataGridView4.Rows.Remove(row);
                    }
                }
                oledbAdapterForCourse.Update(ds.Tables["course"]);
            }
            else if (result == DialogResult.No)
            {

            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Form6 frm6 = new Form6(ds, oledbAdapterForCourse);
            frm6.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form7 frm7 = new Form7(ds, oledbAdapterForStudent, dataGridView2);
            frm7.Show();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to delete the record?", "Confirmation", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                foreach (DataGridViewRow row in dataGridView5.SelectedRows)
                {
                    if (!row.IsNewRow)
                    {
                        dataGridView5.Rows.Remove(row);
                    }
                }
                oledbAdapterForMembership.Update(ds.Tables["membership"]);
            }
            else if (result == DialogResult.No)
            {

            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Form10 frm10 = new Form10(ds, oledbAdapterForMembership);
            frm10.Show();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            ds.Tables["profitMargin"].Rows[0][1] = Convert.ToDouble(textBox1.Text);
            oledbAdapterForProfitMargin.Update(ds.Tables["profitMargin"]);
            MessageBox.Show("You have modify the profit margin to " + Convert.ToDouble(textBox1.Text));
        }

        private void button15_Click(object sender, EventArgs e)
        {
            Form11 frm11 = new Form11(ds, oledbAdapterForMembership, dataGridView5);
            frm11.Show();
        }

        private void tabPage6_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            Form8 frm8 = new Form8(ds, oledbAdapterForStudent, dataGridView3);
            frm8.Show();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Form9 frm9 = new Form9(ds, oledbAdapterForStudent, dataGridView4);
            frm9.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2(ds, oledbAdapterForTeacher);
            frm2.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to delete the record?", "Confirmation", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                foreach (DataGridViewRow row in dataGridView2.SelectedRows)
                {
                    if (!row.IsNewRow)
                    {
                        dataGridView2.Rows.Remove(row);
                    }
                }
                oledbAdapterForStudent.Update(ds.Tables["student"]);
            }
            else if (result == DialogResult.No)
            {

            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form4 frm4 = new Form4(ds, oledbAdapterForStudent);
            frm4.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form3 frm3 = new Form3(ds, oledbAdapterForTeacher, dataGridView1);
            frm3.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to delete the record?", "Confirmation", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                {
                    if (!row.IsNewRow)
                    {
                        dataGridView1.Rows.Remove(row);
                    }
                }
                oledbAdapterForTeacher.Update(ds.Tables["teacher"]);
            }
            else if (result == DialogResult.No)
            {
                
            }
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
    }
}
