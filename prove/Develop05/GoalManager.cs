public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _score;

    public GoalManager()
    {

    }

    public void Start()
    {
        string option = "";
        while (option != "6")
        {
            DisplayPlayerInfo();

            Console.WriteLine("Menu options:\n    1. Create New Goal\n    2. List Goals\n    3. Save Goals\n    4. Load Goals\n    5. Record Event\n    6. Quit");
            Console.Write("Select a choice from the menu: ");
            option = Console.ReadLine();

            if (option == "1")
            {
                CreateGoal();
            }
            else if (option == "2")
            {
                ListGoalDetails();
            }
            else if (option == "3")
            {
                SaveGoals();
            }
            else if (option == "4")
            {
                LoadGoals();
            }
            else if (option == "5")
            {
                RecordEvent();
            }
        }
    }
    private void DisplayPlayerInfo()
    {
        Console.WriteLine($"\nYou have {_score} points.\n");
    }
    private void ListGoalNames()
    {
        Console.Clear();
        Console.WriteLine("The goals are:");
        
        foreach (Goal goal in _goals)
        {
            int index = _goals.IndexOf(goal) + 1;
            Console.WriteLine($"{index}. {goal.GetName()}");
        }
    }
    private void ListGoalDetails()
    {
        Console.Clear();
        Console.WriteLine("The goals are:");

        foreach (Goal goal in _goals)
        {
            int index = _goals.IndexOf(goal) + 1;
            Console.WriteLine($"{index}. {goal.GetDetailsString()}");
        }
    }
    private void CreateGoal()
    {
        Console.Clear();
        Console.WriteLine("The types of Goals are:\n    1. Simple Goal\n    2. Eternal Goal\n    3. Checklist Goal\n    4. Negative Goal");
        Console.Write("Wich type of goal would you like to create: ");
        int typeOfGoal = int.Parse(Console.ReadLine());

        Console.Write("What is the name of your goal? ");
        string name = Console.ReadLine();
        Console.Write("What is a short description of it? ");
        string description = Console.ReadLine();
        Console.Write("What is the amount of points associated with this goal? ");
        string points = Console.ReadLine();

        if (typeOfGoal == 1)
        {
            SimpleGoal newSimpleGoal = new SimpleGoal(name, description, points);
            _goals.Add(newSimpleGoal);
        }
        else if (typeOfGoal == 2)
        {
            EternalGoal newEternalGoal = new EternalGoal(name, description, points);
            _goals.Add(newEternalGoal);
        }
        else if (typeOfGoal == 3)
        {
            Console.Write("How many times does this goal need to be accomplished for a bonus? ");
            int target = int.Parse(Console.ReadLine());
            Console.Write("What is the bonus for accomplishing it that many times? ");
            int bonus = int.Parse(Console.ReadLine());

            CheckListGoal newCheckListGoal = new CheckListGoal(name, description, points, target, bonus);
            _goals.Add(newCheckListGoal);
        }
        else if (typeOfGoal == 4)
        {
            NegativeGoal newNegativeGoal = new NegativeGoal(name, description, points);
            _goals.Add(newNegativeGoal);
        }
    }
    private void RecordEvent()
    {
        ListGoalNames();
        
        Console.Write("Which goal did you accomplish? ");
        int numberOfGoal = int.Parse(Console.ReadLine());

        Goal goal = _goals[numberOfGoal - 1];
        if (!goal.IsComplete() && goal.ToString() != "NegativeGoal")
        {
            goal.RecordEvent();
            _score += int.Parse(goal.GetPoints());
            Console.WriteLine($"Congratulations! you have earned {goal.GetPoints()} points!");

           if (goal.IsComplete() && goal.ToString() == "CheckListGoal")
           {
                _score += goal.GetBonus();
           }
        }
        else if (!goal.IsComplete() && goal.ToString() == "NegativeGoal")
        {
            _score -= int.Parse(goal.GetPoints());
            Console.WriteLine($"You have lost {goal.GetPoints()} points!");
        }
    }
    private void SaveGoals()
    {
        Console.Clear();
        Console.Write("What is the filename for the goal file? ");
        string filename = Console.ReadLine();

        using(StreamWriter writer = new StreamWriter(filename))
        {
            writer.WriteLine(_score);

            foreach (Goal goal in _goals)
            {
                writer.WriteLine(goal.GetStringRepresentation());
            }
        }

        
    }
    private void LoadGoals()
    {
        _score = 0;
        _goals.Clear();
        Console.Clear();
        Console.Write("What is the filename for the goal file? ");
        string filename = Console.ReadLine();

        string[] lines = System.IO.File.ReadAllLines(filename);

        _score = int.Parse(lines[0]);

        foreach (string line in lines)
        {
            if (line != lines[0])
            {
                string[] parts = line.Split("|");

                string name = parts[1];
                string description = parts[2];
                string points = parts[3];
                
                if (parts[0] == "SimpleGoal")
                {
                    // SimpleGoal|name|description|points|isComplete
                    bool isComplete = bool.Parse(parts[4]);

                    SimpleGoal simpleGoal = new SimpleGoal(name, description, points);

                    if (isComplete)
                    {
                        simpleGoal.RecordEvent();
                    }
                    _goals.Add(simpleGoal);
                }
                else if (parts[0] == "EternalGoal")
                {
                    // EternalGoal|name|description|points
                    EternalGoal eternalGoal = new EternalGoal(name, description, points);
                    _goals.Add(eternalGoal);
                }
                else if (parts[0] == "CheckListGoal")
                {
                    // CheckListGoal|name|description|points|bonus|amountCompleted|target
                    int bonus = int.Parse(parts[4]);
                    int amountCompleted = int.Parse(parts[5]);
                    int target = int.Parse(parts[6]);

                    CheckListGoal checkListGoal = new CheckListGoal(name, description, points, target, bonus);

                    for (int i = 0; i < amountCompleted; i++)
                    {
                        checkListGoal.RecordEvent();
                    }

                    _goals.Add(checkListGoal);
                }
                else if (parts[0] == "NegativeGoal")
                {
                    // NegativeGoal|name|description|points
                    NegativeGoal negativeGoal = new NegativeGoal(name, description, points);
                    _goals.Add(negativeGoal);
                }
            }
        }
    }
}