using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int userResponse = -1, total = 0, max = 0;
        float average = 0;

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        do
        {
            Console.Write("Enter number: ");
            userResponse = int.Parse(Console.ReadLine());
           
            if (userResponse != 0)
                numbers.Add(userResponse);

        } while (userResponse != 0);

        foreach (int number in numbers)
        {
            total += number;
            if (number > max)
            {
                max = number;
            }
        }

        average = (float)total / numbers.Count;

        Console.WriteLine($"The sum is: {total}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {max}");
    }
}