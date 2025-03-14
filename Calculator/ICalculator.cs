using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    interface ICalculator
    {
        int Plus(int Number1, int Number2);
        int Minus(int Number1, int Number2);
        int Multiplication(int Number1, int Number2);
        int Devide(int Number1, int Number2);

    }
}
