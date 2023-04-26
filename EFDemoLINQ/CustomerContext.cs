using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFDemoLINQ
{
    internal class CustomerContext : DbContext
    {
        //Creating our Customers table in the DB
        public DbSet<Customer> Customers { get; set; }

        //Connection String
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=RankenCustomers;Trusted_Connection=True;MultipleActiveResultSets=true");
        }

        //Give my app some seed data
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>().HasData(
                new Customer { CustomerId=1, CustomerName="Evan Gudmestad", Budget=10000},
                new Customer { CustomerId = 2, CustomerName = "Charles Corrigan", Budget = 20000 },
                new Customer { CustomerId = 3, CustomerName = "Ashley Reddick", Budget = 30000 }
                );
        }


    }
}
