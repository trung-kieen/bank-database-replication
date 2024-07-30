using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Author: trung-kieen

/*
 * Provide key - value for load default data in combobox 
 */
namespace BankReplication.utils
{
    public class Gender
    {
        public Gender(String name)
        {
            Name = name;
        }
        public String Name { get; set; }
    }
    public class LoaiGD
    {
        public LoaiGD(String Text, String Value)
        {
            this.Text = Text;
            this.Value = Value;

        }
        public String Text { get; set; }
        public String Value { get; set; }
    }
    public class KeyValue
    {
        public KeyValue(String Text, String Value)
        {
            this.Text = Text;
            this.Value = Value;

        }

        public String Text { get; set; }
        public String Value { get; set; }

        public static List<KeyValue> roles = new List<KeyValue>{
            new KeyValue("Khách hàng", "KhachHang"),
            new KeyValue("Chi nhánh", "ChiNhanh"),
            new KeyValue("Ngân hàng", "NganHang")
        };


    }
    public static class RoleIndex
    {
        public static int KhachHang = 0;
        public static int ChiNhanh = 1;
        public static int NganHang = 2;
    }


}
