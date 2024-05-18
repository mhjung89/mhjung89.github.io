namespace MyBlog.Core.Models.Blogs;

public class Post
{
    public string Title { get; set; } = string.Empty;
    public DateTime Date { get; set; }
    public string Content { get; set; } = string.Empty;
}