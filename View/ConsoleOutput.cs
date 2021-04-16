using System;
using System.Collections.Generic;
using NumbersToWords.BL;
namespace NumbersToWords.View
{
    class ConsoleOutput
    {
        private IInterpret _inter;

        public ConsoleOutput(List<string> slova)
        {
            _inter = new Interpter();
            int blocks = slova.Count;
            string substring2;

            for (int i = 0; i < blocks; i++)
            {
                substring2 = _inter.Interpret(slova);

                if (substring2.Contains("error"))
                {
                    Console.Clear();
                    Console.Write("Something went wrong. Check number you want to interpret");
                    Console.ReadKey();
                    return;
                }
                else
                    Console.Write(substring2);
            }
            Console.ReadKey();
        }
    }
}
