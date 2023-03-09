using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace WebApplication1.Models
{
    public class Class
    {
        [Key]
        public Guid Id { get; set; }

        public string Name { get; set; }

        public List<Teacher> Teachers { get; set; }


    }
}
