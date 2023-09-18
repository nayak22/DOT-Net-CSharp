using System;

namespace CustomExceptionDemo
{
    public class InvalidAgeException : Exception
    {
        public InvalidAgeException(string message): base(message) { }
    }

    public class ProgramE
    {
        static void Validate(int age)
        {
            if (age < 18)
            {
                throw new InvalidAgeException("Sorry Age must be greater than 18");
            }
        }
        public static void Main(string[] args)
        {
            try
            {
                Validate(12);

            }
            catch (Exception e) { Console.WriteLine(e.Message); }
            Console.WriteLine("Rest of the Code");
            Console.WriteLine();
        }
    }
}