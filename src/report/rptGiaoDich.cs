﻿using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using BankReplication.utils;
// Author: trung-kieen

namespace BankReplication.report
{
    public partial class rptGiaoDich : DevExpress.XtraReports.UI.XtraReport
    {
        public rptGiaoDich()
        {
            InitializeComponent();
        }
        public rptGiaoDich(String sotk,DateTime tungay, DateTime denngay, String hoten)
        {
           
            InitializeComponent();
            sqlDataSource1.Connection.ConnectionString = Program.connstr;
            sqlDataSource1.Queries[0].Parameters[0].Value = sotk;
            sqlDataSource1.Queries[0].Parameters[1].ValueInfo = tungay.ToString("yyyy-MM-dd ") + "00:00:00" ;
            sqlDataSource1.Queries[0].Parameters[2].ValueInfo = denngay.ToString("yyyy-MM-dd ") + "23:59:59" ;

            xrlbHoten.Text = hoten;
            xrlbSotk.Text = sotk;
            xrlbTungay.Text = tungay.ToString("dd/MM/yyyy");
            xrlbDenngay.Text = denngay.ToString("dd/MM/yyyy");
            sqlDataSource1.Fill();
        }

    }
}
