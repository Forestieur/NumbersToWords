using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NumbersToWords.BL;

namespace NumbersToWords
{
    class Program
    {
        static void Main(string[] args)
        {
            string roman = "10005";
            Splitting splitting = new Splitting();
            Expression expression = new Expression();
            splitting.SplitStrings(roman, out List<string> numbers1);

            int blocks = numbers1.Count;
            for (int i = 0; i < blocks; i++)
            {
                Console.Write(expression.Interpret( numbers1));
            }

            Console.ReadKey();
        }
    }
}
