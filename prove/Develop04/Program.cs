using System;
using System.Threading;
using System;
using System.Threading;

// public abstract class Activity
// {
//     protected string name;
//     protected string description;
//     protected int duration;

//     protected Activity(string name, string description)
//     {
//         this.name = name;
//         this.description = description;
//     }

//     public virtual void Start()
//     {
//         Console.WriteLine($"Starting {name}: {description}");
//         Console.Write("Enter duration in seconds: ");
//         duration = int.Parse(Console.ReadLine());
//         Console.WriteLine("Get ready to begin in 3 seconds...");
//         Thread.Sleep(3000);
//     }

//     public virtual void End()
//     {
//         Console.WriteLine($"You did a great job! You completed {name} for {duration} seconds.");
//         Console.WriteLine("Press any key to continue...");
//         Console.ReadKey();
//     }
// }

// public class BreathingActivity : Activity
// {
//     public BreathingActivity() : base("Breathing Activity", "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.")
//     {
//     }

//     public override void Start()
//     {
//         base.Start();
//         Console.WriteLine("Begin breathing...");
//         for (int i = 0; i < duration; i++)
//         {
//             if (i % 2 == 0)
//             {
//                 Console.WriteLine("Breathe in...");
//             }
//             else
//             {
//                 Console.WriteLine("Breathe out...");
//             }
//             Thread.Sleep(1000);
//         }
//     }
// }

// public class ReflectionActivity : Activity
// {
//     private readonly string[] prompts = new string[]
//     {
//         "Think of a time when you stood up for someone else.",
//         "Think of a time when you did something really difficult.",
//         "Think of a time when you helped someone in need.",
//         "Think of a time when you did something truly selfless."
//     };

//     private readonly string[] questions = new string[]
//     {
//         "Why was this experience meaningful to you?",
//         "Have you ever done anything like this before?",
//         "How did you get started?",
//         "How did you feel when it was complete?",
//         "What made this time different than other times when you were not as successful?",
//         "What is your favorite thing about this experience?",
//         "What could you learn from this experience that applies to other situations?",
//         "What did you learn about yourself through this experience?",
//         "How can you keep this experience in mind in the future?"
//     };

//     public ReflectionActivity() : base("Reflection Activity", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.")
//     {
//     }

//     public override void Start()
//     {
//         base.Start();
//         Random random = new Random();
//         string prompt = prompts[random.Next(prompts.Length)];
//         Console.WriteLine(prompt);
//         Thread.Sleep(3000);
//         foreach (string question in questions)
//         {
//             Console.WriteLine(question);
//             Thread.Sleep(3000);
//         }
//         for (int i = questions.Length; i < duration; i++)
//         {
//             Console.WriteLine("Think about the experience...");
//             Thread.Sleep(1000);
//         }
//     }
// }

// class ListingActivity : Activity
// {
//     private string prompt;

//     public ListingActivity(string name, string description, string prompt)
//         : base(name, description)
//     {
//         this.prompt = prompt;
//     }

//     public override void Start()
//     {
//         base.Start();
//         Console.WriteLine($"Prompt: {this.prompt}");
//         Console.WriteLine("Starting in:");
//         for (int i = 3; i > 0; i--)
//         {
//             Console.WriteLine(i);
//             Thread.Sleep(1000);
//         }
//         Console.WriteLine("Go!");

//         int itemCount = 0;
//         DateTime endTime = DateTime.Now.AddSeconds(duration);
//         while (DateTime.Now < endTime)
//         {
//             Console.Write("Enter an item: ");
//             string input = Console.ReadLine();
//             if (!string.IsNullOrEmpty(input))
//             {
//                 itemCount++;
//             }
//         }

//         Console.WriteLine($"You listed {itemCount} items.");
//         End();
//     }
// }


// using System;
class Program
{
    static void Main(string[] args)
    {
        int option;
        do
        {
            Console.WriteLine("Choose an activity:");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Exit");
            Console.Write("Enter your choice (1-4): ");
            option = int.Parse(Console.ReadLine());

            switch (option)
            {
                case 1:
                    Console.WriteLine("Starting Breathing Activity...");
                    BreathingActivity breathingActivity = new BreathingActivity();
                    breathingActivity.Start();
                    break;
                case 2:
                    Console.WriteLine("Starting Reflection Activity...");
                    ReflectionActivity reflectionActivity = new ReflectionActivity();
                    reflectionActivity.Start();
                    break;
                case 3:
                    Console.WriteLine("Starting Listing Activity...");
                    ListingActivity listingActivity = new ListingActivity("Listing Activity", "This activity will help you improve your memory by listing as many items as you can remember.", "Enter an item:");
                    listingActivity.Start();
                    break;
                case 4:
                    Console.WriteLine("Goodbye!");
                    break;
                default:
                    Console.WriteLine("Invalid option. Try again.");
                    break;
            }
            Console.WriteLine();
        } while (option != 4);
    }
}
