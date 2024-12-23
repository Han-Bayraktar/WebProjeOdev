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

        // Employee tablosuna varsayılan bir çalışan ekliyoruz
        modelBuilder.Entity<Employee>().HasData(new Employee
        {
            Id = 1,
            Name = "Mustafa Yılmaz",
            Specialty = "Haircut",
            WorkingHours = "9 am-5 pm"
        });

        // Service tablosuna varsayılan bir servis ekliyoruz
        modelBuilder.Entity<Service>().HasData(new Service
        {
            Id = 1,
            Name = "Haircut",
            Duration = 30,
            Price = 50
        });

        // Appointment tablosuna varsayılan bir randevu ekliyoruz
        modelBuilder.Entity<Appointment>().HasData(new Appointment
        {
            Id = 1,
            AppointmentTime = new DateTime(2024, 12, 30, 9, 0, 0, DateTimeKind.Utc),
            ServiceId = 1,
            EmployeeId = 1,
            UserId = 1,
            Status = false
        });
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
