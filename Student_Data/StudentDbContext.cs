using Microsoft.EntityFrameworkCore;
using Student_Data.Model;

namespace Student_Data;

public class StudentDbContext : DbContext
{
    public StudentDbContext(DbContextOptions<StudentDbContext> options) : base(options)
    {
    }

    public DbSet<Student> Students { get; set; }
    public DbSet<StudentResponse> StudentList { get; set; }
    public DbSet<DropdownList> State { get; set; }
    public DbSet<DropdownList> City { get; set; }
}
