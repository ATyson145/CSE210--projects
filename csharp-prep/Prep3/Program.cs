using System;

class Program
{
    static void Main(string[] args)
    {
        bool game = true;

        Random randomGenerator = new Random();
        int magic_number = randomGenerator.Next(1, 101);

        while (game == true)
        {
            Console.Write("Guess the magic number! ");
            string input = Console.ReadLine();
            int guess = int.Parse(input);

            if (guess == magic_number)
            {
                Console.WriteLine("You guessed the magic number!");
                game = false;
            }
                else if (guess > magic_number)
            {
                Console.WriteLine("Too high! Guess a lower number.");
            }
                 else
            {
                Console.WriteLine("Too low. Guess a higher number.");
            }
        }
    }
}