using System;
using System.Collections.Generic;

class Comment
{
    public string Author { get; set; }
    public string Text { get; set; }

    public Comment(string author, string text)
    {
        Author = author;
        Text = text;
    }
}

class Video
{
    public string Title { get; set; }
    public string Author { get; set; }
    public int DurationSeconds { get; set; }
    private List<Comment> comments = new List<Comment>();

    public Video(string title, string author, int durationSeconds)
    {
        Title = title;
        Author = author;
        DurationSeconds = durationSeconds;
    }

    public void AddComment(Comment comment)
    {
        comments.Add(comment);
    }

    public int GetCommentCount()
    {
        return comments.Count;
    }

    public List<Comment> GetComments()
    {
        return comments;
    }

}


class Program
{
    static void Main(string[] args)
    {
        // Creazione dei video
        Video video1 = new Video("How Python Works", "TechWorld", 740);
        video1.AddComment(new Comment("Ella", "Very interesting video!"));
        video1.AddComment(new Comment("Dario", "Clear and helpful explanation."));
        video1.AddComment(new Comment("Marco", "Finally understood how it works!"));

        Video video2 = new Video("Tutorial on how to make lasagna", "ItalianCuisine", 500);
        video2.AddComment(new Comment("Laura", "Very good!"));
        video2.AddComment(new Comment("Amy", "I'll try it tonight."));
        video2.AddComment(new Comment("Angela", "Thanks for the recipe!"));

        Video video3 = new Video("Guitar tutorial for beginners", "GuitarZone", 520);
        video3.AddComment(new Comment("Peter", "It made me learn new things!"));
        video3.AddComment(new Comment("Jeremy", "Perfect for starting out."));
        video3.AddComment(new Comment("Jason", "Great pace and instructions."));

        // Lista dei video
        List<Video> videos = new List<Video> { video1, video2, video3 };

        // Visualizzazione delle informazioni
        foreach (Video video in videos)
        {
            Console.WriteLine($"Title: {video.Title}");
            Console.WriteLine($"Author: {video.Author}");
            Console.WriteLine($"Duration: {video.DurationSeconds} seconds");
            Console.WriteLine($"Number of comments: {video.GetCommentCount()}");
            Console.WriteLine("Comments:");
            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine($"- {comment.Author}: \"{comment.Text}\"");
            }
            Console.WriteLine(new string('-', 40));
        }
    }
}

