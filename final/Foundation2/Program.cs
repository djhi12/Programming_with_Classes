using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Create some products
        Product product1 = new Product("Product 1", "P001", 10.99, 2);
        Product product2 = new Product("Product 2", "P002", 5.99, 1);

        // Create some addresses
        Address address1 = new Address("123 Main St", "City1", "State1", "USA");
        Address address2 = new Address("456 Elm St", "City2", "State2", "Canada");

        // Create some customers
        Customer customer1 = new Customer("John Doe", address1);
        Customer customer2 = new Customer("Jane Smith", address2);

        // Create orders
        Order order1 = new Order(customer1);
        order1.AddProduct(product1);
        order1.AddProduct(product2);

        Order order2 = new Order(customer2);
        order2.AddProduct(product2);

        // Display packing label, shipping label, and total price for each order
        Console.WriteLine("Order 1:");
        Console.WriteLine("Packing Label:");
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine("Shipping Label:");
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine("Total Price: $" + order1.GetTotalPrice());

        Console.WriteLine();

        Console.WriteLine("Order 2:");
        Console.WriteLine("Packing Label:");
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine("Shipping Label:");
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine("Total Price: $" + order2.GetTotalPrice());
    }
}

class Order
{
    private List<Product> products;
    private Customer customer;

    public Order(Customer customer)
    {
        products = new List<Product>();
        this.customer = customer;
    }

    public void AddProduct(Product product)
    {
        products.Add(product);
    }

    public double GetTotalPrice()
    {
        double totalPrice = 0;
        foreach (Product product in products)
        {
            totalPrice += product.GetPrice();
        }

        // Add shipping cost based on customer's location
        if (customer.GetAddress().IsInUSA())
        {
            totalPrice += 5;
        }
        else
        {
            totalPrice += 35;
        }

        return totalPrice;
    }

    public string GetPackingLabel()
    {
        string packingLabel = "";
        foreach (Product product in products)
        {
            packingLabel += "Product Name: " + product.GetName() + ", Product ID: " + product.GetProductId() + "\n";
        }
        return packingLabel;
    }

    public string GetShippingLabel()
    {
        return "Customer Name: " + customer.GetName() + "\n" + customer.GetAddress().GetFullAddress();
    }
}

class Product
{
    private string name;
    private string productId;
    private double price;
    private int quantity;

    public Product(string name, string productId, double price, int quantity)
    {
        this.name = name;
        this.productId = productId;
        this.price = price;
        this.quantity = quantity;
    }

    public double GetPrice()
    {
        return price * quantity;
    }

    public string GetName()
    {
        return name;
    }

    public string GetProductId()
    {
        return productId;
    }
}

class Customer
{
    private string name;
    private Address address;

    public Customer(string name, Address address)
    {
        this.name = name;
        this.address = address;
    }

    public string GetName()
    {
        return name;
    }

    public Address GetAddress()
    {
        return address;
    }
}

class Address
{
    private string streetAddress;
    private string city;
    private string state;
    private string country;

    public Address(string streetAddress, string city, string state, string country)
    {
        this.streetAddress = streetAddress;
        this.city = city;
        this.state = state;
        this.country = country;
    }

    public bool IsInUSA()
    {
        return country.Equals("USA");
    }

    public string GetFullAddress()
    {
        return "Street Address: " + streetAddress + "\nCity: " + city + "\nState/Province: " + state + "\nCountry: " + country;
    }
}

/*
    This program demonstrates the implementation of the classes for Product, Customer, Address, and Order. It creates two orders with multiple products and displays the packing label, shipping label, and total price for each order.

    Please note that this is just one possible implementation, and you can modify it according to your specific needs or preferences.
*/