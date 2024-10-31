

using Labb3_InformationSystem.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Labb3_InformationSystem.Data
{
    public class AppDbContext : IdentityDbContext<IdentityUser>
    {

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Driver> Drivers { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Event> Events { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Konfigurera relationen mellan Driver och Event
            modelBuilder.Entity<Event>()
                .HasOne(e => e.Driver)
                .WithMany(d => d.Events)
                .OnDelete(DeleteBehavior.Cascade);

            // Seed Data för roller
            modelBuilder.Entity<IdentityRole>().HasData(
                new IdentityRole { Id = "admin-role-id", Name = "Admin", NormalizedName = "ADMIN" },
                new IdentityRole { Id = "employee-role-id", Name = "Employee", NormalizedName = "EMPLOYEE" }
            );

            // Seed Data för exempel-användare kopplad till Admin-rollen
            var hasher = new PasswordHasher<IdentityUser>();
            var adminUser = new IdentityUser
            {
                Id = "admin-id",
                UserName = "admin@example.com",
                NormalizedUserName = "ADMIN@EXAMPLE.COM",
                Email = "admin@example.com",
                NormalizedEmail = "ADMIN@EXAMPLE.COM",
                PasswordHash = hasher.HashPassword(null, "AdminPassword123!"),
                EmailConfirmed = true
            };
            modelBuilder.Entity<IdentityUser>().HasData(adminUser);

            modelBuilder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string>
            {
                RoleId = "admin-role-id",
                UserId = "admin-id"
            });

            // Seed Data för anställd
            var employeeUser = new IdentityUser
            {
                Id = "employee-id",
                UserName = "employee@example.com",
                NormalizedUserName = "EMPLOYEE@EXAMPLE.COM",
                Email = "employee@example.com",
                NormalizedEmail = "EMPLOYEE@EXAMPLE.COM",
                PasswordHash = hasher.HashPassword(null, "EmployeePassword123!"),
                EmailConfirmed = true
            };
            modelBuilder.Entity<IdentityUser>().HasData(employeeUser);

            modelBuilder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string>
            {
                RoleId = "employee-role-id",
                UserId = "employee-id"
            });

            // Seed Data för Drivers
            modelBuilder.Entity<Driver>().HasData(
                new Driver
                {
                    DriverID = 1,
                    DriverName = "Anton",
                    CarReg = "ABC123",
                    NoteDate = DateTime.UtcNow,
                    NoteDescription = "Service på bil",
                    ResponsibleEmployee = "Petter",
                    BeloppUt = 200,
                    BeloppIn = 100,
                    TotalBeloppUt = 200,
                    TotalBeloppIn = 100
                },
                new Driver
                {
                    DriverID = 2,
                    DriverName = "Adam",
                    CarReg = "XYZ789",
                    NoteDate = DateTime.UtcNow.AddDays(-1),
                    NoteDescription = "Bytte däck",
                    ResponsibleEmployee = "Simon",
                    BeloppUt = 100,
                    BeloppIn = 50,
                    TotalBeloppUt = 100,
                    TotalBeloppIn = 50
                }
            );

            // Seed Data för Employees
            modelBuilder.Entity<Employee>().HasData(
                new Employee
                {
                    EmployeeID = 1,
                    Name = "Petter Svensson",
                    Email = "petter.svensson@example.com",
                    Role = "Employee",
                    IdentityUserId = "employee-id" // Koppla till användaren
                },
                new Employee
                {
                    EmployeeID = 2,
                    Name = "Simon Karlsson",
                    Email = "simon.karlsson@example.com",
                    Role = "Employee",
                    IdentityUserId = "employee-id" // Koppla till användaren
                },
                new Employee
                {
                    EmployeeID = 3,
                    Name = "Jessica Andersson",
                    Email = "jessica.andersson@example.com",
                    Role = "Admin",
                    IdentityUserId = "admin-id" // Koppla till admin-användaren
                }
            );

            // Seed Data för Events
            modelBuilder.Entity<Event>().HasData(
                new Event
                {
                    EventID = 1,
                    EventDate = DateTime.UtcNow,
                    Description = "Förare Anton genomförde en service på bilen.",
                    DriverID = 1
                },
                new Event
                {
                    EventID = 2,
                    EventDate = DateTime.UtcNow.AddDays(-1),
                    Description = "Förare Adam bytte däck.",
                    DriverID = 2
                },
                new Event
                {
                    EventID = 3,
                    EventDate = DateTime.UtcNow.AddDays(-2),
                    Description = "Förare Anton hade en incident med en annan bil.",
                    DriverID = 1
                },
                new Event
                {
                    EventID = 4,
                    EventDate = DateTime.UtcNow.AddDays(-3),
                    Description = "Förare Adam genomförde en rutinkontroll.",
                    DriverID = 2
                }
            );
        }
    }
}