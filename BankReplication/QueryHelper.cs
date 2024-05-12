using System;

using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;
using BankReplication.utils;


namespace BankReplication
{
    public static partial class Program
    {
        

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
                MessageBox.Show("Lỗi kết nối cơ sở dữ liệu.\nBạn xem lại user name và password.\n " + e.Message, "", MessageBoxButtons.OK);
                Program.conn.Close();
                return false;
            }
        }


    }
}
