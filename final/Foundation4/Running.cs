public class Running : Activity
{
    private double _distance;

    public Running(string date, double length, double distance) : base(date, length)
    {
        _distance = distance;
    }

    protected override double GetDistance()
    {
        return _distance;
    }
    protected override double GetSpeed()
    {
        return (_distance / _length) * 60;
    }
    protected override string GetTypeOfActivity()
    {
        return "Running";
    }
}