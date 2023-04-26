using System;
using System.IO;
using System.Collections.Generic;

namespace PromptJournal
{
    class Entry
    {
        public string Prompt { get; set; }
        public string Response { get; set; }
        public DateTime Date { get; set; }

        public Entry(string prompt, string response, DateTime date)
        {
            Prompt = prompt;
            Response = response;
            Date = date;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Entries";
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }

            List<Entry> entries = new List<Entry>();

            while (true)
            {
                Console.WriteLine("\nMenu:\n1. Add new entry\n2. Display journal\n3. Save journal to file\n4. Load journal from file\n5. Exit");

                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Enter a prompt:");
                        string prompt = Console.ReadLine();

                        Console.WriteLine("Enter a response:");
                        string response = Console.ReadLine();

                        Entry entry = new Entry(prompt, response, DateTime.Now);
                        entries.Add(entry);

                        Console.WriteLine("Entry added.");
                        break;

                    case 2:
                        if (entries.Count == 0)
                        {
                            Console.WriteLine("No entries found.");
                            break;
                        }

                        Console.WriteLine($"Journal Entries ({entries.Count})\n");

                        foreach (Entry e in entries)
                        {
                            Console.WriteLine($"Date: {e.Date}\nPrompt: {e.Prompt}\nResponse: {e.Response}\n");
                        }

                        break;

                    case 3:
                        Console.WriteLine("Enter a filename to save the journal to:");
                        string fileName = Console.ReadLine();

                        string fullPath = Path.Combine(path, fileName);

                        using (StreamWriter writer = new StreamWriter(fullPath))
                        {
                            foreach (Entry e in entries)
                            {
                                writer.WriteLine($"Prompt: {e.Prompt}");
                                writer.WriteLine($"Response: {e.Response}");
                                writer.WriteLine($"Date: {e.Date}");
                            }
                        }

                        Console.WriteLine($"Journal saved to {fullPath}");

                        break;

                    case 4:
                        Console.WriteLine("Enter a filename to load the journal from:");
                        fileName = Console.ReadLine();

                        fullPath = Path.Combine(path, fileName);

                        if (!File.Exists(fullPath))
                        {
                            Console.WriteLine($"File {fullPath} not found.");
                            break;
                        }

                        entries.Clear();

                        using (StreamReader reader = new StreamReader(fullPath))
                        {
                            while (!reader.EndOfStream)
                            {
                                string p = reader.ReadLine().Substring(8);
                                string r = reader.ReadLine().Substring(10);
                                DateTime d = DateTime.Parse(reader.ReadLine().Substring(6));

                                Entry e = new Entry(p, r, d);
                                entries.Add(e);
                            }
                        }

                        Console.WriteLine($"Journal loaded from {fullPath}");

                        break;

                    case 5:
                        Console.WriteLine("Exiting program.");
                        return;

                    default:
                        Console.WriteLine("Invalid choice.");
                        break;
                }
            }
        }
    }
}
