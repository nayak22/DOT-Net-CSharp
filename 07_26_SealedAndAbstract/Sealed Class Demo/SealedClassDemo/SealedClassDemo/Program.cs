using System;

namespace Demo
{

    public sealed class BaseClass
    {
        public void Display()
        {
            Console.WriteLine("This is a sealed Class and can't be further inherited:");
        }


    }

    //public class DerivedClass : BaseClass
    //{

    //} //This cant be done as the parent class sealed 


    public class Program
    {
        public static void Main(string[] args)
        {
            BaseClass baseClass = new BaseClass();
            baseClass.Display();

            Console.ReadKey();
        }
        
    }
}