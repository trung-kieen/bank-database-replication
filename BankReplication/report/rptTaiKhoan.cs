using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace BankReplication.report
{
    public partial class rptTaiKhoan : DevExpress.XtraReports.UI.XtraReport
    {
        public rptTaiKhoan(DateTime tungay, DateTime denngay, Boolean allSite)
        {
            InitializeComponent();
            sqlDataSource1.Connection.ConnectionString = Program.connstr;
            sqlDataSource1.Queries[0].Parameters[0].ValueInfo = tungay.ToString("yyyy-MM-dd ") + "00:00:00" ;
            sqlDataSource1.Queries[0].Parameters[1].ValueInfo = denngay.ToString("yyyy-MM-dd ") + "23:59:59" ;
            sqlDataSource1.Queries[0].Parameters[2].ValueInfo= allSite  ? "True" : "False";
            xrlbTungay.Text = tungay.ToString("dd/MM/yyyy");
            xrlbDenngay.Text = denngay.ToString("dd/MM/yyyy");
            
        }

    }
}
