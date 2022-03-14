using EF_INTRO.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Console;
using System;
using System.Collections.Generic;
using System.Text;

namespace EF_INTRO
{
    public class ShopContext:DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }

        public DbSet<Order> Orders { get; set; }

        public DbSet<User> Users { get; set; }

        public DbSet<Address> Addresses { get; set; }

        public DbSet<Customer> Customers { get; set; }

        ////static LoggerFactory object
        public static readonly ILoggerFactory MyLoggerFactory
            = LoggerFactory.Create(builder => { builder.AddConsole(); });


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder
           .UseLoggerFactory(MyLoggerFactory)  //tie-up DbContext with LoggerFactory object
                                               //.EnableSensitiveDataLogging()
                                               //.UseSqlite("Data Source=shop.db");
                                               //.UseSqlServer(@"Data Source=DESKTOP-9SFDJHR;Initial Catalog=ShopDB;Integrated Security=SSPI");
                .UseMySql(@"server=localhost;port=3306;database=shopDB;username=root;password=onur123;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<User>()
                .HasIndex(u => u.Username) // Username alanina indeks biraktik.
                .IsUnique();

            modelBuilder.Entity<Customer>()
                .Property(p => p.IdentityNumber)
                .HasMaxLength(11)
                .IsRequired();

            modelBuilder.Entity<Product>()
                        .ToTable("Urunler")
                        .HasKey(p => p.Id);

            modelBuilder.Entity<ProductCategory>()
                .HasKey(t => new { t.ProductId, t.CategoryId }); //ManyToMany tanimlamak icin
            modelBuilder.Entity<ProductCategory>()
                .HasOne(pc => pc.Product)
                .WithMany(p => p.ProductCategories)
                .HasForeignKey(pc => pc.ProductId); //ManyToMany tanimlamak icin

            modelBuilder.Entity<ProductCategory>()
                .HasOne(ct => ct.Category)
                .WithMany(c => c.ProductCategories)
                .HasForeignKey(ct => ct.CategoryId);// ManyToMany tanimlamak icin

        }
    }
}
