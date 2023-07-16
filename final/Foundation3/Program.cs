using System;

namespace Foundation3 {
    class Program
    {
        static void Main(string[] args)
        {
            Address address1 = new Address("123 Main St", "Cityville", "State", "Country");
            Address address2 = new Address("456 Elm St", "Townsville", "State", "Country");
            Address address3 = new Address("789 Oak St", "Villagetown", "State", "Country");

            Lecture lecture = new Lecture("Introduction to AI", "Learn the basics of artificial intelligence", DateTime.Now.AddDays(7), TimeSpan.FromHours(10), address1, "John Doe", 50);
            Reception reception = new Reception("Networking Event", "Connect with professionals in your field", DateTime.Now.AddDays(14), TimeSpan.FromHours(18), address2, "rsvp@example.com");
            OutdoorGathering gathering = new OutdoorGathering("Summer Picnic", "Enjoy outdoor activities and food", DateTime.Now.AddDays(21), TimeSpan.FromHours(12), address3, "Sunny and warm");

            Console.WriteLine("---------------------------");
            Console.WriteLine("Standard Details:\n");
            Console.WriteLine(lecture.GetStandardDetails());
            Console.WriteLine();
            Console.WriteLine(reception.GetStandardDetails());
            Console.WriteLine();
            Console.WriteLine(gathering.GetStandardDetails());
            Console.WriteLine();

            Console.WriteLine("---------------------------");

            Console.WriteLine("Full Details:\n");
            Console.WriteLine(lecture.GetFullDetails());
            Console.WriteLine();
            Console.WriteLine(reception.GetFullDetails());
            Console.WriteLine();
            Console.WriteLine(gathering.GetFullDetails());
            Console.WriteLine();

            Console.WriteLine("---------------------------");

            Console.WriteLine("Short Description:\n");
            Console.WriteLine(lecture.GetShortDescription());
            Console.WriteLine();
            Console.WriteLine(reception.GetShortDescription());
            Console.WriteLine();
            Console.WriteLine(gathering.GetShortDescription());

        }
    }
}