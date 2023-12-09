class Event
{
    private string title;
    private string description;
    private DateTime date;
    private TimeSpan time;
    private Address address;

    public Event(string title, string description, DateTime date, TimeSpan time, Address address)
    {
        this.title = title;
        this.description = description;
        this.date = date;
        this.time = time;
        this.address = address;
    }

    public string GenerateStandardDetails()
    {
        return $"Event Tile: {title}\nDescription: {description}\nDate: {date.ToShortDateString()} Time: {time} Address: {address}";
    }

    public virtual string GenerateFullDetails()
    {
        return GenerateStandardDetails();
    }

    public virtual string GenerateShortDescription()
    {
        return $"Type: {GetType().Name} Event Title: {title} Date: {date.ToShortDateString()}";
    }
}