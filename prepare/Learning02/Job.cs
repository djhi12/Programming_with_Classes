public class Job
{
    public string _jobTitle = "";
    public string _company = "";
    public string _year = "";

    public void Display()
    {
        Console.WriteLine($"{_jobTitle} ({_company}) {_year}");
    }


}

