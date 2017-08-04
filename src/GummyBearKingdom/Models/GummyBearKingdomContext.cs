using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace GummyBearKingdom.Models
{
    public class GummyBearKingdomContext : DbContext
    {
        public GummyBearKingdomContext()
        {
        }

        public DbSet<Product> Products { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=GummyBearKingdom;integrated security=True");
        }

        public GummyBearKingdomContext(DbContextOptions<GummyBearKingdomContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}
