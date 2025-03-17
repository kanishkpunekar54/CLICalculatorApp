using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLICalculatorApp.Strategies
{
    public interface ICalculatorStrategy
    {
        double Calculate(string expression);
    }
}