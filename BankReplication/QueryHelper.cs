using System;

using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;


namespace BankReplication
{
    public static partial class Program
    {
        public static String FetchMACNFromDB()
        {
            Program.myReader = Program.ExecSqlDataReader("SELECT MACN FROM ChiNhanh");
            if (Program.myReader == null) throw new Exception("Chinh nhanh khong ton tai");
            Program.myReader.Read();

            String macn = Program.myReader.GetString(0);
            Program.myReader.Close();
            return macn;
        }

        public static Boolean IsEmployeeExist(String MaNV)
        {

            // NOTE: Use method KetNoi to connect to server first
            String cmd = "EXEC SP_TimNhanVien '" + MaNV + "'";
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
                if (myReader.Read())
                {
                    if ( myReader.GetString(0) != "")  return true;
                }
                myReader.Close();
                return false;
            }
            catch (Exception e)
            {
                MessageBox.Show("Lỗi kết nối cơ sở dữ liệu.\nBạn xem lại user name và password.\n " + e.Message, "", MessageBoxButtons.OK);
                Program.conn.Close();
                return false;
            }
        }


    }
}
