using System;
using System.Collections.Generic;
using System.ComponentModel;


namespace AnonymousTypeDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Anonymous type creation for Student

            var Student = new
            {
                ID = 3389,
                Name= "John",
                Course="C#.net",
                DOJ="2023-06-24",
                //Nested decalartion
                Address = new {City= "Bengaluru",Street="Marathahalli",Pin=560037 },
                Marks= new {M1=45,M2=76,M3=72}
            };


            //Accessing the Anonymous type
            Console.WriteLine("Student Details\n");
            Console.WriteLine("-------------------");
            Console.WriteLine($"Student Id : {Student.ID} \nStudent Name : {Student.Name} \nStudent Course" +
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
