using System;
using System.Collections.Generic;
using System.Threading;

public class Activity
{
    private string _name;
    private string _description;
    protected int _duration;

    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }

    public void DisplayStartingMessage()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_name} Activity");
        Console.WriteLine();
        Console.WriteLine(_description);
        Console.WriteLine();
        Console.Write("How long, in seconds, would you like for your session? ");
        _duration = int.Parse(Console.ReadLine()); // Get user input and store it

        Console.WriteLine("Prepare to begin...");
        ShowSpinner(3); // Pause with animation
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine("Well done!!");
        ShowSpinner(3);
        Console.WriteLine($"You have completed another {_duration} seconds of the {_name} Activity.");
        ShowSpinner(3);
    }

    public void ShowSpinner(int seconds)
    {
        List<string> spinner = new List<string> { "|", "/", "-", "\\" };
        DateTime endTime = DateTime.Now.AddSeconds(seconds);
        int i = 0;
        while (DateTime.Now < endTime) // Loop until time is up
        {
            Console.Write(spinner[i]);
            Thread.Sleep(250); // Wait 0.25 seconds
            Console.Write("\b \b"); // Erase the character to animate
            i = (i + 1) % spinner.Count; // Cycle through spinner list
        }
    }

    // Animation: Countdown 5, 4, 3, 2, 1
    public void ShowCountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000); // Wait 1 second
            Console.Write("\b \b"); // Erase the number
        }
    }
}