using System;

class Running : Activity
{
    private double distanceKm;

    public Running(DateTime date, int durationMinutes, double distanceKm)
        : base(date, durationMinutes)
    {
        this.distanceKm = distanceKm;
    }

    public override double GetDistance() => distanceKm;
    public override double GetSpeed() => (distanceKm / GetDuration()) * 60;
    public override double GetPace() => GetDuration() / distanceKm;
}


