using System;

namespace PositiveOrNegative
{
    internal static class Program
    {
        public static void Main()
        {
            // We are disallowed to use actual multiplication to get the answer.
            Console.WriteLine("Calculator to check if multiplication result is positive or negative.");

            Console.WriteLine("Enter number A: ");
            int numberA = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Enter number B: ");
            int numberB = Convert.ToInt32(Console.ReadLine());

            if (numberA == 0 || numberB == 0)
            {
                Console.WriteLine($"{numberA} times {numberB} results in 0 which is neither a positive or a negative number.");
                return;
            }

            if (numberA > 0)
            {
                Console.WriteLine(
                    numberB > 0
                    ? $"{numberA} times {numberB} results in a positive number."
                    : $"{numberA} times {numberB} results in a negative number."
                );
            }
            else
            {
                Console.WriteLine(
                    numberB > 0
                    ? $"{numberA} times {numberB} results in a negative number."
                    : $"{numberA} times {numberB} results in a positive number."
                );
            }
        }
    }
}