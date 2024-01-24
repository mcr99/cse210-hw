using System;
using System.ComponentModel;
using System.Formats.Asn1;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();

        int uNumber = 0;

        do
        {
            Console.Write("Enter a number (0 to quit): ");
            string response = Console.ReadLine();
            uNumber = int.Parse(response);
            if (uNumber !=0 );
            {
                numbers.Add(uNumber);
            }
        } while (uNumber !=0);

        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }
        Console.WriteLine($"The sum is: {sum} ");

        float average = ((float)sum) / numbers.Count;
        Console.WriteLine($"The Average is: {average} ");

        int max = numbers[0];
        {
            
            foreach (int number in numbers)
            if (number > max)
            {
                max = number;
            }
            Console.WriteLine($"The max is: {max}");

        }
    }
}