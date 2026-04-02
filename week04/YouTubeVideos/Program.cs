using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        // Video 1
        Video v1 = new Video("Learning C# Basics", "Tech Guru", 600);
        v1.AddComment(new Comment("Alice", "Great explanation!"));
        v1.AddComment(new Comment("Bob", "Very helpful."));
        v1.AddComment(new Comment("Chris", "I finally understand classes!"));

        // Video 2
        Video v2 = new Video("OOP Concepts Explained", "Code Master", 800);
        v2.AddComment(new Comment("David", "Nice breakdown."));
        v2.AddComment(new Comment("Emma", "Loved the examples."));
        v2.AddComment(new Comment("Frank", "Can you do more tutorials?"));

        // Video 3
        Video v3 = new Video("C# Advanced Tips", "Dev Pro", 900);
        v3.AddComment(new Comment("Grace", "Very insightful."));
        v3.AddComment(new Comment("Henry", "Learned a lot."));
        v3.AddComment(new Comment("Ivy", "This helped my assignment."));

        // Add to list
        videos.Add(v1);
        videos.Add(v2);
        videos.Add(v3);

        // Display all videos
        foreach (Video video in videos)
        {
            video.DisplayVideoInfo();
        }
    }
}