using BooksManagementSystem.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace BooksManagementSystem.Data
{
    public class CustomersDbContext : DbContext
    {
        // Here we add in all the tables we are using.
        public DbSet<Customer> Customer { get; set; }
        public DbSet<Books> Books { get; set; }
        public DbSet<Order> Order { get; set; }
        // We need 2 constructors, one is empty, and the other injects in DbContextOptions
        public CustomersDbContext(DbContextOptions<CustomersDbContext> options)
        : base(options)
        {
        }
        public CustomersDbContext()
        {
        }
    }
}
