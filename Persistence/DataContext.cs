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

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Seminar>()
                .HasData(
                    new Seminar { Id = 1, Name = "Seminar 101", Address = "101 Main St", City = "Gothenburg", DateTime = DateTime.Now },
                    new Seminar { Id = 2, Name = "Seminar 102", Address = "101 Main St", City = "Gothenburg", DateTime = DateTime.Now },
                    new Seminar { Id = 3, Name = "Seminar 103", Address = "101 Main St", City = "Gothenburg", DateTime = DateTime.Now }
                );
        }
    }
}
