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
    public partial class Form11 : Form
    {

        DataSet ds;
        OleDbDataAdapter oledbAdapter;
        DataGridView dataGridView5;

        string membershipID = "";
        string status = "";
        string discount = "";

        public Form11(DataSet ds, OleDbDataAdapter oledbAdapter, DataGridView dataGridView5)
        {
            InitializeComponent();
            this.dataGridView5 = dataGridView5;
            this.ds = ds;
            this.oledbAdapter = oledbAdapter;
            this.membershipID = dataGridView5.CurrentRow.Cells[0].Value.ToString();
            this.status = dataGridView5.CurrentRow.Cells[1].Value.ToString();
            this.discount = dataGridView5.CurrentRow.Cells[2].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView5.CurrentRow.Cells[0].Value = textBox1.Text;
            dataGridView5.CurrentRow.Cells[1].Value = textBox2.Text;
            dataGridView5.CurrentRow.Cells[2].Value = textBox3.Text;
            oledbAdapter.Update(ds.Tables["membership"]);
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form11_Load(object sender, EventArgs e)
        {
            textBox1.Text = membershipID;
            textBox2.Text = status;
            textBox3.Text = discount;
        }
    }
}
