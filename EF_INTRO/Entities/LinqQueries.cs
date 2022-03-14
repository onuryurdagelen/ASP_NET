using EF_INTRO.Data.EfCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EF_INTRO.Entities
{
    public class LinqQueries
    {

        public void getLinqQueries(NorthwindContext northwindContext)
        {
            using (var db = northwindContext)
            {
                //Siparis sayisi sifirdan buyuk olan musteriler.
                var customers = db.Customers
                    //.Where(i => i.Orders.Count() > 0) // i.Orders.Any() ==> herhangi bir kaydin olmasi durumudur.Ayni sonuc alinir.
                    .Where(i => i.Orders.Any())
                    .Select(i => new CustomerDemo
                    {
                        CustomerId = i.Id,
                        Name = i.FirstName,
                        OrderCount = i.Orders.Count(),
                        Orders = i.Orders.Select(o => new OrderDemo
                        {
                            OrderId = o.Id,
                            Total = (decimal)o.OrderDetails.Sum(od => od.Quantity * od.UnitPrice),
                            Products = o.OrderDetails.Select(p => new ProductDemo
                            {
                                ProductId = (int)p.ProductId,
                                ProductName = p.Product.ProductName,
                                ProductPrice = p.Product.ListPrice
                            }).ToList()
                        }).ToList()
                    })
                    .OrderBy(i => i.OrderCount)
                    .ToList();

                foreach (var customer in customers)
                {
                    Console.WriteLine($"ID: {customer.CustomerId } Name: {customer.Name} OrderCount: {customer.OrderCount}");
                    foreach (var order in customer.Orders)
                    {
                        Console.WriteLine($"OrderID: {order.OrderId} Order Total: {order.Total}");

                        foreach (var product in order.Products)
                        {
                            Console.WriteLine($"ProductID: {product.ProductId} Product Name: {product.ProductName} Product Price: {product.ProductPrice}");
                        }
                    }
                }

            }
        }
        public void getAllCustomers(NorthwindContext northwindContext)
        {
            //using(var db = northwindContext)
            //{
            //    var city = "Miami";
            //    var customers = db.Customers
            //      .FromSqlRaw("select * from customers where city={0}",city).ToList(); //Tum customer'lari getirir.

            //    foreach (var item in customers)
            //    {
            //        Console.WriteLine(item.FirstName);
            //    }
            //}

            using(var db = new CustomNorthwindContext())
            {
                var customers = db.CustomerOrders.FromSqlRaw("select c.id,c.first_name,count(*) as count from customers c inner join orders o on c.id = o.customer_id group by c.id").ToList();

                foreach (var item in customers)
                {
                    Console.WriteLine("CustomerId: {0} firstName: {1} Order Count: {2}",item.CustomerId,item.FirstName,item.OrderCount);
                }
            }
        }
    }
}
