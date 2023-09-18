using System;

namespace DelegateDemo1
{
    class Program
    {   
         //declaring the delegates
         public delegate void AddDelegate(int v1, int v2);
         //method Declaration

        static void Addition(int v1, int v2)
        {
            Console.WriteLine($"Sum of 2 numbers is: {v1+v2}");
        }

        static void Main(string[] args)
        {
            //initializing the delegate
            AddDelegate addDelegate = new AddDelegate(Addition);

            //invoking the delegate
            addDelegate(5, 25);

            Console.ReadLine();
        }
    }
}