class ExpenseTracker
{
    private List<Expense> expenses = new List<Expense>();

    public void AddExpense(decimal amount)
    {
        Expense expense = new Expense(amount);
        expenses.Add(expense);
        Console.WriteLine("Expense added successfully!");
    }

    public void ViewExpenses()
    {
        Console.WriteLine("Expense List");
        if (expenses.Count == 0)
        {
            Console.WriteLine("No expenses found.");
        }
        else
        {
            for (int i = 0; i < expenses.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {expenses[i]}");
            }
        }
    }

    public void CalculateTotalExpenses()
    {
        decimal total = 0;

        foreach (Expense expense in expenses)
        {
            total += expense.Amount;
        }

        Console.WriteLine($"Total expenses: {total}");
    }
}