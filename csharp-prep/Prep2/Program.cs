using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string input = Console.ReadLine();
        float grade_percentage = float.Parse(input);  

        string letter = "";
        if (grade_percentage >= 90)
        {
            letter = "A";
        }
        else if (grade_percentage >= 80)
        {
            letter = "B";
        }
        else if (grade_percentage >= 70)
        {
            letter = "C";
        }
        else if (grade_percentage >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        Console.WriteLine($"Your letter grade is a {letter}");

        if (grade_percentage < 70)
        {
            Console.WriteLine("You did not pass the class");
        }
        else
        {
            Console.WriteLine("You passed the class!");
        }
    }
}