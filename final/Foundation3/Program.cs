using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("20422 Cohasset St.","Winnetka","California","91306");
        Address address2 = new Address("20422 Cohasset St.","Winnetka","California","91306");
        Address address3 = new Address("20422 Cohasset St.","Winnetka","California","91306");

        Lecture lectureEvent = new Lecture("Social Media training","WOrking with social media",DateTime.Now.AddDays(7), new TimeSpan(14, 30, 0), address1, "Jonny Acosta", 100);
        Reception receptionEvent = new Reception("Social Media training","WOrking with social media",DateTime.Now.AddDays(14), new TimeSpan(18, 0, 0), address2, "rsvp");
        OutdoorGathering outdoorEvent = new OutdoorGathering("Social Media training","WOrking with social media",DateTime.Now.AddDays(21), new TimeSpan(16, 0, 0), address3, "Cloudy");

        Console.WriteLine("Standard Details:" + lectureEvent.GenerateStandardDetails());
        Console.WriteLine("Full Details: " + receptionEvent.GenerateFullDetails());
        Console.WriteLine("Short Description: " + outdoorEvent.GenerateShortDescription());
    }
}