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
            List<string> numbers = new List<string>();
            string roman = "12345678910";
            Context context = new Context(roman);
            Splitting splitting = new Splitting();
            splitting.SplitStrings(roman, out List<string> numbers1);


            //Строим 'parse tree'
           /* List<Expression> tree = new List<Expression>
            {
                new ThousandExpression(),
                new HundredExpression(),
                new TenExpression(),
                new OneExpression()
            };*/

            //Интерпритатор

            //foreach (Expression exp in tree)
            //{
            //    exp.Interpret(context);
            //}

            foreach (string exp in numbers1)
            {
                Console.WriteLine(exp);
            }
            //Console.WriteLine("{0} = {1}",
            //    roman, context.Output);
            // Wait for user

            Console.ReadKey();
        }
    }
}
