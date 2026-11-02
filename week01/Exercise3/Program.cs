using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise3 Project.");
        

        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 101);

        int guess = -1;

        while (guess != number)
        {
            Console.WriteLine(" What is the magic number?");
            guess = int.Parse(Console.ReadLine());

            if (number < guess)
            {
                Console.WriteLine("Lower");
            }
            else if (number > guess)
            {
                Console.WriteLine("Higher");
            }
            else
            {
                Console.WriteLine("You guessed it!");
            }
        }
    }
}