using System.Collections.Generic;
using NumbersToWords.BL;

namespace NumbersToWords.View
{
    class VIew
    {
        private IController controller;

        public VIew()
        {
            controller = new Controller();
        }

        public void ConsoleView(string input)
        {
            _ = new Splitting(input, out List<string> words);
            controller.ControllerOutput(words);
        }
    }
}
