public class Activity
{
    protected string _date;
    protected double _length;

    public Activity(string date, double length)
    {
        _date = date;
        _length = length;
    }

    protected virtual double GetDistance()
    {
        return 0.0;
    }
    protected virtual double GetSpeed()
    {
        return 0.0;
    }
    protected double GetPace()
    {
        return _length / GetDistance();
    }
    protected virtual string GetTypeOfActivity()
    {
        return "";
    }
    public string GetSummary()
    {
        return $"{_date} {GetTypeOfActivity()} ({_length} min) - Distance: {GetDistance()} km, Speed: {GetSpeed()} kph, Pace: {GetPace()} min per km";
    }
}