using System;
using System.Collections.Generic;

namespace Foundation4 {
class Program
    {
        static void Main(string[] args)
        {
            List<Activity> activities = new List<Activity>();

            activities.Add(new Running(new DateTime(2022, 11, 3), 30, 3.0));
            activities.Add(new Cycling(new DateTime(2022, 11, 3), 30, 12.0));
            activities.Add(new Swimming(new DateTime(2022, 11, 3), 30, 60));
            Console.WriteLine();
            foreach (var activity in activities)
            {
                Console.WriteLine(activity.GetSummary());
                Console.WriteLine("----------------------------");
            }
        }
    }
}