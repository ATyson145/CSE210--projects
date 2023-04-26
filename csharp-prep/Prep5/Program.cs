using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayMessage();
        string username = Name();
        int number = Number();
        int squared = Square(number);
        Display(username, squared);
    }
    static void DisplayMessage()
    {
        Console.WriteLine("Welcome to the program!");
    }
    static string Name()
    {
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();
        return name;
    }
    static int Number()
    {
        Console.Write("Please enter your favorite number: ");
        string input = Console.ReadLine();
        int number = int.Parse(input);
        return number;
    }
    static int Square(int integer)
    {
        int square = integer * integer;
        return square;
    }
    static void Display(string username, int squared)
    {
        Console.WriteLine($"{username}, the sqaure of your number is {squared}");
    }
}