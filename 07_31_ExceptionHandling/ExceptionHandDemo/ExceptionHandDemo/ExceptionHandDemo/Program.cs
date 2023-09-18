using System;
namespace ExceptionHandDemo
{
    class Student
    {
        public string stdStudentName = "Abcd";

        private static void PrintStudentName(Student student)
        {
            if (student == null)
            {
                throw new NullReferenceException("Student Object is null");
            }
        }

        static void Main(string[] args)
        {
            Student student = null;
            

            try
            {
                PrintStudentName(student);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadKey();
        }
    }
}
