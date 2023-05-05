using System;
using System.Linq;

// class Reference
// {
//     public string Book { get; set; }
//     public int Chapter { get; set; }
//     public int StartVerse { get; set; }
//     public int EndVerse { get; set; }

//     public Reference(string book, int chapter, int startVerse, int endVerse = -1)
//     {
//         Book = book;
//         Chapter = chapter;
//         StartVerse = startVerse;
//         EndVerse = endVerse;
//     }

//     public override string ToString()
//     {
//         if (EndVerse > 0)
//         {
//             return $"{Book} {Chapter}:{StartVerse}-{EndVerse}";
//         }
//         else
//         {
//             return $"{Book} {Chapter}:{StartVerse}";
//         }
//     }
// }

// class Scripture
// {
//     public Reference Reference { get; set; }
//     public string Text { get; set; }

//     public Scripture(Reference reference, string text)
//     {
//         Reference = reference;
//         Text = text;
//     }

//     public string[] GetWords()
//     {
//         return Text.Split(' ');
//     }
// }

class Program
{
    static void Main(string[] args)
    {
        Reference reference = new Reference("John", 3, 16);
        Scripture scripture = new Scripture(reference, "For aGod so bloved the cworld, that he dgave his eonly begotten fSon, that whosoever gbelieveth in him should not perish, but have heverlasting ilife.");
        string[] words = scripture.GetWords();
        int[] hiddenIndices = new int[words.Length];

        Console.Clear();
        Console.WriteLine(scripture.Reference);
        Console.WriteLine(scripture.Text);
        Console.WriteLine("Press enter to hide words or type 'quit' to exit.");
        string input = Console.ReadLine();

        while (input.ToLower() != "quit")
        {
            // Find words to hide
            int numWordsToHide = words.Length / 3; // Hide 1/3 of words
            int[] wordsToHide = Enumerable.Range(0, words.Length)
                                          .Where(i => hiddenIndices[i] == 0) // Only consider words that are not already hidden
                                          .OrderBy(i => Guid.NewGuid()) // Randomly sort the list
                                          .Take(numWordsToHide)
                                          .ToArray();
            // Hide words
            for (int i = 0; i < words.Length; i++)
            {
                if (wordsToHide.Contains(i))
                {
                    Console.Write(new string('_', words[i].Length) + " ");
                    hiddenIndices[i] = 1;
                }
                else
                {
                    Console.Write(words[i] + " ");
                }
            }

            Console.WriteLine();
            Console.WriteLine("Press enter to hide more words or type 'quit' to exit.");
            input = Console.ReadLine();
        }
    }
}
