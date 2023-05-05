using System;
using System.Linq;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        var scripture = new Scripture("John", 3, 16, "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life.");

        Console.Clear();
        Console.WriteLine(scripture.ToString());
        Console.WriteLine("Press enter to hide words or type 'quit' to exit.");
        string input = Console.ReadLine();

        while (input.ToLower() != "quit")
        {
            // Find words to hide
            int numWordsToHide = scripture.Words.Count / 3; // Hide 1/3 of words
            List<int> wordsToHide = Enumerable.Range(0, scripture.Words.Count)
                                               .Where(i => !scripture.Words[i].IsHidden)
                                               .OrderBy(i => Guid.NewGuid())
                                               .Take(numWordsToHide)
                                               .ToList();

            // Hide words
            foreach (var word in scripture.Words)
            {
                if (wordsToHide.Contains(word.Index))
                {
                    Console.Write(new string('_', word.Text.Length) + " ");
                    word.Hide();
                }
                else
                {
                    Console.Write(word.Text + " ");
                }
            }

            Console.WriteLine();
            Console.WriteLine("Press enter to hide more words or type 'quit' to exit.");
            input = Console.ReadLine();
        }
    }
}

// class Scripture
// {
//     public Reference Reference { get; }
//     public List<Word> Words { get; }

//     public Scripture(string book, int chapter, int verse, string text)
//     {
//         Reference = new Reference(book, chapter, verse);
//         Words = text.Split(' ')
//                     .Select((word, index) => new Word(index, word))
//                     .ToList();
//     }

//     public override string ToString()
//     {
//         return $"{Reference.ToString()} {string.Join(" ", Words.Select(word => word.Text))}";
//     }
// }

// class Word
// {
//     public int Index { get; }
//     public string Text { get; }
//     public bool IsHidden { get; private set; }

//     public Word(int index, string text)
//     {
//         Index = index;
//         Text = text;
//         IsHidden = false;
//     }

//     public void Hide()
//     {
//         IsHidden = true;
//     }
// }

// class Reference
// {
//     public string Book { get; }
//     public int Chapter { get; }
//     public int Verse { get; }

//     public Reference(string book, int chapter, int verse)
//     {
//         Book = book;
//         Chapter = chapter;
//         Verse = verse;
//     }

//     public override string ToString()
//     {
//         return $"{Book} {Chapter}:{Verse}";
//     }
// }
