class GoalTracker
{
    private List<Goal> _goals;
    private int _totalPoints;

    public GoalTracker()
    {
        _goals = new List<Goal>();
        _totalPoints = 0;
    }

    public void CreateGoal()
    {
        Console.WriteLine("The types of goals available are:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");

        Console.Write("Which type of goal would you like to create? ");
        int goalType = int.Parse(Console.ReadLine());

        Console.Write("What is the name of your goal? ");
        string name = Console.ReadLine();

        Console.Write("What is a short description of it? ");
        string description = Console.ReadLine();

        Console.Write("What is the amount of points associated with this goal? ");
        int points = int.Parse(Console.ReadLine());

        Goal goal;
        switch (goalType)
        {
            case 1:
                goal = new SimpleGoal(name, description, points);
                break;
            case 2:
                goal = new EternalGoal(name, description, points);
                break;
            case 3:
                Console.Write("How many times does this goal need to be accomplished for a bonus? ");
                int requiredCount = int.Parse(Console.ReadLine());
                goal = new ChecklistGoal(name, description, points, requiredCount);
                break;
            default:
                Console.WriteLine("Invalid goal type.");
                return;
        }

        _goals.Add(goal);
        Console.WriteLine("Goal created successfully.");
    }

    public void ListGoals()
    {
        Console.WriteLine("The goals are:");
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.Write($"{i + 1}. ");
            _goals[i].Display();
        }

        Console.WriteLine();
        Console.WriteLine($"You have {_totalPoints} points.");
    }

    public void SaveGoals(string filename)
    {
        using (StreamWriter writer = new StreamWriter(filename))
        {
            foreach (Goal goal in _goals)
            {
                writer.WriteLine($"{goal.GetType().Name},{goal.Name},{goal.Description},{goal.Points},{goal.Completed}");
            }
        }

        Console.WriteLine("Goals saved successfully.");
    }

    public void LoadGoals(string filename)
    {
        if (!File.Exists(filename))
        {
            Console.WriteLine("File not found.");
            return;
        }

        _goals.Clear();
        _totalPoints = 0;

        using (StreamReader reader = new StreamReader(filename))
        {
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                string[] parts = line.Split(',');

                if (parts.Length < 5)
                {
                    Console.WriteLine("Invalid data in file.");
                    return;
                }

                string goalType = parts[0];
                string name = parts[1];
                string description = parts[2];
                int points = int.Parse(parts[3]);
                bool completed = bool.Parse(parts[4]);

                Goal goal;
                switch (goalType)
                {
                    case nameof(SimpleGoal):
                        goal = new SimpleGoal(name, description, points);
                        break;
                    case nameof(EternalGoal):
                        goal = new EternalGoal(name, description, points);
                        break;
                    case nameof(ChecklistGoal):
                        int requiredCount = int.Parse(parts[5]);
                        goal = new ChecklistGoal(name, description, points, requiredCount);
                        break;
                    default:
                        Console.WriteLine("Invalid goal type in file.");
                        return;
                }

                goal.Completed = completed;
                _goals.Add(goal);
                if (completed)
                {
                    _totalPoints += points;
                }
            }
        }

        Console.WriteLine("Goals loaded successfully.");
    }

    public void RecordEvent()
    {
        Console.WriteLine("The goals are:");
        ListGoals();
        Console.Write("Which goal did you accomplish? ");
        int choice = int.Parse(Console.ReadLine()) - 1;

        if (choice < 0 || choice >= _goals.Count)
        {
            Console.WriteLine("Invalid choice.");
            return;
        }

        Goal goal = _goals[choice];
        goal.RecordProgress();
        if (goal.Completed)
        {
            _totalPoints += goal.Points;
        }
    }
}