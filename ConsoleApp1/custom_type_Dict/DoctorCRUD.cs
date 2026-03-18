using System;
using custom_type_Dict.Models; // Bridging to the Models folder

namespace custom_type_Dict.GenericClasses
{
    internal class DoctorCRUD
    {
        // Static allows you to call this without creating a 'new DoctorCRUD()'
        public static Doctor AddDoctor()
        {
            Doctor d = new Doctor();

            Console.Write("Please enter doctor Id: ");
            d.Id = int.Parse(Console.ReadLine());

            Console.Write("Please enter doctor Name: ");
            d.Name = Console.ReadLine();

            Console.Write("Please enter Specialization: ");
            d.Specialization = Console.ReadLine();

            return d;
        }
    }
}