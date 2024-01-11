using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>(); 
        int number = -1;
        int sum = 0;
        double average = 0;
        int maximum;
        int smallestPositive = 99999999;

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        while (number != 0)
        {
            Console.Write("Enter number: ");
            number = int.Parse(Console.ReadLine());
            if (number != 0)
            {
                numbers.Add(number);
            }
        }


        foreach (int num in numbers)
        {
            sum += num;
        }

        // sum = numbers.Sum(); <- it could works too.
        average = numbers.Average();
        maximum = numbers.Max();

        foreach (int num in numbers)
        {
            if (num < smallestPositive && num > 0)
            {
                smallestPositive = num;
            }
        }

        numbers.Sort();


        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {maximum}");
        Console.WriteLine($"The smallest positive number is: {smallestPositive}");
        Console.WriteLine("The sorted list is:");
        numbers.ForEach(Console.WriteLine);

    }
}