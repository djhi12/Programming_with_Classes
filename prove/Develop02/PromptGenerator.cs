using System;
using System.IO;
using System.Text;

public class PromptGenerator
{
    string _filePath = "C:\\Programming_with_Classes\\prove\\Develop02";
    
    PromptGenerator()
    {
    }


    public void writeFile(){
        StringBuilder builder = new StringBuilder();

        string text1 = "Text1";
        string text2 = "Text2";

        builder.AppendLine(string.Format("{0} | {1}", text1, text2));

        File.WriteAllText(_filePath, builder.ToString());

    }

    public void readFile(){
        StreamReader streamReader = new StreamReader(_filePath);

        while (!streamReader.EndOfStream) {
            var line = streamReader.ReadLine();
            var values = line.Split();

            Console.WriteLine("{0}", values[0]);
        }
    }
  

}