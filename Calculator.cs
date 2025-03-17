using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLICalculatorApp
{
    public sealed class Calculator
    {
        private static readonly Calculator instance = new Calculator();
        public Calculator() { }
        public static Calculator Instance
        {
            get
            {
                return instance;
            }
        }
        public double EvaluateExpression(string expression)
        {
            if (expression.Contains("/0") || expression.Contains("/ 0"))
            {
                throw new InvalidOperationException("Division by zero is not allowed");
            }
            return Convert.ToDouble(new DataTable().Compute(expression, null));
        }
    }
}
