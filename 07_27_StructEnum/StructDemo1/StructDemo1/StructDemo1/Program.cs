using System;

namespace StructureDemo
{
    struct Car
    {
        //declaring the fields 
        public string strCarModel;
        public string strCarName;
        public string strCarColor;
        public double dblCarPrice;

        //declaring the mthod
        public void DisplayCardDetails()
        {
            Console.WriteLine("Car details are: ");
            Console.WriteLine("-------------------");
            Console.WriteLine($"Car Model is : {strCarModel},Car Name is : {strCarName}, Car Color is : {strCarColor} and Car Price is :{dblCarPrice}");
        }
    }

    class Program
    {
        public static void Main(string[] args)
        {
            Car car;

            //Car car=new Car();// this is also valid but not neccssesary

            car.strCarModel = "Maruti Brezza's VXI";
            car.strCarColor = "Red";
            car.strCarName = "Breeza";
            car.dblCarPrice = 1150000d;

            car.DisplayCardDetails();
            Console.ReadKey();

        }
    }
}