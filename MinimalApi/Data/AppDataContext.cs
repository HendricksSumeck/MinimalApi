using Microsoft.EntityFrameworkCore;
using MinimalApi.Entitys;

namespace MinimalApi.Data;

public class AppDataContext : DbContext
{
    public DbSet<Book> Books { get; set; }
 
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseNpgsql("Host=localhost;Port=5442;Database=MinimalApi;Username=postgres;Password=postgres");
}