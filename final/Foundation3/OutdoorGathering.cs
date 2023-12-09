class OutdoorGathering : Event
{
    private string weather;

    public OutdoorGathering(string title, string description, DateTime date, TimeSpan time, Address address, string weather)
    :base(title,description,date,time,address)
    {
        this.weather = weather;
    }

    public override string GenerateFullDetails()
    {
        return base.GenerateFullDetails() + $"Type: Outdoor Gathering\nWeather: {weather}";
    }
}