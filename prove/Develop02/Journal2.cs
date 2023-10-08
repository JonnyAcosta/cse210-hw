public class Journal2 
{
    public string Name { get; set; }

    public List<Entry2> Entries { get; set; }

    public Journal2()
    {
        Entries = new List<Entry2>();
    }
}