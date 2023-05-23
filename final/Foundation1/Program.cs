using System;
using System.Collections.Generic;

class Video
{
    public string Title { get; set; }
    public string Author { get; set; }
    public int Length { get; set; }
    public List<Comment> Comments { get; set; }

    public int GetNumberOfComments()
    {
        return Comments.Count;
    }
}

class Comment
{
    public string CommenterName { get; set; }
    public string Text { get; set; }
}

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        // Create and populate videos
        Video video1 = new Video
        {
            Title = "Video 1",
            Author = "Author 1",
            Length = 120,
            Comments = new List<Comment>()
        };
        video1.Comments.Add(new Comment { CommenterName = "User1", Text = "Comment 1" });
        video1.Comments.Add(new Comment { CommenterName = "User2", Text = "Comment 2" });

        Video video2 = new Video
        {
            Title = "Video 2",
            Author = "Author 2",
            Length = 180,
            Comments = new List<Comment>()
        };
        video2.Comments.Add(new Comment { CommenterName = "User3", Text = "Comment 3" });
        video2.Comments.Add(new Comment { CommenterName = "User4", Text = "Comment 4" });
        video2.Comments.Add(new Comment { CommenterName = "User5", Text = "Comment 5" });

        videos.Add(video1);
        videos.Add(video2);

        // Display video information
        foreach (var video in videos)
        {
            Console.WriteLine("Title: " + video.Title);
            Console.WriteLine("Author: " + video.Author);
            Console.WriteLine("Length: " + video.Length + " seconds");
            Console.WriteLine("Number of comments: " + video.GetNumberOfComments());
            Console.WriteLine("Comments:");

            foreach (var comment in video.Comments)
            {
                Console.WriteLine("- " + comment.CommenterName + ": " + comment.Text);
            }

            Console.WriteLine();
        }

        Console.ReadLine();
    }
}

/*
    This program creates two videos with their respective comments and stores them in a list. It then iterates through the list, displaying the title, author, length, number of comments, and the comments for each video.

    Please note that this program does not have any error handling or input validation. It's a simplified example focusing on the core functionality.
*/