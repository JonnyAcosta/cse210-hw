class SimpleGoal : Goal
{
    public SimpleGoal(string name, int points)
    {
        Name = name;
        Points = points;
    }

    public override void RecordEvent()
    {
       if (!IsCompleted)
       {
        IsCompleted = true;
        Console.WriteLine($"Goal '{Name}' completed! Earned {Points} points.");
       } 
    }
}