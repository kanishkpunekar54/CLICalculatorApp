using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLICalculatorApp.Operations
{
    public class Logarithm : IOperation
    {
        double IOperation.Execute(double a, double b)
        {
            if (a <= 0 || b <= 0 || b == 1)
                throw new ArgumentException("Logarithm of a non-positive number is not allowed");
            return Math.Log((double)a, (double)b);
        }

        double IOperation.Execute(double a)
        {
            if (a <= 0)
            {
                throw new ArgumentException("Logarithm of a non-positive number is not allowed");
            }
            return Math.Log10((double)a);
        }
    }
}
