public class Lecture : Event
{
    private string _speakerName;
    private int _capacity;
    public Lecture(string title, string description, string date, string time, Address address, string speaker, int capacity) : base(title, description, date, time, address)
    {
        _speakerName = speaker;
        _capacity = capacity;
    }

    public void DisplayFullDetails()
    {
        Console.WriteLine("---------------------------------");
        DisplayStandardDetails();

        Console.WriteLine($"Type of Event: Lecture\nSpeaker: {_speakerName}\nCapacity: {_capacity}");
        Console.WriteLine("---------------------------------");
    }
    public void DisplayShortDescription()
    {

        Console.WriteLine("---------------------------------");
        Console.WriteLine($"Type of Event: Lecture\n{_title}\nDate: {_date}");
        Console.WriteLine("---------------------------------");
    }
}