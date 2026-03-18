using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace custom_type_Dict
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Doctor> doctors = new List<Doctor>();
            Doctor d = DoctorCRUD.AddDoctor();
            Doctor d = new Doctor();
            d.Id = 1;
            d.Name = "ram";
            d.Specialization = "Eye";
            d.Experience = 12;
            d.Phone = "123456789";
            doctors.Add(d);

            Doctor d1 = new Doctor();
            d1.Id = 2;
            d1.Name = "shyam";
            d1.Specialization = "Heart";
            d1.Experience =23;
            d1.Phone = "000000000";
            doctors.Add(d1);

            foreach (Doctor doc in doctors)
            {
                Console.WriteLine($"Doctor {doc.Name} specializes in {doc.Specialization} with {doc.Experience} years of experience.");
            }
        }
    }
}
