using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        Video video1 = new Video("C# Tutorial for Beginners", "Code With Me", 1200);
        video1.AddComment(new Comment("Alice", "This was super helpful!"));
        video1.AddComment(new Comment("Bob", "I finally understand classes now."));
        video1.AddComment(new Comment("Charlie", "Can you do one on inheritance next?"));
        video1.AddComment(new Comment("Matt", "Interesting tutorial."));
        videos.Add(video1);

        Video video2 = new Video("Top 10 Travel Destinations 2026", "Wanderlust TV", 540);
        video2.AddComment(new Comment("David", "Adding Japan to my list!"));
        video2.AddComment(new Comment("Emma", "The footage was amazing."));
        video2.AddComment(new Comment("Frank", "Costa Rica is underrated."));
        video2.AddComment(new Comment("Grace", "Loved this video!"));
        videos.Add(video2);

        Video video3 = new Video("How to Bake Sourdough Bread", "Kitchen Basics", 900);
        video3.AddComment(new Comment("Hannah", "My first loaf turned out great!"));
        video3.AddComment(new Comment("Ian", "What kind of flour do you recommend?"));
        video3.AddComment(new Comment("Jill", "Thanks for the tips."));
        video3.AddComment(new Comment("Lucy", "This is nice!!"));
        videos.Add(video3);

        Video video4 = new Video("Abstraction in Programming", "CS Professor", 720);
        video4.AddComment(new Comment("Kyle", "This example made it click."));
        video4.AddComment(new Comment("Linda", "Great explanation."));
        video4.AddComment(new Comment("Mike", "Looking forward to the next lesson."));
        video4.AddComment(new Comment("Nina", "Subscribed!"));
        videos.Add(video4);

        foreach (Video video in videos)
        {
            video.DisplayVideoInfo();
        }
    }
}