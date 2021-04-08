using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumbersToWords.BL
{
    abstract class Expression
    {
        delegate string Number();

        public void Interpret(Context context,  List<string> stroka)
        {
            char[] subchar;
            string substring = null;
            Number num;
            if (context.Input.Length == 0)
                return;

            subchar = stroka.Last().ToCharArray();

            if(subchar[0] != '0')
            {
                switch(subchar[0])
                {
                    case '1': { substring = new string(DozenExpression.Zero()); };
                }
            }

          /*  if (context.Input.StartsWith(Nine()))
            {
                context.Output += 9 * Multiplier();
                context.Input = context.Input.Substring(2);
            }
            else if (context.Input.StartsWith(Four()))
            {
                context.Output += 4 * Multiplier();
                context.Input = context.Input.Substring(2);
            }
            else if (context.Input.StartsWith(Five()))
            {
                context.Output += 5 * Multiplier();
                context.Input = context.Input.Substring(1);
            }

            while (context.Input.StartsWith(One()))
            {
                context.Output += 1 * Multiplier();
                context.Input = context.Input.Substring(1);
            }*/
        }

        public virtual string One() { return "one"; }
        public virtual string Two() { return "two"; }
        public virtual string Three() { return "three"; }
        public virtual string Four() { return "four"; }
        public virtual string Five() { return "five"; }
        public virtual string Six() { return "six"; }
        public virtual string Seven() { return "seven"; }
        public virtual string Eight() { return "eight"; }
        public virtual string Nine() { return "nine"; }
        public virtual string Zero() { return "nine"; }
        //   public virtual int Multiplier();
    }
}
