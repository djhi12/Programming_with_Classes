public class BreathingActivity : Activity
{
    public BreathingActivity() : base("Breathing Activity", "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.")
    {
    }

    public override void Start()
    {
        base.Start();
        Console.WriteLine("Begin breathing...");
        for (int i = 0; i < duration; i++)
        {
            if (i % 2 == 0)
            {
                Console.WriteLine("Breathe in...");
            }
            else
            {
                Console.WriteLine("Breathe out...");
            }
            Thread.Sleep(1000);
        }
    }
}