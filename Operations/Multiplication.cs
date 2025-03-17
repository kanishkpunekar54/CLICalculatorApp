using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLICalculatorApp.Operations
{
    public class Multiplication : IOperation
    {
        public double Execute(double a, double b)
        {
            return a * b;
        }
        public double Execute(double num1)
        {
            throw new NotImplementedException("Multiplication is not possible with one variable");
        }
    }
}
