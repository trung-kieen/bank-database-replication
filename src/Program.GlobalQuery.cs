using System;

using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;
using BankReplication.utils;


namespace BankReplication
{
    public static partial class Program
    {
        

        // Rebuild connection string when any property change before any database access action
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

        // Option to ingore error when connect to database 
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
                if(ex.Number== 15118)
                {
                    Msg.Error("Mật khẩu của bạn không thỏa mãn chính sách bảo mật.");
                    return ex.Number;
                }
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
        /// Use to get value from one column - one row query direct to a string 
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


        public static Boolean IsEmployeeExist(String MaNV)
        {
            String cmd = "EXEC SP_TimNhanVien '" + MaNV + "'";
            if (Program.conn.State == ConnectionState.Closed)
            {
                Program.conn.Open();
            }
            try
            {
                int existCode = Int32.Parse(ExecSqlScalar(cmd));
                if (existCode == Database.CheckExist.NotFound)
                    return false;
                else
                    return true;
            }
            catch (Exception e)
            {
                Msg.Error("Lỗi kết nối cơ sở dữ liệu.\nBạn xem lại user name và password.\n " + e.Message);
                Program.conn.Close();
                return false;
            }

        }

        public static Boolean IsAccountExist(String sotk)
        {
            String cmd = "EXEC SP_TimTaiKhoan '" + sotk + "'";
            if (Program.conn.State == ConnectionState.Closed)
            {
                Program.conn.Open();
            }
            try
            {
                int existCode = Int32.Parse(ExecSqlScalar(cmd));
                if (existCode == Database.CheckExist.NotFound)
                    return false;
                else
                    return true;
            }
            catch (Exception e)
            {
                Msg.Error("Lỗi kết nối cơ sở dữ liệu.\nBạn xem lại user name và password.\n " + e.Message);
                Program.conn.Close();
                return false;
            }

        }
        public static String LayMaCN()
        {
            if (Program.KetNoi() == Database.Connection.Fail) return null;
            try
            {
                return Program.ExecSqlScalar("SELECT MACN FROM NGANHANG.dbo.NHANVIEN");
            }catch
            {
                return null;
            }
        }

        public static String GetNewEmployeeID()
        {
            if (Program.KetNoi() == Database.Connection.Fail) return null;
            String newId = Program.ExecSqlScalar("EXEC SP_MaNVMoi");
            return newId;
        }

    }
}
