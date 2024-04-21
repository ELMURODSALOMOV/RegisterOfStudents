
using RegisterOfStudents.Models;
using System.Collections.Generic;

List<Student> students = new List<Student>()
{
    new Student()
    {
        Id = 1,
        FirstName = "Elmurod",
        LastName = "Salomov",
        Age = 27,
        Email = "Salomov@gmail.com"
    },
    new Student()
    {
        Id = 2,
        FirstName = "Baxtiyor",
        LastName = "Ruziyev",
        Age = 27,
        Email = "Ruziyev@gmail.com"
    },
    new Student()
    {
        Id = 3,
        FirstName = "Asilbek",
        LastName = "Abduvohidov",
        Age = 27,
        Email = "Abduvohidov@gmail.com"
    },
    new Student()
    {
        Id = 4,
        FirstName = "Donyor",
        LastName = "Homidov",
        Age = 27,
        Email = "Homidov@gmail.com"
    },
    new Student()
    {
        Id = 5,
        FirstName = "Shoxrux",
        LastName = "Abduvaliyev",
        Age = 27,
        Email = "Abduvaliyev@gmail.com"
    }
};

students.ForEach(student => Console.WriteLine($"{student.FirstName}\n{student.Email}"));

foreach(Student student in students)
{
    if(student.FirstName.ToLower().Contains("a"))
    {
        Console.WriteLine(student.FirstName);
    }
}