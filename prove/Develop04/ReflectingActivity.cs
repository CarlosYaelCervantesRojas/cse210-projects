public class ReflectingActivity : Activity
{
    private List<string> _prompts = new List<string>();
    private List<string> _questions = new List<string>();

    public ReflectingActivity()
    {
        _name = "Reflecting";
        _description = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";

        _prompts.Add("Think of a time when you stood up for someone else.");
        _prompts.Add("Think of a time when you did something really difficult.");
        _prompts.Add("Think of a time when you helped someone in need.");
        _prompts.Add("Think of a time when you did something truly selfless.");
    
        _questions.Add("Why was this experience meaningful to you?");
        _questions.Add("Have you ever done anything like this before?");
        _questions.Add("How did you get started?");
        _questions.Add("How did you feel when it was complete?");
        _questions.Add("What made this time different than other times when you were not as successful?");
        _questions.Add("What is your favorite thing about this experience?");
        _questions.Add("What could you learn from this experience that applies to other situations?");
        _questions.Add("What did you learn about yourself through this experience?");
        _questions.Add("How can you keep this experience in mind in the future?");
    }

    public void Run()
    {
        if (_prompts.Count != 0)
        {
            Console.Clear();

            DisplayStartingMessage();

            Console.Write("How long, in seconds, would you like for your session? ");
            _duration = int.Parse(Console.ReadLine());

            bool enter = false;
            while (enter == false)
            {
                Console.Clear();

                Console.WriteLine("Get ready...\n\nConsider the following prompt:\n");
                Console.Write("--- ");
                DisplayPrompt();
                Console.Write(" ---\n");

                Console.WriteLine("\nWhen you have something in mind, press enter to continue.");
                string pressed = Console.ReadLine();

                if (pressed == "")
                {
                    enter = true;
                }
            }

            Console.WriteLine("Now ponder on each of the following questions as they related to this experience.");
            Console.Write("You may begin in: ");
            ShowCountDown(5);

            Console.Clear();
            int times = _duration / 5;

            for (int i = 0; i < times; i++)
            {
                Console.Write("\n> ");
                DisplayQuestions();
                ShowSpinner(5);
            }
        
            DisplayEndingMessage();
        }
        else
        {
            Console.WriteLine("There are not more prompts for this session.");
            ShowSpinner(5);
        }
    }
    private string GetRandomPrompt()
    {
        Random random = new Random();
        if (_prompts.Count != 0)
        {
            string prompt = _prompts[random.Next(0, _prompts.Count)];
            _prompts.Remove(prompt);
            return prompt;
        }
        return "";
    }
    private string GetRandomQuestion()
    {
        Random random = new Random();
        if (_questions.Count != 0)
        {
            string question = _questions[random.Next(0, _questions.Count)];
            _questions.Remove(question);   
            return question;
        }
        return "All questions answered!";
    }
    private void DisplayPrompt()
    {
        string prompt = GetRandomPrompt();
        Console.Write(prompt);
    }
    private void DisplayQuestions()
    {
        string question = GetRandomQuestion();
        Console.Write(question + " ");
    }
}