using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        bool dili = true; 

        while (dili == true)
        {
            Console.Write("Please input some numbers [enter 0 to end the program]: ");
            string input = Console.ReadLine();
            int lp = int.Parse(input);

            if (lp != 0)
            {
                numbers.Add(lp);
            }
            else
            {
                break;
            }
        }
        int min = numbers.Min();
        int max = numbers.Max();
        double average = numbers.Average();
        Console.WriteLine($"Min {min}, Max {max}, Average {average}");
    }
}