using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DevExpress.UserSkins;
using DevExpress.Skins;
using System.Data;
using System.Data.SqlClient;
using BankReplication.form;

namespace BankReplication
{
    static class Program
    
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>

        public static SqlConnection conn = new SqlConnection();
        public static String connstr;
        public static String connstr_publisher = "Data Source=DESKTOP-T4TQ0L3;Initial Catalog=NganHang;Integrated Security=True";
        public static SqlDataReader myReader;
        public static String servername = "";
        public static String username = "";
        public static String mlogin = "";
        public static String password = "";

        public static String database = "NGANHANG";
        public static String remotelogin = "htkn";
        public static String remotepassword = "123456";

        public static String mloginDN = "";
        public static String passwordDN = "";
        public static String mGroup = "";
        public static String mHoTen = "";

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


        public static int KetNoi()
        {
            // Close old connection avoid system close connection time out 
            if(Program.conn !=null && Program.conn.State == System.Data.ConnectionState.Open)
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
                return 1;
            }
            catch (Exception e) {
                MessageBox.Show("Lỗi kết nối cơ sở dữ liệu.\nBạn xem lại user name và password.\n " + e.Message, "", MessageBoxButtons.OK);
                return 0;
            }
        }
        public static SqlDataReader ExecSqlDataReader(String cmd)
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
            if(Program.conn.State == ConnectionState.Closed)
            {
                Program.conn.Open();
            }
            try
            {
                myReader = sqlcmd.ExecuteReader();
                Program.conn.Close();
                return myReader;
            }
            catch (Exception e)
            {
                MessageBox.Show("Lỗi kết nối cơ sở dữ liệu.\nBạn xem lại user name và password.\n " + e.Message, "", MessageBoxButtons.OK);
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
            if(Program.conn.State == ConnectionState.Closed)
            {
                Program.conn.Open();
            }

            try
            {
                sqlcmd.ExecuteNonQuery();
                conn.Close();
                return 0;
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Message);
                conn.Close();
                // Return error code from sql 
                return e.State;
            }
        }

        public static DataTable ExecSqlDataTable(String cmd)
        ///<summary>
        ///<para>command string</para>
        /// Return DataTable object or null if catch error
        ///</summary>
        {
            DataTable dataTable = new DataTable();
            if(Program.conn.State == ConnectionState.Closed)
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
                MessageBox.Show(e.Message);
                return null;
            }

        }

    }


}
