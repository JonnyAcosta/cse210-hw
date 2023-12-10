class Activity
{
    public DateTime Date { get; set;}
    public int DurationInMinutes { get; set; }

    public virtual double GetDistance()
    {
        return 0.0;
    }
    public virtual double GetSpeed()
    {
        return 0.0;
    }

    public virtual double GetPace()
    {
        return 0.0;
    }

    public virtual string GetSummary()
    {
        return $"{Date: dd MMM yyyy} {GetType().Name} ({DurationInMinutes}min):" +
        $"Distance: {GetDistance():F1}km, Speed {GetSpeed():F1} kph, Pace: {GetPace():F1} min per km";
    }

    protected virtual string GetSpeedUnit()
    {
        return "units";
    }

    protected virtual string GetPaceUnit()
    {
        return "units";
    }
}