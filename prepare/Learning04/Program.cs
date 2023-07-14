using System;

namespace Learning04 {
    class Program
    {
        static void Main(string[] args)
        {


            Assignment assignment1 = new Assignment("Adam", "Math");
            Console.WriteLine(assignment1.GetSummary());

            MathAssignment assignment2 = new MathAssignment("Adam", "Circles", "Pain for Kids", "Why is a circle circular?");
            Console.WriteLine(assignment2.GetSummary());
            Console.WriteLine(assignment2.GetHomeworkList());

            WritingAssignment assignment3 = new WritingAssignment("Adam", "Fiction", "A Shrektastic Summer");
            Console.WriteLine(assignment3.GetSummary());
            Console.WriteLine(assignment3.GetWritingAssignment());
        }
    }
}