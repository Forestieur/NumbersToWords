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
}