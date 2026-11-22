using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        Video video1 = new Video("Unboxing Industrial Hydraulic Pump", "MechLab Pro", 485);
        video1.AddComment(new Comment("Lucas Andrade", "Great explanation of the bench test pressure."));
        video1.AddComment(new Comment("Marina Costa", "Helped me understand the flow rate check."));
        video1.AddComment(new Comment("Rafael Souza", "Clean setup and easy to follow."));
        videos.Add(video1);

        Video video2 = new Video("Morning Mobility & Jiu-Jitsu Warmup", "MatFlow Academy", 720);
        video2.AddComment(new Comment("Camila Rocha", "Using this routine before open mat every day."));
        video2.AddComment(new Comment("Thiago Lima", "My hips feel much looser after two weeks."));
        video2.AddComment(new Comment("Beatriz Melo", "Simple drills that make a big difference."));
        video2.AddComment(new Comment("Diego Nunes", "Subscribed for more warmups."));
        videos.Add(video2);

        Video video3 = new Video("C# Classes and Encapsulation Explained", "CodeCraft Studio", 610);
        video3.AddComment(new Comment("Fernanda Dias", "Private fields with constructors finally clicked."));
        video3.AddComment(new Comment("Pedro Alves", "Short, direct, and no fluff."));
        video3.AddComment(new Comment("Juliana Reis", "Saved this for my CSE 210 review."));
        videos.Add(video3);

        foreach (Video video in videos)
        {
            video.DisplayInfo();
        }
    }
}