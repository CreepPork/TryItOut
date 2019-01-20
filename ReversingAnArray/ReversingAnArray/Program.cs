using System;
using System.Collections.Generic;

namespace ReversingAnArray
{
    internal static class Program
    {
        public static void Main()
        {
            Console.WriteLine("Reversing an Array!");
            
            int[] numbers = GenerateNumbers();
            PrintNumbers(numbers);
            numbers = Reverse(numbers);
            PrintNumbers(numbers);
        }
        
        private static int[] GenerateNumbers()
        {
            return new[] {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
        }

        private static int[] Reverse(IReadOnlyList<int> numbers)
        {
            int reversedIndex = 9;
            int[] reversedArray = new int[10];
            
            for (int index = 0; index < numbers.Count; index++)
            {
                reversedArray[index] = numbers[reversedIndex--];
            }

            return reversedArray;
        }

        private static void PrintNumbers(IEnumerable<int> numbers)
        {
            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }
        }
    }
}