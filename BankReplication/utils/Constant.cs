using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankReplication.utils
{
   public static class Database
    {
        public static class CheckExist
        {
            public static int FoundSameSite = 1;
            public static int FoundOtherSite = 2;
            public static int NotFound = 0;
        }
        public static class NoQuery
        {
            public static int Success = 0;

        }
        public static class Connection
        {
            public static int Success = 1;
            public static int Fail = 0;
            public static Boolean NotShowError = false;
        }

    } 
}
