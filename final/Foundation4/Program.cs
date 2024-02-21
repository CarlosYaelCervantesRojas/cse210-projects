using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>();

        Running running = new Running("22 Nov 2023", 40, 10);
        activities.Add(running);
        Cycling cycling = new Cycling("13 Sep 2023", 60, 30);
        activities.Add(cycling);
        Swimming swimming = new Swimming("05 Oct 2023", 30, 5);
        activities.Add(swimming);

        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
            Console.WriteLine();
        }
    }
}