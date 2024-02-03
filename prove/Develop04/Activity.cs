public class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;

    public Activity()
    {
    
    }

    protected void DisplayStartingMessage()
    {
        Console.WriteLine($"Welcome to the {_name} Activity\n");
        Console.WriteLine($"{_description}\n");
    }
    protected void DisplayEndingMessage()
    {
        Console.WriteLine("\n\nWell done!!");
        ShowSpinner(3);
        Console.WriteLine($"\nYou have completed another {_duration} seconds of the {_name} Activity.");
        ShowSpinner(4);
    }
    protected void ShowSpinner(int seconds)
    {
        List<string> strings = new List<string>();
        strings.Add("|");
        strings.Add("/");
        strings.Add("—");
        strings.Add("\\");

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(seconds);

        int i = 0;
        while (DateTime.Now < endTime)
        {
            string s = strings[i]; 
            Console.Write(s);
            Thread.Sleep(500);
            Console.Write("\b \b");
            i++;

            if (i >= strings.Count)
            {
                i = 0;
            }
        } 
    }
    protected void ShowCountDown(int seconds)
    {
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(seconds);

        for (int i = seconds; i > 0; i--)
        {
            Console.Write(seconds);
            Thread.Sleep(1000);
            Console.Write("\b \b");

            seconds--;
        }
    }
}