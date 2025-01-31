// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

using(CategoryContext context = new CategoryContext())
{
    foreach(var post in context.Posts)
    {
        Console.WriteLine($"{post.BlogId}, {post.Title}, {post.CategoryName}");
    }
    
}
