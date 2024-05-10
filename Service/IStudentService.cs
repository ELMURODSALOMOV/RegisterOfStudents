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
        void Print(string firstName, string Email);
        bool LetterCheck(string firstName);
        bool Check(Student student);
        Student InsertStudent(Student student);
    }
}
