class Reception : Event
{
    private string rsvp;

    public Reception(string title, string description, DateTime date, TimeSpan time, Address address, string rsvp)
    : base(title, description, date, time, address)
    {
        this.rsvp = rsvp;
    }

    public override string GenerateFullDetails()
    {
        return base.GenerateFullDetails() + $"Type: Reception RSVP Email: {rsvp}";
    }
}