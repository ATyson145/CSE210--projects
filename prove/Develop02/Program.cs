using System;
using System.Collections.Generic;
using System.IO;

namespace Develop02
{
    class Program
    {
        static void Main(string[] args)
        {
            Journal journal = new Journal();
            Prompts randomPrompt = new Prompts();
            string input = string.Empty;

            Console.WriteLine("\nWelcome to the new Journal program!\n");

            while (input != "5") {

                Console.Write(@"Menu Options:
                1. Write new entry
                2. Display Journal entries
                3. Save Journal
                4. Load Journal
                5. Exit Program
                Your choice: ");
                input = Console.ReadLine();

                if (input == "1") {
                    Console.Write("\nPlease enter today's date (i.e. May 15th, 2020): ");
                    string date = Console.ReadLine();

                    string prompt = randomPrompt.GetRandomPrompt();
                    Console.WriteLine($"{prompt}");

                    Console.Write($"Enter your response here: ");
                    string response = Console.ReadLine();

                    journal.StoreEntry(prompt, response, date);
                }

                else if (input == "2") {
                    journal.DisplayEntries();
                }

                else if (input == "3") {
                    Console.Write("Enter the filename you wish to save your entries (i.e. Journal.txt): ");
                    string filename = Console.ReadLine();

                    journal.SaveJournal(filename);
                    Console.WriteLine("The entries have been saved to your file.\n");
                }

                else if (input == "4") {
                    Console.Write("Enter the filename you wish to save your entries (i.e. Journal.txt): ");
                    string filename = Console.ReadLine();

                    journal.LoadJournal(filename);
                    Console.WriteLine("The files' entries have been loaded.\n");
                }

                else if (input == "5") {

                    Console.WriteLine("Exiting the program...");

                }
                else {

                    Console.WriteLine("Input not valid. Please try again.\n");

                }
            }
        }
    }
}