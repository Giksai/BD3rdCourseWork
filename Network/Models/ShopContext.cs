using System;
using Microsoft.EntityFrameworkCore;

namespace Network.Models
{
    public class ShopContext : DbContext //Crash when all name lengths is more than 16
        //Entities's property names also affects it
    {
        /// <summary>
        /// Accounts
        /// </summary>
        public DbSet<Account> Acc { get; set; }
        /// <summary>
        /// Purchases
        /// </summary>
        public DbSet<Purchase> Prc { get; set; }
        /// <summary>
        /// Products (Amount, without description
        /// </summary>
        public DbSet<Product> Prd { get; set; }
        /// <summary>
        /// Items storage
        /// </summary>
        public DbSet<ItemsStorage> Str { get; set; }
        /// <summary>
        /// ProductDescription
        /// </summary>
        public DbSet<ProductD> PrD { get; set; }

        //public DbSet<Gear> Gears { get; set; }
        //public DbSet<Weapon> Weapons { get; set; }

        public ShopContext()
        {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseOracle("Data Source=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)(PORT=1521))(CONNECT_DATA=(SERVICE_NAME=xe))); User Id = SCOTT; Password = dandan2011;");
        }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    base.OnModelCreating(modelBuilder);

        //    modelBuilder.Entity<>(entity =>
        //    {
        //        entity.HasKey(e => e.RecordId);
        //        entity.Property(e => e.FirstName).IsRequired();
        //        entity.Property(e => e.LastName).IsRequired();
        //        entity.Property(e => e.DateOfBirth).IsRequired();
        //    });
        //}
    }
}
