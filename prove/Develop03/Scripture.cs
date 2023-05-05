class Scripture
{
    public Reference Reference { get; }
    public List<Word> Words { get; }

    public Scripture(string book, int chapter, int verse, string text)
    {
        Reference = new Reference(book, chapter, verse);
        Words = text.Split(' ')
                    .Select((word, index) => new Word(index, word))
                    .ToList();
    }

    public override string ToString()
    {
        return $"{Reference.ToString()} {string.Join(" ", Words.Select(word => word.Text))}";
    }
}