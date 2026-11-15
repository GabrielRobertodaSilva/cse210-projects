using System;

class Program
{
    static void Main(string[] args)
    {
        

        Reference reference = new Reference("Proverbs", 3, 5, 6);

        
        string scriptureText = "Trust in the Lord with all thine heart and lean not unto thine own understanding";

        
        Scripture scripture = new Scripture(reference, scriptureText);

        
        string userInput = "";

        while (userInput != "quit" && !scripture.IsCompletelyHidden())
        {
            Console.Clear();
            
            
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine();
            
            Console.WriteLine("Press enter to continue or type 'quit' to finish:");
            userInput = Console.ReadLine().Trim().ToLower();

           
            if (userInput != "quit")
            {
                scripture.HideRandomWords(3); 
            }
        }

        
        Console.Clear();
        Console.WriteLine(scripture.GetDisplayText());
        Console.WriteLine("\nProgram ended.");
    }
}