using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace WebApplication1.Models
{
    public class Teacher
    {
        [Key]
        public Guid Id { get; set; }
        public string Name { get; set; }

        public List<Class> ClassList { get; set; }
        [Required]
        public string Teacher_id { get; set; }
        
    }
}
