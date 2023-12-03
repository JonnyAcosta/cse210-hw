using System.Runtime.InteropServices;

public class Video{
    public string Title { get; set; }
    public string Author { get; set; }

    public int LengthInSeconds { get; set; }
    private List<Comment> comments = new List<Comment>();

    public void AddComment(string commenterName, string text)
    {
        Comment comment = new Comment {CommenterName = commenterName, Text = text};
        comments.Add(comment);
    }

    public int GetNumberOfComments()
    {
        return comments.Count;
    }

    public void DisplayVideoInfo()
    {
        Console.WriteLine($"Title: {Title}");
        Console.WriteLine($"Author: {Author}");
        Console.WriteLine($"Length (second): {LengthInSeconds}");
        Console.WriteLine($"Number of Comments: {GetNumberOfComments()}");

        if (GetNumberOfComments() > 0)
        {
            Console.WriteLine("Comments:");
            foreach (Comment comment in comments)
            {
                Console.WriteLine($"- {comment.CommenterName}: {comment.Text}");
            }
        }
        Console.WriteLine();
    }
}