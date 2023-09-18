using System;
using System.Collections.Generic;
using System.ComponentModel;


namespace ArrayOfAnonymous
{
    class Program
    {
        static void Main(string[] args)
        {
            //anonymous type creation of student
            var Student = new
            {
                Id = 3398,
                Name = "John",
                Course = "C#.Net",
                DOJ = "2023-06-24",
                // Nested anonymous type declarion
                Address = new { City = "Hyd", Street = "Ameerpet", Pin = 12333 },
                Marks = new { M1 = 65, M2 = 76, M3 = 90 }

            };

            var Students = new[]
            {
                new{id =1,name="Ravi",course="C#.net"},
                new{id =2,name="Venky",course="C#.net"},
                new{id =3,name="Vishnu",course="C#.net"},
                new{id =4,name="Narayna",course="C#.net"}
            };
            Console.WriteLine("Student Details\n");
            Console.WriteLine("-------------------");
            Console.WriteLine(Students[0]);
            Console.WriteLine(Students[1]);
            Console.WriteLine(Students[2]);
            Console.WriteLine(Students[3]);

            Console.WriteLine("-------------------\n");
            // accessing of anonymous student
            Console.WriteLine("Student Details\n");
            Console.WriteLine("-------------------");
            Console.WriteLine($"Student Id : {Student.Id} \nStudent Name : {Student.Name} \nStudent Course" +
                $" : {Student.Course}");

            // accessing of nested anonymous type
            Console.WriteLine("\nStudent Address & Marks Details\n");
            Console.WriteLine("-------------------");
            Console.WriteLine($"Student Address : {Student.Address.City} {Student.Address.Street} {Student.Address.Pin}" +
                $" \nStudent Marks : {Student.Marks.M1}, {Student.Marks.M2}, {Student.Marks.M3}");

            Console.ReadLine();

        }
    }
}