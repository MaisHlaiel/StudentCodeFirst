using System.ComponentModel.DataAnnotations;

namespace CodeFirstDemo
{
public class Student
{
[Key]
public int StudentId { get; set; }

public string FirstName { get; set; }

public string LastName { get; set; }
}
}
