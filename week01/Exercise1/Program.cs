using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is yuor first name?");
        string firstname = Console.ReadLine();

        Console.Write("what is your last name?");
        string lastname = Console.ReadLine();

        // print(f"Your name is {lastname}, {firstname} {lastname}")
        Console.WriteLine($"your name is {lastname}, {firstname} {lastname} ");
    }
}