using System;
using System.Collections.Generic;

namespace ExerciseTrackingApp
{
    // class Activity
    // {
    //     private DateTime date;
    //     protected int minutes; // Changed access modifier to protected

    //     public Activity(DateTime date, int minutes)
    //     {
    //         this.date = date;
    //         this.minutes = minutes;
    //     }

    //     public virtual double GetDistance()
    //     {
    //         return 0; // Base implementation returns 0, override in derived classes
    //     }

    //     public virtual double GetSpeed()
    //     {
    //         return 0; // Base implementation returns 0, override in derived classes
    //     }

    //     public virtual double GetPace()
    //     {
    //         return 0; // Base implementation returns 0, override in derived classes
    //     }

    //     public string GetSummary()
    //     {
    //         return $"{date:dd MMM yyyy} {GetType().Name} ({minutes} min) - Distance: {GetDistance():F2} km, Speed: {GetSpeed():F2} kph, Pace: {GetPace():F2} min per km";
    //     }
    // }

    // class Running : Activity
    // {
    //     private double distance;

    //     public Running(DateTime date, int minutes, double distance) : base(date, minutes)
    //     {
    //         this.distance = distance;
    //     }

    //     public override double GetDistance()
    //     {
    //         return distance;
    //     }

    //     public override double GetSpeed()
    //     {
    //         return (distance / minutes) * 60;
    //     }

    //     public override double GetPace()
    //     {
    //         return minutes / distance;
    //     }
    // }

    // class Cycling : Activity
    // {
    //     private double speed;

    //     public Cycling(DateTime date, int minutes, double speed) : base(date, minutes)
    //     {
    //         this.speed = speed;
    //     }

    //     public override double GetSpeed()
    //     {
    //         return speed;
    //     }

    //     public override double GetDistance()
    //     {
    //         return speed * (minutes / 60.0);
    //     }

    //     public override double GetPace()
    //     {
    //         return 60 / speed;
    //     }
    // }

    // class Swimming : Activity
    // {
    //     private int laps;

    //     public Swimming(DateTime date, int minutes, int laps) : base(date, minutes)
    //     {
    //         this.laps = laps;
    //     }

    //     public override double GetDistance()
    //     {
    //         return laps * 50 / 1000.0; // Distance in kilometers
    //     }

    //     public override double GetSpeed()
    //     {
    //         return (GetDistance() / minutes) * 60;
    //     }

    //     public override double GetPace()
    //     {
    //         return minutes / GetDistance();
    //     }
    // }

    class Program
    {
        static void Main(string[] args)
        {
            List<Activity> activities = new List<Activity>();

            activities.Add(new Running(new DateTime(2022, 11, 3), 30, 3.0));
            activities.Add(new Cycling(new DateTime(2022, 11, 3), 30, 6.0));
            activities.Add(new Swimming(new DateTime(2022, 11, 3), 30, 20));

            foreach (Activity activity in activities)
            {
                Console.WriteLine(activity.GetSummary());
            }
        }
    }
}

/*
This program defines a base class Activity and derived classes Running, Cycling, and Swimming. The base class contains attributes and methods common to all activities, and the derived classes provide additional attributes and override the calculation methods.

In the Main method, we create instances of each activity type and add them to a list. Then, we iterate over the list and call the GetSummary method on each activity to
*/