using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class RentACarContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=RentaCar;Trusted_Connection=True");
        }
        public DbSet<Car> cars { get; set; }
        public DbSet<Brand> brands { get; set; }
        public DbSet<Color> colors { get; set; }
        public DbSet<Customer> customers { get; set; }
        public DbSet<User> users { get; set; }
        public DbSet<Rental> rentals { get; set; }

    }
}
