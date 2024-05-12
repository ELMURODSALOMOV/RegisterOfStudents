//----------------------------------------
// Great Code Team (c) All rights reserved
//----------------------------------------

using RegisterOfStudents.Models;

namespace RegisterOfStudents.Service
{
    internal interface IStudentService
    {
        DemoStudent DisplayStudent(int id);
        List<Student> CheckoutByLetter(char letter);
        Student CheckoutByName(string firstName);
        Student InsertStudent(Student student);
    }
}
