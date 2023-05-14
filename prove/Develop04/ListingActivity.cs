class ListingActivity : Activity
{
    private string prompt;

    public ListingActivity(string name, string description, string prompt)
        : base(name, description)
    {
        this.prompt = prompt;
    }

    public override void Start()
    {
        base.Start();
        Console.WriteLine($"Prompt: {this.prompt}");
        Console.WriteLine("Starting in:");
        for (int i = 3; i > 0; i--)
        {
            Console.WriteLine(i);
            Thread.Sleep(1000);
        }
        Console.WriteLine("Go!");

        int itemCount = 0;
        DateTime endTime = DateTime.Now.AddSeconds(duration);
        while (DateTime.Now < endTime)
        {
            Console.Write("Enter an item: ");
            string input = Console.ReadLine();
            if (!string.IsNullOrEmpty(input))
            {
                itemCount++;
            }
        }

        Console.WriteLine($"You listed {itemCount} items.");
        End();
    }
}