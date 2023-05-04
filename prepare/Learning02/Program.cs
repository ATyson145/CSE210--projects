using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job ();
        job1._company = "BYUI";
        job1._jobTitle = "Data Analyst";
        job1._startYear = "2022";
        job1._endYear = "2023";

        Job job2 = new Job ();
        job2._company = "Kia";
        job2._jobTitle = "Sales Rep";
        job2._startYear = "2019";
        job2._endYear = "2021";

        job1.Display();
        job2.Display();

        Resume atResume = new Resume ();
        atResume._name = "Adam Tyson";
        atResume._jobs.Add(job1);
        atResume._jobs.Add(job2);

        atResume.Display();
    }
}
