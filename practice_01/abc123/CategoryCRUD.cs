using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace abc123
{
    internal class CategoryCRUD
    {
   
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["MyConnection"].ToString());
        public void AddCategory(int id, string name)
        {
            string query = "INSERT INTO Categories (id, [name]) VALUES (@id, @name)";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@name", name);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            Console.WriteLine("Added successfully!");
        }
        public void ShowCategories()
        {
            string query = "SELECT * FROM Categories";
            SqlCommand cmd = new SqlCommand(query, con);

            con.Open();
            SqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                Console.WriteLine($"ID: {rdr["id"]} | Name: {rdr["name"]}");
            }
            con.Close();
        }
        public void UpdateCategory(int id, string newName)
        {
            string query = "UPDATE Categories SET [name] = @name WHERE id = @id";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@name", newName);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            Console.WriteLine("Updated successfully!");
        }
        public void DeleteCategory(int id)
        {
            string query = "DELETE FROM Categories WHERE id = @id";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@id", id);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            Console.WriteLine("Deleted successfully!");
        } }
}
