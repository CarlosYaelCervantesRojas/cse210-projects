public class Event
{
    protected string _title;
    private string _description;
    protected string _date;
    private string _time;
    private Address _address;

    public Event(string title, string description, string date, string time, Address address)
    {
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
        _address = address;
    }

    public void DisplayStandardDetails()
    {
        Console.WriteLine($"{_title}\n{_description}\n{_date} {_time}\n{_address.GetAddressInfo()}");
    }
}