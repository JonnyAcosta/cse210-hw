class Swimming : Activity
{
    private int laps;

    public int Laps
    {
        get { return laps; }
        set { laps = value; }
    }

    public override double GetDistance()
    {
        return laps * 50.0 / 1000.0;
    }

    public override double GetSpeed()
    {
        return GetDistance() / (DurationInMinutes / 60.0);
    }

    public override double GetPace()
    {
        return DurationInMinutes / GetDistance();
    }

    protected override string GetSpeedUnit()
    {
        return "kph";
    }

    protected override string GetPaceUnit()
    {
        return "min per km";
    }
}