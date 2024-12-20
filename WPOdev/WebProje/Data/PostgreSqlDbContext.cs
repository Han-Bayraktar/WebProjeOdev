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

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        // User tablosu için varsayılan bir Admin kaydı ekliyoruz
        modelBuilder.Entity<User>().HasData(new User
        {
            Id = 1,
            Name = "Admin",
            Surname = "User",
            Email = "b22121210034@gmail.com",
            Password = "sau",
            Role = "admin"
        });

        // Diğer tablolar için gerekli yapılandırmalar burada yapılabilir
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            // Bağlantı dizesi eklenmesi, appsettings.json'dan alınabilir
            optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=WebProjeDB;Username=barber_admin;Password=sau");
        }

        optionsBuilder.ConfigureWarnings(warnings => warnings.Ignore(RelationalEventId.PendingModelChangesWarning));
    }
}
