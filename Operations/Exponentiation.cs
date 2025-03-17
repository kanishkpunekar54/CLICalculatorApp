using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLICalculatorApp.Operations
{
    public class Exponentiation : IOperation
    {
        double IOperation.Execute(double a)
        {
            throw new NotImplementedException("Exponentiation is not possible with one variable");
        }

        double IOperation.Execute(double a, double b)
        {
            return Math.Pow(a, b);
        }
    }
}
