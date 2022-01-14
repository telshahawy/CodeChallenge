using CodeChallenge.Server.Models;
using Microsoft.EntityFrameworkCore;

namespace CodeChallenge.Server
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ShiftType>().HasData(
                new ShiftType()
                {
                    Id = 1,
                    Name = "Morning Shift",
                    StartTime = new TimeSpan(0, 8, 0, 0),
                    EndTime = new TimeSpan(0, 16, 0, 0),
                    BreakPerHourInMin = 10,
                    BreakPerFourHoursInMin = 20
                }, new ShiftType()
                {
                    Id = 2,
                    Name = "Night Shift",
                    StartTime = new TimeSpan(0, 16, 0, 0),
                    EndTime = new TimeSpan(0, 8, 0, 0),
                    BreakPerHourInMin = 15,
                    BreakPerFourHoursInMin = 30
                });
        }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<ShiftType> ShiftTypes { get; set; }
        public DbSet<Shift> Shifts { get; set; }
    }
}
