public class Swimming : Activity
{
    private double _laps;

    public Swimming(string date, double length, double laps) : base(date, length)
    {
        _laps = laps;
    }

    protected override double GetDistance()
    {
        return (_laps * 50) / 1000;
    }
    protected override double GetSpeed()
    {
        return (GetDistance() / _length) * 60;
    }
    protected override string GetTypeOfActivity()
    {
        return "Swimming";
    }
}