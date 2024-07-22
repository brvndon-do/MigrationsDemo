using MigrationsDemo.Entities;

using var db = new MyDbContext();

// adding dummy data
Blog blog = new Blog
{
    Url = "https://google.com",
    Posts = {
        new Post
        {
            Blog = null!,
            Title = "Migration",
            Content = "How to apply migrations in a team environment"
        }
    }
};

db.Blogs.Add(blog);
await db.SaveChangesAsync();