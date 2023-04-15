using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Console.Write("Hello");
        // Account account = new Account();
        // account.balance = 50;
        // account.Deposit(100);

        // account.Deposit(100);


        // account.balance = 50; // if we make the change above, this doesn't work anymore!
        // account.Deposit(100); // however, this approach would continue to work


        //     private List<int> transactions = new List<int>();

        // public void Deposit(int amount)
        //     {
        //      transactions.Add(amount);
        //     }


        // private string _title;
        // private string _firstName;
        // private string _lastName;

        // account.GetInformalSignature();



        // Getter and Setters
        // Person p = new Person();
        // p.SetFirstName("Peter");

        // Console.WriteLine(p.GetFirstName());
        // Create a list of strings  
        var countries = new List<string>();
        countries.Add("India");
        countries.Add("Australia");
        countries.Add("Japan");
        countries.Add("Canada");
        countries.Add("Mexico");

        // Iterate list element using foreach loop  
        foreach (var country in countries)
        {
            Console.WriteLine(country[0]);
        }
        Console.ReadLine();
        Console.Clear();



    }
}