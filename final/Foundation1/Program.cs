using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>
        {
            new Video
            {
                Title ="How to kick a ball",
                Author = "Jonathan Acosta",
                LengthInSeconds = 600,
            },
            new Video
            {
                Title ="Champion League Final Highlights",
                Author = "UEFA",
                LengthInSeconds = 800,
            },
            new Video 
            {
                Title ="Life in Los Angeles",
                Author ="Jorge Acosta",
                LengthInSeconds= 700,
            }
        };

        foreach (Video video in videos)
        {
            video.AddComment("User1", " Thank you for the tips");
            video.AddComment("User2","Great video to watch");
            video.AddComment("User3","That was really cool");
        }

        foreach (Video video in videos)
        {
            video.DisplayVideoInfo();
        }
    }
}