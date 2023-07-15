using System;
using System.Collections.Generic;
using System.Threading;

namespace Develop04
{
    public class ExerciseActivity : Activity
    {
        private string[] _exercises = {
            "Push-ups",
            "Sit-ups",
            "Pull-ups",
            "Burpees",
            "Wall sit",
            "Squats",
            "Plank",
        };
        public ExerciseActivity() : base("Exercise", "This activity will guide you through exercises to improve your physical well-being.")
        {
        }

        protected override void PerformActivity()
        {
            Console.WriteLine("Let's start the exercise activity!");

            Random random = new Random();

            DateTime startTime = DateTime.Now;
            TimeSpan elapsedTime = DateTime.Now - startTime;
            int remainingSeconds = _duration;

            while (remainingSeconds > 0) {
                string exercise = _exercises[random.Next(_exercises.Length)];
                Console.WriteLine($"Exercise: {exercise}");
                PauseForSeconds(10);
                elapsedTime = DateTime.Now - startTime;
                remainingSeconds = _duration - (int)elapsedTime.TotalSeconds;
            }
        }
    }
}