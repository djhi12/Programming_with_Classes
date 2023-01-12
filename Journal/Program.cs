using System;
using System.Collections.Generic;
using System.IO;
class Program
{
    static void Main(string[] args)
    {
        while (true)
        {

            Console.Write("Please select one of the following choices:\n1. Write\n2. Display\n3. Load\n4. Save\n5. Quit\nWhat would you like to do? ");

            int choices = int.Parse(Console.ReadLine());

            if (choices == 1)
            {
                string filename = "listQuestions.txt";
                string[] lines = System.IO.File.ReadAllLines(filename);

                foreach (string line in lines)
                {
                    string[] parts = line.Split(",");

                    string firstName = parts[0];
                    string lastName = parts[1];
                }

                using (StreamWriter outputFile = new StreamWriter(filename))
                {
                    // You can add text to the file with the WriteLine method
                    outputFile.WriteLine("This will be the first line in the file.");

                    // You can use the $ and include variables just like with Console.WriteLine
                    string color = "Blue";
                    outputFile.WriteLine($"My favorite color is {color}");
                }

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