class ChecklistGoal : Goal
{
    private int _requiredCount;
    private int _currentCount;

    public ChecklistGoal(string name, string description, int points, int requiredCount)
        : base(name, description, points)
    {
        _requiredCount = requiredCount;
        _currentCount = 0;
    }

    public override void Display()
    {
        Console.WriteLine($"[{_completed}] {_name} ({_description}) -- Currently completed: {_currentCount}/{_requiredCount}");
    }

    public override void RecordProgress()
    {
        _currentCount++;
        if (_currentCount >= _requiredCount)
        {
            Console.WriteLine("Congratulations! You have earned " + _points + " points!");
            _completed = true;
        }
        else
        {
            Console.WriteLine("Progress recorded. Keep going!");
        }
    }
}