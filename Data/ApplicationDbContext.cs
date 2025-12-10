using Microsoft.EntityFrameworkCore;
using TodoApp.Models;

namespace TodoApp.Data;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    public DbSet<TodoItem> TodoItems { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        // Seed data
        modelBuilder.Entity<TodoItem>().HasData(
            new TodoItem
            {
                Id = 1,
                Title = "ASP.NET Core öğren",
                Description = "Entity Framework Core ve MVC pattern'lerini öğren",
                IsCompleted = false,
                CreatedAt = DateTime.Now.AddDays(-2),
                Priority = "High"
            },
            new TodoItem
            {
                Id = 2,
                Title = "GitHub profilini güncelle",
                Description = "Yeni projeleri ekle ve README'leri düzenle",
                IsCompleted = true,
                CreatedAt = DateTime.Now.AddDays(-5),
                CompletedAt = DateTime.Now.AddDays(-1),
                Priority = "Medium"
            },
            new TodoItem
            {
                Id = 3,
                Title = "Portföy sitesini iyileştir",
                Description = "Responsive tasarım ve animasyonlar ekle",
                IsCompleted = false,
                CreatedAt = DateTime.Now.AddDays(-1),
                Priority = "Low"
            }
        );
    }
}