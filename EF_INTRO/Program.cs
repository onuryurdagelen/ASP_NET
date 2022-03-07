using EF_INTRO.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace EF_INTRO
{
    class Program
    {
        static void Main(string[] args)
        {
            //InsertUsers();

            //InsertAddresses();

            //AddSingleProduct();

            //AddProducts();

            //getAllProducts();

            //getProductById(3);
            //getProductByName("sams");

            //updateProduct();

            //deleteProduct();
            //dotnet ef database update ==> Console bu komutu yazdigimizda database olusturulur ve gerekli guncellemeler gerceklestirilir.

            using (var db = new ShopContext())
            {
                var user = db.Users.FirstOrDefault(i => i.Username == "onur134");

                if (user != null)
                {

                    user.Addresses = new List<Address>(); // Address prop'u basta null bir deger oldugu icin user.Address'in yeni bir List<Address> instance'i olusturulmalidir.

                    user.Addresses.AddRange(
                        new List<Address>()
                        {
                        new Address() { Fullname = "Onur Yurdagelen", Title = "Ev Adresi 1", Body = "Istanbul" },
                        new Address() { Fullname = "Onur Yurdagelen", Title = "Ev Adresi 2", Body = "Ankara" },
                        new Address() { Fullname = "Onur Yurdagelen", Title = "Ev Adresi 3", Body = "Tokat" },
                        }
                        );

                    db.SaveChanges();
                }
            }
        }
        static void getAllProducts()
        {
            using(var context = new ShopContext())
            {
                //get metodu ile urunleri alirken ToList() metodu kullanilmalidir.
                var products = context
                    .Products
                        .Select(p => new
                        {
                            p.Name,
                            p.Price
                        })
                    .ToList();

                foreach (var product in products)
                {
                    Console.WriteLine($"Name: {product.Name} Price: {product.Price}");
                }
            }
        }
        static void getProductById(int id)
        {
            using (var context = new ShopContext())
            {
                //get metodu ile urunleri alirken ToList() metodu kullanilmalidir.
                var result = context
                    .Products
                    .Where(p => p.Id == id)
                    .Select(p =>
                        new
                        {
                            p.Name,
                            p.Price
                        })
                    .FirstOrDefault();

                if (result !=null)
                {
                    Console.WriteLine($"Name: {result.Name} Price: {result.Price}"); 
                }
                
            }
        }
        static void AddProducts()
        {
            using (var db = new ShopContext())
            {
                try
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
                    //db.Products.AddRange(products);
                    //db.Products.Add(p);

                    db.SaveChanges();

                    Console.WriteLine("Veriler eklendi...");
                }
                catch (Exception ex)
                {

                    Console.WriteLine(ex.Message);
                }

            }
     

        }
        static void AddSingleProduct()
        {
            using (var db = new ShopContext())
            {
                //Birden fazla product ekleme
                var product = new Product()
                {
                    Name = "Ipad",
                    Price = 3500
                };
                db.Products.Add(product);

                db.SaveChanges();

                Console.WriteLine("Veri eklendi...");

            }
        }

        static void getProductByName(string name)
        {
            using (var context = new ShopContext())
            {
                //get metodu ile urunleri alirken ToList() metodu kullanilmalidir.
                var products = context
                    .Products
                    .Where(p => p.Price >2000m && p.Name.Contains(name))
                    .Select(p =>
                        new
                        {
                            p.Name,
                            p.Price
                        })
                    .ToList();

                foreach (var product in products)
                {
                    Console.WriteLine($"Name: {product.Name} Price: {product.Price}");
                }

            }
        }

        static void updateProduct()
        {

            using(var db = new ShopContext())
            {
                var p = db.Products.Where(i => i.Id == 1).FirstOrDefault();

                if (p != null)
                {
                    p.Price = 2400;
                    db.Products.Update(p);
                    db.SaveChanges();
                }
            }

            //2.Yontem
            //using(var db = new ShopContext())
            //{
            //    var entity = new Product() { Id = 1};

            //    db.Products.Attach(entity);

            //    entity.Price = 3000;

            //    db.SaveChanges();
            //}

            //1.Yontem
            //using(var db = new ShopContext())
            //{
            //    //change tracking
            //    var p = db
            //        .Products
            //        .Where(i => i.Id == 1).FirstOrDefault();

            //    if (p !=null)
            //    {
            //        p.Price *= 1.2m;

            //        db.SaveChanges();

            //        Console.WriteLine("Veri guncellendi...");
            //    }
            //}
        }

        static void deleteProduct()
        {
            using(var db = new ShopContext())
            {
                var p = new Product() { Id = 2 };

                //db.Products.Remove(p);
                db.Entry(p).State = EntityState.Deleted;

                db.SaveChanges();

            }

            //using(var db = new ShopContext())
            //{
            //    var p = db.Products.FirstOrDefault(i => i.Id == id);

            //    if (p != null)
            //    {
            //        db.Products.Remove(p);
            //        //db.Remove()
            //        db.SaveChanges();

            //        Console.WriteLine("Veri silindi...");
            //    }
            //}
        }

        static void InsertUsers()
        {
            var users = new List<User>()
            {
                new User(){Username = "onur134",Email = "onur213@test.com"},
                new User(){Username = "bekir123",Email = "bekir213@test.com"},
                new User(){Username = "kaan123",Email = "kaan213@test.com"},
            };

            using (var db = new ShopContext())
            {
                db.Users.AddRange(users);

                db.SaveChanges();

                Console.WriteLine("Users successfully inserted to database...");
            }
        }

        static void InsertAddresses()
        {
            var address = new List<Address>()
            {
                new Address(){Fullname = "Onur Yurdagelen",Title = "Ev Adress",Body = "Istanbul",UserId = 1},
                new Address(){Fullname = "Onur Yurdagelen",Title = "Is Adresi",Body = "Istanbul",UserId =1},
                new Address(){Fullname = "Bekir Yurdagelen",Title = "Work Adress",Body = "Kocaeli",UserId =2},
                new Address(){Fullname = "Kaan Yurdagelen",Title = "Hotel",Body = "Tokat",UserId = 3}

            };

            using (var db = new ShopContext())
            {
                db.Addresses.AddRange(address);

                db.SaveChanges();

                Console.WriteLine("Addresses successfully inserted to database...");
            }
        }
    }
}
