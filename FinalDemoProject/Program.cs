using System;
using System.Collections.Generic;

// class Expense
// {
//     public decimal Amount { get; set; }
//     public DateTime Date { get; set; }

//     public Expense(decimal amount)
//     {
//         Amount = amount;
//         Date = DateTime.Now;
//     }

//     public override string ToString()
//     {
//         return $"{Date:yyyy-MM-dd HH:mm:ss} - {Amount}";
//     }
// }

// class ExpenseTracker
// {
//     private List<Expense> expenses = new List<Expense>();

//     public void AddExpense(decimal amount)
//     {
//         Expense expense = new Expense(amount);
//         expenses.Add(expense);
//         Console.WriteLine("Expense added successfully!");
//     }

//     public void ViewExpenses()
//     {
//         Console.WriteLine("Expense List");
//         if (expenses.Count == 0)
//         {
//             Console.WriteLine("No expenses found.");
//         }
//         else
//         {
//             for (int i = 0; i < expenses.Count; i++)
//             {
//                 Console.WriteLine($"{i + 1}. {expenses[i]}");
//             }
//         }
//     }

//     public void CalculateTotalExpenses()
//     {
//         decimal total = 0;

//         foreach (Expense expense in expenses)
//         {
//             total += expense.Amount;
//         }

//         Console.WriteLine($"Total expenses: {total}");
//     }
// }

class Program
{
    static void Main()
    {
        ExpenseTracker expenseTracker = new ExpenseTracker();
        bool isRunning = true;

        while (isRunning)
        {
            Console.WriteLine("Expense Tracker");
            Console.WriteLine("1. Add an expense");
            Console.WriteLine("2. View all expenses");
            Console.WriteLine("3. Calculate total expenses");
            Console.WriteLine("4. Exit");

            Console.Write("Enter your choice: ");
            int choice = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();

            switch (choice)
            {
                case 1:
                    Console.Write("Enter the expense amount: ");
                    decimal amount = Convert.ToDecimal(Console.ReadLine());
                    expenseTracker.AddExpense(amount);
                    break;
                case 2:
                    expenseTracker.ViewExpenses();
                    break;
                case 3:
                    expenseTracker.CalculateTotalExpenses();
                    break;
                case 4:
                    isRunning = false;
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }

            Console.WriteLine();
        }
    }
}
