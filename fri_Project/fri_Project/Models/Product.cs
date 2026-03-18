namespace fri_Project.Models
{
    public class Product
    {
        public int Id { get; set; }

        public string? Name { get; set; }

        // Foreign key
        public int CategoryId { get; set; }

        // Navigation property
        public Category? Category { get; set; }
    }
}
