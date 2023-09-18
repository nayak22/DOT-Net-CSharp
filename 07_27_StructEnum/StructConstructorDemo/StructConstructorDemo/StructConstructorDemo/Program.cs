using System;

namespace StructConstructor
{
    struct Student
    {
        //properties
        string Name;
        int Age;


        //constructor
        public Student(string name, int age)
        {
            Name = name;
            Age = age;
        }

        //Methods
        public void printStudentDetails()
        {
            Console.WriteLine($"Name:{Name}");
            Console.WriteLine($"Age:{Age}");


        }

    }

    class Program
    {
        public static void Main(string[] args)
        {
            Student student = new Student("Linn", 24);
            student.printStudentDetails();

            Console.ReadKey();

        }
        
    }


}