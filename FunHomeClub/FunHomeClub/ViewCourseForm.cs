using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace FunHomeClub
{
    public partial class ViewCourseForm : Form
    {
        OleDbConnection connection;
        OleDbDataAdapter dataAdapter;
        DataTable dt;

        public ViewCourseForm(OleDbConnection connection)
        {
            InitializeComponent();
            this.connection = connection;
            FillCourseTree();
            categortTree.ExpandAll();
        }
        public void FillCourseTree()
        {
            
            string sql = "SELECT * FROM courseCategory";
            dataAdapter = new OleDbDataAdapter(sql, connection);
            dt = new DataTable();
            dataAdapter.Fill(dt);

            for(int i = 0; i < dt.Rows.Count; i++)
            {
                categortTree.Nodes.Add(dt.Rows[i]["name"].ToString());

                sql = "SELECT * FROM course WHERE categoryID = '" + dt.Rows[i]["categoryID"].ToString() + "'";
                dataAdapter.SelectCommand.CommandText = sql;
                DataTable tmp = new DataTable();
                dataAdapter.Fill(tmp);

                for(int n = 0; n < tmp.Rows.Count; n++)
                {
                    categortTree.Nodes[i].Nodes.Add(tmp.Rows[n]["courseID"].ToString() + "-" + tmp.Rows[n]["name"].ToString());
                }
            }
        }

        private void categortTree_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if(categortTree.SelectedNode.Parent != null)
                FillPanel(categortTree.SelectedNode.ToString().Split(' ')[1].Split('-')[0]);
        }
        public void FillPanel(String courseID)
        {
            courseDetailPanel.Controls.Clear();
            CourseDetailControl cdc = new CourseDetailControl(connection, courseID);
            courseDetailPanel.Controls.Add(cdc);
            cdc.Dock = DockStyle.Fill;
        }

        private void ViewCourseForm_Load(object sender, EventArgs e)
        {
            categortTree.SelectedNode = categortTree.Nodes[0].Nodes[0];
        }
    }
}
