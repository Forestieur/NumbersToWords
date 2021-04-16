using System;
using System.Collections.Generic;
using System.Linq;


namespace NumbersToWords.BL
{
    class Interpter : IInterpret
    {
        public string Interpret(List<string> stroka)
        {
            Validation val = new Validation();
            if (stroka.Count == 0)
                return null;

            string substring = null;

            val.LengthValidation(out char[] subchar, stroka);

            if (subchar[0] != '0')
            {
                substring += InterpOne(subchar[0]);
                substring += " hundred";
            }

            if (subchar[1] != '0')
            {
                if (subchar[1] == '1')
                {
                    substring += InterpTen(subchar[2]);
                }
                else
                {
                    substring += InterpDozen(subchar[1]);
                }
            }

            if (subchar[1] != '1' && subchar[2] != '0')
                substring += InterpOne(subchar[2]);

            if (substring != null)
                substring += val.CheckRank(stroka.Count);

            stroka.RemoveAt(0);
            return substring;
        }
       
        public string InterpTen(char subchar)
        {
            TenExpression ten = new TenExpression();

            switch (subchar)
            {
                case '0':
                    return ten.Zero();
                case '1':
                    return ten.One();
                case '2':
                    return ten.Two();
                case '3':
                    return ten.Three();
                case '4':
                    return ten.Four();
                case '5':
                    return ten.Five();
                case '6':
                    return ten.Six();
                case '7':
                    return ten.Seven();
                case '8':
                    return ten.Eight();
                case '9':
                    return ten.Nine();
                default:
                    return null;
            }
        }

        public string InterpDozen(char subchar)
        {
            DozenExpression dozen = new DozenExpression();

            switch (subchar)
            {
                case '2':
                    return dozen.Two();
                case '3':
                    return dozen.Three();
                case '4':
                    return dozen.Four();
                case '5':
                    return dozen.Five();
                case '6':
                    return dozen.Six();
                case '7':
                    return dozen.Seven();
                case '8':
                    return dozen.Eight();
                case '9':
                    return dozen.Nine();
                default:
                    return "error";
            }

        }

        public string InterpOne(char subchar)
        {
            OneExpression one = new OneExpression();

            switch (subchar)
            {
                case '1':
                    return one.One();
                case '2':
                    return one.Two();
                case '3':
                    return one.Three();
                case '4':
                    return one.Four();
                case '5':
                    return one.Five();
                case '6':
                    return one.Six();
                case '7':
                    return one.Seven();
                case '8':
                    return one.Eight();
                case '9':
                    return one.Nine();
                default:
                    return null;
            }
        }
    }
}
