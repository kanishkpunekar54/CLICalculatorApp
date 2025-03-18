using CLICalculatorApp.Operations;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CLICalculatorApp
{
    public static class OperationsFactory
    {
        public static IOperation GetOperation(string operation)
        {
            return operation switch
            {
                "+" => new Addition(),
                "-" => new Subtraction(),
                "*" => new Multiplication(),
                "/" => new Division(),
                "%" => new Modulo(),
                "!" => new Factorial(),
                "sqrt" => new SquareRoot(),
                "^" => new Exponentiation(),
                "sin" => new Sine(),
                "cos" => new Cosine(),
                "tan" => new Tangent(),
                "log" => new Logarithm(),
                "ln" => new NaturalLogarithm(),
                _ => throw new InvalidOperationException("Invalid operation")
            };
        }
    }
}
