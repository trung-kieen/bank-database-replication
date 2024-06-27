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
