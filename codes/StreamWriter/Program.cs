using System.IO;

string filePath = "example.txt";
string textToWrite = "Hello, world!";

using (StreamWriter writer = new StreamWriter(filePath))
{
    writer.Write(textToWrite);
}
