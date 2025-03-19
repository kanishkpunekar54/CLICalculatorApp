using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLICalculatorApp.Operations
{
    public class NaturalLogarithm : IOperation
    {
        public double Execute(double a, double b)
        {
            throw new NotImplementedException("Natural logarithm has only one input");
        }

        public double Execute(double a)
        {
            if (a <= 0)
            {
                throw new ArgumentException("Natural logarithm of a non-positive number is not allowed");
            }
            else
            {
                return Math.Log(a);
            }
        }
    }
}
