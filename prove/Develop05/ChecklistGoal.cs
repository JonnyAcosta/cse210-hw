class ChecklistGoal : Goal
{
    private int targetCount;
    private int completedCount;

    public int TargetCount => targetCount;
    public int CompletedCount => completedCount;

    public ChecklistGoal(string name, int points, int targetCount)
    {
        Name = name;
        Points = points;
        this.targetCount = targetCount;
    }

    public override void RecordEvent()
    {
        if (!IsCompleted)
        {
            completedCount++;
            Console.WriteLine($"Recorded '{Name}'. Earned {Points} points.");

            if (completedCount == targetCount)
            {
                IsCompleted = true;
                Console.WriteLine($"Bonus: Goal '{Name}' completed {targetCount} times. Earned additional 500 points.");
            }
        }
    }
}