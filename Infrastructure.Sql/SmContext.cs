using Domain.Entittes;
using Infrastructure.Sql.Configuration;
using Microsoft.EntityFrameworkCore;
using System;

namespace Infrastructure.Sql
{
    public class SmContext : DbContext
    {
        public SmContext(DbContextOptions options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ProductConfiguration());
            modelBuilder.ApplyConfiguration(new UserConfiguration());
            modelBuilder.ApplyConfiguration(new LaptopConfiguration());
            modelBuilder.ApplyConfiguration(new CameraConfiguration());
            modelBuilder.ApplyConfiguration(new CellphoneConfiguration());
            base.OnModelCreating(modelBuilder);
        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Media> Medias { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Laptop> Laptops { get; set; }
        public DbSet<Camera> Cameras { get; set; }
        public DbSet<Cellphone> Cellphones { get; set; }
    }
}
