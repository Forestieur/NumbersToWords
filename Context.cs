using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NumbersToWords.BL;

namespace NumbersToWords
{

    class Context
    {
        public Context(string input)
        {
            _input = input;
        }

        public string Input { get { return _input; } set { _input = value; } }

        private string _input { get; set; }
        public int Output { get; set; }
    }   
   
    class ThousandExpression : Expression
    {
        public override string One() { return "M"; }
        public override string Two() { return "2"; }
        public override string Three() { return "3"; }
        public override string Four() { return " "; }
        public override string Five() { return " "; }
        public override string Six() { return "6"; }
        public override string Seven() { return "7"; }
        public override string Eight() { return "8"; }
        public override string Nine() { return " "; }
        public override int Multiplier() { return 1000; }
    }

    class HundredExpression : Expression
    {
        public override string One() { return "C"; }
        public override string Two() { return "2"; }
        public override string Three() { return "3"; }
        public override string Four() { return "CD"; }
        public override string Five() { return "D"; }
        public override string Six() { return "6"; }
        public override string Seven() { return "7"; }
        public override string Eight() { return "8"; }
        public override string Nine() { return "CM"; }
        public override int Multiplier() { return 100; }
    }

    class TenExpression : Expression
    {
        public override string One() { return "X"; }
        public override string Two() { return "2"; }
        public override string Three() { return "3"; }
        public override string Four() { return "XL"; }
        public override string Five() { return "L"; }
        public override string Six() { return "6"; }
        public override string Seven() { return "7"; }
        public override string Eight() { return "8"; }
        public override string Nine() { return "XC"; }
        public override int Multiplier() { return 10; }
    }

    class OneExpression : Expression
    {
        public override string One() { return "1"; }
        public override string Two() { return "2"; }
        public override string Three() { return "3"; }
        public override string Four() { return "4"; }
        public override string Five() { return "5"; }
        public override string Six() { return "6"; }
        public override string Seven() { return "7"; }
        public override string Eight() { return "8"; }
        public override string Nine() { return "9"; }
        public override int Multiplier() { return 1; }
    }
}