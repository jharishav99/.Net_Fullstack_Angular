using System;
using System.ComponentModel.DataAnnotations;

namespace _2232026.Models
{
    public class Party
    {
        public int Id { get; set; }

        [Required]
        public string? Name { get; set; }

        public bool IsExternal { get; set; }
    }
}
