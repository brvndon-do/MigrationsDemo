using Microsoft.EntityFrameworkCore;

namespace MigrationsDemo.Entities;

public class MyDbContext : DbContext
{
    public DbSet<Blog> Blogs { get; set; }
    public DbSet<Post> Posts { get; set; }

    public string DbPath { get; init; }

    public MyDbContext() => DbPath = Path.Join(Environment.CurrentDirectory, "blogging.db");

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) => optionsBuilder.UseSqlite($"Data Source={DbPath}");
}