class Activity
{
    private DateTime date;
    protected int minutes; // Changed access modifier to protected

    public Activity(DateTime date, int minutes)
    {
        this.date = date;
        this.minutes = minutes;
    }

    public virtual double GetDistance()
    {
        return 0; // Base implementation returns 0, override in derived classes
    }

    public virtual double GetSpeed()
    {
        return 0; // Base implementation returns 0, override in derived classes
    }

    public virtual double GetPace()
    {
        return 0; // Base implementation returns 0, override in derived classes
    }

    public string GetSummary()
    {
        return $"{date:dd MMM yyyy} {GetType().Name} ({minutes} min) - Distance: {GetDistance():F2} km, Speed: {GetSpeed():F2} kph, Pace: {GetPace():F2} min per km";
    }
}