using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumbersToWords.BL
{
    interface IInterpret
    {
        string Interpret(List<string> stroka);
        string InterpTen(char subchar);
        string InterpDozen(char subchar);
        string InterpOne(char subchar);
    }
}
