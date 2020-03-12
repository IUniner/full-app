using ConsoleApp1.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class ContextInitializer : DropCreateDatabaseAlways<DatabaseContext>
    {
        protected override void Seed(DatabaseContext db)
        {

        }
    }

    public class DatabaseContext : DbContext
    {
        static DatabaseContext()
        {
            Database.SetInitializer<DatabaseContext>(new ContextInitializer());
        }
        public DbSet<Company> Companies { get; set; }
        public DbSet<Employee> Employees { get; set; }

        public DbSet<User> Users { get; set; }
        public DbSet<UserProfile> UserProfiles { get; set; }
        public DbSet<Admin> Admins { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Company>()
                .HasMany(p => p.Employees)
                .WithMany(p => p.Companies)
                .Map(x => x.MapLeftKey("EmployeeId")
                           .MapRightKey("CompanyId")
                           .ToTable("CompanyEmployees")
                    );

            modelBuilder.Entity<User>()
               .Property(p => p.Login)
               .IsRequired();

            modelBuilder.Entity<User>()
               .HasOptional(p => p.Profile)
               .WithRequired(p => p.User);
        }
    }
}
