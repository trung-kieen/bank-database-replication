using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankReplication.utils
{
    class Msg
    {
        public static void Info(string msg, String title = "Thông báo")
        {
            MessageBox.Show(msg, title, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static void Warm(string msg, String title = "Thông báo")
        {
            MessageBox.Show(msg, title, MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        public static void Error(string msg, String title = "Thông báo")
        {
            MessageBox.Show(msg, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static DialogResult InforConfirm(string msg, String title = "Xác nhận")
        {
            return MessageBox.Show(msg, title, MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
        }

        public static DialogResult WarmConfirm(string msg, String title = "Xác nhận")
        {
            return MessageBox.Show(msg, title, MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
        }
    }
}
