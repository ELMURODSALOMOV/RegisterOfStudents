using RegisterOfStudents.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegisterOfStudents.Broker.Storeage
{
    internal class ListStoreageBroker : IStoreageBroker
    {
        List<Student> demoStudents = new List<Student>();
        List<Student> students = new List<Student>();
        public ListStoreageBroker()
        {
            students[0] = new Student()
            {
                FirstName = "Elmurod",
                LastName = "Salomov",
                Age = 27,
                Email = "Salomov@gamil.com"
            };
            students[1] = new Student()
            {
                FirstName = "Baxtiyor",
                LastName = "Ruziyev",
                Age = 27,
                Email = "Ruziyev"
            };
            students[2] = new Student()
            {
                FirstName = "Asilbek",
                LastName = "Abduvohidov",
                Age = 27,
                Email = "Abduvohidov"
            };
        }

        public Student AddStudent(Student student)
        {
            throw new NotImplementedException();
        }

        public bool CheckoutStudent(Student student)
        {
            throw new NotImplementedException();
        }
    }
}
