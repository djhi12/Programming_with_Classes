public class Resume
{

    Job job1 = new Job();
    Job job2 = new Job();
    public string _name = "";
    List<string> job = new List<string>();
    public void jobDisplay()
    {
        Console.WriteLine($"Name: {_name}\nJobs:{job1._jobTitle} {job1._company} {job1._year}\n{job2._jobTitle} {job2._company} {job2._year}\n");
    }

}