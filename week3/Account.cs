using System;

public class Account
{
    // public int balance = 0;

    // public void Deposit(int amount)
    // {
    //     balance = balance + amount;
    //     Console.Write(balance);
    // }

    // public List<int> transactions = new List<int>(); // if we change this to a list...

    // public void Deposit(int amount)
    // {
    //     transactions.Add(amount);
    //     return transactions;
    // }

    // private string _title;
    // private string _firstName;
    // private string _lastName;

    // public string GetInformalSignature()
    // {
    //     return "Thanks, " + _firstName;
    // }

    // public string GetFormalSignature()
    // {
    //     return "Sincerely, " + GetFullName();
    // }

    // private string GetFullName()
    // {
    //     return _title + " " + _firstName + " " + _lastName;
    // }


    // Getters and Setters
    private string _title;
    private string _firstName;
    private string _lastName;

    public string GetFirstName()
    {
        return _firstName;
    }

    public void SetFirstName(string firstName)
    {
        _firstName = firstName;
    }


}