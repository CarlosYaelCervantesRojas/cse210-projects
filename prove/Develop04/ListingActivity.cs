public class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts = new List<string>();

    public ListingActivity()
    {
        _name = "Listing";
        _description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";

        _prompts.Add("Who are people that you appreciate?");
        _prompts.Add("What are personal strengths of yours?");
        _prompts.Add("Who are people that you have helped this week?");
        _prompts.Add("When have you felt the Holy Ghost this month?");
        _prompts.Add("Who are some of your personal heroes?");
    }

    public void Run()
    {
        Console.Clear();

        DisplayStartingMessage();
        
        Console.Write("How long, in seconds, would you like for your session? ");
        _duration = int.Parse(Console.ReadLine());

        Console.Clear();

        if (_prompts.Count != 0)
        {
            Console.WriteLine("Get ready...");
            ShowSpinner(3);

            Console.WriteLine("\nList as many responses you can to the following prompt:\n");
            Console.Write("--- ");
            GetRandomPrompt();
            Console.Write(" ---\n");
            Console.Write("You may begin in: ");
            ShowCountDown(5);
            Console.WriteLine("\n");

            List<string> userList = GetListFromUser();

            Console.WriteLine($"You listed {userList.Count} items.");

            DisplayEndingMessage();
        }
        else
        {
            Console.WriteLine("No more prompts for this session!");
            ShowSpinner(3);
        }
    }
    private void GetRandomPrompt()
    {
        Random random = new Random();
        if (_prompts.Count != 0)
        {
            string prompt = _prompts[random.Next(0, _prompts.Count)];
            _prompts.Remove(prompt);
            Console.Write(prompt);
        }
        Console.Write("No more prompts for this session!");
    }
    private List<string> GetListFromUser()
    {
        List<string> userList = new List<string>();

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            string answer = Console.ReadLine();

            userList.Add(answer);
        }

        return userList;
    }
}