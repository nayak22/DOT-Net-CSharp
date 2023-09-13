using System;

namespace PrivateConstructor
{
    class Car
    {
        //private constructor
        private Car() {
            Console.WriteLine("Private constructor called!!");
        }
    }

    class CarDrive
    {
        static void Main(string[] args)
        {
            //create the instance of the class
            //Car car = new Car();//will give error

        }
    }
}