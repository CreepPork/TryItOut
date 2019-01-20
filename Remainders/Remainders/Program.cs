using System;

namespace Remainders
{
    internal static class Program
    {
        public static void Main()
        {
            Console.WriteLine("Remainder Calculator!");

            Console.WriteLine("Enter number A: ");
            int numberA = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter number B: ");
            int numberB = Convert.ToInt32(Console.ReadLine());

            int quotient = numberA / numberB;

            int remainder = numberA % numberB;
            
            Console.WriteLine($"{numberA} / {numberB} is {quotient} remainder {remainder}.");

            int checkValue = numberB * quotient + remainder;

            Console.WriteLine($"Check value (number A) is {checkValue}.");
        }
    }
}