using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Calculator : ICalculator
    {
        public int Devide(int Number1, int Number2)
        {
            return Number1 / Number2;
        }

        public int Minus(int Number1, int Number2)
        {
            return Number1 - Number2;
        }

        public int Multiplication(int Number1, int Number2)
        {
            return Number1 * Number2;
        }

        public int Plus(int Number1, int Number2)
        {
            return Number1 + Number2;
        }
    }
}
