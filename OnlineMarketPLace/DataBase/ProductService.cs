using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using OnlineMarketPLace.DataBase;
using OnlineMarketPLace.models;

namespace OnlineMarketPLace.services
{
    public class ProductService
    {
        // Method to get all products filtered by keyword (e.g., name or category)
        public List<Product> GetProducts(string keyword)
        {
            List<Product> products = new List<Product>();

            using (MySqlConnection conn = DBConnection.GetConnection())  //
            {
                conn.Open();

                string query = "SELECT id, seller_id, name, description, price, quantity FROM products WHERE name LIKE @keyword";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@keyword", "%" + keyword + "%");

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Product product = new Product
                            {
                                ProductId = reader["id"].ToString(),
                                SellerUsername = reader["seller_id"].ToString(),
                                Name = reader["name"].ToString(),
                                Description = reader["description"].ToString(),
                                Price = Convert.ToDecimal(reader["price"]),
                                QuantityAvailable = Convert.ToInt32(reader["quantity"])
                            };

                            products.Add(product);
                        }
                    }
                }
            }

            return products;
        }

        // Method to get a single product by its ID
        public Product GetProductById(int productId)
        {
            Product product = null;

            using (MySqlConnection conn = DBConnection.GetConnection())  // ✅ OK
            {
                conn.Open();

                string query = "SELECT id, seller_id, name, description, price, quantity FROM products WHERE id = @productId";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@productId", productId);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            product = new Product
                            {
                                ProductId = reader["id"].ToString(),
                                SellerUsername = reader["seller_id"].ToString(),
                                Name = reader["name"].ToString(),
                                Description = reader["description"].ToString(),
                                Price = Convert.ToDecimal(reader["price"]),
                                QuantityAvailable = Convert.ToInt32(reader["quantity"])
                            };
                        }
                    }
                }
            }

            return product;
        }
    }
}
