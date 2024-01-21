using System;

// Improve the process of saving and loading to save as a .csv file that could be opened in Excel
class Program
{
    static void Main(string[] args)
    {
        PromptGenerator prompts = new PromptGenerator();
        Journal theJournal = new Journal();

        prompts._prompts.Add("What is something that I learned today?");
        prompts._prompts.Add("What could I have done better today?");
        prompts._prompts.Add("What challenge have you overcome in your life?");
        prompts._prompts.Add("What is something you would like to learn?");
        prompts._prompts.Add("What is your favorite topic to talk about?");

        int choice = 0;
        while (choice != 5)
        {
            Console.WriteLine("Welcome to the Journal Program!");
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write\n2. Display\n3. Load\n4. Save\n5. Quit");
            Console.Write("What would you like to do? ");
            choice = int.Parse(Console.ReadLine());

            if (choice == 1)
            {

                Entry newEntry = new Entry();
                string prompt = prompts.GetRandomPrompt();
                
                Console.WriteLine(prompt);
                Console.Write("> ");

                DateTime currentTime = DateTime.Now;
                
                newEntry._date = currentTime.ToShortDateString();
                newEntry._promptText = prompt;
                newEntry._entryText  = Console.ReadLine();
                
                theJournal.AddEntry(newEntry);

            } 
            else if (choice == 2)
            {

               theJournal.DisplayAll();

            }
            else if (choice == 3)
            {

                Console.WriteLine("What is the filename?");

                string fileName = "";
                try
                {
                    fileName = Console.ReadLine();
                    theJournal.LoadFromFile(fileName);
                }
                catch (System.IO.FileNotFoundException)
                {
                    Console.WriteLine($"No such file: {fileName}");
                }
               
            }
            else if (choice == 4)
            {

                 Console.WriteLine("What is the filename?");

                string fileName;
                fileName = Console.ReadLine();
                theJournal.SaveToFile(fileName);

            }

        }
    }
}