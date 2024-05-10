﻿using RegisterOfStudents.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegisterOfStudents.Broker.Storeage
{
    internal interface IStoreageBroker
    {
        Print PrintNameAndEmail(int id);
        bool FindStudentByLetter(string firstName);
        Student FindStudentById(int id);
        Student AddStudent(Student student);
    }
}
