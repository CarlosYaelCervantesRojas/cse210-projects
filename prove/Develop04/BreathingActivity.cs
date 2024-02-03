public class BreathingActivity : Activity
{
    public BreathingActivity()
    {
        _name = "Breathing";
        _description = "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.";
    }

    public void Run()
    {
        Console.Clear();

        DisplayStartingMessage();

        Console.Write("How long, in seconds, would you like for your session? ");
        _duration = int.Parse(Console.ReadLine());

        Console.Clear();

        Console.WriteLine("Get ready...");
        ShowSpinner(3);

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            Console.Write("\n\nBreathe in...");
            ShowCountDown(4);
            Console.Write("\nBreathe out...");
            ShowCountDown(5);
        }

        DisplayEndingMessage();
    }
}