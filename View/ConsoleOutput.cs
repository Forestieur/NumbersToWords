using System;
using System.Collections.Generic;
using NumbersToWords.BL;

namespace NumbersToWords.View
{
    class ConsoleOutput
    {
        private Expression _expression;

        public ConsoleOutput(List<string> slova)
        {
            _expression = new Expression();
            int blocks = slova.Count;
            string substring;
           
            for (int i = 0; i < blocks; i++)
            {
                substring = _expression.Interpret(slova);

                if(substring.Contains("error"))
                {
                    Console.Clear();
                    Console.Write("Something went wrong. Check number you want to interpret");
                    Console.ReadKey();
                    return;
                }
                else
                    Console.Write(substring);
            }
            Console.ReadKey();
        }
    }
}
