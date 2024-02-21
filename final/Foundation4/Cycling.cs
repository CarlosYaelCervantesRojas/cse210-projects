public class Cycling : Activity
{
    private double _speed;

    public Cycling(string date, double length, double speed) : base(date, length)
    {
        _speed = speed;
    }

    protected override double GetDistance()
    {
        return (_speed * _length) / 60;
    }
    protected override double GetSpeed()
    {
        return _speed;
    }
    protected override string GetTypeOfActivity()
    {
        return "Cycling";
    }
}