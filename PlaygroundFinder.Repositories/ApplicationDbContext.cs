using Microsoft.EntityFrameworkCore;
using PlaygroundFinder.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlaygroundFinder.Repositories
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
            // This is where you can use the Fluent API to have finer control over the database setup.
            // Anything you can do with data annotations on the entity models can also be done with the
            // fluent API.



        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
           
            builder.HasPostgresExtension("postgis");
        }

        public DbSet<Playground> Playgrounds { get; set; }
    }
}
