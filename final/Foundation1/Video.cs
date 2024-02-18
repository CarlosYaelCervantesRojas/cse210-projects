public class Video
{
    private string _title;
    private string _author;
    private int _length;
    private List<Comment> _comments = new List<Comment>();

    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
    }

    public int GetNumberOfComments()
    {
        return _comments.Count;
    }
    public void DisplayVideoInfo()
    {
        Console.WriteLine($"{_title}\n{_author}\n{_length} s.");
    }

    public void DisplayComments()
    {
        foreach (Comment comment in _comments)
        {
            comment.DisplayComment();
        }
    }
    public void AddComment(Comment comment)
    {
        _comments.Add(comment);
    }
}