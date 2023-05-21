using System;
using System.Collections.Generic;
using System.IO;

// abstract class Goal
// {
//     protected string _name;
//     protected string _description;
//     protected int _points;
//     protected bool _completed;

//     public string Name
//     {
//         get { return _name; }
//         set { _name = value; }
//     }

//     public string Description
//     {
//         get { return _description; }
//         set { _description = value; }
//     }

//     public int Points
//     {
//         get { return _points; }
//         set { _points = value; }
//     }

//     public bool Completed
//     {
//         get { return _completed; }
//         set { _completed = value; }
//     }

//     public Goal(string name, string description, int points)
//     {
//         _name = name;
//         _description = description;
//         _points = points;
//         _completed = false;
//     }

//     public abstract void Display();
//     public abstract void RecordProgress();
// }

// class SimpleGoal : Goal
// {
//     public SimpleGoal(string name, string description, int points)
//         : base(name, description, points)
//     {
//     }

//     public override void Display()
//     {
//         Console.WriteLine($"[{_completed}] {_name} ({_description})");
//     }

//     public override void RecordProgress()
//     {
//         Console.WriteLine("Congratulations! You have earned " + _points + " points!");
//         _completed = true;
//     }
// }

// class EternalGoal : Goal
// {
//     public EternalGoal(string name, string description, int points)
//         : base(name, description, points)
//     {
//     }

//     public override void Display()
//     {
//         Console.WriteLine($"[ ] {_name} ({_description})");
//     }

//     public override void RecordProgress()
//     {
//         Console.WriteLine("Eternal goals cannot be marked as completed.");
//     }
// }

// class ChecklistGoal : Goal
// {
//     private int _requiredCount;
//     private int _currentCount;

//     public ChecklistGoal(string name, string description, int points, int requiredCount)
//         : base(name, description, points)
//     {
//         _requiredCount = requiredCount;
//         _currentCount = 0;
//     }

//     public override void Display()
//     {
//         Console.WriteLine($"[{_completed}] {_name} ({_description}) -- Currently completed: {_currentCount}/{_requiredCount}");
//     }

//     public override void RecordProgress()
//     {
//         _currentCount++;
//         if (_currentCount >= _requiredCount)
//         {
//             Console.WriteLine("Congratulations! You have earned " + _points + " points!");
//             _completed = true;
//         }
//         else
//         {
//             Console.WriteLine("Progress recorded. Keep going!");
//         }
//     }
// }


// class GoalTracker
// {
//     private List<Goal> _goals;
//     private int _totalPoints;

//     public GoalTracker()
//     {
//         _goals = new List<Goal>();
//         _totalPoints = 0;
//     }

//     public void CreateGoal()
//     {
//         Console.WriteLine("The types of goals available are:");
//         Console.WriteLine("1. Simple Goal");
//         Console.WriteLine("2. Eternal Goal");
//         Console.WriteLine("3. Checklist Goal");

//         Console.Write("Which type of goal would you like to create? ");
//         int goalType = int.Parse(Console.ReadLine());

//         Console.Write("What is the name of your goal? ");
//         string name = Console.ReadLine();

//         Console.Write("What is a short description of it? ");
//         string description = Console.ReadLine();

//         Console.Write("What is the amount of points associated with this goal? ");
//         int points = int.Parse(Console.ReadLine());

//         Goal goal;
//         switch (goalType)
//         {
//             case 1:
//                 goal = new SimpleGoal(name, description, points);
//                 break;
//             case 2:
//                 goal = new EternalGoal(name, description, points);
//                 break;
//             case 3:
//                 Console.Write("How many times does this goal need to be accomplished for a bonus? ");
//                 int requiredCount = int.Parse(Console.ReadLine());
//                 goal = new ChecklistGoal(name, description, points, requiredCount);
//                 break;
//             default:
//                 Console.WriteLine("Invalid goal type.");
//                 return;
//         }

//         _goals.Add(goal);
//         Console.WriteLine("Goal created successfully.");
//     }

//     public void ListGoals()
//     {
//         Console.WriteLine("The goals are:");
//         for (int i = 0; i < _goals.Count; i++)
//         {
//             Console.Write($"{i + 1}. ");
//             _goals[i].Display();
//         }

//         Console.WriteLine();
//         Console.WriteLine($"You have {_totalPoints} points.");
//     }

//     public void SaveGoals(string filename)
//     {
//         using (StreamWriter writer = new StreamWriter(filename))
//         {
//             foreach (Goal goal in _goals)
//             {
//                 writer.WriteLine($"{goal.GetType().Name},{goal.Name},{goal.Description},{goal.Points},{goal.Completed}");
//             }
//         }

//         Console.WriteLine("Goals saved successfully.");
//     }

//     public void LoadGoals(string filename)
//     {
//         if (!File.Exists(filename))
//         {
//             Console.WriteLine("File not found.");
//             return;
//         }

//         _goals.Clear();
//         _totalPoints = 0;

//         using (StreamReader reader = new StreamReader(filename))
//         {
//             string line;
//             while ((line = reader.ReadLine()) != null)
//             {
//                 string[] parts = line.Split(',');

//                 if (parts.Length < 5)
//                 {
//                     Console.WriteLine("Invalid data in file.");
//                     return;
//                 }

//                 string goalType = parts[0];
//                 string name = parts[1];
//                 string description = parts[2];
//                 int points = int.Parse(parts[3]);
//                 bool completed = bool.Parse(parts[4]);

//                 Goal goal;
//                 switch (goalType)
//                 {
//                     case nameof(SimpleGoal):
//                         goal = new SimpleGoal(name, description, points);
//                         break;
//                     case nameof(EternalGoal):
//                         goal = new EternalGoal(name, description, points);
//                         break;
//                     case nameof(ChecklistGoal):
//                         int requiredCount = int.Parse(parts[5]);
//                         goal = new ChecklistGoal(name, description, points, requiredCount);
//                         break;
//                     default:
//                         Console.WriteLine("Invalid goal type in file.");
//                         return;
//                 }

//                 goal.Completed = completed;
//                 _goals.Add(goal);
//                 if (completed)
//                 {
//                     _totalPoints += points;
//                 }
//             }
//         }

//         Console.WriteLine("Goals loaded successfully.");
//     }

//     public void RecordEvent()
//     {
//         Console.WriteLine("The goals are:");
//         ListGoals();
//         Console.Write("Which goal did you accomplish? ");
//         int choice = int.Parse(Console.ReadLine()) - 1;

//         if (choice < 0 || choice >= _goals.Count)
//         {
//             Console.WriteLine("Invalid choice.");
//             return;
//         }

//         Goal goal = _goals[choice];
//         goal.RecordProgress();
//         if (goal.Completed)
//         {
//             _totalPoints += goal.Points;
//         }
//     }
// }

class Program
{
    static void Main(string[] args)
    {
        GoalTracker goalTracker = new GoalTracker();
        string filename = "goals.txt";

        Console.WriteLine("Menu Options:");
        Console.WriteLine("1. Create New Goal");
        Console.WriteLine("2. List Goals");
        Console.WriteLine("3. Save Goals");
        Console.WriteLine("4. Load Goals");
        Console.WriteLine("5. Record Event");
        Console.WriteLine("6. Quit");

        while (true)
        {
            Console.Write("\nSelect a choice from the menu: ");
            int choice = int.Parse(Console.ReadLine());
            Console.WriteLine();

            switch (choice)
            {
                case 1:
                    goalTracker.CreateGoal();
                    break;
                case 2:
                    goalTracker.ListGoals();
                    break;
                case 3:
                    Console.Write("What is the filename for the goal file? ");
                    filename = Console.ReadLine();
                    goalTracker.SaveGoals(filename);
                    break;
                case 4:
                    Console.Write("What is the filename for the goal file? ");
                    filename = Console.ReadLine();
                    goalTracker.LoadGoals(filename);
                    break;
                case 5:
                    goalTracker.RecordEvent();
                    break;
                case 6:
                    Console.WriteLine("Goodbye!");
                    return;
                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }
        }
    }
}