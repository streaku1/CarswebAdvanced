using Carsweb.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace Carsweb.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Cars> Cars { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
    }
}
