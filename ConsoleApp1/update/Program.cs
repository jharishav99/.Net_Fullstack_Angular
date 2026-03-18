using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace update
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1. Initialize the CRUD class
            CategoryCRUD crud = new CategoryCRUD();

            // 2. Create a Category object to UPDATE
            // Note: Use an ID that actually exists in your database
            Category updateCat = new Category();
            updateCat.Id = 1;
            updateCat.Name = "Electronics - Updated";

            Console.WriteLine("Attempting to update...");

            // 3. Call the method and capture the return string ("Success" or Error)
            string result = crud.UpdateCategory(updateCat);

            // 4. Show the result to the user
            Console.WriteLine("Result: " + result);

            // Keep the console window open
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
