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
        private List<Student> students = new List<Student>();
        public ListStoreageBroker()
        {

            this.students.Add(new Student()
            {
                Id = 1,
                FirstName = "Elmurod",
                LastName = "Salomov",
                Age = 27,
                Email = "Salomov@gmail.com"
            });
            this.students.Add(new Student()
            {
                Id = 2,
                FirstName = "Baxtiyor",
                LastName = "Ruziyev",
                Age = 27,
                Email = "Ruziyev@gmail.com"
            });
            this.students.Add(new Student()
            {
                Id = 3,
                FirstName = "Asilbek",
                LastName = "Abduvohidov",
                Age = 27,
                Email = "Abduvohidov@gmail.com"
            });
            this.students.Add(new Student()
            {
                Id = 4,
                FirstName = "Donyor",
                LastName = "Homidov",
                Age = 27,
                Email = "Homidov@gmail.com"
            });
            this.students.Add(new Student()
            {
                Id = 5,
                FirstName = "Shoxrux",
                LastName = "Abduvaliyev",
                Age = 27,
                Email = "Abduvaliyev@gmail.com"
            });
            
        }

        public Student AddStudent(Student student)
        {
            foreach(Student studentItem in this.students)
            {
                if(studentItem.Id == student.Id
                    && studentItem.Email == student.Email)
                {
                    return new Student();
                }
            }
            this.students.Add(student);
            return student;
        }

        public Student FindStudentByName(string firstName)
        {
            foreach (Student studentItem in this.students)
            {
                if (studentItem.FirstName == firstName)
                {
                    return studentItem;
                }
            }
            return new Student();
        }

        public List<Student> FindStudentByLetter(char letter)
        {
            List<Student> studentNew = new List<Student>();
            foreach (Student studentItem in this.students)
            {
                if (studentItem.FirstName.Contains(letter))
                {
                    studentNew.Add(studentItem);
                }
            }
            return studentNew;
        }

        public Print PrintNameAndEmail(int id)
        {
            foreach (Student studentItem in this.students)
            {
                if (studentItem.Id == id)
                {
                    var studentInfo = new Print()
                    {
                        FirstName = studentItem.FirstName,
                        Email = studentItem.Email
                    };
                    return studentInfo;
                }
            }
            return new Print();
        }
    }
}
