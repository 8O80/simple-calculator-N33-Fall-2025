using System;

namespace SimpleCalculator
{
    public class CalculatorEngine
    {
        public double Calculate(string argOperation, double argFirstNumber, double argSecondNumber)
        {
            //You can use switch case also here for multiple operations or use if-else-if ladder
            double result = 0;

            switch (argOperation.ToLower())
            {
                case "+":
                case "add":
                    result = argFirstNumber + argSecondNumber;
                    break;

                case "-":
                case "subtract":
                    result = argFirstNumber - argSecondNumber;
                    break;

                case "*":
                case "multiply":
                case "x":
                    result = argFirstNumber * argSecondNumber;
                    break;

                case "/":
                case "divide":
                    result = argFirstNumber / argSecondNumber;
                    break;

                default:
                    throw new InvalidOperationException("Invalid operation.");
            }

            return result;
        }
    }
}