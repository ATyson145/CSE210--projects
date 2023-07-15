using System;
using System.Collections.Generic;
using System.Threading;

namespace Develop04 {
    public class ListeningActivity : Activity {
        private string[] prompts = {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };
    public ListeningActivity() : base ("Listening", @"This activity will help you reflect on the good things in your life by 
    having you list as many things as you can in a certain area.") {
    }
        protected override void PerformActivity()
        {
            Console.WriteLine("Let's star the listening activity.");
            Random random = new Random();
            int promptIndex = random.Next(0, prompts.Length);
            Console.WriteLine(prompts[promptIndex]);
            PauseForSeconds(4);

            Console.WriteLine("Start listing what comes to mind: ");
            List<string> items = new List<string>();
            DateTime startTime = DateTime.Now;
            while((DateTime.Now - startTime).TotalSeconds < _duration) {
                string item = Console.ReadLine();
                items.Add(item);
            }
            Console.WriteLine($"You listed {items.Count} items.");
        }
    }
}