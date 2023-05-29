class Expense
{
    public decimal Amount { get; set; }
    public DateTime Date { get; set; }

    public Expense(decimal amount)
    {
        Amount = amount;
        Date = DateTime.Now;
    }

    public override string ToString()
    {
        return $"{Date:yyyy-MM-dd HH:mm:ss} - {Amount}";
    }
}