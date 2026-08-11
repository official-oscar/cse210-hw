using System;

public class SwimmingExercise : Exercise
{
    private int _laps;
    private const double LapLengthKm = 0.05; // 50 meters

    public SwimmingExercise(DateTime date, int minutes, int laps) 
        : base(date, minutes)
    {
        _laps = laps;
    }

    public override double GetDistance() => _laps * LapLengthKm;
    public override double GetSpeed() => (GetDistance() / Minutes) * 60;
    public override double GetPace() => Minutes / GetDistance();
}