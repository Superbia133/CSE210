using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        var video1 = new Video("Magic Sword Fight", "Edward Dancer", 120);
        video1.AddComment(new Comment("Alice", "This was epic!"));
        video1.AddComment(new Comment("Bob", "Loved the moves!"));
        video1.AddComment(new Comment("Eve", "So graceful and deadly."));

        var video2 = new Video("Cooking with Fire", "DragonChef", 300);
        video2.AddComment(new Comment("Lana", "I'm hungry now."));
        video2.AddComment(new Comment("Gabe", "Where can I get dragon peppers?"));
        video2.AddComment(new Comment("Nina", "🔥🔥🔥"));

        var video3 = new Video("How to Track Monsters", "Frēogan", 240);
        video3.AddComment(new Comment("Tom", "Very informative."));
        video3.AddComment(new Comment("Jerry", "This saved my village."));
        video3.AddComment(new Comment("Zara", "Can you do vampires next?"));

        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);

        foreach (var video in videos)
        {
            video.Display();
        }
    }
}
