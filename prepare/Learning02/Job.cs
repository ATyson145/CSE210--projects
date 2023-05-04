using System;

public class Job 
{
    public string _company;
    public string _jobTitle;
    public int _startYear;
    public int _endYear;

    public void Display()
    {
        Console.WriteLine($"Company: {_company}, Job Title: {_jobTitle}, Employed from {_startYear} to {_endYear}.");
    }
}
