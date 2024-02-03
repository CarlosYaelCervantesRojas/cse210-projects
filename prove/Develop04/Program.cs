using System;

// Make sure no random prompts/questions are selected until they have all been used at least once in that session.
class Program
{
    static void Main(string[] args)
    {   
        BreathingActivity breathingActivity = new BreathingActivity();
        ReflectingActivity reflectingActivity = new ReflectingActivity();
        ListingActivity listingActivity = new ListingActivity();

        int option = 0;
        while (option != 4)
        {
            Console.Clear();
            Console.WriteLine("Menu Options:\n   1. Start breathing activity\n   2. Start reflecting activity\n   3. Start listing activity\n   4. Quit");
            Console.Write("Select a choice from the menu: ");
            option = int.Parse(Console.ReadLine());

            if (option == 1)
            {
                breathingActivity.Run();         
            }
            else if (option == 2)
            {
                reflectingActivity.Run();
            }
            else if (option == 3)
            {
                listingActivity.Run();
            }
        }
    }
}