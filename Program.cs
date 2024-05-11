
using RegisterOfStudents.Broker.Storeage;
using RegisterOfStudents.Models;
using RegisterOfStudents.Service;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

StudentService studentService = new StudentService();
Console.WriteLine("Ismni kiriting:");
string studentName = Console.ReadLine();
studentService.CheckoutByName(studentName);
