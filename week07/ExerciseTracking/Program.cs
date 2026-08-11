using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Exercise> exercises = new List<Exercise>();

        exercises.Add(new RunningExercise(new DateTime(2022, 11, 3), 30, 3.0));
        exercises.Add(new CyclingExercise(new DateTime(2022, 11, 3), 45, 20.0));
        exercises.Add(new SwimmingExercise(new DateTime(2022, 11, 3), 40, 20));

        foreach (Exercise exercise in exercises)
        {
            Console.WriteLine(exercise.GetSummary());
        }
    }
}