using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NumbersToWords.BL;

namespace NumbersToWords.View
{
    class ConsoleOutput
    {
        Expression _expression;

        public ConsoleOutput(List<string> slova)
        {
            _expression = new Expression();
            int blocks = slova.Count;
            for (int i = 0; i < blocks; i++)
            {
                Console.Write(_expression.Interpret(slova));
            }
            Console.ReadKey();
        }
    }
}
