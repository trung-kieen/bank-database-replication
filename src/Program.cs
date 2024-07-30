using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

using DevExpress.UserSkins;
using DevExpress.Skins;
using System.Data;
using BankReplication.utils;
using System.Data.SqlClient;
using BankReplication.form;
using BankReplication.Properties;
// Author: trung-kieen

/* 
 * Class itself is static and can access in any part of application (yeah i know singleton)
 * Main entrypoint of application 
 * Contain all static variable as global variable
 * call something like Program.servername for access servername global variable
 * Contain configuration and method to communicate with database 
 * All method for database accessing store in Program.GlobalQuery.cs (partial of this class)
 */

namespace BankReplication
{
    public static partial class Program

    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>

        public static SqlConnection conn = new SqlConnection();
        public static String connstr;
        public static String connstr_publisher = "Data Source=" + servername + ";Initial Catalog=" + database + " ;Integrated Security=True";
        public static SqlDataReader myReader;
        public static String servername = System.Environment.MachineName +  "\\NGANHANG";
        public static String username = "sa";
        public static String mlogin = "sa";

        public static String database = "NGANHANG";
        public static String remotelogin = "htkn";
        public static String remotepassword = htkn_password;

        // NOTE: change 2 sql server password base on your machine!!!
        public static String password = "kc";
        public static readonly String htkn_password = "123456";
       
        /* 
         * Information from user save on login for build connection, log username in report 
         * Any action with data will use with those login for authorization because specific group 
         * have permission perform action on specific type of query 
         */
        public static String mloginDN = "";
        public static String passwordDN = "";
        public static String mGroup = "";
        public static String mHoTen = "";

        // Selected index at login form
        public static int mChiNhanh = 0;

        public static formMain frmChinh;

        public static BindingSource bds_dspm = new BindingSource(); // giữa bdsPM khi đăng nhập


        [STAThread]

        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Main winform class to manager 
            frmChinh = new formMain();
            Application.Run(frmChinh);
        }


    }


}
