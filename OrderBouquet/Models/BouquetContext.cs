using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace OrderBouquet.Models
{
    public class BouquetContext : DbContext
    {
        public DbSet<Bouquet> Bouquets { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Order> Orders { get; set; }

        public BouquetContext(DbContextOptions<BouquetContext> opsions) : base(opsions)
        {
            Database.EnsureCreated();
        }
        //ленивая загрузка всех свойств
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseLazyLoadingProxies();
        }
    }
}
