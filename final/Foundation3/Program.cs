using System;

// Address class to store the event address
// class Address
// {
//     public string Street { get; set; }
//     public string City { get; set; }
//     public string State { get; set; }
//     public string Country { get; set; }

//     public Address(string street, string city, string state, string country)
//     {
//         Street = street;
//         City = city;
//         State = state;
//         Country = country;
//     }
// }

// Base Event class
// class Event
// {
//     private string title;
//     private string description;
//     private DateTime date;
//     private TimeSpan time;
//     private Address address;

//     public Event(string title, string description, DateTime date, TimeSpan time, Address address)
//     {
//         this.title = title;
//         this.description = description;
//         this.date = date;
//         this.time = time;
//         this.address = address;
//     }

//     public string GetStandardDetails()
//     {
//         return $"Title: {title}\nDescription: {description}\nDate: {date.ToShortDateString()}\nTime: {time}\nAddress: {GetAddress()}";
//     }

//     public virtual string GetFullDetails()
//     {
//         return GetStandardDetails();
//     }

//     public virtual string GetShortDescription()
//     {
//         return $"Type: Generic Event\nTitle: {title}\nDate: {date.ToShortDateString()}";
//     }

//     private string GetAddress()
//     {
//         return $"{address.Street}, {address.City}, {address.State}, {address.Country}";
//     }
// }

// Lecture class derived from Event
// class Lecture : Event
// {
//     private string speaker;
//     private int capacity;

//     public Lecture(string title, string description, DateTime date, TimeSpan time, Address address, string speaker, int capacity)
//         : base(title, description, date, time, address)
//     {
//         this.speaker = speaker;
//         this.capacity = capacity;
//     }

//     public override string GetFullDetails()
//     {
//         return $"{base.GetFullDetails()}\nType: Lecture\nSpeaker: {speaker}\nCapacity: {capacity}";
//     }
// }

// Reception class derived from Event
// class Reception : Event
// {
//     private string email;

//     public Reception(string title, string description, DateTime date, TimeSpan time, Address address, string email)
//         : base(title, description, date, time, address)
//     {
//         this.email = email;
//     }

//     public override string GetFullDetails()
//     {
//         return $"{base.GetFullDetails()}\nType: Reception\nEmail for RSVP: {email}";
//     }
// }

// OutdoorGathering class derived from Event
// class OutdoorGathering : Event
// {
//     private string weather;

//     public OutdoorGathering(string title, string description, DateTime date, TimeSpan time, Address address, string weather)
//         : base(title, description, date, time, address)
//     {
//         this.weather = weather;
//     }

//     public override string GetFullDetails()
//     {
//         return $"{base.GetFullDetails()}\nType: Outdoor Gathering\nWeather: {weather}";
//     }
// }

class Program
{
    static void Main()
    {
        // Create instances of each event type
        var lecture = new Lecture(
            "Public Speaking 101",
            "Learn the art of public speaking from experts.",
            new DateTime(2023, 6, 15),
            new TimeSpan(14, 0, 0),
            new Address("123 Main St", "New York", "NY", "USA"),
            "John Doe",
            50);

        var reception = new Reception(
            "Networking Mixer",
            "Connect with professionals in your industry.",
            new DateTime(2023, 7, 10),
            new TimeSpan(18, 30, 0),
            new Address("456 Elm St", "San Francisco", "CA", "USA"),
            "rsvp@example.com");

        var outdoorGathering = new OutdoorGathering(
            "Summer BBQ",
            "Enjoy delicious food and fun activities.",
            new DateTime(2023, 8, 20),
            new TimeSpan(12, 0, 0),
            new Address("789 Oak St", "Los Angeles", "CA", "USA"),
            "Sunny");

        // Generate marketing messages for each event
        Console.WriteLine("Lecture:");
        Console.WriteLine(lecture.GetStandardDetails());
        Console.WriteLine(lecture.GetFullDetails());
        Console.WriteLine(lecture.GetShortDescription());
        Console.WriteLine();

        Console.WriteLine("Reception:");
        Console.WriteLine(reception.GetStandardDetails());
        Console.WriteLine(reception.GetFullDetails());
        Console.WriteLine(reception.GetShortDescription());
        Console.WriteLine();

        Console.WriteLine("Outdoor Gathering:");
        Console.WriteLine(outdoorGathering.GetStandardDetails());
        Console.WriteLine(outdoorGathering.GetFullDetails());
        Console.WriteLine(outdoorGathering.GetShortDescription());
    }
}

/*
In this program, we define an Address class to store the address information. The Event class serves as the base class for all event types and contains common attributes and methods. The derived classes Lecture, Reception, and OutdoorGathering extend the Event class and provide specific implementations for the GetFullDetails() method.

In the Main method, we create instances of each event type and set their values. Then, we call the various methods to generate the marketing messages and output the results to the console.
*/