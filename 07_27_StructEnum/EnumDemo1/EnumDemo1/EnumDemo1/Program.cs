using System;

namespace EnumDemo1
{
    enum Button
    {
        //off denotes the button is switched off with value 0
        OFF,

        //on mean the Button is on with value 1
        ON
    }

    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the 0 or 1 to know the state of electric switch!");

            int i= Convert.ToInt32(Console.ReadLine());

            if(i==(Byte)Button.OFF)
            {
                Console.WriteLine("Electric switch is OFF");
            }
            else if (i == (Byte)Button.ON)
            {
                Console.WriteLine("Electric switch is ON");
            }
            else
            {
                Console.WriteLine("Please give the vqalid Input i.e 0 or 1");
            }

            Console.ReadKey();
        }
    }
}