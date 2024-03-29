using System;

using System.Data.SqlClient;
using System.Windows.Forms;

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
            try
            {
                String cmd = "EXEC SP_TimNhanVien '" + MaNV + "'";
                Boolean notDisplayErrorNoEmployee = true;
                myReader = ExecSqlDataReader(cmd, notDisplayErrorNoEmployee);
                
                if (myReader == null) return false;
                return true;
            }
            catch
            {
                
                return false;
            }

        }



    }
}
