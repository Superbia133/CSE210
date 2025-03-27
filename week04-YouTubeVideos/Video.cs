public class Video
{
    public string Title { get; set; }
    public string Author { get; set; }
    public int Length { get; set; }
    private List<Comment> Comments = new List<Comment>();

    public Video(string title, string author, int length)
    {
        Title = title;
        Author = author;
        Length = length;
    }

    public void AddComment(Comment comment)
    {
        Comments.Add(comment);
    }

    public int GetCommentCount()
    {
        return Comments.Count;
    }

    public void Display()
    {
        Console.WriteLine($"\nTitle: {Title}");
        Console.WriteLine($"Author: {Author}");
        Console.WriteLine($"Length: {Length} seconds");
        Console.WriteLine($"Comments ({GetCommentCount()}):");
        foreach (var comment in Comments)
        {
            comment.Display();
        }
    }
}
