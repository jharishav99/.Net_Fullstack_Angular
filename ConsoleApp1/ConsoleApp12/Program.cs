using System;
using System.Collections.Generic;
using custom_type_Dict.Models;         // FIX: Allows access to Doctor class
using custom_type_Dict.GenericClasses; // FIX: Allows access to DoctorCRUD tool

namespace custom_type_Dict
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Implementation of a Generic List restricted to 'Doctor' types
            List<Doctor> doctors = new List<Doctor>();

            // Calling the tool to get user input and return a Doctor object
            Doctor d = DoctorCRUD.AddDoctor();

            // Adding that object to our generic collection
            doctors.Add(d);

            // Accessing data through iteration
            foreach (Doctor doc in doctors)
            {
                Console.WriteLine($"ID: {doc.Id} | Name: {doc.Name} | Specialty: {doc.Specialization}");
            }

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}