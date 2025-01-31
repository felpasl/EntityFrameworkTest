using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

public class CategoryContext : DbContext
{
    public DbSet<Category> Categories { get; set; }

    // The following configures EF to create a Sqlite database file in the
    // special "local" folder for your platform.
    protected override void OnConfiguring(DbContextOptionsBuilder options)
        => options.UseNpgsql("Host=db;Database=postgres;Username=postgres;Password=postgres");
}

[Table("Category", Schema = "category")]
public class Category
{
    public int CategoryId { get; set; }
    public string Name { get; set; }

}
