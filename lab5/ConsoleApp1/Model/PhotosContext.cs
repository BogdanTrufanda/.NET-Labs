using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Model
{
    public class PhotosContext : DbContext
    {
        public DbSet<Photograph> Photographs { get; set; }
        public DbSet<PhotographFullImage> PhotographFullImages { get; set; }
        public PhotosContext()
        : base("name=PhotosContext")
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Photograph>()
            .HasRequired(p => p.PhotographFullImage)
            .WithRequiredPrincipal(p => p.Photograph);
            modelBuilder.Entity<Photograph>()
            .ToTable("Photograph", "BazaDeDate");
            modelBuilder.Entity<PhotographFullImage>()
            .ToTable("Photograph", "BazaDeDate");
        }

    }
}
