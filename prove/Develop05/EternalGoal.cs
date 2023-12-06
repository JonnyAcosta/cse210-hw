class EternalGoal : Goal 
{
    public EternalGoal(string name, int points)
    {
        Name = name;
        Points = points;
    }

    public override void RecordEvent()
    {
        Console.WriteLine($"Recorded '{Name}'. Earned {Points} points.");
    }
}