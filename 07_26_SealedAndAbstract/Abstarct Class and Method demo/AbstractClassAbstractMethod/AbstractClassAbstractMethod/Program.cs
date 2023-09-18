using System;

namespace AbstractClassMethods
{
    public abstract class MotorBike
    {
        public abstract void Brake();
         
    }

    public class SportsBike:MotorBike 
    {
        public override void Brake()
        {
            Console.WriteLine("Sports Bike Brake");
        }


    }

    public class MountainBike : MotorBike
    {
        public override void Brake()
        {
            Console.WriteLine("Mountain Bike Brake");
        }


    }

    public class Program
    {
        public static void Main(string[] args) 
        { 
            //MotorBike motorBike = new MotorBike(); // cannot reate the instance of Abstract class
            SportsBike sportsBike = new SportsBike();
            MountainBike mountainBike = new MountainBike();

            sportsBike.Brake();
            mountainBike.Brake();

            Console.ReadKey();
        }
    }
}
