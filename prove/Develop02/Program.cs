using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
// using System.String;

class Program
{

    static void Main(string[] args)
    {
        while (true)
        {   

            Console.Write("Please select one of the following choices:\n1. Write\n2. Display\n3. Load\n4. Save\n5. Quit\nWhat would you like to do? ");

            int choices = int.Parse(Console.ReadLine());
            string filePath = "prompts.csv";

            if (choices == 1)
            {

                PromptGenerator program = new PromptGenerator();

                program.writeToCSV();
                program.readFromCSV();

                public void writeToCSV()
                {
                    StringBuilder builder = new StringBuilder();

                    string text1 = "Text1";
                    string text2 = "Text2";

                    builder.AppendLine(string.Format("{0}|{1}", text1, text2));

                    File.WriteAllText(filePath, builder.ToString());
                }

                public void readFromCSV()
                {
                    StreamReader streamReader = new StreamReader(filePath);

                    while (!streamReader.EndOfStream)
                    {
                        var line = streamReader.ReadLine();
                        var values = line.Split();

                        Console.WriteLine("{0}", values[0]);
                    }
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
