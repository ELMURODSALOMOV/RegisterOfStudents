using RegisterOfStudents.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace RegisterOfStudents.Broker.Storeage
{
    internal interface IStoreageBroker
    {
        Print PrintNameAndEmail(int id);
        List<Student> FindStudentByLetter(char letter);
        Student FindStudentByName(string firstName);
        Student AddStudent(Student student);
    }
}
