using System;

namespace Develop04 {
    public class Menu {
        public void DisplayMenu() {
            Console.Clear();
            Console.WriteLine("Welcome to the Mindfulness App");
            Console.WriteLine("----------------");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. Listening Activity");
            Console.WriteLine("----------------");
        }
        public void RunMenu() {
            DisplayMenu();
            Console.Write("Enter you choice (1-3): ");
            string choice = Console.ReadLine();
            Console.WriteLine("----------------");

            Activity activity;
            switch (choice) {

                case "1":   
                    activity = new BreathingActivity();
                    activity.Start();
                    break;

                case "2":
                    activity = new ReflectionActivity();
                    activity.Start();
                    break;

                case "3":
                    activity = new ListeningActivity();
                    activity.Start();
                    break;

                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;

            }

            Console.WriteLine("----------------");
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
            Console.Clear();

        }
    }
}