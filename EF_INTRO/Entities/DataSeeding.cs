using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EF_INTRO.Entities
{
    public class DataSeeding
    {
        public  void Seed(DbContext context)
        {
            if (context .Database.GetPendingMigrations().Count() == 0) // Butun migrationlar database'e aktarilmissa
            {
                if (context is ShopContext)
                {
                    ShopContext _context = context as ShopContext;

                    if (_context.Products.Count() == 0)
                    {
                        //productlari ekle

                        _context.Products.AddRange(Products);
                    }
                    if (_context.Categories.Count() == 0)
                    {
                        //category ekle

                        _context.Categories.AddRange(Categories);
                    }

                   
                }
                context.SaveChanges();

                //ShopContext

                //AbcContext

            }
        }

        private static Product[] Products =
        {
            new Product() {Name = "Samsung S9",Price = 4000,Id=1},
            new Product() {Name = "Samsung S10",Price = 4500,Id=2},
            new Product() {Name = "Asus Razor Gaming",Price = 5000,Id=3},
        };

        private static Category[] Categories =
        {
            new Category() {Name = "Mobilya"},
            new Category() {Name = "Beyaz Esya"}
        };
    }
}
