using System.Collections.Generic;
namespace NumbersToWords.BL
{

    class Context
    {
        public Context(string input)
        {
            _input = input;
        }

        private List<string> _words { get; set; }
        public List<string> Words { get { return _words; } set { } }

        public string Input { get { return _input; } set { _input = value; } }
        private string _input { get; set; }
        
    }     
}