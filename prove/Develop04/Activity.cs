public abstract class Activity
{
    protected string name;
    protected string description;
    protected int duration;

    protected Activity(string name, string description)
    {
        this.name = name;
        this.description = description;
    }

    public virtual void Start()
    {
        Console.WriteLine($"Starting {name}: {description}");
        Console.Write("Enter duration in seconds: ");
        duration = int.Parse(Console.ReadLine());
        Console.WriteLine("Get ready to begin in 3 seconds...");
        Thread.Sleep(3000);
    }

    public virtual void End()
    {
        Console.WriteLine($"You did a great job! You completed {name} for {duration} seconds.");
        Console.WriteLine("Press any key to continue...");
        Console.ReadKey();
    }
}