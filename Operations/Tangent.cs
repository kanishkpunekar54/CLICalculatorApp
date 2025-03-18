using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLICalculatorApp.Operations
{
    public class Tangent : IOperation
    {
        double IOperation.Execute(double a, double b)
        {
            throw new NotImplementedException("Tangent requires only one input ");
        }

        double IOperation.Execute(double a)
        {
            return Math.Tan(a);
        }
    }
}
