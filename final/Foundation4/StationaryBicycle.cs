class StationaryBicycle : Activity
{
    private double speed;

    public double Speed
    {
        get { return speed; }
        set { speed = value; }
    }

    public override double GetSpeed()
    {
        return speed;
    }

    protected override string GetSpeedUnit()
    {
        return "kph";
    }
}