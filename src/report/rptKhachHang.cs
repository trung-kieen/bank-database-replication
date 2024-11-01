﻿using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
// Author: trung-kieen

namespace BankReplication.report
{
    public partial class rptKhachHang : DevExpress.XtraReports.UI.XtraReport
    {
        public rptKhachHang( String Connstr ,String SP_Name)
        {
            InitializeComponent();
            sqlDataSource1.Queries[0].Name = SP_Name;
            sqlDataSource1.Queries.RemoveAt(0);
            DevExpress.DataAccess.Sql.StoredProcQuery storedProcQuery1 = new DevExpress.DataAccess.Sql.StoredProcQuery();
            storedProcQuery1.Name = SP_Name;
            storedProcQuery1.StoredProcName = SP_Name;
            DataMember = SP_Name;
            this.sqlDataSource1.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            storedProcQuery1});
            sqlDataSource1.Connection.ConnectionString = Connstr;
            DetailsLoad(); 
        }
        private void DetailsLoad()
        {
            xrlbNguoiLap.Text = Program.mHoTen;
        }
        public rptKhachHang(String Connstr)
        {
            InitializeComponent();
            sqlDataSource1.Connection.ConnectionString = Connstr;
            DetailsLoad(); 
        }

    }
}
