using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string input = Console.ReadLine();
        int grade = int.Parse(input);

        string letter;

        if (grade >= 90) {
            letter = "A";
            Console.WriteLine($"You got an {letter}!");
        }
        else if (grade >= 80) {
            letter = "B";
            Console.WriteLine($"You got an {letter}!");
        }
        else if (grade >= 70) {
            letter = "C";
            Console.WriteLine($"You got an {letter}!");
        }
        else if (grade >= 60) {
            letter = "D";
            Console.WriteLine($"You got an {letter}!");
        }
        else if (grade < 60) {
            letter = "F";
            Console.WriteLine($"You got an {letter}!");
        }

        if (grade >= 70) {
            Console.WriteLine("You passed!!!");
        }
        else if (grade < 70) {
            Console.WriteLine("You failed the class. Please try again.");
        }
    }
}