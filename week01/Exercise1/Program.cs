using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your name? ");
        string first = Console.ReadLine();

        Console.Write("What is your last mane? ");
        string last = Console.ReadLine();

        Console.WriteLine($"Your name is {first} , {first} {last}.");

         
    }
}