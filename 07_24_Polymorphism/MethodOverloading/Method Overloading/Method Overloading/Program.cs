using System;


namespace MethodOverloading
{
    class PolymorphismDemo
    {
        //method doesnt take any parameter
        public void greet()
        {
            Console.WriteLine("Hello, welcome to the Learning club");

        }

        //overloaded metho which take one argument 
        public void greet(string name)
        {
            Console.WriteLine($"Hello {name}, welcome to the Learning club");

        }


        static void Main()
        { 
            PolymorphismDemo obj=new PolymorphismDemo();

            //calling 1st method
            obj.greet();

            //calling second method
            obj.greet("Samrath");


            Console.ReadKey();

        }
    }
}