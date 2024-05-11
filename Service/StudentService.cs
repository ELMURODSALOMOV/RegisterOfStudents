using RegisterOfStudents.Broker.Logging;
using RegisterOfStudents.Broker.Storeage;
using RegisterOfStudents.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegisterOfStudents.Service
{
    internal class StudentService : IStudentService
    {
        private readonly ILoggingBroker loggingBroker;
        private readonly IStoreageBroker storeageBroker;
        public StudentService()
        {
            this.loggingBroker = new LoggingBroker();
            this.storeageBroker = new ListStoreageBroker();
        }

        public List<Student> CheckoutByLetter(char letter)
        {
            return letter.ToString() is null
                ? InvalidCheckoutByLetter()
                : ValidationCheckoutByLetter(letter);
        }

        private List<Student> ValidationCheckoutByLetter(char letter)
        {
           List<Student> studenInfo = this.storeageBroker.FindStudentByLetter(letter);
            foreach (var student in studenInfo)
            {
                if (student.FirstName.Contains(letter.ToString()))
                {
                    this.loggingBroker.LogInformation($"Id: {student.Id}\n" +
                            $"FirstName: {student.FirstName}\nLastName: {student.LastName}\n" +
                            $"Age: {student.Age}\nEmail: {student.Email}");
                    return studenInfo; 
                }
                else
                {
                    if(!student.FirstName.Contains(letter.ToString()))
                    {
                        this.loggingBroker.LogError("The reference is not valid.");
                        return studenInfo;
                    }
                }
            }
            return new List<Student>();
        }

        private List<Student> InvalidCheckoutByLetter()
        {
            this.loggingBroker.LogError("Not Found.");
            return new List<Student>();
        }

        public Student CheckoutByName(string firstName)
        {
            return firstName is null
                ? InvalidCheckoutByName()
                : ValidationAndCheckoutByName(firstName);
        }

        public Print DisplayStudent(int id)
        {
            return new Print();
                 
        }

        public Student InsertStudent(Student student)
        {
            return student is null
                ? InsertStudentInvalid()
                : ValidationAndInsertStudent(student);
        }

        private Student ValidationAndInsertStudent(Student student)
        {
            if(student.Id is 0
                || String.IsNullOrWhiteSpace(student.FirstName)
                || String.IsNullOrWhiteSpace(student.LastName))
            {
                this.loggingBroker.LogError("Invalid student information.");
                return new Student();
            }
            else
            {
                var studentInformation = this.storeageBroker.AddStudent(student);
                if(studentInformation is null)
                {
                    this.loggingBroker.LogError("Not Added.");
                }
                else
                {
                    this.loggingBroker.LogInformation("Secssesfull.");
                }
                return studentInformation;
            }
        }

        private Student InvalidCheckoutByName()
        {
            this.loggingBroker.LogError("The firstname is invalid.");
            return new Student();
        }

        private Student ValidationAndCheckoutByName(string firstName)
        {
            if (String.IsNullOrWhiteSpace(firstName))
            {
                this.loggingBroker.LogError("The information is not fully formed.");
                return new Student();
            }
            else
            {
                var studentInfo = this.storeageBroker.FindStudentByName(firstName);
                if (studentInfo is not null)
                {
                    this.loggingBroker.LogInformation($"Reference found.\nId: {studentInfo.Id}\n" +
                        $"FirstName: {studentInfo.FirstName}\nLastName: {studentInfo.LastName}\n" +
                        $"Age: {studentInfo.Age}\nEmail: {studentInfo.Email}");
                }
                else
                {
                    this.loggingBroker.LogError("Not Found.");
                }

                return studentInfo;
            }
        }

        private Student InsertStudentInvalid()
        {
            this.loggingBroker.LogError("Student info is null.");
            return new Student();
        }
    }
}
