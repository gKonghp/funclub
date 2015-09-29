﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace FunHomeClub
{
    public partial class MaintainMembership : Form
    {
        OleDbConnection connection;
        OleDbDataAdapter dataAdapter;
        DataTable dt;
        string msID;
        string sql;
        public MaintainMembership(String buttonText,OleDbConnection connection)
        {
            InitializeComponent();
            btnSave.Text = buttonText;
            this.connection = connection;
            sql = "SELECT * FROM membership";
            initProgram();
        }
        public MaintainMembership(String buttonText, string msID, OleDbConnection connection)
        {
            InitializeComponent();
            btnSave.Text = buttonText;
            this.connection = connection;
            this.msID = msID;
            sql = "SELECT * FROM membership WHERE membershipID = '" + msID + "'";
            initProgram();

            txtStatus.Text = dt.Rows[0]["status"].ToString();
            txtDiscount.Text = dt.Rows[0]["discount"].ToString();
        }
        public void initProgram()
        {
            dataAdapter = new OleDbDataAdapter(sql, connection);
            dt = new DataTable();
            dataAdapter.Fill(dt);
        }
        private string findAvailableID()
        {
            string idHeader = "ms";
            string idMiddle = "000";
            int idNumber = 1;

            Console.WriteLine(idHeader + idMiddle + idNumber);
            for(int i = 0; i < dt.Rows.Count; i++)
            {
                if (!dt.Rows[i]["membershipID"].ToString().Equals(idHeader + idMiddle + idNumber))
                {
                    return idHeader + idMiddle + idNumber;
                }
                else
                {
                    idNumber += 1;
                    if (idNumber == 10 || idNumber == 100 || idNumber == 1000)
                    {
                        idMiddle = idMiddle.Substring(0, idMiddle.Length - 1);
                    }
                    else if (idNumber > 10000)
                    {
                        return "ERROR";
                    }
                }
            }
            return idHeader + idMiddle + idNumber;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (btnSave.Text.Equals("Add")){
                String id = findAvailableID();
                if (id.Equals("ERROR"))
                {
                    MessageBox.Show("Do not have any Available ID!");
                }
                else
                {
                    new OleDbCommand("Insert into membership values('" + id + "', '" + txtStatus.Text + "', " + txtDiscount.Text + ")", connection).ExecuteNonQuery();
                    MessageBox.Show("Adding membership successul!");
                    this.DialogResult = DialogResult.OK;
                }
            }
            else
            {
                new OleDbCommand("Update membership set status = '" + txtStatus.Text + "', discount = " + txtDiscount.Text + " WHERE membershipID = '" + msID + "'", connection).ExecuteNonQuery();
                MessageBox.Show("Changing successul!");
                this.DialogResult = DialogResult.OK;
            }
            this.Close();
        }

        private void MaintainMembership_Load(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
