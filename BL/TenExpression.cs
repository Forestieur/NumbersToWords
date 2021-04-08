using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumbersToWords.BL
{
    class TenExpression : Expression
    {
        public static string Zero() { return " ten"; }
        public static string One() { return " eleven"; }
        public static string Two() { return " twelve"; }
        public static string Three() { return " thirteen"; }
        public static string Four() { return " fourteen"; }
        public static string Five() { return " fifteen"; }
        public static string Six() { return " sixteen"; }
        public static string Seven() { return " seventeen"; }
        public static string Eight() { return " eighteen"; }
        public static string Nine() { return " nineteen"; }
    }
}
