using System;
using System.Collections.Generic;
using System.Linq;


namespace NumbersToWords.BL
{
     class Expression
    {
        delegate string Number();

        public string Interpret(List<string> stroka)
        {            
            if (stroka.Count == 0)
                return null;

            string substring = null;

            Validation(out char[] subchar, stroka);
            
            if (subchar[0] != '0')
            {
                substring += InterpOne(subchar[0]);
                substring += " hundred";
            }

            if (subchar[1] != '0')
            {
                if (subchar[1] == '1')
                {
                    substring+= InterpTen(subchar[2]);
                }
                else
                {
                    substring += InterpDozen(subchar[1]);                    
                }
            }

            if (subchar[1] != '1' && subchar[2] != '0')            
                substring += InterpOne(subchar[2]);
            
            if(substring != null)
                substring += CheckRank(stroka.Count);
            
            stroka.RemoveAt(0);
            return substring;
        }
        private void Validation(out char[] subchar, List<string> stroka)
        {
            subchar = stroka.First().ToCharArray();
            Array.Resize(ref subchar, 3);
            if (subchar[2] == '\0')
            {
                if (subchar[1] == '\0')
                {
                    subchar[2] = subchar[0];
                    subchar[1] = '0';
                    subchar[0] = '0';

                }
                else
                {
                    subchar[2] = subchar[1];
                    subchar[1] = subchar[0];
                    subchar[0] = '0';
                }
            }
        }

        private string CheckRank(int rank)
        {
            if(rank-1 ==3)
            {
                return " billion";
            }
            if (rank - 1 == 2)
            {
                return " million";
            }
            if (rank - 1 == 1)
            {
                return " thousand";
            }
            return null;
        }

        private string InterpTen(char subchar)
        {
            string substring = null;

                switch (subchar)
                {
                    case '0':
                        return substring += TenExpression.Zero();
                    case '1':
                        return substring += TenExpression.One();
                    case '2':
                        return substring += TenExpression.Two();
                    case '3':
                        return substring += TenExpression.Three();
                    case '4':
                        return substring += TenExpression.Four();
                    case '5':
                        return substring += TenExpression.Five();
                    case '6':
                        return substring += TenExpression.Six();
                    case '7':
                        return substring += TenExpression.Seven();
                    case '8':
                        return substring += TenExpression.Eight();
                    case '9':
                        return substring += TenExpression.Nine();
                }

            return null;
        }
        private string InterpDozen(char subchar)
        {
            string substring = null;

                switch (subchar)
                {
               
                    case '2':
                        return substring += DozenExpression.Two();
                    case '3':
                        return substring += DozenExpression.Three();
                    case '4':
                        return substring += DozenExpression.Four();
                    case '5':
                        return substring += DozenExpression.Five();
                    case '6':
                        return substring += DozenExpression.Six();
                    case '7':
                        return substring += DozenExpression.Seven();
                    case '8':
                        return substring += DozenExpression.Eight();
                    case '9':
                        return substring += DozenExpression.Nine();
                }

            return null;
        }

        private string InterpOne(char subchar)
        {
            string substring = null;
                switch (subchar)
                {
                    case '1':
                        return substring += OneExpression.One();
                    case '2':
                        return substring += OneExpression.Two();
                    case '3':
                        return substring += OneExpression.Three();
                    case '4':
                        return substring += OneExpression.Four();
                    case '5':
                        return substring += OneExpression.Five();
                    case '6':
                        return substring += OneExpression.Six();
                    case '7':
                        return substring += OneExpression.Seven();
                    case '8':
                        return substring += OneExpression.Eight();
                    case '9':
                        return substring += OneExpression.Nine();
                }

            return null;
        }
    }
}
