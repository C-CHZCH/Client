using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Newtonsoft.Json;

namespace WebApplication1.Models
{
    public class Student
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Student_Class { get; set; }

        [Required]
        public string Student_id { get; set; }
        public List<Homework>? Homeworks { get; set; }

        public string? Teacher_id { get; set; }
    }
}
