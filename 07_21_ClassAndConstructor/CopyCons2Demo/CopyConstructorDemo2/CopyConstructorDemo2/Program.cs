using System;

namespace CopyConstructorDemo2
{
    class Car
    {
        string brand;
        //parameterized constructor
        public Car(string carBarnd)
        {
            brand = carBarnd;
        }

        //copy constructor

        public Car(Car car)
        {
            brand=car.brand;
        }

        

        public static void Main(string[] args)
        {
            //creating the first instance of the class 

            Car car1 = new Car("Hyundai");

            Console.WriteLine($"Car Brand from the first instance is : {car1.brand}");

            //invoking  the copy constructor
            Car car2 = new Car(car1);
            Console.WriteLine($"Car Brand from the second/copied instance is : {car2.brand}");


            Console.ReadKey();
        }
    }

}