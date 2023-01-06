using System;
using System.Linq;
using System.Collections.Generic;

class Program
{
    // C# Prep 5 - Functions
    static void MyMethod(){
        Console.Write($"Welcome to the Program!\n");

        Console.Write($"Please enter your name: ");
        string userName = Console.ReadLine();

        Console.Write($"Please enter your favorite number: ");
        string favoriteNum = Console.ReadLine();
        int favNum = int.Parse(favoriteNum);

        int squareNum = favNum * favNum;


        Console.Write($"{userName}, the square of your number is {squareNum}");




    }
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
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 101);
        // Console.Write($"\n\nWhat is the magic number? ");
        // string magicNumber = Console.ReadLine();
        // int magicNum = int.Parse(magicNumber);

        while (true) {
            

            Console.Write($"\nWhat is your guess? ");
            string guess = Console.ReadLine();
            int guessNum = int.Parse(guess);

            if(number > guessNum) {
                Console.Write($"Higher\n");
            }

            else if (number < guessNum) {
                Console.Write($"Lower\n");
            }

            else if (number == guessNum) {
                Console.Write($"You guessed it!\n");
                break;
            }
            
        }


        // C# Prep 4 - Lists
        Console.Write($"\n\nEnter a list of numbers, type 0 when finished.\n");
        List<int> numbers = new List<int>();
        int enterNumber = -1;
        

        while (true) {

            Console.Write($"Enter a number: ");
            string enterNum = Console.ReadLine();
            enterNumber = int.Parse(enterNum);
            numbers.Add(enterNumber);
            numbers.Sort();

            if (enterNumber == 0) {
                int sum = numbers.AsQueryable().Sum(); // Sum
                double average = Queryable.Average(numbers.AsQueryable()); // average
                int larg_num = numbers.Max(); // largest
                long smallNum = numbers.AsQueryable().Min();

                Console.Write($"\nThe sum is: {sum}\n");
                Console.Write($"The average is: {Math.Round(average, 3)}\n");
                Console.Write($"The largest number is: {larg_num}\n");
                // Console.Write($"The smallest number is: {smallNum}\n");
                // Console.WriteLine($"The sorted list is: {string.Join(" ", numbers)}\n\n");
                Console.WriteLine($"The sorted list is: ");
                for(int i = 0; i < numbers.Count; i++){
                    Console.WriteLine(numbers[i]);
                }
                break;

            }   
            
        }

        // C# Prep 5 - Functions
        MyMethod();
        



    }
}
