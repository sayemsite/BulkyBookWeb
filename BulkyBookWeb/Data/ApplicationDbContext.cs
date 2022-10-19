
using BulkyBookWeb.Models;
using Microsoft.EntityFrameworkCore;

namespace BulkyBookWeb.Data;
public class ApplicationDbContext :DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
    }

    public DbSet<Category> Categories { get; set; } = null!;
    public DbSet<Member> Members { get; set; }
}

// Null assaigned sample
//public class TodoItem
//{
//    public long Id { get; set; }
//    public string? Name { get; set; }
//    public bool IsComplete { get; set; }
//}

//public class TodoContext : DbContext
//{
//    public TodoContext(DbContextOptions<TodoContext> options)
//        : base(options)
//    {
//    }

//    public DbSet<TodoItem> TodoItems { get; set; } = null!;
//}