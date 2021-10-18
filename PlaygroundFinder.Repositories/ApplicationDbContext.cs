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
            builder.Entity<PlaygroundGroundCover>()
                .HasKey(e => new { e.PlaygroundId, e.GroundCoverId });

     
        }

        public DbSet<Playground> Playgrounds { get; set; }
        public DbSet<GroundCover> GroundCovers { get; set; }

        public DbSet<PlaygroundGroundCover> PlaygroundGroundCovers { get; set; }
    }
}
