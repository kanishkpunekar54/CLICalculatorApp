using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLICalculatorApp.Strategies
{
    public class SimpleCalculatorStrategy : ICalculatorStrategy
    {
        public double Calculate(string expression)
        {
            return Calculator.Instance.EvaluateExpression(expression);
        }
    }
}
