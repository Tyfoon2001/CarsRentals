
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Models;

namespace Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<Cars> cars { get; set; }
        public DbSet<Customer> customers{ get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cars>().HasData(
                new Cars { CarId = 1, Brand = "BMW", Model = "3Series", Price = 3000, IsAvailable = true },
                new Cars { CarId = 2, Brand = "BMW", Model = "5Series", Price = 5000, IsAvailable = true },
                new Cars { CarId = 3, Brand = "BMW", Model = "6Series", Price = 6000, IsAvailable = true },
                new Cars { CarId = 4, Brand = "BMW", Model = "GLS", Price = 8000, IsAvailable = true },
                new Cars { CarId = 5, Brand = "Mercedes", Model = "AMG", Price = 7000, IsAvailable = true },
                new Cars { CarId = 6, Brand = "Mercedes", Model = "SClass", Price = 9000, IsAvailable = true }

                );
            modelBuilder.Entity<Customer>().HasData(
                new Customer { customerId = 1, name = "rushi" },
                new Customer { customerId = 2, name = "Test" },
                new Customer { customerId = 3, name = "Jack" }


                );
            
        }

       
    }
}
