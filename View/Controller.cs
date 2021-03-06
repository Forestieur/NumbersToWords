using System;
using System.Collections.Generic;
using NumbersToWords.BL;
using NumbersToWords.BL.Interfaces;
namespace NumbersToWords.View
{
    class Controller : IController
    {
        private IInterpret _inter;

        public Controller()
        {
            _inter = new Interpter();

        }

        public void ControllerOutput(List<string> slova)
        {
            int blocks = slova.Count;
            string substring;

            if (blocks == 0)
            {
                Console.Write("Something went wrong. Check number you want to interpret");
                Console.ReadKey();
                return;
            }

            for (int i = 0; i < blocks; i++)
            {
                substring = _inter.Interpret(slova);

                if (substring == null && blocks == 1)
                {
                    Console.Write("zero");
                    Console.ReadKey();
                    return;
                }

                if (substring != null && substring.Contains("error"))
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
