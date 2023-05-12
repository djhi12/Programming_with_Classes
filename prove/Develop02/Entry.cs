class Entry
{
    public string EntryPrompt { get; set; }
    public string Response { get; set; }
    public DateTime Date { get; set; }

    public Entry(string prompt, string response, DateTime date)
    {
        EntryPrompt = prompt;
        Response = response;
        Date = date;
    }
}