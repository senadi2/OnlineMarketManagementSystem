using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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
                                ProductId = Convert.ToInt32(reader["id"]),
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

            using (MySqlConnection conn = DBConnection.GetConnection()) 
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
                                ProductId = Convert.ToInt32(reader["id"]),
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
    


    public void UpdateProduct(Product product)
        {
            using (MySqlConnection conn = DBConnection.GetConnection())
            {
                conn.Open();

                string query = @"UPDATE products 
                                 SET name = @Name, description = @Description, price = @Price, quantity = @Quantity, Category = @Category 
                                 WHERE ProductId = @ProductId";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Name", product.Name);
                    cmd.Parameters.AddWithValue("@Description", product.Description);
                    cmd.Parameters.AddWithValue("@Price", product.Price);
                    cmd.Parameters.AddWithValue("@Quantity", product.QuantityAvailable);
                    cmd.Parameters.AddWithValue("@Category", product.Category);
                    cmd.Parameters.AddWithValue("@ProductId", product.ProductId);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        // Make sure this also exists (you already seem to be calling it)
        public void AddProduct(Product product)
        {
            string connectionString = "server=localhost;user=root;password=;database=Online_Marketplace_System;";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();

                string query = "INSERT INTO products (seller_id, name, description, price, quantity, category) " +
               "VALUES (@sellerId, @name, @desc, @price, @qty, @category)";


                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@sellerId", product.Seller_id);
                    cmd.Parameters.AddWithValue("@name", product.Name);
                    cmd.Parameters.AddWithValue("@desc", product.Description);
                    cmd.Parameters.AddWithValue("@price", product.Price);
                    cmd.Parameters.AddWithValue("@qty", product.QuantityAvailable);
                    cmd.Parameters.AddWithValue("@category", product.Category);

                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
    

