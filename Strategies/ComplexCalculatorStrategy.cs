using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLICalculatorApp.Strategies
{
    class ComplexCalculatorStrategy : ICalculatorStrategy
    {
        public double Calculate(string expression)
        {
            //extend for complex calculation strategy

            return Calculator.Instance.EvaluateExpression(expression);
        }
    }
}
