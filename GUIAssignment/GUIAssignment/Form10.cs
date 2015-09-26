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
    public partial class Form10 : Form
    {
        DataSet ds;
        OleDbDataAdapter oledbAdapter;

        public Form10(DataSet ds, OleDbDataAdapter oledbAdapter)
        {
            InitializeComponent();
            this.ds = ds;
            this.oledbAdapter = oledbAdapter;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataRow row = ds.Tables["membership"].NewRow();
            row.SetField("membershipID", textBox1.Text);
            row.SetField("status", textBox2.Text);
            row.SetField("discount", Convert.ToDouble(textBox3.Text));
            ds.Tables["membership"].Rows.Add(row);
            oledbAdapter.Update(ds.Tables["membership"]);
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
