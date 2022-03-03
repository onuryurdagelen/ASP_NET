using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Veritabani_Ile_Calisma
{
    public interface IProductDal
    {
        List<Product> GetAllProducts();

        Product GetProductById(int id);

        List<Product> Find(string productName);

        void Create(Product p);

        void Update(int id,Product p);

        void Delete(int productId);
    }
    class Program
    {
        static void Main(string[] args)
        {

            //var mysqlProductDal = new MySQLProductDal();
            //var products = mysqlProductDal.GetAllProducts();

            //var msSqlProductDal = new MsSqlProductDal();
            //var msProducts = mysqlProductDal.GetAllProducts();

            //Product manager sayesinde sql'leri kontrol edebiliriz.

            //var productDal = new ProductManager(new MySQLProductDal());

            var productDal = new ProductManager(new MySQLProductDal());

            //var products = productDal.GetAllProducts();

            //Console.Write("Lutfen ogrenmek istediginiz urununun ID'sini giriniz: ");
            //int id = Convert.ToInt32(Console.ReadLine());

            //var filteredProducts = productDal.GetProductById(3);
            var filteredProducts = productDal.Find("C");

            foreach (var product in filteredProducts)
            {
                Console.WriteLine($"{product.ProductName}");
            }

            Console.WriteLine(filteredProducts);
        }
       
        
    }
}
