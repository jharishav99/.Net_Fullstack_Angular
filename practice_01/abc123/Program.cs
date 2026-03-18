using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abc123
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ProductCRUD productApp = new ProductCRUD();
            bool running = true;

            while (running)
            {
                Console.WriteLine("\n--- PRODUCT MANAGEMENT ---");
                Console.WriteLine("1. Add Product");
                Console.WriteLine("2. Update Product");
                Console.WriteLine("3. Delete Product");
                Console.WriteLine("4. Fetch Products");
                Console.WriteLine("5. Exit");
                Console.Write("Choose Option: ");

                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.Write("Enter Product Name: ");
                        string name = Console.ReadLine();

                        Console.Write("Enter Category Id: ");
                        int catId = int.Parse(Console.ReadLine());

                        productApp.AddProduct(name, catId);
                        break;

                    case 2:
                        Console.Write("Enter Product ID to Update: ");
                        int updateId = int.Parse(Console.ReadLine());

                        Console.Write("Enter New Name: ");
                        string newName = Console.ReadLine();

                        productApp.UpdateProduct(updateId, newName);
                        break;

                    case 3:
                        Console.Write("Enter Product ID to Delete: ");
                        int deleteId = int.Parse(Console.ReadLine());

                        productApp.DeleteProduct(deleteId);
                        break;

                    case 4:
                        productApp.FetchProducts();
                        break;

                    case 5:
                        running = false;
                        Console.WriteLine("Exiting...");
                        break;

                    default:
                        Console.WriteLine("Invalid Choice!");
                        break;
                }
            }
        }
    }
}