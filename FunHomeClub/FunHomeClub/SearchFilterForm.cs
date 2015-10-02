using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace FunHomeClub
{
    public partial class SearchFilterForm : Form
    {
        SearchForm sf;
        DataTable category;
        public SearchFilterForm(SearchForm sf)
        {
            InitializeComponent();
            this.sf = sf;
            FillCategory();

        }
        private void FillCategory()
        {
            cboCategory.Items.Clear();
            sf.dataAdapter.SelectCommand.CommandText = "SELECT * FROM courseCategory";
            category = new DataTable();
            sf.dataAdapter.Fill(category);
            for (int i = 0; i < category.Rows.Count; i++)
            {
                cboCategory.Items.Add(category.Rows[i]["name"].ToString());
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if((txtPrice1.Text.Length > 0 && txtPrice2.Text.Length <= 0) || (txtPrice1.Text.Length <= 0 && txtPrice2.Text.Length > 0) || (txtPrice1.Text.Length <= 0 && txtPrice2.Text.Length <= 0))
            {
                MessageBox.Show("Please fill in two field of price before click search!");
                return;
            }

            string pricePattern = "^([0-9]|[.][0-9])*$";
            Regex regex = new Regex(pricePattern);
            if (!regex.IsMatch(txtPrice1.Text))
            {
                MessageBox.Show("Price format is not correct!");
                return;
            }

            if (Convert.ToDouble(txtPrice1.Text) > Convert.ToDouble(txtPrice2.Text))
            {
                MessageBox.Show("Price scope is not correct!");
                return;
            }

            string selectString = "SELECT cc.name, c.name, weekday, startMonth, endMonth, startTime, endTime,  ((teacherRate + operatingCharges) * " +
             sf.profitMargin + ") / 10 as Price, quota, room, courseID FROM course c, courseCategory cc WHERE c.categoryID = cc.categoryID"
                + " AND quota >= " + Convert.ToInt32(nudQuota.Value.ToString());

            if (cboMonth.SelectedIndex > 0)
                selectString += " AND " + cboMonth.SelectedIndex + " BETWEEN startMonth AND endMonth";

            if (cboWeekday.SelectedIndex > 0)
                selectString += " AND weekday =" + cboWeekday.SelectedIndex;

            if (!(txtPrice1.Text.Equals("") || txtPrice2.Text.Equals("")))
                selectString += " AND ((teacherRate + operatingCharges) * " + sf.profitMargin + ") / 10 BETWEEN " + txtPrice1.Text + " AND " + txtPrice2.Text;

            if (cboCategory.SelectedIndex >= 0)
                selectString += " AND cc.categoryID = '" + category.Rows[cboCategory.SelectedIndex]["categoryID"].ToString() + "'";

            sf.dataAdapter.SelectCommand.CommandText = selectString;
            sf.dt.Clear();
            sf.dataAdapter.Fill(sf.dt);
            sf.FillListView();
            this.Close();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            cboMonth.SelectedIndex = 0;
            cboWeekday.SelectedIndex = 0;
            cboCategory.SelectedIndex = -1;
            txtPrice1.Text = "";
            txtPrice2.Text = "";
            nudQuota.Value = 0;

            sf.dataAdapter.SelectCommand.CommandText = sf.showAllCourse;
            sf.dt.Clear();
            sf.dataAdapter.Fill(sf.dt);
            sf.FillListView();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
