using System;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            // Prompt
            prompt promptQuestions = new prompt();
            
            promptQuestions._promptQuestions = List<string>();
            
            promptQuestions.Add("Who was the most interesting person I interacted with today?");
            promptQuestions.Add("What was the best part of my day?");
            promptQuestions.Add("How did I see the hand of the Lord in my life today?");
            promptQuestions.Add("What was the strongest emotion I felt today?");
            promptQuestions.Add("If I had one thing I could do over today, what would it be?");


            Console.Write("Please select one of the following choices:\n1. Write\n2. Display\n3. Load\n4. Save\n5. Quit");
            int choices = int.Parse(Console.ReadLine());

            if (choices == 1)
            {
                promptDisplay();
            }

            else if (choices == 2)
            {

            }

            else if (choices == 3)
            {

            }

            else if (choices == 4)
            {

            }

            else if (choices == 5)
            {
                break;
            }
        }
    }
}