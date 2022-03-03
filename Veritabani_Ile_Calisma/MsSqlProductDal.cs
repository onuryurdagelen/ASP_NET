using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace Veritabani_Ile_Calisma
{
    public class MsSqlProductDal : IProductDal
    {
         private SqlConnection SqlConnection()
        {
            string connectionString = @"Data Source=DESKTOP-9SFDJHR;Initial Catalog=Northwind;Integrated Security=SSPI;";
            return new SqlConnection(connectionString);
        }
        public void Create(Product p)
        {
            throw new NotImplementedException();
        }
        

        public List<Product> GetAllProducts()
        {
            List<Product> products = null;
            using (var connection = SqlConnection())
            {
                try
                {
                    connection.Open();
                    Console.WriteLine("Baglanti saglandi...");

                    string sql = "select * from products";
                    SqlCommand command = new SqlCommand(sql, connection);

                    var reader = command.ExecuteReader();

                    
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
            using (var connection = new SqlConnection())
            {

                try
                {
                    connection.Open();
                    Console.WriteLine("Baglanti saglandi...");

                    //sql injection==> kotu niyetli sorgu
                    string queryStr = "select * from Products where ProductID=@productId";

                    SqlCommand command = new SqlCommand(queryStr, connection);
                    command.Parameters.Add("@productId", System.Data.SqlDbType.Int).Value = id;

                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        product = new Product()
                        {
                            ProductId = int.Parse(reader["ProductID"].ToString()),
                            ProductName = reader["ProductName"].ToString(),
                            Price = double.Parse(reader["UnitPrice"]?.ToString())
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
                    connection.Close();
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
            using (var connection = new SqlConnection())
            {

                try
                {
                    connection.Open();
                    Console.WriteLine("Baglanti saglandi...");

                    //sql injection==> kotu niyetli sorgu
                    string queryStr = "select * from Products where product_name LIKE %productName%";

                    SqlCommand command = new SqlCommand(queryStr, connection);
                    command.Parameters.Add("@productName", System.Data.SqlDbType.Text).Value = "%"+productName+"%";

                    SqlDataReader reader = command.ExecuteReader();

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
