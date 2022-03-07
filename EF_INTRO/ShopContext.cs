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
    }
}
