using System;

namespace DestructorsDemo
{
    public class Student
    {
        public string strName;
        public int intSno;
        public string strClass;

        public Student()
        {
            this.strName = "Venky";
            this.intSno = 440;
            this.strClass = "C#";


        }

        //destructor
        ~Student()
        {
            Console.WriteLine("Student Class Destructor involed");
            Console.ReadKey();
        }


    }
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            student.strName = "Harshith";
            student.intSno = 1000;
            student.strClass = "HTML,Css";

            Console.WriteLine($"Students Details are");
            Console.WriteLine("------------------------------");

            Console.WriteLine($"Students Name: {student.strName}, StudentID: {student.intSno} and Student Class: {student.strClass}");

            Console.ReadKey();
        }
    }
}