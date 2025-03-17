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
                    case "6":
                        PerformBinaryOperation("^");
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
        }
    }
}
