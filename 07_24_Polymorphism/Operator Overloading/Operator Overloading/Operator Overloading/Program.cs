using System;


namespace OperatorOverloading
{
    class PolymorphismDemo
    {
        public static void Main(string[] args)
        {
            int x=7, y=6;
            int sum = x + y;//"+" will add to numbers
            Console.WriteLine($"sum of 2 numbers : {sum}");

            string firstName = "Samrath ", lastName = "Nayak";
            string fullName=firstName + lastName;   //"+ " concatenates 2 strings 
            Console.WriteLine($"Welcome to Learning club, {fullName}");
            Console.ReadKey();
        }
    }
}
