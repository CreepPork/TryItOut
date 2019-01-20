using System;

namespace MakingACalculator
{
    internal static class Program
    {
        public static void Main()
        {
            Console.WriteLine("Basic Calculator");

            Console.WriteLine("Enter number A: ");
            double numberA = Convert.ToDouble(Console.ReadLine());
            
            Console.WriteLine("Enter number B: ");
            double numberB = Convert.ToDouble(Console.ReadLine());
            
            Console.WriteLine("Enter an operation to perform (+ - * / % ^): ");
            Console.WriteLine("    Addition (+)");
            Console.WriteLine("    Subtraction (-)");
            Console.WriteLine("    Multiplication (*)");
            Console.WriteLine("    Division (/)");
            Console.WriteLine("    Remainder (%)");
            Console.WriteLine("    Power (^)");
            string operationToPerform = Console.ReadLine();

            double result;
            switch (operationToPerform)
            {
                case "+":
                    result = numberA + numberB;
                    break;
                
                case "-":
                    result = numberA - numberB;
                    break;
                
                case "*":
                    result = numberA * numberB;
                    break;
                
                case "/":
                    result = numberA / numberB;
                    break;
                
                case "%":
                    result = numberA % numberB;
                    break;
                
                case "^":
                    result = Math.Pow(numberA, numberB);
                    break;
                
                default:
                    throw new ArgumentException($"{operationToPerform} is not a valid option!");
            }

            Console.WriteLine($"{numberA} {operationToPerform} {numberB} = {result}");
        }
    }
}