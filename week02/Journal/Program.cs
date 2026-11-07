using System;

class Program
{
    static void Main(string[] args)
    {
        Journal theJournal = new Journal();
        PromptGenerator promptGen = new PromptGenerator();
        int choice = 0;

        while (choice != 5)
        {
            Console.WriteLine("Menu:");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display the journal");
            Console.WriteLine("3. Load the journal from file");
            Console.WriteLine("4. Save the journal to file");
            Console.WriteLine("5. Quit");
            Console.Write("Select a choice from the menu: ");
            
            string response = Console.ReadLine();
            choice = int.Parse(response);

            if (choice == 1)
            {
                string prompt = promptGen.GetRandomPrompt();
                Console.WriteLine(prompt);
                Console.Write("> ");
                string userEntry = Console.ReadLine();

                Console.Write("How are you feeling today (Mood)? ");
                string userMood = Console.ReadLine();
                
                string dateText = DateTime.Now.ToShortDateString();

                Entry newEntry = new Entry();
                newEntry._date = dateText;
                newEntry._promptText = prompt;
                newEntry._entryText = userEntry;
                newEntry._mood = userMood;

                theJournal.AddEntry(newEntry);
            }
            else if (choice == 2)
            {
                theJournal.DisplayAll();
            }
            else if (choice == 3)
            {
                Console.Write("What is the filename? ");
                string filename = Console.ReadLine();
                theJournal.LoadFromFile(filename);
            }
            else if (choice == 4)
            {
                Console.Write("What is the filename? ");
                string filename = Console.ReadLine();
                theJournal.SaveToFile(filename);
            }
        }
    }
}