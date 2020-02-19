using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace rapnetApi.Models
{
    public class DatabaseContext : DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder
            .UseSqlite(@"Data Source = Diamonds.db;");
        }

        public DbSet<Diamond> Diamonds { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Diamond>().HasData(
            new Diamond() { Id = 1, Shape = "Round" ,Clarity = "IF", Color = "D", ListPrice = 18000, Price = 15000, Size = new decimal(1.02) },
            new Diamond() { Id = 2, Shape = "Pear" ,Clarity = "VVS1", Color = "E", ListPrice = 21000, Price = 20000, Size = new decimal(1.5) },
            new Diamond() { Id = 3, Shape = "Emerald" ,Clarity = "VVS2", Color = "G", ListPrice = 10000, Price = 12000, Size = new decimal(0.95) },
            new Diamond() { Id = 4, Shape = "Round" ,Clarity = "I2", Color = "F", ListPrice = 55000, Price = 50000, Size = new decimal(2.15) },
            new Diamond() { Id = 5, Shape = "Emerald", Clarity = "IF", Color = "D", ListPrice = 3000, Price = 2000, Size = new decimal(0.5) },
            new Diamond() { Id = 6, Shape = "Pear", Clarity = "I1", Color = "G", ListPrice = 12000, Price = 15000, Size = new decimal(1.2) }
            );
        }
    }
}
