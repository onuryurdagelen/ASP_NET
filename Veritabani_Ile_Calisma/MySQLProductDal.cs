using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace Veritabani_Ile_Calisma
{
    public class MySQLProductDal : IProductDal
    {
        private MySqlConnection MySqlConnection()
        {
            string connectionString = @"server=localhost;port=3306;database=northwind;user=root;password=onur123;";
            return new MySqlConnection(connectionString);
        }

        public void Create(Product p)
        {
            throw new NotImplementedException();
        }
        List<Product> products = null;
        public List<Product> GetAllProducts()
        {
           
            using (var connection = MySqlConnection())
            {
                try
                {
                    connection.Open();
                    Console.WriteLine("Baglanti saglandi...");

                    string sql = "select * from products";
                    MySqlCommand command = new MySqlCommand(sql, connection);

                    var reader = command.ExecuteReader();

                    products = new List<Product>();

                    //Product sayisi kadar dongu doner.Kayitlari okur.
                    while (reader.Read())
                    {
                        products.Add(
                            new Product
                            {
                                ProductId = int.Parse(reader["id"].ToString()),
                                ProductName = reader["product_name"].ToString(),
                                Price = double.Parse(reader["list_price"]?.ToString())
                            }); ;

                    };
                    reader.Close();
                }
                catch (Exception ex)
                {

                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    connection.Close();
                    Console.WriteLine("Baglanti koptu...");
                }
            }
            return products;
        }

        public Product GetProductById(int id)
        {
            Product product = null;
            using (var connection = new MySqlConnection())
            {

                try
                {
                    connection.Open();
                    Console.WriteLine("Baglanti saglandi...");

                    //sql injection==> kotu niyetli sorgu
                    string queryStr = "select * from products where id=@productId";

                    MySqlCommand command = new MySqlCommand(queryStr, connection);
                    command.Parameters.Add("@productId", MySqlDbType.Int32).Value = id;

                    MySqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        product = new Product()
                        {
                            ProductId = int.Parse(reader["id"].ToString()),
                            ProductName = reader["product_name"].ToString(),
                            Price = double.Parse(reader["list-price"]?.ToString())
                        };
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {

                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    //connection.Close();
                }
            }
            return product;
        }

        public void Update(Product p)
        {
            throw new NotImplementedException();
        }

        public void Update(int productId)
        {
            throw new NotImplementedException();
        }

        public void Update(int id, Product p)
        {
            throw new NotImplementedException();
        }

        public void Delete(int productId)
        {
            throw new NotImplementedException();
        }

        public List<Product> Find(string productName)
        {
            List<Product> products = null;
            using (var connection = new MySqlConnection())
            {

                try
                {
                    connection.Open();
                    Console.WriteLine("Baglanti saglandi...");

                    //sql injection==> kotu niyetli sorgu
                    string queryStr = "select * from products where product_name LIKE %productName%";

                    MySqlCommand command = new MySqlCommand(queryStr, connection);
                    command.Parameters.Add("@productName",MySqlDbType.String).Value = "%" + productName + "%";

                    MySqlDataReader reader = command.ExecuteReader();

                    products = new List<Product>();

                    //Product sayisi kadar dongu doner.Kayitlari okur.
                    while (reader.Read())
                    {
                        products.Add(
                            new Product
                            {
                                ProductId = int.Parse(reader["ProductID"].ToString()),
                                ProductName = reader["ProductName"].ToString(),
                                Price = double.Parse(reader["UnitPrice"]?.ToString())
                            }); ;

                    };
                    reader.Close();


                }
                catch (Exception ex)
                {

                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    connection.Close();
                }
            }
            return products;
        }
    }
}
