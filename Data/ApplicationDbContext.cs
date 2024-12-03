using EmployeeInfo.Models;
using Microsoft.EntityFrameworkCore;

namespace EmployeeInfo.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {/Users/santo/Desktop/BloodBridge/Program.cs

        }

        public DbSet<Employee> Employees { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>().Property(e => e.DOB).HasColumnType("date");

            modelBuilder.Entity<Employee>().HasData(
                new Employee { Id = 1, Name = "Abul Kalam", Email = "abul@gmail.com", Mobile = "01714546489", DOB = new DateTime(2000, 09, 20) },
                new Employee { Id = 2, Name = "Jobyda Haque", Email = "jobhaq@gmail.com", Mobile = "01354748493", DOB = new DateTime(1983, 08, 02) },
                new Employee { Id = 3, Name = "Tanim Shariar", Email = "tanim@yahoo.com", Mobile = "015698746312", DOB = new DateTime(1999, 05, 03) },
                new Employee { Id = 4, Name = "Shubir Nondi", Email = "nondi@hotmail.com", Mobile = "01845693216", DOB = new DateTime(2001, 05, 30) },
                new Employee { Id = 5, Name = "Afia Khatun", Email = "afia@gmail.com", Mobile = "01752146369", DOB = new DateTime(2000, 07, 10) },
                new Employee { Id = 6, Name = "Tonima Enam", Email = "tonima@yahoo.com", Mobile = "017896544123", DOB = new DateTime(1998, 05, 11) }
            );
        }
    }
}
