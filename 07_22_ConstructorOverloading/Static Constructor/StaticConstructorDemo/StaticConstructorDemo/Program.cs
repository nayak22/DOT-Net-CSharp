using System;

namespace StaticConstructorDemo
{
    class Car
    {
        // Static COnstructor
        static Car() {
            Console.WriteLine("Static Constructor Called!!");

        }

        //parameter less Constructor
        public Car() {
            Console.WriteLine("Paramterless Constructor Called ");
        }

        public static void Main()
        {
            //instance 1 
            Car car1 = new Car();

            //secodn instance \
            Car car2 = new Car();

            Console.ReadKey();
        }

    }
}