using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise2 Project.");
        

        Console.WriteLine("What is your grade percentage?");
        string gradePercentage = Console.ReadLine();
        int grade = int.Parse(gradePercentage);

        string letter = "";
        string sign = "";

        int plusOrLess = grade % 10;
         

        if (grade >= 90)
        {
            letter= "A";
            
        }
        else if (grade >= 80)
        {
            letter= "B";
        }
        else if (grade >= 70)
        {
            letter= "C";
        }
        else if (grade >= 60)
        {
            letter= "D";
        }
        else
        {
            letter= "F";
        }

        if (letter != "F")
        {
            if (plusOrLess >=7)
            {
                sign = "+";
            }
            else if (plusOrLess <3)
            {
                sign = "-";
            }
        }
        if (letter == "A" && sign == "+")
        {
            sign = ""; 
        }
        if (grade >= 70)
        {
            Console.WriteLine($"Congratulations you have passed this course, your grade was {letter} {sign}");
        }
        else
        {
            Console.WriteLine($"Sorry you not pass this course, we encourage you for next time, your grade was {letter} {sign}");
        }
        

    }
}