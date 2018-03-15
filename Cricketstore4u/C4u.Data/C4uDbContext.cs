using System;
using System.Collections.Generic;
using System.Text;
using C4u.Library.Models;
using Microsoft.EntityFrameworkCore;

namespace C4u.Data
{
    public class C4uDbContext : DbContext
    {
        public C4uDbContext(DbContextOptions<C4uDbContext> options) : base(options)
        { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
            }
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }
        public DbSet<Customer> CustomerList { get; set; }

    }
}
