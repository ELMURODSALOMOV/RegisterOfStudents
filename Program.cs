
using RegisterOfStudents.Broker.Storeage;
using RegisterOfStudents.Models;
using RegisterOfStudents.Service;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

StudentService studentService = new StudentService();
Console.WriteLine("Harfni kiriting");
char letter = Convert.ToChar(Console.ReadLine());
studentService.CheckoutByLetter(letter);
