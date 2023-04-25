using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Job 1
        Job job1 = new Job();
        job1._jobTitle = "\nSoftware Engineer";
        job1._company = "Microsoft";
        job1._year = "2019-2022";
        // job1.Display();


        // Job 2
        Job job2 = new Job();
        job2._jobTitle = "Manager";
        job2._company = "Apple";
        job2._year = "2022-2023\n";
        // job2.Display();


        // Resume
        Resume resume = new Resume();
        resume._name = "Allison Rose";
        resume.jobDisplay();
    }
}
