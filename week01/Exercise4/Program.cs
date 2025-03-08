using System;
using System.Collections.Generic;
using System.Linq; // For sorting

class Program
{
    static void Main()
    {
        List<int> numbers = new List<int>();
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        while (true)
        {
            Console.Write("Enter number: ");
            string input = Console.ReadLine();
            int number;

            if (int.TryParse(input, out number))
            {
                if (number == 0) // Stop when 0 is entered
                    break;

                numbers.Add(number);
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a number.");
            }
        }

        // Core Requirements
        if (numbers.Count > 0)
        {
            int sum = numbers.Sum(); // Compute the sum
            double average = numbers.Average(); // Compute the average
            int maxNumber = numbers.Max(); // Find the largest number

            Console.WriteLine($"The sum is: {sum}");
            Console.WriteLine($"The average is: {average}");
            Console.WriteLine($"The largest number is: {maxNumber}");

            // Stretch Challenge: Find the smallest positive number
            int? smallestPositive = numbers.Where(n => n > 0).DefaultIfEmpty().Min();
            if (smallestPositive != null)
                Console.WriteLine($"The smallest positive number is: {smallestPositive}");

            // Stretch Challenge: Sort the list and display it
            numbers.Sort();
            Console.WriteLine("The sorted list is:");
            foreach (int num in numbers)
            {
                Console.WriteLine(num);
            }
        }
        else
        {
            Console.WriteLine("No numbers were entered.");
        }
    }
}
