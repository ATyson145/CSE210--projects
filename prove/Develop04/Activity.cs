using System;
using System.Threading;

namespace Develop04 {
    public abstract class Activity {
        private string _name = "";
        private string _description = "";
        protected int _duration;
        protected Activity(string name, string _description) {
            this._name = name;
            this._description = _description;
        }
        public void Start() {
            DisplayStartingMessage();
            PerformActivity();
            DisplayFinishingMessage();
        }
        protected abstract void PerformActivity();
        private void DisplayStartingMessage() {
            Console.Clear();
            Console.WriteLine($"Starting {_name} activity: ");
            Console.WriteLine(_description);
            _duration = GetDuration();
            Console.Clear();
            Console.WriteLine("Prepare to begin...");
            PauseForSeconds(3);
        }
        private void DisplayFinishingMessage() {
            Console.WriteLine("\nGood job! You have completed the activity.");
            Console.WriteLine($"You spent {_duration} seconds on {_name}.");
            PauseForSeconds(3);
        }
        private int GetDuration() {
            int duration = 0;
            bool validInput = false;
            while (!validInput) {
                Console.Write("Enter the amount of seconds you'd like to spend on this activity: ");
                string input = Console.ReadLine();
                validInput = int.TryParse(input, out duration) && duration > 0;

                if (!validInput) {
                    Console.WriteLine("Invalid input. Please enter a positive integer.");
                }
            }
            return duration;
        }
        protected void PauseForSeconds(int seconds) {
            for (int i = 0; i < seconds; i++) {
                Console.Write("/");
                Thread.Sleep(250);
                Console.Write("\b-");
                Thread.Sleep(250);
                Console.Write("\b\\");
                Thread.Sleep(250);
                Console.Write("\b|");
                Thread.Sleep(250);
                Console.Write("\b \b");
                }
            Console.WriteLine(" ");
        }
    }
}