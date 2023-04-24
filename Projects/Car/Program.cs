using System;

namespace MyNamespace
{

    class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car();
            myCar.make = "Honda";
            myCar.model = "Civic";
            myCar.year = 2022;
            myCar.Accelerate();

            Console.WriteLine(myCar.make);

        }
    }
}
