class Word
{
    public int Index { get; }
    public string Text { get; }
    public bool IsHidden { get; private set; }

    public Word(int index, string text)
    {
        Index = index;
        Text = text;
        IsHidden = false;
    }

    public void Hide()
    {
        IsHidden = true;
    }
}