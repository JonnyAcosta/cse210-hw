class ReflectionActivity : Activity
{
    public ReflectionActivity(string name, string description)
    : base(name, description)
    {
    }

    public override void Start()
    {
        ShowStartingMessage(0);
        Console.WriteLine("Reflection activity is in progress. ");
        Thread.Sleep(5000);
        ShowEndingMessage(0);
    }
}