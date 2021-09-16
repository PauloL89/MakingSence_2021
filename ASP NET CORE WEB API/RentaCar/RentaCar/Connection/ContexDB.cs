using Microsoft.EntityFrameworkCore;
using RentaCar.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RentaCar.Connection
{
    public class ContexDB:DbContext
    {
        public ContexDB(DbContextOptions<ContexDB> options): base (options)
        {

        }

        public DbSet<Car> cars { get; set; }
        public DbSet<Box> boxes { get; set; }
        public DbSet<Brand> brands { get; set; }
        public DbSet<Color> colors { get; set; }
        public DbSet<Customer> customers { get; set; }
        public DbSet<Rental> rentals { get; set; }
    }
}
