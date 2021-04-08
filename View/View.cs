using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NumbersToWords.BL;

namespace NumbersToWords.View
{
    class VIew
    {
        Splitting _splitting;
        ConsoleOutput _console;

        public VIew(string input)
        {
            _splitting = new Splitting(input,out List<string> words);
            _console = new ConsoleOutput(words);
        }
    }
}
