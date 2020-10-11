using Domain;
using Microsoft.EntityFrameworkCore;
using System;

namespace Persistence
{
    public class DataContext : DbContext //using a class in entity framework core
    {
        public DataContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Seminar> Seminars { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserSeminar> UserSeminars { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Seminar>()
                .HasData(
                    new Seminar { Id = 1, Name = "Seminar 101", Address = "101 Main St", City = "Gothenburg", DateTime = DateTime.Now.AddDays(31).AddHours(10), Category = "Science", Description = "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Aenean commodo ligula eget dolor. Aenean massa. Cum sociis natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus. Donec quam felis, ultricies nec, pellentesque eu, pretium quis, sem. Nulla consequat massa quis enim. Donec pede justo, fringilla vel, aliquet nec, vulputate eget, arcu. In enim justo, rhoncus ut, imperdiet a, venenatis vitae, justo. Nullam dictum felis eu pede mollis pretium. Integer tincidunt. Cras dapibus. Vivamus elementum semper nisi. Aenean vulputate eleifend tellus. Aenean leo ligula, porttitor eu, consequat vitae, eleifend ac, enim. Aliquam lorem ante, dapibus in, viverra quis, feugiat a,", Active = true },
                    new Seminar { Id = 2, Name = "Seminar 102", Address = "102 Main St", City = "Gothenburg", DateTime = DateTime.Now.AddDays(22).AddHours(10), Category = "History", Description = "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Aenean commodo ligula eget dolor. Aenean massa. Cum sociis natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus. Donec quam felis, ultricies nec, pellentesque eu, pretium quis, sem. Nulla consequat massa quis enim. Donec pede justo, fringilla vel, aliquet nec, vulputate eget, arcu. In enim justo, rhoncus ut, imperdiet a, venenatis vitae, justo. Nullam dictum felis eu pede mollis pretium. Integer tincidunt. Cras dapibus. Vivamus elementum semper nisi. Aenean vulputate eleifend tellus. Aenean leo ligula, porttitor eu, consequat vitae, eleifend ac, enim. Aliquam lorem ante, dapibus in, viverra quis, feugiat a,", Active = true },
                    new Seminar { Id = 3, Name = "Seminar 103", Address = "103 Main St", City = "Gothenburg", DateTime = DateTime.Now.AddDays(28).AddHours(10), Category = "Economics", Description = "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Aenean commodo ligula eget dolor. Aenean massa. Cum sociis natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus. Donec quam felis, ultricies nec, pellentesque eu, pretium quis, sem. Nulla consequat massa quis enim. Donec pede justo, fringilla vel, aliquet nec, vulputate eget, arcu. In enim justo, rhoncus ut, imperdiet a, venenatis vitae, justo. Nullam dictum felis eu pede mollis pretium. Integer tincidunt. Cras dapibus. Vivamus elementum semper nisi. Aenean vulputate eleifend tellus. Aenean leo ligula, porttitor eu, consequat vitae, eleifend ac, enim. Aliquam lorem ante, dapibus in, viverra quis, feugiat a,", Active = true },
                    new Seminar { Id = 4, Name = "Seminar 101", Address = "101 Main St", City = "Gothenburg", DateTime = DateTime.Now.AddDays(45).AddHours(10), Category = "Science", Description = "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Aenean commodo ligula eget dolor. Aenean massa. Cum sociis natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus. Donec quam felis, ultricies nec, pellentesque eu, pretium quis, sem. Nulla consequat massa quis enim. Donec pede justo, fringilla vel, aliquet nec, vulputate eget, arcu. In enim justo, rhoncus ut, imperdiet a, venenatis vitae, justo. Nullam dictum felis eu pede mollis pretium. Integer tincidunt. Cras dapibus. Vivamus elementum semper nisi. Aenean vulputate eleifend tellus. Aenean leo ligula, porttitor eu, consequat vitae, eleifend ac, enim. Aliquam lorem ante, dapibus in, viverra quis, feugiat a,", Active = true },
                    new Seminar { Id = 5, Name = "Seminar 102", Address = "102 Main St", City = "Gothenburg", DateTime = DateTime.Now.AddDays(14).AddHours(10), Category = "History", Description = "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Aenean commodo ligula eget dolor. Aenean massa. Cum sociis natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus. Donec quam felis, ultricies nec, pellentesque eu, pretium quis, sem. Nulla consequat massa quis enim. Donec pede justo, fringilla vel, aliquet nec, vulputate eget, arcu. In enim justo, rhoncus ut, imperdiet a, venenatis vitae, justo. Nullam dictum felis eu pede mollis pretium. Integer tincidunt. Cras dapibus. Vivamus elementum semper nisi. Aenean vulputate eleifend tellus. Aenean leo ligula, porttitor eu, consequat vitae, eleifend ac, enim. Aliquam lorem ante, dapibus in, viverra quis, feugiat a,", Active = true }
                );

            builder.Entity<UserSeminar>(x => x.HasKey(us => new { us.UserId, us.SeminarId }));

            builder.Entity<UserSeminar>().HasOne(u => u.User).WithMany(a => a.UserSeminars).HasForeignKey(u => u.UserId).OnDelete(DeleteBehavior.Restrict);

            builder.Entity<UserSeminar>().HasOne(a => a.Seminar).WithMany(u => u.UserSeminars).HasForeignKey(a => a.SeminarId);

        }
    }
}
