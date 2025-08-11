using System;

abstract class Activity
{
    private DateTime date;
    private int durationMinutes;

    public Activity(DateTime date, int durationMinutes)
    {
        this.date = date;
        this.durationMinutes = durationMinutes;
    }

    public DateTime GetDate() => date;
    public int GetDuration() => durationMinutes;

    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();

    public virtual string GetSummary()
    {
        return $"{date:dd MMM yyyy} {GetType().Name} ({durationMinutes} min): " +
               $"Distance: {GetDistance():0.0} km, Speed: {GetSpeed():0.0} km/h, Pace: {GetPace():0.00} min/km";
    }
}


