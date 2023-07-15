using System;
using System.Threading;

namespace Develop04 {
    public class BreathingActivity : Activity {
        public BreathingActivity() : base("Breathing", @"This activity will help you relax by walking your through breathing in 
        and out slowly. Clear your mind and focus on your breathing.") {
        }
        protected override void PerformActivity() {
            Console.WriteLine("Let's start the breathing activity.");

            DateTime startTime = DateTime.Now;
            TimeSpan elapsedTime;

            while (true) {
                elapsedTime = DateTime.Now - startTime;

                if (elapsedTime.TotalSeconds < _duration) {
                    if ((int)elapsedTime.TotalSeconds % 2 == 0) {
                        Console.WriteLine("Breathe in...");
                        PauseForSeconds(5);
                    }
                    else {
                        Console.WriteLine("Breathe out...");
                        PauseForSeconds(5);
                    }
                }   
                else {
            break;
        }
    }
    }
    }
}
