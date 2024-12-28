using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;
using Microsoft.Extensions.Configuration;
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

        // User tablosu için varsayılan bir Admin kaydı
        modelBuilder.Entity<User>().HasData(new User
        {
            Id = 1,
            Name = "Admin",
            Surname = "User",
            Email = "b22121210034@gmail.com",
            Password = "sau",
            Role = "admin"
        });

        // Employee tablosu için varsayılan bir çalışan
        modelBuilder.Entity<Employee>().HasData(new Employee
        {
            Id = 1,
            Name = "Mustafa Yılmaz",
            Specialty = "Haircut",
            WorkingHours = "9 am-5 pm"
        });

        // Service tablosu için varsayılan bir servis
        modelBuilder.Entity<Service>().HasData(new Service
        {
            Id = 1,
            Name = "Haircut",
            Duration = 30,
            Price = 50
        });

        var appointments = new List<Appointment>();
        int idCounter = 1000; // Çakışmayı önlemek için ID başlangıç değeri

        var startDate = new DateTime(2024, 12, 30);
        var endDate = new DateTime(2025, 1, 4);

        // Hizmet ve çalışan eşleştirmelerini döngü ile işleme alıyoruz
        var serviceEmployeeMappings = new List<(int ServiceId, int EmployeeId)>
    {
        (1, 1),
        (2, 2),
        (3, 3),
        (4, 4),
        (5, 1)
    };

        foreach (var mapping in serviceEmployeeMappings)
        {
            for (var date = startDate; date <= endDate; date = date.AddDays(1))
            {
                for (var time = new TimeSpan(6, 0, 0); time < new TimeSpan(14, 0, 0); time = time.Add(new TimeSpan(0, 30, 0)))
                {
                    appointments.Add(new Appointment
                    {
                        Id = idCounter++,
                        AppointmentTime = new DateTime(date.Year, date.Month, date.Day, time.Hours, time.Minutes, 0, DateTimeKind.Utc),
                        ServiceId = mapping.ServiceId,
                        EmployeeId = mapping.EmployeeId,
                        UserId = 1, 
                        Status = false
                    });
                }
            }
        }

        // Appointment verilerini ekliyoruz
        modelBuilder.Entity<Appointment>().HasData(appointments.ToArray());
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            var configuration = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json")
                .Build();

            optionsBuilder.UseNpgsql(configuration.GetConnectionString("DefaultConnection"));
        }

        optionsBuilder.ConfigureWarnings(warnings => warnings.Ignore(RelationalEventId.PendingModelChangesWarning));
    }
}
