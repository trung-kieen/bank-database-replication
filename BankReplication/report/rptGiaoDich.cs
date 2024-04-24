using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace BankReplication.report
{
    public partial class rptGiaoDich : DevExpress.XtraReports.UI.XtraReport
    {
        public rptGiaoDich()
        {
            InitializeComponent();
        }
        public rptGiaoDich(String sotk,DateTime tungay, DateTime denngay)
        {
           
            InitializeComponent();
            sqlDataSource1.Connection.ConnectionString = Program.connstr;
            sqlDataSource1.Queries[0].Parameters[0].Value = sotk;
            sqlDataSource1.Queries[0].Parameters[1].Value = tungay;
            sqlDataSource1.Queries[0].Parameters[2].Value = denngay;
            sqlDataSource1.Fill();
            
        }

    }
}
