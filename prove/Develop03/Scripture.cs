class Scripture
{
    public Reference Reference { get; set; }
    public string Text { get; set; }

    public Scripture(Reference reference, string text)
    {
        Reference = reference;
        Text = text;
    }

    public string[] GetWords()
    {
        return Text.Split(' ');
    }
}