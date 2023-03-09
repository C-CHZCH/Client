using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.Models
{
    public class Homework
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Student_id { get; set; }

        public string Teacher_id { get; set; }

        public string? Word_url { get; set; }

        [NotMapped]
        public IFormFile words { get; set; }
    }
}
