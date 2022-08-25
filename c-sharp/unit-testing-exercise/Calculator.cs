using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator
{
    public class Calculator : CalculatorBase
    {
        public  int Add(int numb1, int numb2)
        {
            return numb1 + numb2;
        }

        public  int Subtract(int numb1, int numb2)
        {
            return numb1 - numb2;
        }

        public  int Multiply(int numb1, int numb2)
        {
            return numb1 * numb2;
        }

        public  int Divide(int numb1, int numb2)
        {
            return numb1 / numb2;
        }
    }
}
