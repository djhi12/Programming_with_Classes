using System;

public class Account
{
    public List<int> _transactions = new List<int>(); // if we change this to a list...

    public void Deposit(int amount)
    {
        _transactions.Add(amount);
    }
}

class Program
{
    static void Main(string[] args)
    {
        Account savings = new Account();
        savings._balance = 50; // if we make the change above, this doesn't work anymore!
        savings.Deposit(100); // however, this approach would continue to work
    }
}