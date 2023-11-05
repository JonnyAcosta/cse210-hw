abstract class Activity
{
    public string Name;
    public string Description;

    public int Duration { get; internal set; }

    public Activity(string name, string description)
{
    Name = name;
    Description = description;
}
public abstract void Start();
    public void ShowStartingMessage(int duration)
    {
    Console.WriteLine($"Activity:{Name}");
    Console.WriteLine($"Description: {Description}");
    Console.Write($"Please set the duration (in seconds): {duration} seconds");

    int userInputDuration = int.Parse(Console.ReadLine());
    Console.WriteLine("Prepare to begin in 3 seconds...");
    Thread.Sleep(3000);
    }
    public void ShowEndingMessage(int duration)
    {
    Console.WriteLine($"Good job");
    Console.WriteLine($"You completed the {Name} activity for {duration} seconds. ");
    Console.WriteLine($"Finishing in 3 seconds...");
    Thread.Sleep(3000);
    }
}