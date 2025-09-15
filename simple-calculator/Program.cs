using System;

using System.Text;

namespace SimpleCalculator
{
    
   public class Program
    {
        static void Main(string[] args)
        {
            try
            {
              
                Console.WriteLine("Welcome to Simple Calculator\nEnter  your first number then press Enter:");
                double firstNumber = InputConverter.ConvertInputToNumeric(Console.ReadLine());
                Console.WriteLine("Enter  your Second number then press Enter:");
                double secondNumber = InputConverter.ConvertInputToNumeric(Console.ReadLine());
                Console.WriteLine("Enter operation like + or add number then press Enter:");
                string operation = Console.ReadLine();
                
                double result = CalculatorEngine.Calculate(operation, firstNumber, secondNumber);

                var results = new StringBuilder();

                results.AppendFormat("The value {0} {1} value {2} is equal to {3} ,", firstNumber, operation, secondNumber, result);

                Console.WriteLine(results.ToString());
            }
          catch (InvalidOperationException)
{
    Console.WriteLine("Invalid operation entered.");
    Console.WriteLine(" Valid operations are:");
    Console.WriteLine("   + or add        Addition");
    Console.WriteLine("   - or subtract   Subtraction");
    Console.WriteLine("   * or multiply   Multiplication");
    Console.WriteLine("   / or divide     Division");
}
catch (Exception ex)

{
    
    Console.WriteLine("An unexpected error occurred: " + ex.Message);
}

        }
    }
}