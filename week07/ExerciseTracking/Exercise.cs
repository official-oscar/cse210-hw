using System;

public abstract class Exercise
{
    private DateTime _date;
    private int _minutes;

    public Exercise(DateTime date, int minutes)
    {
        _date = date;
        _minutes = minutes;
    }

    protected int Minutes { get { return _minutes; } }
    protected string Date { get { return _date.ToString("dd MMM yyyy"); } }

    public abstract double GetDistance(); // km
    public abstract double GetSpeed(); // kph
    public abstract double GetPace(); // min per km

    public virtual string GetSummary()
    {
        return $"{Date} {this.GetType().Name.Replace("Exercise", "")} ({_minutes} min)- " +
               $"Distance {GetDistance():F1} km, " +
               $"Speed: {GetSpeed():F1} kph, " +
               $"Pace: {GetPace():F2} min per km";
    }
}