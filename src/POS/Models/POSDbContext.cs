using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POS.Models
{
    public class POSDbContext : IdentityDbContext<ApplicationUser>
    {
        public POSDbContext() { }
        public DbSet<Wine> Wines { get; set; }
        public DbSet<Beer> Beers { get; set; }
        public DbSet<MixedDrink> MixedDrinks { get; set; }
        public DbSet<Dessert> Desserts { get; set; }
        public DbSet<Entre> Entres { get; set; }
        public DbSet<App> Apps { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Table> Tables { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=POS;integrated security=True");
        }
        public POSDbContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}
