using System.Data.Entity;

namespace CodeFirstDemo
{
public class StudentContext : DbContext
{
public StudentContext() : base("StudentDB")
{
}

public DbSet<Student> Students { get; set; }
}
}
