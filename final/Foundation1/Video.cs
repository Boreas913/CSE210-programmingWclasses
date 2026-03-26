// Your program should have a class for a Video that has the responsibility to 
// track the title, author, and length (in seconds) of the video. Each video also 
// has responsibility to store a list of comments, and should have a method to return 
// the number of comments. A comment should be defined by the Comment class which has the 
// responsibility for tracking both the name of the person who made the comment and the text of the comment.
using System.Transactions;

public class Video
{
    private string _title;
    private string _creator;
    private int _length;
    private List<Comment> _comments;

    public Video(string title, string creator, int length)
    {
        _title = title;
        _creator = creator;
        _length = length;
        _comments = new List<Comment>();
    }

    public void AddComment(Comment comment)
    {
        _comments.Add(comment);
    }

    public int NumberOfComments()
    {
        return _comments.Count;
    }

    public string DisplayVideoInfo()
    {
        return $"Title: {_title}\nCreator: {_creator}\nLength: {_length} seconds\nNumber of Comments: {NumberOfComments()}";
    }

    public string DisplayAllComments()
    {
        string result = "";
        foreach (Comment comment in _comments)
        {
            result += comment.DisplayComment() + "\n";
        }
        return result;
    }
}

