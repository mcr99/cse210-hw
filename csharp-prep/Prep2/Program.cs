using System;
using System.Diagnostics;
using System.Reflection.Metadata;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter your Porcentage: ");
        string Porcentage = Console.ReadLine();

        int x = int.Parse(Porcentage);
        string letter = "";

        if (x >= 90)
        {
            letter = "A" ;
        }

        else if ( x >= 80 )
        {
            letter = "B";
        }
        
        else if ( x >= 70 )
        {
            letter = "C";
        }

        else if ( x>= 60 )
        {
            letter = "D";
        }

        else 
        {
            letter = "F";
        }

        Console.WriteLine($"Your grade is: {letter}");

        if ( x >= 70 )
        {
            Console.WriteLine("You passed!");
        }
        else
        {
            Console.WriteLine("You Will get it next time! ");
        }
    }
}