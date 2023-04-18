using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter your grade percentage: ");
        int grade = int.Parse(Console.ReadLine());

        string letter;
        if (grade >= 90)
        {
            letter = "A";
            Console.WriteLine("Congratulations, you got an A!");
        }
        else if (grade >= 80)
        {
            letter = "B";
            Console.WriteLine("You got a B.");
        }
        else if (grade >= 70)
        {
            letter = "C";
            Console.WriteLine("You got a C.");
        }
        else
        {
            letter = "F";
            Console.WriteLine("You got an F. Better luck next time!");
        }

        if (grade >= 70)
        {
            Console.WriteLine("Congratulations, you passed the class!");
        }
        else
        {
            Console.WriteLine("Sorry, you did not pass the class. Keep working hard!");
        }

        Console.WriteLine("Your letter grade is: " + letter);
    }
}
