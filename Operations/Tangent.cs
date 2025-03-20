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
            throw new NotImplementedException("Tangent requires only one input");
        }

        public double Execute(double a)
        {
            // Convert degrees to radians
            double radians = a * (Math.PI / 180);

            // Check if the input is an odd multiple of 90 degrees
            if (Math.Abs(a % 180 - 90) < 1e-10)
            {
                return double.PositiveInfinity;
            }

            return Math.Tan(radians);
        }
    }
}

