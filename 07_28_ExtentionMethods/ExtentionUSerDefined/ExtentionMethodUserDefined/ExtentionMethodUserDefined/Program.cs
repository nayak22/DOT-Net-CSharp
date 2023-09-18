using System;

namespace ExtentionMethodUserDefined
{
    public class Parent
    {
        public string userName;
        public string userLocation;

        public void Show()
        {
            Console.WriteLine("Executing Show Method");
        }

        public void Print()
        {
            Console.WriteLine("Executing Print Method");
        }
    }

    public static class ExtentionClass
    {
        public static void NewMethod(this Parent parent)
        {
            Console.WriteLine("Executing the Extention Method");
            Console.WriteLine("---------------------------------");
            Console.WriteLine($"User Name: {parent.userName} and User Location: {parent.userLocation}");
        }
    }

    class Program
    {
        public static void Main(string[] args)
        {
            Parent parent = new Parent();
            parent.userName = "Samrath";
            parent.userLocation = "Bengaluru";
            parent.Show();
            parent.Print();

            parent.NewMethod();
            Console.ReadKey();
        }
    }
}

