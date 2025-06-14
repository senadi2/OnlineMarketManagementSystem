using MySql.Data.MySqlClient;
using OnlineMarketPLace.models; // Product class namespace
using System.Collections.Generic;

namespace OnlineMarketPLace.services
{
    public class ProductService
    {
        private string connStr = "server=localhost;user id=root;password=;database=online_marketplace_system;";

        public List<Product> GetProducts(string keyword)
        {
            List<Product> products = new List<Product>();

            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                conn.Open();

                string sql = @"SELECT id, seller_id, name, description, price, quantity 
                               FROM products 
                               WHERE Name LIKE @keyword OR Description LIKE @keyword";

                using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@keyword", "%" + keyword + "%");

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            products.Add(new Product
                            {
                                ProductId = reader.GetInt32("id").ToString(), 
                                SellerUsername = reader.GetInt32("seller_id").ToString(), 
                                Name = reader.GetString("name"),
                                Description = reader.GetString("description"),
                                Price = reader.GetDecimal("price"),
                                QuantityAvailable = reader.GetInt32("quantity")
                            });
                        }
                    }
                }
            }

            return products;
        }

        public Product GetProductById(string productId)
        {
            Product product = null;

            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                conn.Open();

                string sql = @"SELECT ProductId, SellerUsername, Name, Description, Price, QuantityAvailable 
                               FROM Products 
                               WHERE ProductId = @productId";

                using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@productId", productId);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            product = new Product
                            {
                                ProductId = reader.GetString("ProductId"),
                                SellerUsername = reader.GetString("SellerUsername"),
                                Name = reader.GetString("Name"),
                                Description = reader.GetString("Description"),
                                Price = reader.GetDecimal("Price"),
                                QuantityAvailable = reader.GetInt32("QuantityAvailable")
                            };
                        }
                    }
                }
            }

            return product;
        }
    }
}
   