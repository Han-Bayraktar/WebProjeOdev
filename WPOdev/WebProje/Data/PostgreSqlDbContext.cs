using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;
using Npgsql;
using WebProje.Models;

public class PostgreSqlDbContext : DbContext
{
    public PostgreSqlDbContext(DbContextOptions<PostgreSqlDbContext> options) : base(options)
    {
        
    }
    public DbSet<User> Users { get; set; }
    public DbSet<Service> Services { get; set; }
    public DbSet<Employee> Employees { get; set; }
    public DbSet<Appointment> Appointments { get; set; }
    // Burada veritabanı tablolarınıza karşılık gelen DbSet'leri tanımlayın

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        // İlk admin kullanıcısını ekleyin
        modelBuilder.Entity<User>().HasData(new User
        {
            Id=-1,
            Name = "Admin",
            Surname = "User",
            Email = "b22121210034@gmail.com",
            Password = "sau", // Bu şifreyi hashleyerek saklamanız önerilir
            Role = "admin"
        });
    }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.ConfigureWarnings(warnings => warnings.Ignore(RelationalEventId.PendingModelChangesWarning));
    }
}