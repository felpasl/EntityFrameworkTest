using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

public class CategoryContext : DbContext
{
    public DbSet<Category> Categories { get; set; }
    public DbSet<PostView> Posts { get; set; }

    // The following configures EF to create a Sqlite database file in the
    // special "local" folder for your platform.
    protected override void OnConfiguring(DbContextOptionsBuilder options)
        => options.UseNpgsql("Host=db;Database=postgres;Username=postgres;Password=postgres");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Category>().ToTable("Category", "category");
        modelBuilder.Entity<PostView>().ToTable("vw_posts", "public", action => action.ExcludeFromMigrations()).HasNoKey();
        base.OnModelCreating(modelBuilder);
    }
}

public class Category
{
    public int CategoryId { get; set; }
    public string Name { get; set; }

}

public class PostView
{
    public int BlogId { get; set; }
    public string Url { get; set; }
    public int PostId { get; set; }
    public string Title { get; set; }
    public int CategoryId { get; set; }
    public string CategoryName { get; set; }
}
