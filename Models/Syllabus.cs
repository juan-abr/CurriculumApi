using Microsoft.EntityFrameworkCore;

namespace CurriculumApi.Models
{
    public class Syllabus
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Content { get; set; }    // Should be a file (i.e. jpeg or png)
        public string? Media { get; set; }
    }
    public class SyllabusDb : DbContext
    {
        public SyllabusDb(DbContextOptions options) : base(options) { }
        public DbSet<Syllabus> Syllabi { get; set; }
    }
}