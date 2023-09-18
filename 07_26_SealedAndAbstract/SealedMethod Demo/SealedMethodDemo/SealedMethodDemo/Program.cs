using System;

namespace SealedMethodDemo
{
    public class Parent
    {
        public virtual void Display()
        {
            Console.WriteLine("Virtual Method");
        }

    }

    public class Child:Parent { 
    public override sealed void Display()
        {
            Console.WriteLine("Sealed Method ");
        }
    }


    //public class Child2 : Child
    //{
    //    public override void Display()
    //    {
    //        Console.WriteLine("Sealed Method ");
    //    }
    //}

    //Cannot overide  the sealed method

    public class Program
    {
        public static void Main(string[] args) { 
        Parent parent = new Parent();
        Child child = new Child();
            parent.Display();
            child.Display();

            Console.ReadLine();
        }
    }
}