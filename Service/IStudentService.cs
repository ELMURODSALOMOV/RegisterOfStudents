using RegisterOfStudents.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegisterOfStudents.Service
{
    internal interface IStudentService
    {
        Print DisplayStudent(int id);
        List<Student> CheckoutByLetter(char letter);
        Student CheckoutById(Student student);
        Student InsertStudent(Student student);
    }
}
