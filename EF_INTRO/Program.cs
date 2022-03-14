using EF_INTRO.Data.EfCore;
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

            //using (var db = new ShopContext())
            //{
            //    var user = db.Users.FirstOrDefault(i => i.Username == "onur134");

            //    if (user != null)
            //    {

            //        user.Addresses = new List<Address>(); // Address prop'u basta null bir deger oldugu icin user.Address'in yeni bir List<Address> instance'i olusturulmalidir.

            //        user.Addresses.AddRange(
            //            new List<Address>()
            //            {
            //            new Address() { Fullname = "Onur Yurdagelen", Title = "Ev Adresi 1", Body = "Istanbul" },
            //            new Address() { Fullname = "Onur Yurdagelen", Title = "Ev Adresi 2", Body = "Ankara" },
            //            new Address() { Fullname = "Onur Yurdagelen", Title = "Ev Adresi 3", Body = "Tokat" },
            //            }
            //            );

            //        db.SaveChanges();
            //    }
            //}

            using (var db = new NorthwindContext())
            {
                //    var products = db.Products.ToList();

                //    foreach (var product in products)
                //    {
                //        Console.WriteLine(product.ProductName);
                //    }
                //}

                //***Tum musteri kayitlarini getiriniz***.

                //var customers = db.Customers.ToList();

                //foreach (var item in customers)
                //{
                //    Console.WriteLine(item.FirstName + " "+item.LastName);
                //}

                // *** Tum musteri kayitlarinin sadece firstName ve lastName bilgilerini getiriniz.***
                //var firstLastName = db.Customers.Select(c => new
                //{
                //    c.FirstName,
                //    c.LastName
                //});

                //foreach (var item in firstLastName)
                //{
                //    Console.WriteLine(item.FirstName + " "+ item.LastName);
                //}

                // *** New York'ta yasayan musterileri isim sirasina gore getiriniz***

                //var customer = db.Customers
                //    .Where(i => i.City == "New York")
                //    .Select(c => new {c.FirstName,c.LastName,c.City})
                //    .OrderByDescending(o => o.FirstName)
                //    .ToList();

                //foreach (var item in customer)
                //{
                //    Console.WriteLine(item.FirstName + " " + item.LastName + " "+item.City);
                //}

                //** "Beverages" kategorisine ait urunlerin isimlerini getiriniz.

                //var BeveragesCategories = db.Products
                //    .Where(c => c.Category == "Beverages")
                //    .Select(n => n.ProductName)
                //    //.OrderByDescending(o => o.ProductName)
                //    .ToList();

                //foreach (var name in BeveragesCategories)
                //{
                //    Console.WriteLine(name);
                //}

                //*** En son eklenen 5 urun bilgisini aliniz.***

                //var products = db.Products
                //    .OrderByDescending(o=> o.Id) // Azalan bir sekilde siralar.
                //    .Take(5); //Tablonun en ustunden 5 urunu alir.

                //foreach (var product in products)
                //{
                //    Console.WriteLine(product.Id+" "+product.ProductName);
                //}

                //***Fiyati 10 ile 30 arasinda olan urunlerin isim,fiyat bilgilerini getiriniz.***

                //var products = db.Products
                //    .Where(i => i.ListPrice >= 10 && i.ListPrice <= 30)
                //    .Select(i => new { i.ProductName, i.ListPrice })
                //    .OrderBy(i => i.ListPrice)
                //    .ToList();

                //foreach (var product in products)
                //{
                //    Console.WriteLine($"Product Name: {product.ProductName} Price: {product.ListPrice}");
                //}

                //***"Baverages" kategorisindeki urunlerin ortalama fiyati nedir?***

                //var BeveragesAveragesPrice = db.Products
                //    .Where(i => i.Category == "Beverages")
                //    .Average(i => i.ListPrice);

                //Console.WriteLine("Ortalama: {0}",BeveragesAveragesPrice);

                //*** "Beverages" kategorisinde kac urun vardir?***

                //var productCount = db.Products.Count(i => i.Category == "Beverages");

                //Console.WriteLine("Urun Adet: {0}", productCount);

                //*** "Beverages" ve "Condiments" kategorielerindeki urunlerin toplam fiyati nedir?
                //var totalPrices = db.Products
                //    .Where(i => i.Category == "Beverages" || i.Category == "Condiments")
                //    .Sum(i => i.ListPrice);

                //Console.WriteLine("Toplam Fiyat: {0}",totalPrices);

                // ***'Tea' kelimesini iceren urunleri getiriniz***

                //var products = db.Products
                //    .Where(i => i.ProductName.Contains("Tea")) // LIKE == Contains
                //    .Select(i => i.ProductName)
                //    .ToList();

                //foreach (var item in products)
                //{
                //    Console.WriteLine(item);
                //}

                //*** En pahali urun ve en ucuz urun hangisidir?

                //var minPrice = db.Products.Min(i => i.ListPrice);
                //var maxPrice = db.Products.Max(i => i.ListPrice);

                //Console.WriteLine($"En ucuz urun: {minPrice}");
                //Console.WriteLine($"En pahali urun: {maxPrice}");

                //En ucuz urunu bulur.
                //var product = db.Products
                //    .Where(i => i.ListPrice == (db.Products.Min(a => a.ListPrice)))
                //    .FirstOrDefault();

                //En pahali urunu bulur.
                //var product2 = db.Products
                //    .Where(i => i.ListPrice == (db.Products.Max(a => a.ListPrice)))
                //    .FirstOrDefault();

                //Console.WriteLine($"Name: {product.ProductName} price: {product.ListPrice}");
                //Console.WriteLine($"Name: {product2.ProductName} price: {product2.ListPrice}");

                var linqQueries = new LinqQueries();
                //linqQueries.getLinqQueries(new NorthwindContext());
                linqQueries.getAllCustomers(new NorthwindContext());

            }
            using (var db = new ShopContext())
            {
                //var customer = new Customer()
                //{
                //    IdentityNumber = "1231234566",
                //    FirstName = "Bekir",
                //    LastName = "Yurdagelen",
                //    User = db.Users.FirstOrDefault(i =>i.Id == 3)
                //};
                //db.Customers.Add(customer);
                //db.SaveChanges();

                //var user = new User()
                //{
                //    Username = "burakbaykut60",
                //    Email = "burakbaykut60@gmail.com",
                //    Customer = new Customer()
                //    {
                //        FirstName = "Burak",
                //        LastName = "Baykut",
                //        IdentityNumber = "2323232",
                //    }
                //};

                //db.Users.Add(user);

                //db.SaveChanges();

                //var products = new List<Product>()
                //    {
                //        new Product(){Name = "Ipad M2",Price = 3999},
                //        new Product(){Name = "Ipad M1",Price = 4500},
                //        new Product(){Name = "Ipad M3",Price = 5000},
                //    };

                //db.Products.AddRange(products);

                //var categories = new List<Category>()
                //{
                //    new Category() { Name = "Telefon" },
                //    new Category() { Name = "Elektronik" },
                //    new Category() { Name = "Bilgisayar" }
                //};

                //db.Categories.AddRange(categories);

                //db.SaveChanges();

                //int[] ids = new int[2] { 1, 2 };
                //var p = db.Products.Find(1);

                //p.ProductCategories = ids.Select(cid => new ProductCategory() {

                //    CategoryId = cid,
                //    ProductId = p.Id
                //}).ToList();

                //db.SaveChanges();

                //var p = new Product()
                //{
                //    Name = "Samsung S22",
                //    Price = 3000,
                //    Id = 2
                //};

                //db.Products.Add(p);

                //var p = db.Products.FirstOrDefault(p => p.Id == 2);

                //p.Name = "Samsung S10";

                //var dataSeeding = new DataSeeding();

                //dataSeeding.Seed(new ShopContext());

                //var dataSeeding2 = new DataSeeding();

                //dataSeeding2.Seed(new ShopContext());






            }
            static void getAllProducts()
            {
                using (var context = new ShopContext())
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

                    if (result != null)
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
                        .Where(p => p.Price > 2000m && p.Name.Contains(name))
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

                using (var db = new ShopContext())
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
                using (var db = new ShopContext())
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
}
