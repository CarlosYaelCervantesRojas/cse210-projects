public class Reception : Event
{
    private string _email;
    public Reception(string title, string description, string date, string time, Address address, string email) : base(title, description, date, time, address)
    {
        _email = email;
    }

    public void DisplayFullDetails()
    {
        Console.WriteLine("---------------------------------");
        DisplayStandardDetails();

        Console.WriteLine($"Type of Event: Reception\nEmail for RSVP: {_email}");
        Console.WriteLine("---------------------------------");
    }
    public void DisplayShortDescription()
    {
        Console.WriteLine("---------------------------------");
        Console.WriteLine($"Type of Event: Reception\n{_title}\nDate: {_date}");
        Console.WriteLine("---------------------------------");
    }
}