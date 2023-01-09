using System;

public class Job
{
    public string _name = "Allison Rose";
    public string _job1 = "Software Engineer (Microsoft)";
    public int _startYear1 = 2019;
    public int _endYear1 = 2022;

    public string _job2 = "Manager (Apple)";
    public int _startYear2 = 2022;
    public int _endYear2 = 2023;



    public Job()
    {
    }

    // A method that displays the person's full name as used in eastern 
    // countries or <family name, given name>.
    public void ShowResume()
    {
        Console.WriteLine($"\nName: {_name}\nJobs:\n{_job1} {_startYear1}-{_endYear1}\n{_job2} {_startYear2}-{_endYear2}\n");
    }

}



class Program
{
    // C# Prep 5 - Functions

    static void Main(string[] args)
    {

        // Console.Write("Hello world!");
        Job resume = new Job();

        resume.ShowResume();

    }
}