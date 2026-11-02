using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise1 Project.");
        Console.WriteLine("What is your first name?");
        Console.WriteLine("What is your Last name?");

        string firstName =Console.ReadLine();
        string lastName = Console.ReadLine();
        Console.WriteLine($"Your name is {lastName}, {firstName} {lastName}");
    }
}