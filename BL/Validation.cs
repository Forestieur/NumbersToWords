using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumbersToWords.BL
{
    class Validation
    {
        public void LengthValidation(out char[] subchar, List<string> stroka)
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

        public string CheckRank(int rank)
        {
            switch (rank - 1)
            {
                case 3:
                    return " billion";
                case 2:
                    return " million";
                case 1:
                    return " thousand";
                default:
                    return null;
            }
        }
    }
}
