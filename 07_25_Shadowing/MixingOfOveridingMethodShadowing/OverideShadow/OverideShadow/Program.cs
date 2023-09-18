using System;

namespace OveridingShadow
{
    public class Parent
    {
        public virtual string GetOwnerInfo()
        {
            return "The owner of the code is PArent";
        }
    }

    public class Child : Parent
    {
        public virtual new string GetOwnerInfo()
        {
            return "The owner of the code is Chaild";
        }
    }

    public class Child2 : Parent
    {
        public override string GetOwnerInfo()
        {
            return "The owner of the code is Chaild2";
        }
    }


    public class Program
    {
        public static void Main(string[] args)
        {
            Parent parent = new Parent();
            Child child = new Child();
            Child2 child2 = new Child2();

            Console.WriteLine(parent.GetOwnerInfo());
            Console.WriteLine(child.GetOwnerInfo());
            Console.WriteLine(child2.GetOwnerInfo());
            Console.ReadKey();
        }
    }
}