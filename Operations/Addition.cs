using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLICalculatorApp.Operations
{
    public class Addition :IOperation
    {
        public double Execute(double a, double b)
        {
            return a + b;
        }
        public double Execute(double num1)
        {
            throw new NotImplementedException("Addition is not possible with one variable");
        }
    }
}
