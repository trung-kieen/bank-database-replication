using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public LoaiGD(String Text, String Value )
        {
            this.Text = Text;
            this.Value = Value;
           
        }
        public String Text{ get; set; }
        public String Value{ get; set; }
    }
    public class KeyValue
    {
        public KeyValue(String Text, String Value )
        {
            this.Text = Text;
            this.Value = Value;
           
        }

        public String Text{ get; set; }
        public String Value{ get; set; }
    }
}
