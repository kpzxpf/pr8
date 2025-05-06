using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Pr8.entity;

namespace Pr8;

public class AppDbContext : DbContext
{
    public DbSet<User> users { get; set; }
    public DbSet<Purchase> purchases { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Username=User;" +
                                 "Password=Password;Database=DatabasePr8");
    }
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<User>()
            .Property(u => u.role)
            .HasConversion<int>(); 
        
        modelBuilder.Entity<Purchase>()
            .Property(p => p.category)
            .HasConversion<int>()
            .IsRequired();
    }
}



