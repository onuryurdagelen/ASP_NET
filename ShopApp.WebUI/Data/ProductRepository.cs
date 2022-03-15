using ShopApp.WebUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopApp.WebUI.Data
{
    //Bir kere kullanmak icin,ornek olusturmamasi icin static kullanilir.
    public static class ProductRepository
    {
        private static List<Product> _products = null;

        static ProductRepository()
        {
            _products = new List<Product>()
            {
                new Product()
            {
                ProductId = 1,
                Name = "Iphone 8",
                Price = 3500,
                Description = "Good One",
                IsApproved=false,
                ImageUrl = "1.png",
                CategoryId = 1
            },
              new Product()
                {
                  ProductId = 2,
                    Name = "Iphone 10",
                    Price = 3800,
                    Description = "Really Good One",
                IsApproved=true,
                ImageUrl = "2.png",
                CategoryId = 1
                    //IsApproved = true
                },
                new Product()
                {
                    ProductId = 3,
                    Name = "Iphone 7",
                    Price = 3200,
                    Description = "Really Good One",
                    IsApproved=true,
                    ImageUrl = "3.png",
                    CategoryId = 1
                },
                new Product()
                {
                    ProductId = 4,
                    Name = "Iphone 9",
                    Price = 5800,
                    Description = "Really Good One",
                    IsApproved=false,
                    ImageUrl = "4.png",
                    //IsApproved = true,
                    CategoryId = 1
                },
                new Product()
                {
                    ProductId = 5,
                    Name = "PC 1",
                    Price = 5800,
                    Description = "Really Good One",
                    IsApproved=false,
                    ImageUrl = "5.png",
                    //IsApproved = true,
                    CategoryId = 2
                },
                new Product()
                {
                    ProductId = 6,
                    Name = "PC 2",
                    Price = 5800,
                    Description = "Really Good One",
                    IsApproved=false,
                    ImageUrl = "6.jpeg",
                    //IsApproved = true,
                    CategoryId = 2
                },
                new Product()
                {
                    ProductId = 7,
                    Name = "PC 3",
                    Price = 5800,
                    Description = "Really Good One",
                    IsApproved=false,
                    ImageUrl = "7.jpeg",
                    //IsApproved = true,
                    CategoryId = 2
                },
                new Product()
                {
                    ProductId = 8,
                    Name = "Apple 1",
                    Price = 5800,
                    Description = "Really Good One",
                    IsApproved=false,
                    ImageUrl = "8.jpeg",
                    //IsApproved = true,
                    CategoryId = 3
                },
                new Product()
                {
                    ProductId = 9,
                    Name = "Apple 2",
                    Price = 5800,
                    Description = "Really Good One",
                    IsApproved=false,
                    ImageUrl = "9.jpeg",
                    //IsApproved = true,
                    CategoryId = 3
                },
                new Product()
                {
                    ProductId = 10,
                    Name = "Refrigerator ",
                    Price = 5800,
                    Description = "Really Good One",
                    IsApproved=false,
                    ImageUrl = "10.png",
                    //IsApproved = true,
                    CategoryId = 4
                },
                new Product()
                {
                    ProductId = 11,
                    Name = "Apple 2",
                    Price = 5800,
                    Description = "Really Good One",
                    IsApproved=false,
                    ImageUrl = "11.jpeg",
                    //IsApproved = true,
                    CategoryId = 4
                },
            };
            }
        public static List<Product> Products
        {
            get
            {
               return  _products;
            }
        }
        public static void AddProduct(Product product)
        {
            _products.Add(product);
        }
        public static Product GetProductById(int id)
        {
            return _products.FirstOrDefault(p => p.ProductId == id);
        }
    }
}
