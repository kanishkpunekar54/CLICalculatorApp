using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLICalculatorApp.Operations
{
    public class Tangent : IOperation
    {
        public double Execute(double a, double b)
        {
            throw new NotImplementedException("Tangent requires only one input ");
        }

        public double Execute(double a)
        {
            return Math.Tan(a);
        }
    }
}
