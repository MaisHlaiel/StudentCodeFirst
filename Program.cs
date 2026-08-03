using System;

namespace CodeFirstDemo
{
class Program
{
static void Main(string[] args)
{
using (StudentContext db = new StudentContext())
{
Student student = new Student()
{
FirstName = "John",
LastName = "Smith"
};

db.Students.Add(student);
db.SaveChanges();

Console.WriteLine("Student added successfully!");
}

Console.WriteLine("Press any key to exit...");
Console.ReadKey();
}
}
}
