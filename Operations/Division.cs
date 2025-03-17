using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLICalculatorApp.Operations
{
    public class Division : IOperation
    {
        public double Execute(double a, double b)
        {
            if (b == 0)
            {
                throw new DivideByZeroException("Cannot divide by zero");
            }
            return a / b;
        }
        public double Execute(double num1)
        {
            throw new NotImplementedException("Division is not possible with one variable");
        }
    }
}
