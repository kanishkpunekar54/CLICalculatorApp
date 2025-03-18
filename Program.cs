using CLICalculatorApp.Operations;

namespace CLICalculatorApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Complex CLI Calculator by Team Binary Legion: ");
                Console.WriteLine("Available Opearations");
                Console.WriteLine("1.  Addition(+)");
                Console.WriteLine("2.  Subtraction(-)");
                Console.WriteLine("3.  Multiplication(*)");
                Console.WriteLine("4.  Division(/)");
                Console.WriteLine("5.  Modulo(%)");
                Console.WriteLine("6.  Exponentiation(^)");
                Console.WriteLine("7.  Square Root (sqrt)");
                Console.WriteLine("8.  Factorial");
                Console.WriteLine("9.  Sine (sin)");
                Console.WriteLine("10. Cosine (cos)");
                Console.WriteLine("11. Tangent (tan)");
                Console.WriteLine("12. Logarithm10 (log)");
                Console.WriteLine("13. Natural Logarithm (ln)");
                Console.WriteLine("14. Custom base Logarithm (log)");

                string choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        PerformBinaryOperation("+");
                        break;
                    case "2":
                        PerformBinaryOperation("-");
                        break;
                    case "3":
                        PerformBinaryOperation("*");
                        break;
                    case "4":
                        PerformBinaryOperation("/");
                        break;
                    case "5":
                        PerformBinaryOperation("%");
                        break;
                    case "6":
                        PerformBinaryOperation("^");
                        break;
                    case "7":
                        PerformUnaryOperation("sqrt");
                        break;
                    case "8":
                        PerformUnaryOperation("!");
                        break;
                    case "9":
                        PerformUnaryOperation("sin");
                        break;
                    case "10":
                        PerformUnaryOperation("cos");
                        break;
                    case "11":
                        PerformUnaryOperation("tan");
                        break;
                    case "12":
                        PerformUnaryOperation("log");
                        break;
                    case "13":
                        PerformUnaryOperation("ln");
                        break;
                    case "14":
                        PerformBinaryOperation("log");
                        break;
                    default:
                        Console.WriteLine("Invalid Choice");
                        break;
                }
                Console.WriteLine("Do you want to perform another operation? (Y/N)");
                if (Console.ReadLine().ToUpper() != "Y") break;
            }

            static void PerformBinaryOperation(string symbol)
            {
                try
                {
                    IOperation opearation = OperationsFactory.GetOperation(symbol);

                        Console.WriteLine("Enter the first number");
                        double num1 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Enter the second number");
                        double num2 = Convert.ToDouble(Console.ReadLine());
                        double result = opearation.Execute(num1, num2);
                        Console.WriteLine($"Result: {result}");
                }
                catch (DivideByZeroException ex)
                {
                    Console.WriteLine($"Error message {ex.Message}");
                }
                catch (FormatException ex)
                {
                    Console.WriteLine($"Error message {ex.Message}");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Unexpected error {ex.Message}");
                }
            }
            static void PerformUnaryOperation(string symbol)
            {
                try
                {
                    IOperation operation = OperationsFactory.GetOperation(symbol);

                    Console.Write("Enter the number: ");
                    double num = Convert.ToDouble(Console.ReadLine());

                    double result = operation.Execute(num);
                    Console.WriteLine($"Result: {result}");
                }
                catch (FormatException ex)
                {
                    Console.WriteLine($"❌ Error: Invalid input! Please enter a valid number. ({ex.Message})");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"❌ Unexpected error: {ex.Message}");
                }
            }
        }
    }
}
