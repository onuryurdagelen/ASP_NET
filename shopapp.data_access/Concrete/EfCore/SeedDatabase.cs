using Microsoft.EntityFrameworkCore;
using shopapp.entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace shopapp.data_access.Concrete.EfCore
{
    public static class SeedDatabase
    {
        public static void Seed()
        {
            var context = new ShopContext();

            if (context.Database.GetPendingMigrations().Count() == 0)
            {
                if (context.Categories.Count() == 0)
                {
                    context.Categories.AddRange(Categories);
                }
                if (context.Categories.Count() == 0)
                {
                    context.Products.AddRange(Products);
                }
            }
            context.SaveChanges();
        }
        private static Category[] Categories =
        {
            new Category(){Name = "Phones"},
            new Category(){Name = "PC"},
            new Category(){Name = "Laptop"},
            new Category(){Name = "Electronic"},
        };
        private static Product[] Products =
        {
            new Product(){Name = "Samsung S5",Price=2000,ImageUrl="1.jpg",Description="Iyi telefon",IsApproved=true},
            new Product(){Name = "Samsung S6",Price=3000,ImageUrl="10.png",Description="Cok Iyi telefon",IsApproved=true},
            new Product(){Name = "Samsung S7",Price=4000,ImageUrl="2.png",Description="Cok cok Iyi telefon",IsApproved=false},
            new Product(){Name = "Samsung S8",Price=5000,ImageUrl="3.png",Description="Cok cok cok Iyi telefon",IsApproved=true},

        };
        
    }
}
