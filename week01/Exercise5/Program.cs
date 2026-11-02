using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise5 Project.");

        DisplayMessage();

        DisplayPersonalMessage();

        

        int userNumb = AddNumber();
        string userName = DisplayPersonalMessage();

        int squareUser = SquareFavoriteNumber(userNumb);

        DisplayResult(userName, squareUser);

        

        
        
         
    }
    static void DisplayMessage()
    {
        Console.WriteLine("Welcome to the program!");
    }

    static string DisplayPersonalMessage ()
    {
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();
        return name;
    }

    static int AddNumber ()
    {
        Console.WriteLine("Please enter your favorite number:");
        int youNumber = int.Parse(Console.ReadLine());
        return youNumber;
    }

    static int SquareFavoriteNumber (int squareNumb)
    {
        int square = squareNumb * squareNumb;
        return square;
    }

    static void DisplayResult (string name, int square)
    {
        Console.WriteLine($"Brother {name} the square of your number is {square}");
    }
}