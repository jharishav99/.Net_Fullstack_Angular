using System;
using System.Configuration;
using System.Data.SqlClient;

namespace abc123
{
    internal class ProductCRUD
    {
        string cs = ConfigurationManager.ConnectionStrings["MyConnection"].ToString();

        // ADD
        public void AddProduct(string name, int catId)
        {
            using (SqlConnection con = new SqlConnection(cs))
            {
                string query = "INSERT INTO products (Name, CategoryId) VALUES (@name, @catId)";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@catId", catId);

                con.Open();
                cmd.ExecuteNonQuery();
                Console.WriteLine("Product Added Successfully!");
            }
        }

        // FETCH (Show all products)
        public void FetchProducts()
        {
            using (SqlConnection con = new SqlConnection(cs))
            {
                string query = "SELECT * FROM products";
                SqlCommand cmd = new SqlCommand(query, con);

                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();
                Console.WriteLine("\n--- PRODUCTS ---");
                while (rdr.Read())
                {
                    Console.WriteLine($"ID: {rdr["ProductId"]} | Name: {rdr["Name"]} | CategoryId: {rdr["CategoryId"]}");
                }
            }
        }

        // UPDATE
        public void UpdateProduct(int id, string newName)
        {
            using (SqlConnection con = new SqlConnection(cs))
            {
                string query = "UPDATE products SET Name = @name WHERE ProductId = @id";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@name", newName);

                con.Open();
                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                    Console.WriteLine("Product Updated Successfully!");
                else
                    Console.WriteLine("Product ID not found!");
            }
        }

        // DELETE
        public void DeleteProduct(int id)
        {
            using (SqlConnection con = new SqlConnection(cs))
            {
                string query = "DELETE FROM products WHERE ProductId = @id";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@id", id);

                con.Open();
                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                    Console.WriteLine("Product Deleted Successfully!");
                else
                    Console.WriteLine("Product ID not found!");
            }
        }
    }
}
