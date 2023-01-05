using System;

class Program
{
    static void Main(string[] args)
    {

        // C# Prep 1 - Variables, Input, and Output 

        Console.Write("What is your first name? ");
        string firstName = Console.ReadLine();

        Console.Write("What is your last name? ");
        string lastName = Console.ReadLine();

        Console.Write($"\nYour name is {lastName}, {firstName} {lastName}.\n");


        // C# Prep 2 - Conditionals
        Console.Write($"\nPrep 2 - Conditionals \n");
        Console.Write("Type the grade percentage: ");
        string percentageGrade = Console.ReadLine();

        int percentGrade = int.Parse(percentageGrade);

        string letter = "";
        

        if (percentGrade >= 90) {
            Console.Write($"{letter = "A"}");

            if (letter == "A") {
                Console.Write($"\nGreat job!");
            }
        }
        else if (percentGrade >= 80) {
            Console.Write($"{letter = "B"}");

            if (letter == "B") {
                Console.Write($"\nWell done!\n");
            }
        }
        else if (percentGrade >= 70) {
            Console.Write($"{letter = "C"}");

            if (letter == "C") {
                Console.Write($"\nYou passed!");
            }
        }
        else if (percentGrade >= 60) {
            Console.Write($"{letter = "D"}");

            if (letter == "C") {
                Console.Write($"\nDo you best next time!");
            }
        }
        else {
            Console.Write($"F\nDo your best next time!\n");
        }


        // C# Prep 3 - Loops

        while (true) {
            Console.Write($"\n\nWhat is the magic number? ");
            string magicNumber = Console.ReadLine();
            int magicNum = int.Parse(magicNumber);

            Console.Write("What is your guess? ");
            string guess = Console.ReadLine();
            int guessNum = int.Parse(guess);

            if(magicNum > guessNum) {
                Console.Write($"Higher\n");
            }

            else if (magicNum < guessNum) {
                Console.Write($"Lower\n");
            }

            else if (magicNum == guessNum) {
                Console.Write($"You guessed it!\n");
                break;
            }
            
        }




    }
}
