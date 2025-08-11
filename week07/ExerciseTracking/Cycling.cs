using System;

class Cycling : Activity
{
    private double speedKmPerHour;

    public Cycling(DateTime date, int durationMinutes, double speedKmPerHour)
        : base(date, durationMinutes)
    {
        this.speedKmPerHour = speedKmPerHour;
    }

    public override double GetSpeed() => speedKmPerHour;
    public override double GetDistance() => (speedKmPerHour * GetDuration()) / 60;
    public override double GetPace() => 60 / speedKmPerHour;
}


