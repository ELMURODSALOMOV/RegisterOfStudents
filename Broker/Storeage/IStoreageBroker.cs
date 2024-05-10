using RegisterOfStudents.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegisterOfStudents.Broker.Storeage
{
    internal interface IStoreageBroker
    {
        Student PrintNameAndEmail(string id);
        bool LetterCheckout(string firstName);
        bool CheckoutStudent(Student student);
        Student AddStudent(Student student);
    }
}
