using System.Collections.Generic;
using System.Linq;

using NumbersToWords.BL.Interfaces;

namespace NumbersToWords.BL
{
    class Interpter : IInterpret
    {
        private IExpression expression;

        public string Interpret(List<string> stroka)
        {
            Validation val = new Validation();
            if (stroka.Count == 0)
                return null;

            string substring = null;
          
            val.LengthValidation(out char[] subchar, stroka);


            if (subchar[0] != '0')
            {
                expression = new OneExpression();
                substring += InterpNumber(subchar[0]);
             
                substring += " hundred";
            }
           
            if (subchar[1] != '0')
            {
                if (subchar[1] == '1')
                {
                    expression = new TenExpression();
                    substring += InterpNumber(subchar[2]);

                }
                else
                {
                    expression = new DozenExpression();
                    substring += InterpNumber(subchar[1]);

                }
            }

            if (subchar[1] != '1' && subchar[2] != '0')
            {
                expression = new OneExpression();
                substring += InterpNumber(subchar[2]);

            }
            

            if (substring != null)
                substring += val.CheckRank(stroka.Count);

            stroka.RemoveAt(0);
            return substring;
        }

        public string InterpNumber(char subchar)
        {
            switch (subchar)
            {
                case '0':
                    return expression.Zero();
                case '1':
                    return expression.One();
                case '2':
                    return expression.Two();
                case '3':
                    return expression.Three();
                case '4':
                    return expression.Four();
                case '5':
                    return expression.Five();
                case '6':
                    return expression.Six();
                case '7':
                    return expression.Seven();
                case '8':
                    return expression.Eight();
                case '9':
                    return expression.Nine();
                default:
                    return " error";
            }
        }
    }
}
