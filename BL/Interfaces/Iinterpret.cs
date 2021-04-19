using System.Collections.Generic;

namespace NumbersToWords.BL.Interfaces
{
    interface IInterpret
    { 
        string Interpret(List<string> stroka);
        string InterpNumber(char subchar);

    }
}
