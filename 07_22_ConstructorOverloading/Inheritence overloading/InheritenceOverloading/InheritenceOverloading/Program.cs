using System;

namespace InheritenceOverloading
{
    public class Parent
    {
        //Add number method in parent class
        public int AddNumber(int a, int b)
        {
            Console.WriteLine("Parent method called");
            return a + b;
        }

    }
    public class Child:Parent {
        //add number in  child class with 3 parameters
        public int AddNumber(int a, int b,int c)
        {
            Console.WriteLine("Child method called");
            return a + b+c;
        }


    }   

    public class MyProgram
    {
        public static void Main(string[] args)
        {
            Child childObj = new Child();
            int sum1 = childObj.AddNumber(74, 26);
            Console.WriteLine($"Sum of 2 number is {sum1}");
            int sum2 = childObj.AddNumber(74, 26,100);
            Console.WriteLine($"Sum of 3 number is {sum2}");




            Console.ReadKey();
        }
    }
}