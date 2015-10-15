using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FunHomeClub
{
    public partial class PromotionForm : Form
    {
        string connStr = ConfigurationManager.ConnectionStrings["FunHomeClub.Properties.Settings.masterDBConnectionString"].ToString();
        private OleDbConnection connection;
        public PromotionForm()
        {
            InitializeComponent();
            connection = new OleDbConnection(connStr);
        }

        private void PromotionForm_Load(object sender, EventArgs e)
        {
            PromotionControl promotionUC = new PromotionControl(connection);
            panel2.Controls.Add(promotionUC);
            promotionUC.Dock = DockStyle.Fill;
            promotionUC.Show();
            Utility.repaintFrameSize(this.MdiParent, this, promotionUC, 190,10);
        }
    }
}
