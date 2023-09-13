using System;

namespace ConstructorOverloadingDemo
{
    class Car
    {
        string brand;
        //construtor with no paramter
        public Car() {
            Console.WriteLine("Constructor with no paramter is called ");
            brand = "Hyundai";
        }

        //constructor with parameter
        public Car(string brandName)
        {
            Console.WriteLine("Constructor with 1 paramter is called ");
            brand = brandName;
        }


        public static void Main()
        {
            Car car1 = new Car();
            Console.WriteLine($"Brand of the card is {car1.brand}");

            Car car2 = new Car("Kia");
            Console.WriteLine($"Brand of the card is {car2.brand}");


            Console.ReadLine();
        }

    }
}