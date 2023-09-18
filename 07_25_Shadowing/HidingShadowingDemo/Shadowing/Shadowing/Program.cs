using System;

namespace Shadowing
{
    public class Parent
    {
        public string GetOwnerInfo()
        {
            return "The owner of the code is PArent";
        }
    }

    public class Child : Parent
    {
        public new string GetOwnerInfo()
        {
            return "The owner of the code is Chaild";
        }
    }


    public class Program
    {
        public static void Main(string[] args)
        {
            Parent parent = new Parent();
            Child child = new Child();

            Console.WriteLine(parent.GetOwnerInfo());
            Console.WriteLine(child.GetOwnerInfo());
            Console.ReadKey();
        }
    }
}