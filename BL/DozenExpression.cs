using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumbersToWords.BL
{
    class DozenExpression : Expression
    {
        public static string One() { return " ten"; }
        public static string Two() { return " twenty"; }
        public static string Three() { return " thirty"; }
        public static string Four() { return " forty"; }
        public static string Five() { return " fifty"; }
        public static string Six() { return " sixty"; }
        public static string Seven() { return " seventy"; }
        public static string Eight() { return " eighty"; }
        public static string Nine() { return " ninety"; }
    }
}
