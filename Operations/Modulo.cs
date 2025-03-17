using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLICalculatorApp.Operations
{
    public class Modulo : IOperation
    {
        double IOperation.Execute(double a, double b)
        {
            if (b == 0)
            {
                throw new DivideByZeroException("Modulo by zero is not allowed ");

            }
            return a % b;
        }

        double IOperation.Execute(double a)
        {
            throw new NotImplementedException("Modulo requires two arguments");
        }
    }
}
