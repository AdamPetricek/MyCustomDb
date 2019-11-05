using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using MyCustomDb.Data;

namespace MyCustomDb
{
    class MainDbContext : DbContext
    {
        public DbSet<House> Houses { get; set; }
        public DbSet<City> City { get; set; }

        public MainDbContext() : base()
        {
            Database.EnsureDeleted();
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(@"Data Source=");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<City>().HasData(new City { Id = 1, Name = "Liberec" });
            modelBuilder.Entity<City>().HasData(new City { Id = 2, Name = "Jablonec nad Nisou" });
            modelBuilder.Entity<House>().HasData(new House { CityId = 1, Id = 1, Height = 50 });
            modelBuilder.Entity<House>().HasData(new House { CityId = 1, Id = 2, Height = 35 });
            modelBuilder.Entity<House>().HasData(new House { CityId = 1, Id = 3, Height = 40 });
            modelBuilder.Entity<House>().HasData(new House { CityId = 2, Id = 4, Height = 25 });
            modelBuilder.Entity<House>().HasData(new House { CityId = 2, Id = 5, Height = 15 });
        }
    }
}
