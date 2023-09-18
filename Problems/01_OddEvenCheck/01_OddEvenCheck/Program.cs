using System;


namespace OddEven
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter the number to check if Odd or Even: ");
            int inputNum=int.Parse(Console.ReadLine());

            if(inputNum%2==0 )
            {
                Console.WriteLine($"{inputNum} is a Even Number");

            }
            else
            {
                Console.WriteLine($"{inputNum} is a Odd Number");
            }

            Console.ReadKey();
        }
    }
}