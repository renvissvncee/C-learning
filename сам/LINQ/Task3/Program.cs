using System;
class Student
{
    public string? Name { get; set; }
    public int Age { get; set; }
}

class Program {
    public static void Main()
    {
        List<Student> students = new List<Student>
        {
            new Student { Name = "Alex", Age = 20 },
            new Student { Name = "Bob", Age = 17 },
            new Student { Name = "Clara", Age = 22 },
            new Student { Name = "Diana", Age = 18 }
        };

        foreach (var student in students.Where(n => n.Age >= 18))
        {
            Console.WriteLine(student.Name);
        }
    }
}


