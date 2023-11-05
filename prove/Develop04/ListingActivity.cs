using System.Runtime.InteropServices;

class ListingActivity : Activity
{
    public new int Duration {get; set;}
    public ListingActivity(string name, string description)
    : base(name, description)
    {
    }

    public override void Start()
    {
        ShowStartingMessage(Duration);
        Console.WriteLine("Listing Activity is in progress... ");
        Thread.Sleep(Duration * 1000);
        ShowEndingMessage(Duration);
    }
}