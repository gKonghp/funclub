﻿using Microsoft.Reporting.WinForms;
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
    public partial class InvoicePreviewForm : Form
    {
        string connStr = ConfigurationManager.ConnectionStrings["FunHomeClub.Properties.Settings.masterDBConnectionString"].ToString();
        private OleDbConnection conn;
        private string invoiceID;
        public InvoicePreviewForm(string invoiceID)
        {
            InitializeComponent();
            conn = new OleDbConnection(connStr);
            this.invoiceID = invoiceID;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: 這行程式碼會將資料載入 'masterDBDataSet.course' 資料表。您可以視需要進行移動或移除。
            this.courseTableAdapter.Fill(this.masterDBDataSet.course);

            string sql;
            OleDbDataAdapter adapter;
            // Get invoice Table
            sql = string.Format("SELECT * FROM Invoice WHERE invoiceID = '{0}'", invoiceID);
            adapter = new OleDbDataAdapter(sql, conn);
            adapter.Fill(this.masterDBDataSet.invoice);
            adapter.Dispose();
            
            // Get studentCourse Table
            sql = string.Format("SELECT * FROM studentCourse WHERE invoiceID = '{0}'", invoiceID);
            adapter = new OleDbDataAdapter(sql, conn);
            adapter.Fill(this.masterDBDataSet.studentCourse);
            adapter.Dispose();

            //get the student who owned the inovice 
            string studentID = this.masterDBDataSet.studentCourse.Rows[0]["studentID"].ToString();

            // Get student Table
            sql = string.Format("SELECT * FROM student WHERE studentID = '{0}'", studentID);
            adapter = new OleDbDataAdapter(sql, conn);
            adapter.Fill(this.masterDBDataSet.student);
            adapter.Dispose();

            //get the student who owned the inovice 
            string membershipID = this.masterDBDataSet.student.Rows[0]["membershipID"].ToString();

            // Get membership Table
            sql = string.Format("SELECT * FROM membership WHERE membershipID = '{0}'", membershipID);
            adapter = new OleDbDataAdapter(sql, conn);
            adapter.Fill(this.masterDBDataSet.membership);
            adapter.Dispose();

            //ReportParameter p1 = new ReportParameter("invoiceID", "in0001");
            //this.reportViewer1.LocalReport.SetParameters(new ReportParameter[] { p1 });
            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}