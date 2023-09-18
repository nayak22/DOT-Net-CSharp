using System;

namespace ObjectIntializerDemo
{
    public class Student
    {
        public int StudentID { get; set; }
        public string StudentName { get; set; }

        public int Age { get; set; }
        public string Address { get; set; }

    }
    class Program
    {
        public static void Main()
        {
            Student student = new Student()
            {
                StudentID = 1,
                StudentName = "John",
                Age = 20,
                Address = "Bengaluru"
            };
        }
        
    }
}


