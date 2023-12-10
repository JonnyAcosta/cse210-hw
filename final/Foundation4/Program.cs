using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>();

        activities.Add(new Running {Date = DateTime.Parse("09 Dec 2023"), DurationInMinutes = 30, Distance = 3.0});
        activities.Add(new StationaryBicycle {Date = DateTime.Parse("09 Dec 2023"), DurationInMinutes = 30, Speed = 15.0});
        activities.Add(new Swimming {Date = DateTime.Parse("09 Dec 2023"), DurationInMinutes = 30, Laps = 20});
        
        foreach (var activity in activities)
        {
        Console.WriteLine(activity.GetSummary());
        }
    }
}