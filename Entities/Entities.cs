namespace MigrationsDemo.Entities;

public class Blog
{
    public int Id { get; set; }
    public required string Url { get; set; }

    public ICollection<Post> Posts { get; } = new HashSet<Post>();
}

public class Post
{
    public int Id { get; set; }
    public required string Title { get; set; }
    public required string Content { get; set; }

    public int BlogId { get; set; }
    public required Blog Blog { get; set; }
}