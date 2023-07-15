using System;
using System.Threading;
using System.Collections.Generic;

namespace Develop04 {
    
    public class ReflectionActivity : Activity {
        private string[] prompts = {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
        };
        private string[] questions = {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
        };
        public ReflectionActivity () : base("Reflection", @"This activity will help you reflect on times in your life when you 
have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects 
of your life.") {
        }
        protected override void PerformActivity() {
            Console.WriteLine("\nLet's start the reflection activity!");

            Random random = new Random();
            string prompt = prompts[random.Next(prompts.Length)];

            Console.WriteLine($"\nPrompt: {prompt}");
            PauseForEnter();

            Console.WriteLine("\nStarting questions...");

            DateTime startTime = DateTime.Now;
            TimeSpan elapsedTime = DateTime.Now - startTime;

            while (elapsedTime.TotalSeconds < _duration)
            {
                string question = questions[random.Next(questions.Length)];
                Console.WriteLine($"Question: {question}");
                PauseForSeconds(10);

                elapsedTime = DateTime.Now - startTime;
            }
        }
        private void PauseForEnter() {
            Console.WriteLine("Press enter to start receiving questions.");
            Console.ReadKey();
        }
    }
}