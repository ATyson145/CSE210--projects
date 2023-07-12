using System;
using System.Collections.Generic;

namespace Develop02
{
    public class Prompts
    {
        public List<string> prompts;
        Random rnd = new Random();

        public Prompts()
        {
            prompts = new List<string>();
            prompts.Add("What is your favorite color? ");
            prompts.Add("What is your favorite food? ");
            prompts.Add("What was your first pet? ");
            prompts.Add("How was your day? ");
            prompts.Add("Where did you go today? ");
            prompts.Add("Who was the most interesting person I interacted with today? ");
            prompts.Add("What was the best part of my day? ");
            prompts.Add("What was the strongest emotion I felt today? ");
            prompts.Add("If I had one thing I could do over today, what would it be? ");
            
        }
        public string GetRandomPrompt()
        {
            int numberOf = prompts.Count;
            int index = rnd.Next(0,numberOf);
            return prompts [index];
        }
            

    }
}
