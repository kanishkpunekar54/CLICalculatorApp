using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLICalculatorApp.Operations
{
    public class SquareRoot : IOperation
    {
        double IOperation.Execute(double a)
        {
            if (a < 0)
                throw new ArgumentException("Cannot take square root of negative number");
            return Math.Sqrt(a);
        }

        double IOperation.Execute(double a, double b)
        {
            throw new NotImplementedException("Square root requires only one input ");
        }
    }
}
