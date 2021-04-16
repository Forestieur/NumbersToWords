using System.Collections.Generic;
using NumbersToWords.BL;

namespace NumbersToWords.View
{
    class VIew
    {
        private Splitting _splitting;
        private ConsoleOutput _console;

        public VIew(string input)
        {
            _splitting = new Splitting(input, out List<string> words);
            _console = new ConsoleOutput(words);
        }
    }
}
