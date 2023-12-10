class Running : Activity
{
    private double distance;

    public double Distance
    {
        get { return distance; }
        set {distance = value;}
    }

    public override double GetDistance()
    {
        return distance;
    }

    public override double GetSpeed()
    {
        return distance / (DurationInMinutes / 60.0);
    }

    public override double GetPace()
    {
        return DurationInMinutes / distance;
    }

    protected override string GetSpeedUnit()
    {
        return "mph";
    }

    protected override string GetPaceUnit()
    {
        return "min per mile";
    }
}