using System;

namespace NestedExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] number = { 10, 22, 25, 50, 17, 18 };

            int[] divisor = { 5, 0, 0, 10 };


            try
            {
                for(int i=0;i<number.Length;i++)
                {
                    try
                    {
                        Console.WriteLine($"Number: {number[i]} Divisor: {divisor[i]} Quotient: {number[i] / divisor[i]}");
                    }
                    catch (DivideByZeroException e)
                    {
                        Console.WriteLine("Entered into inner catch block "+e.Message);
                    }
                    finally { Console.WriteLine("Executed the nested finally");
                    }
                }
            }
            catch(IndexOutOfRangeException e)
            {
                Console.WriteLine("Entered into outer cacth block "+e.Message);
            }
            finally
            {
                Console.WriteLine("Executed main finally block");
            }
            

        }
        

    }
}