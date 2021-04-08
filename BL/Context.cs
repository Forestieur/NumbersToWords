using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace NumbersToWords.BL
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
   
  /*  class ThousandExpression : Expression
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
       // public override int Multiplier() { return 1000; }
    }*/
   
  
}