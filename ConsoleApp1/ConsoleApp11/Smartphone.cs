using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    public class Smartphone
    {
        public string Brand;
        public string Model;
        public int StorageGB;

        public Smartphone()
        {
            Brand = "Unknown";
            Model = "Generic";
            StorageGB = 64;
        } 
        public Smartphone(string brand, string model)
        {
            Brand = brand;
            Model = model;
            StorageGB = 128;
        }
        public Smartphone(string brand, string model, int storage)
        {
            Brand = brand;
            Model = model;
            StorageGB = storage;
        }
        public void Send(string message)
        {
            Console.WriteLine($"Sending text: {message}");
        }
        public void Send(string message, string contact)
        {
            Console.WriteLine($"Sending to {contact}: {message}");
        }
        public void Send(string message, string contact, bool isUrgent)
        {
            string prefix = isUrgent ? "![URGENT]! " : "";
            Console.WriteLine($"To {contact}: {prefix}{message}");
        }

        public void DisplaySpecs()
        {
            Console.WriteLine($"Device: {Brand} {Model} ({StorageGB}GB)");
        }
    }
    }
