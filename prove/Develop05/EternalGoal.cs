class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points)
        : base(name, description, points)
    {
    }

    public override void Display()
    {
        Console.WriteLine($"[ ] {_name} ({_description})");
    }

    public override void RecordProgress()
    {
        Console.WriteLine("Eternal goals cannot be marked as completed.");
    }
}