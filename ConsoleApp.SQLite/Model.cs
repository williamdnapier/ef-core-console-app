using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace ConsoleApp.SQLite
{
    public class Product
    {
        public int ProductId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
    }

    public class Store
    {
        public int StoreId { get; set; }
        public string Url {get; set;}
        public string Description { get; set; }

        public ICollection<Product> Products { get; set; }
    }

    public class StoreContext : DbContext
    {
        public DbSet<Store> Stores { get; set; }
        public DbSet<Product> Products { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=store.db");
        }
    }
}