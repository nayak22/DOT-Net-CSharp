using System;

namespace UserDefinedException
{
    class CustomDefinedException : Exception
    {
        public CustomDefinedException(string msg):base(msg)
        {
        }
    }

    class Car
    {
        public string strCarBrandName;
        public Car()
        {
            this.strCarBrandName = "";

        }

        public void DisplayCarBarnd()
        {
            if(this.strCarBrandName == "")
            {
                throw new CustomDefinedException("Car brand is empty");
            }
            else
            {
                Console.WriteLine("Car Brand Name: " + this.strCarBrandName);
            }
        }

    }
    public class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Car car = new Car();
                //car.strCarBrandName = "Hyundai";
                car.DisplayCarBarnd();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Console.ReadLine();
        }
    }
}