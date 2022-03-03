using EF_INTRO.Entities;
using System;
using System.Collections.Generic;

namespace EF_INTRO
{
    class Program
    {
        static void Main(string[] args)
        {
           

            using (var db = new ShopContext())
            {
                //Birden fazla product ekleme
                var products = new List<Product>()
                {
                   new Product(){Name= "Samsung S6",Price= 2500},
                   new Product(){Name= "Samsung S7",Price= 2700},
                   new Product(){Name= "Samsung S8",Price= 2850},
                   new Product(){Name= "Iphone S6",Price= 2500}
                };
                var p = new Product()
                {
                    Name = "Samsung S5",
                    Price = 2000
                };

                foreach (var product in products)
                {
                    db.Products.Add(product);
                }

                //OR
                db.Products.AddRange(products);
                //db.Products.Add(p);

                db.SaveChanges();

                Console.WriteLine("Veriler eklendi...");

            }

            //dotnet ef database update ==> Console bu komutu yazdigimizda database olusturulur ve gerekli guncellemeler gerceklestirilir.
        }
    }
}
