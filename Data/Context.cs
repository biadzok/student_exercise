using Microsoft.EntityFrameworkCore;
using TestApplication.Models;

namespace TestApplication.Data
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options) {}
        public DbSet<Values> Values {get; set;}
        public DbSet<Student> Student {get; set;}
        public DbSet<Student_description> Student_Description {get; set;}
    }
}