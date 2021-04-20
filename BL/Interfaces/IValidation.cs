using System.Collections.Generic;

namespace NumbersToWords.BL.Interfaces
{
    interface IValidation
    {
        string CheckRank(int rank);
        void LengthValidation(out char[] subchar, List<string> stroka);
    }
}
