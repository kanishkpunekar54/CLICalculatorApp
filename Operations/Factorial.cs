using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace CLICalculatorApp.Operations
{
    class Factorial : IOperation
    {
        double IOperation.Execute(double a, double b)
        {
            throw new NotImplementedException("Factorial dosent require two inputs");
        }

        double IOperation.Execute(double a)
        {
            if (a < 0)
                throw new ArgumentException("Factorial is not defined for negative numbers");
            int result = 1;
            for (int i = 1; i <= (int)a; i++)
            {
                result *= i;
            }
            return result;
        }
    }
}
