public class OutdoorGathering : Event
{
    private string _weather;
    public OutdoorGathering(string title, string description, string date, string time, Address address, string weather) : base(title, description, date, time, address)
    {
        _weather = weather;
    }

     public void DisplayFullDetails()
    {
        Console.WriteLine("---------------------------------");
        DisplayStandardDetails();

        Console.WriteLine($"Type of Event: Outdoor Gathering\nWeather: {_weather}");
        Console.WriteLine("---------------------------------");
    }
    public void DisplayShortDescription()
    {
        Console.WriteLine("---------------------------------");
        Console.WriteLine($"Type of Event: Outdoor Gathering\n{_title}\nDate: {_date}");
        Console.WriteLine("---------------------------------");
    }
}