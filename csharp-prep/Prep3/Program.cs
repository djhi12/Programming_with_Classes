using System;

class Program
{
    static void Main()
    {
        int magicNumber = 18;
        int guess;

        while (true)
        {
            Console.Write("What is the magic number? ");
            guess = int.Parse(Console.ReadLine());

            if (guess < magicNumber)
            {
                Console.WriteLine("Higher");
            }
            else if (guess > magicNumber)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("You guessed it!");
                break;
            }
        }
    }
}
