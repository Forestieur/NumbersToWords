using System;
using System.Collections.Generic;

namespace NumbersToWords.BL
{
    class Splitting
    {
        public Splitting(string stroka, out List<string> substring)
        {
            SplitStrings(stroka, out substring);
        }

        public void SplitStrings(string stroka, out List<string> substring)
        {
            substring = new List<string>();
            if (stroka.Length % 3 == 0)
            {
                while (stroka.Length % 3 == 0 && stroka.Length != 0)
                {
                    substring.Add(stroka.Substring(0, 3));
                    stroka = stroka.Remove(0, 3);
                }
            }
            else if (stroka.Length > 3)
            {
                char[] inputarray = stroka.ToCharArray();
                Array.Reverse(inputarray);
                stroka = new string(inputarray);

                while (stroka.Length > 3)
                {
                    inputarray = stroka.Substring(0, 3).ToCharArray();
                    Array.Reverse(inputarray);
                    substring.Add(new string(inputarray));
                    stroka = stroka.Remove(0, 3);
                }
                inputarray = stroka.Substring(0, stroka.Length).ToCharArray();
                Array.Reverse(inputarray);
                substring.Add(new string(inputarray));
                substring.Reverse();
            }
            else
            {
                substring.Add(stroka.Substring(0, stroka.Length));
            }
        }
    }
}
