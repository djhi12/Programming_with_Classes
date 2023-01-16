using System;

public class PromptGenerator
{
    string filePath = "prompts.csv";

    PromptGenerator()
    {

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