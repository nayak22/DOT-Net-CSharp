using System;

namespace ThrowingTheException
{
    public class Program
    {
        static void Main(string[] args)
        {
            //takwe the first input from the user
            Console.WriteLine("Enter the first Number");
            int firstNumber=int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the Second Number");
            int secondNumber = int.Parse(Console.ReadLine());

            try
            {
                int divisonResult = firstNumber / secondNumber;
                Console.WriteLine("Divison of 2 number is: " + divisonResult);
            }
            catch (Exception ex)
            {
                Console.WriteLine("An exception occured: "+ex.Message);
            }
            finally
            {
                Console.WriteLine("Sum of 2 numbers is "+(firstNumber+secondNumber));
            }
            Console.ReadKey();
        }
    }
}