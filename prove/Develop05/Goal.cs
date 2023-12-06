abstract class Goal 
{
    public string Name { get; set; }
    protected int Points {get; set; }
    protected bool IsCompleted { get; set; }

    public abstract void RecordEvent();

    public int GetPoints()
    {
        return Points;
    }

    public void Display()
    {
        Console.WriteLine($"[{(IsCompleted ? "X" : "")}] {Name}");
    }
}