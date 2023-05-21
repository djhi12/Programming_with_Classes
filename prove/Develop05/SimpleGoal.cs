class SimpleGoal : Goal
{
    public SimpleGoal(string name, string description, int points)
        : base(name, description, points)
    {
    }

    public override void Display()
    {
        Console.WriteLine($"[{_completed}] {_name} ({_description})");
    }

    public override void RecordProgress()
    {
        Console.WriteLine("Congratulations! You have earned " + _points + " points!");
        _completed = true;
    }
}