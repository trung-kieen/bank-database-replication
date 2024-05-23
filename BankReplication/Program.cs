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


namespace BankReplication
{
    public static partial class Program

    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>

        public static SqlConnection conn = new SqlConnection();
        public static String connstr;
        public static String connstr_publisher = "Data Source=" + Settings.servername + ";Initial Catalog=" + Settings.databasename + " ;Integrated Security=True";
        public static SqlDataReader myReader;
        public static String servername = Settings.servername;
        public static String username = "sa";
        public static String mlogin = "sa";
        public static String password = Settings.sa_password;

        public static String database = Settings.databasename;
        public static String remotelogin = "htkn";
        public static String remotepassword = Settings.htkn_password;

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
            frmChinh = new formMain();
            Application.Run(frmChinh);
            //Application.Run(new formDangNhap());
        }

        public static String GetConnString()
        {
            return Program.connstr = "Data Source=" + Program.servername
                            + ";Initial Catalog=" + Program.database
                            + ";User ID=" + Program.mlogin
                            + ";password=" + Program.password;
        }
        public static String GetConnString(String login, String password)
        {
            return Program.connstr = "Data Source=" + Program.servername
                            + ";Initial Catalog=" + Program.database
                            + ";User ID=" + login
                            + ";password=" + password;
        }
        public static String GetConnString(String login, String password, String servername)
        {
            return Program.connstr = "Data Source=" + servername
                            + ";Initial Catalog=" + Program.database
                            + ";User ID=" + login
                            + ";password=" + password;
        }


        public static int KetNoi(Boolean showError = true)
        {
            // Close old connection avoid system close connection time out 
            if (Program.conn != null && Program.conn.State == System.Data.ConnectionState.Open)
            {
                Program.conn.Close();
            }
            try
            {
                Program.connstr = "Data Source=" + Program.servername
                                + ";Initial Catalog=" + Program.database
                                + ";User ID=" + Program.mlogin
                                + ";password=" + Program.password;
                Program.conn.ConnectionString = Program.connstr;
                Program.conn.Open();
                return Database.Connection.Success;
            }
            catch (Exception ex)
            {
                if (showError)
                {
                    Msg.Error("Lỗi kết nối cơ sở dữ liệu.\nBạn xem lại user name và password.\n" + ex.Message);
                }
                return Database.Connection.Fail;
            }
        }



        public static SqlDataReader ExecSqlDataReader(String cmd, Boolean forceNoMessageBox = false)
        ///<summary>
        /// Use for read data only command
        ///<para>command string</para>
        /// Return value is SqlDataReader object (same with Program.myReader)
        /// Return null if catch error 
        ///</summary>
        {
            SqlDataReader myReader;
            SqlCommand sqlcmd = new SqlCommand(cmd, Program.conn);
            sqlcmd.CommandType = CommandType.Text;
            if (Program.conn.State == ConnectionState.Closed)
            {
                Program.conn.Open();
            }
            try
            {
                myReader = sqlcmd.ExecuteReader();
                // Do not close connection here, it cause myReader unable to read
                return myReader;
            }
            catch (Exception ex)
            {
                if (!forceNoMessageBox)
                {
                    Msg.Error("Lỗi kết nối cơ sở dữ liệu.\nBạn xem lại user name và password.\n " + ex.Message);
                }
                Program.conn.Close();
                return null;
            }
        }


        public static int ExecSqlNonQuery(String cmd)
        ///<summary>
        ///<para>command string</para>
        /// Return value 0 if command run success else return error code from sql server
        ///</summary>
        {
            SqlCommand sqlcmd = new SqlCommand(cmd, Program.conn);
            sqlcmd.CommandType = CommandType.Text;
            const int oneMinute = 60;
            sqlcmd.CommandTimeout = 10 * oneMinute;
            if (Program.conn.State == ConnectionState.Closed)
            {
                Program.conn.Open();
            }

            try
            {
                sqlcmd.ExecuteNonQuery();
                conn.Close();

                return Database.NoQuery.Success;
            }
            catch (SqlException ex)
            {
                Msg.Error(ex.Message);
                conn.Close();
                //                return ex.State;
                return ex.Number;
            }
        }
        public static String ExecSqlScalar(String cmd)
        ///<summary>
        ///<para>command string</para>
        /// Return value 0 if command run success else return error code from sql server
        ///</summary>
        {
            SqlCommand sqlcmd = new SqlCommand(cmd, Program.conn);
            sqlcmd.CommandType = CommandType.Text;
            const int oneMinute = 60;
            sqlcmd.CommandTimeout = 10 * oneMinute;
            if (Program.conn.State == ConnectionState.Closed)
            {
                Program.conn.Open();
            }

            var queryResult = sqlcmd.ExecuteScalar();
            if (queryResult == null)
            {
                conn.Close();
                return null;
            }
            conn.Close();
            return queryResult.ToString();
        }


        public static DataTable ExecSqlDataTable(String cmd)
        ///<summary>
        ///<para>command string</para>
        /// Return DataTable object or null if catch error
        ///</summary>
        {
            DataTable dataTable = new DataTable();
            if (Program.conn.State == ConnectionState.Closed)
            {
                Program.conn.Open();
            }
            SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd, Program.conn);
            try
            {
                dataAdapter.Fill(dataTable);
                Program.conn.Close();
                return dataTable;
            }
            catch (SqlException e)
            {
                Program.conn.Close();
                Msg.Error(e.Message);
                return null;
            }

        }


    }


}
