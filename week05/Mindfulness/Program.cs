using System;

/*
Author: Osarugue Uwagboe
Project: Week 05 Mindfulness Program
EXCEEDED REQUIREMENTS:
1. Input validation - Could add try-catch around int.Parse to prevent crashes
2. File logging - Could save each session to a log.txt file
3. No repeat prompts - Could track used prompts so they don't repeat in one session
*/
class Program
{
    static void Main(string[] args)
    {
        string choice = "";
        // Loop menu until user chooses 4
        while (choice!= "4")
        {
            Console.Clear();
            Console.WriteLine("Menu Options:");
            Console.WriteLine(" 1. Start breathing activity");
            Console.WriteLine(" 2. Start reflecting activity");
            Console.WriteLine(" 3. Start listing activity");
            Console.WriteLine(" 4. Quit");
            Console.Write("Select a choice from the menu: ");
            choice = Console.ReadLine();

            // Create the correct activity object and run it
            if (choice == "1")
            {
                BreathingActivity breathing = new BreathingActivity();
                breathing.Run();
            }
            else if (choice == "2")
            {
                ReflectingActivity reflecting = new ReflectingActivity();
                reflecting.Run();
            }
            else if (choice == "3")
            {
                ListingActivity listing = new ListingActivity();
                listing.Run();
            }
        }
        Console.WriteLine("Goodbye!");
    }
}