using System;
using System.Collections.Generic;

class Comment
{
    public string Name { get; set; }
    public string Text { get; set; }

    // Constructor
    public Comment(string name, string text)
    {
        Name = name;
        Text = text;
    }
}

class Video
{
    public string Title { get; set; }
    public string Author { get; set; }
    public int LenInSec { get; set; }
    private List<Comment> Comments { get; set; }

    // Constructor
    public Video(string title, string author, int LenInSec)
    {
        Title = title;
        Author = author;
        LenInSec = LenInSec;
        Comments = new List<Comment>();
    }

    // Method to add comment to video
    public void AddComment(Comment comment)
    {
        Comments.Add(comment);
    }

    // Methods to return the number and total of comments
    public int GetCommentCount()
    {
        return Comments.Count;
    }

    public List<Comment> GetComments()
    {
        return Comments;
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Create video objects and adding comments to them
        Video video1 = new Video("How to Learn C#", "John Doe", 600);
        video1.AddComment(new Comment("Alice", "Great tutorial!"));
        video1.AddComment(new Comment("Bob", "Very helpful, thanks!"));
        video1.AddComment(new Comment("Charlie", "Loved the examples."));

        Video video2 = new Video("Introduction to Python", "Jane Smith", 750);
        video2.AddComment(new Comment("David", "Clear and concise!"));
        video2.AddComment(new Comment("Eva", "Exactly what I needed."));
        video2.AddComment(new Comment("Frank", "Thank you so much!"));

        Video video3 = new Video("Web Development Basics", "Mike Johnson", 1200);
        video3.AddComment(new Comment("George", "Awesome content!"));
        video3.AddComment(new Comment("Helen", "I learned a lot."));
        video3.AddComment(new Comment("Ian", "Very informative."));

        // List of videos
        List<Video> videos = new List<Video> { video1, video2, video3 };

        // Iterate through each video and display details
        foreach (var video in videos)
        {
            Console.WriteLine($"Title: {video.Title}");
            Console.WriteLine($"Author: {video.Author}");
            Console.WriteLine($"Length: {video.LenInSec} seconds");
            Console.WriteLine($"Number of Comments: {video.GetCommentCount()}");
            Console.WriteLine("Comments:");

            foreach (var comment in video.GetComments())
            {
                Console.WriteLine($"- {comment.Name}: {comment.Text}");
            }

            Console.WriteLine();
        }
    }
}
