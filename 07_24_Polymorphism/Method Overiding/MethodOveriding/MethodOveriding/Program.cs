using System;

namespace MethodOveriding
{
    //base class
    class Parent
    {
        //base class GetInfo()
        public virtual void GetInfo()
        {
            Console.WriteLine("Parent class GetInfo method called ");
        }
    }

    class Child:Parent 
    { 
        public override void GetInfo()
        {
            Console.WriteLine("Child class GetInfo method called ");
        }
    }

    class Program
    {
        public static void Main(string[] args)
        {
            Parent parent = new Parent();
            parent.GetInfo();

            Child child = new Child();  
            child.GetInfo();

            Console.ReadLine();
        }
    }
}