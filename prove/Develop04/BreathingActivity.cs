class BreathingActivity : Activity
{
    public new int Duration {get; set; }
    public BreathingActivity(string name, string description)
    : base(name, description)
    {
    }
    public override void Start()
    {
        ShowStartingMessage(Duration);
        Console.WriteLine("Breath in.");
        Thread.Sleep(Duration * 1000);
        Console.WriteLine("Breath on...");
        ShowEndingMessage(Duration);
    }
}
