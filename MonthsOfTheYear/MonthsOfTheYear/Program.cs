using System;
using System.Diagnostics.CodeAnalysis;

namespace MonthsOfTheYear
{
    internal static class Program
    {
        [SuppressMessage("ReSharper", "UnusedMember.Local")]
        private enum MonthsOfTheYear
        {
            January,
            February,
            March,
            April,
            May,
            June,
            July,
            August,
            September,
            October,
            November,
            December
        }
        
        public static void Main()
        {
            Console.WriteLine("Months of the Year!");

            Console.WriteLine("Enter a number between 1 and 12: ");
            int enteredYear = Convert.ToInt32(Console.ReadLine());

            if (enteredYear < 1 || enteredYear > 12)
            {
                throw new ArgumentOutOfRangeException($"{enteredYear} is not a valid option!");
            }

            // Subtract 1 because it's zero-based.
            MonthsOfTheYear year = (MonthsOfTheYear) enteredYear - 1;

            Console.WriteLine($"You selected {year.ToString()}.");
        }
    }
}