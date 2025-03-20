using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLICalculatorApp.Operations
{
    public class Cosine : IOperation
    {
        public double Execute(double a, double b)
        {
            throw new NotImplementedException("Cosine requires only one input");
        }
        public double Execute(double a)
        {
            double radians = a * (Math.PI / 180);
            return Math.Cos(radians);
        }
    }
}
