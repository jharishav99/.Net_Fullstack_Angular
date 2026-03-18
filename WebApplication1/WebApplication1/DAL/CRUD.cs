using Microsoft.Data.SqlClient;
using WebApplication1.Models;

namespace WebApplication1.DAL
{
    public class CRUD
    {
        private readonly string _connStr;

        public CRUD(IConfiguration config)
        {
            _connStr = config.GetConnectionString("DefaultConnection")
                       ?? throw new Exception("Connection string not found");
        }


        // GET ALL
        public List<Patient> GetPatients()
        {
            List<Patient> list = new();

            using SqlConnection con = new(_connStr);
            SqlCommand cmd = new("SELECT * FROM Patients", con);

            con.Open();
            SqlDataReader rdr = cmd.ExecuteReader();

            while (rdr.Read())
            {
                list.Add(new Patient
                {
                    PatientId = Convert.ToInt32(rdr["PatientId"]),
                    Name = rdr["Name"].ToString() ?? "",
                    Age = rdr["Age"].ToString() ?? "",
                    Gender = rdr["Gender"].ToString() ?? "",
                    Problem = rdr["Problem"].ToString() ?? ""
                });
            }
            return list;
        }

        // GET BY ID
        public Patient GetPatient(int id)
        {
            Patient p = new();

            using SqlConnection con = new(_connStr);
            SqlCommand cmd = new("SELECT * FROM Patients WHERE PatientId=@id", con);
            cmd.Parameters.AddWithValue("@id", id);

            con.Open();
            SqlDataReader rdr = cmd.ExecuteReader();

            if (rdr.Read())
            {
                p.PatientId = Convert.ToInt32(rdr["PatientId"]);
                p.Name = rdr["Name"].ToString() ?? "";
                p.Age = rdr["Age"].ToString() ?? "";
                p.Gender = rdr["Gender"].ToString() ?? "";
                p.Problem = rdr["Problem"].ToString() ?? "";
            }

            return p;
        }

        // INSERT
        public void InsertPatient(Patient p)
        {
            using SqlConnection con = new(_connStr);

            SqlCommand cmd = new(
                "INSERT INTO Patients(Name,Age,Gender,Problem) VALUES(@n,@a,@g,@pr)",
                con);

            cmd.Parameters.AddWithValue("@n", p.Name);
            cmd.Parameters.AddWithValue("@a", p.Age);
            cmd.Parameters.AddWithValue("@g", p.Gender);
            cmd.Parameters.AddWithValue("@pr", p.Problem);

            con.Open();
            cmd.ExecuteNonQuery();
        }

        // UPDATE
        public void UpdatePatient(Patient p)
        {
            using SqlConnection con = new(_connStr);

            SqlCommand cmd = new(
                "UPDATE Patients SET Name=@n,Age=@a,Gender=@g,Problem=@pr WHERE PatientId=@id",
                con);

            cmd.Parameters.AddWithValue("@n", p.Name);
            cmd.Parameters.AddWithValue("@a", p.Age);
            cmd.Parameters.AddWithValue("@g", p.Gender);
            cmd.Parameters.AddWithValue("@pr", p.Problem);
            cmd.Parameters.AddWithValue("@id", p.PatientId);

            con.Open();
            cmd.ExecuteNonQuery();
        }

        // DELETE
        public void DeletePatient(int id)
        {
            using SqlConnection con = new(_connStr);
            SqlCommand cmd = new("DELETE FROM Patients WHERE PatientId=@id", con);
            cmd.Parameters.AddWithValue("@id", id);

            con.Open();
            cmd.ExecuteNonQuery();
        }
    }
}
