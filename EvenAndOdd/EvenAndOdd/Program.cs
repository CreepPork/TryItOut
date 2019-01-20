using System;

namespace EvenAndOdd
{
    internal static class Program
    {
        public static void Main()
        {
            Console.WriteLine("Even and Odd Calculator!");

            Console.WriteLine("Enter number to check: ");
            int numberToCheck = Convert.ToInt32(Console.ReadLine());

            int remainder = numberToCheck % 2;

            Console.WriteLine(
                remainder > 0
                ? $"{numberToCheck} is an odd number."
                : $"{numberToCheck} is an even number."
            );
        }
    }
}