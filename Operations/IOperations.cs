using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLICalculatorApp.Operations
{
    public interface IOperation
    {
        public double Execute(double a, double b);
        public double Execute(double a);
    }
}
