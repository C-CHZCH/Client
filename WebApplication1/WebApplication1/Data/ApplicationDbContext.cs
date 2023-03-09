using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Models;

namespace WebApplication1.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

       public DbSet<Class> dbClass { set; get; }
       public DbSet<Homework> dbHomeworksl { set; get; }
       public DbSet<Student> dbStudent { set; get; }
        public DbSet<Teacher> dbTeacher { set; get; }
    }
}