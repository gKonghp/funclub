using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.OleDb;
using System.Linq;
using System.Text;

namespace FunHomeClub
{
    class Membership
    {
        private res.db.masterDBDataSet masterDBDataSet;
        public string membershipID { get; set; }
        public string status { get; set; }
        public double discount { get; set; }

        public Student student { get; set; }

        public Membership(string membershipID, string status, double discount)
        {
            this.membershipID = membershipID;
            this.status = status;
            this.discount = discount;
        }

        public bool fetchMembership()
        {
            string connStr = ConfigurationManager.ConnectionStrings["FunHomeClub.Properties.Settings.masterDBConnectionString"].ToString();
            OleDbConnection conn = new OleDbConnection(connStr);
            string sql = string.Format("SELECT * FROM Membership WHERE membershipID = '{0}'", membershipID);
            OleDbCommand selectStudCommand = new OleDbCommand();
            OleDbDataAdapter adapter = new OleDbDataAdapter();
            selectStudCommand.Connection = conn;
            selectStudCommand.CommandText = sql;
            adapter.SelectCommand = selectStudCommand;
            adapter.Fill(masterDBDataSet, "Membership");
            adapter.Dispose();

            if (masterDBDataSet.membership.Count > 0)
            {
                status = masterDBDataSet.membership.Rows[0]["status"].ToString();
                discount = Convert.ToDouble(masterDBDataSet.membership.Rows[0]["discount"].ToString());


                student = new student();
                return true;
            }
            else
                return false;
        }
    }
    }
}
